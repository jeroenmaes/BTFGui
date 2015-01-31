using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizTalkFactory.Management.Automation;
using BTF.GUI.BO;
using BTF.GUI.Properties;

namespace BTF.GUI
{
    public partial class MainForm : Form
    {
        private string SqlServerName { get; set; }
        private string BizTalkDatabaseName { get; set; }
        
        private static BtsCatalog _catalog;
        private static string _btsServer;
        private static List<string> _btsAppsToIgnore;

        private const string DateFormat = "<{0,2:00}:{1,2:00}:{2,2:00}> {3}";
        private const string ExceptionFormat = "Exception: {0}";
        private const string InnerExceptionFormat = "InnerException: {0}";

        private readonly BackgroundWorker _workerStopHostInstances;
        private readonly BackgroundWorker _workerRestartHostInstances;
        private readonly BackgroundWorker _workerRemoveApplications;
        private readonly BackgroundWorker _workerExportApplications;

        private BindingList<HostInstance> _hostInstances;
        private BindingList<BApplication> _applications;

        public MainForm()
        {
            InitializeComponent();

            GetSqlServerNameFromConfiguration();
            GetBizTalkDatabaseNameFromConfiguration();

            // init gui
            SetGui();
            
            SetGridStyle();
            SetGridStyle1();

            // read config
            SetConfig();

            _hostInstances = new BindingList<HostInstance>();
            dgv_hostinstances.DataSource = _hostInstances;

            _applications = new BindingList<BApplication>();
            dgv_applications.DataSource = _applications;

            // set bgWorkers
            _workerStopHostInstances = new BackgroundWorker();
            _workerStopHostInstances.WorkerReportsProgress = true;
            _workerStopHostInstances.DoWork += StopHostInstances;
            _workerStopHostInstances.ProgressChanged += WorkerChangedUpdateLog;
            _workerStopHostInstances.RunWorkerCompleted += WorkerStopHostInstancesCompleted;

            _workerRestartHostInstances = new BackgroundWorker();
            _workerRestartHostInstances.WorkerReportsProgress = true;
            _workerRestartHostInstances.DoWork += RestartHostInstances;
            _workerRestartHostInstances.ProgressChanged += WorkerChangedUpdateLog;
            _workerRestartHostInstances.RunWorkerCompleted += WorkerRestartHostInstancesCompleted;

            _workerRemoveApplications = new BackgroundWorker();
            _workerRemoveApplications.WorkerReportsProgress = true;
            _workerRemoveApplications.DoWork += RemoveApplications;
            _workerRemoveApplications.ProgressChanged += WorkerChangedUpdateLog;
            _workerRemoveApplications.RunWorkerCompleted += WorkerRemoveApplicationsCompleted;

            _workerExportApplications = new BackgroundWorker();
            _workerExportApplications.WorkerReportsProgress = true;
            _workerExportApplications.DoWork += ExportApplications;
            _workerExportApplications.ProgressChanged += WorkerChangedUpdateLog;
            _workerExportApplications.RunWorkerCompleted += WorkerExportApplicationsCompleted;
        }

        private void GetBizTalkDatabaseNameFromConfiguration()
        {
            try
            {
                SqlServerName = ConfigurationManager.AppSettings.Get("dbServer");
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void GetSqlServerNameFromConfiguration()
        {
            try
            {
               BizTalkDatabaseName = ConfigurationManager.AppSettings.Get("dbBizTalk");
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void SetGridStyle()
        {
            dgv_applications.AutoGenerateColumns = false;

            var colSelected = new DataGridViewCheckBoxColumn();
            colSelected.DataPropertyName = "Selected";
            colSelected.HeaderText = string.Empty;
            colSelected.ReadOnly = true;
            colSelected.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgv_applications.Columns.Add(colSelected);
            
            var colStatusIcon = new DataGridViewImageColumn();
            colStatusIcon.DataPropertyName = "StatusIcon";
            colStatusIcon.HeaderText = string.Empty;
            colStatusIcon.ReadOnly = true;
            colStatusIcon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgv_applications.Columns.Add(colStatusIcon);
                        
            var colName = new DataGridViewTextBoxColumn();
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.ReadOnly = true;
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgv_applications.Columns.Add(colName);

            var colStatus = new DataGridViewTextBoxColumn();
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.ReadOnly = true;
            colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgv_applications.Columns.Add(colStatus);
        }

        private void SetGridStyle1()
        {
            dgv_hostinstances.AutoGenerateColumns = false;

            var colSelected = new DataGridViewCheckBoxColumn();
            colSelected.DataPropertyName = "Selected";
            colSelected.HeaderText = string.Empty;
            colSelected.ReadOnly = true;
            colSelected.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgv_hostinstances.Columns.Add(colSelected);
            
            var colStatusIcon = new DataGridViewImageColumn();
            colStatusIcon.DataPropertyName = "StatusIcon";
            colStatusIcon.HeaderText = string.Empty;
            colStatusIcon.ReadOnly = true;
            colStatusIcon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgv_hostinstances.Columns.Add(colStatusIcon);
            
            var col = new DataGridViewTextBoxColumn();
            col.DataPropertyName = "Name";
            col.HeaderText = "Name";
            col.ReadOnly = true;
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgv_hostinstances.Columns.Add(col);

            var colStatus = new DataGridViewTextBoxColumn();
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.ReadOnly = true;
            colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgv_hostinstances.Columns.Add(colStatus);
        }

        private void SetGui()
        {
            //empty labels
            lbl_database_c.Text = string.Empty;
            lbl_group_c.Text = string.Empty;
            lbl_server_c.Text = string.Empty;
            lbl_suspendedinstances_c.Text = "--";
            lbl_health_applications_c.Text = "--";
            lbl_health_hostinstances_c.Text = "--";
            lbl_runninginstances_c.Text = "--";

            //disable groupboxes
            gb_applications.Enabled = false;
            gb_hostinstances.Enabled = false;
            gb_health.Enabled = false;

            //disable buttons
            btn_applications_stop.Enabled = false;
            btn_applications_start.Enabled = false;
            btn_hostinstances_restart.Enabled = false;
            btn_hostinstances_stop.Enabled = false;
            btn_applications_remove.Enabled = false;
            btn_applications_export.Enabled = false;
            btn_health_terminate.Enabled = false;
            //btn_server_disconnect.Enabled = false;

            //empty grids
            tb_log.Text = string.Empty;
            dgv_hostinstances.Rows.Clear();
            dgv_applications.Rows.Clear();

        }

        private static void SetConfig()
        {
            var dbServer = ConfigurationManager.AppSettings.Get("dbServer");
            var dbInstance = ConfigurationManager.AppSettings.Get("dbInstance");
            var btsAppsToIgnoreString = ConfigurationManager.AppSettings.Get("btsAppsToIgnore");

            _btsAppsToIgnore = btsAppsToIgnoreString.Split(';').ToList();

            _btsServer = string.Format("{0}\\{1}", dbServer, dbInstance);
        }

        private void WorkerChangedUpdateLog(object sender, ProgressChangedEventArgs e)
        {
            dgv_hostinstances.Refresh();
            dgv_applications.Refresh();

            WriteToLog(e.UserState.ToString());
        }

        private void WorkerStopHostInstancesCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btn_hostinstances_stop.Enabled = true;
        }

        private void WorkerRestartHostInstancesCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btn_hostinstances_restart.Enabled = true;
        }

        private void WorkerRemoveApplicationsCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btn_applications_remove.Enabled = true;

            RefreshApplications();
        }

        private void WorkerExportApplicationsCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btn_applications_export.Enabled = true;
        }

        private void WriteToLog(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                return;
            }

            var objNow = DateTime.Now;
            var line = string.Format(DateFormat, objNow.Hour, objNow.Minute, objNow.Second, message);

            if (tb_log.Text.Length > 0)
            {
                tb_log.Text += Environment.NewLine + line;
            }
            else
            {
                tb_log.Text += line;
            }

            tb_log.SelectionStart = tb_log.Text.Length;
            tb_log.ScrollToCaret();
        }

        private void btn_server_connect_Click(object sender, EventArgs e)
        {
           ConnectServer();

            lbl_server_c.Text = _catalog.Instance;
            lbl_database_c.Text = _catalog.Database;
            lbl_group_c.Text = _catalog.Name;

            gb_applications.Enabled = true;
            gb_hostinstances.Enabled = true;
            gb_health.Enabled = true;

            SetHealthInformation();
            RefreshApplications();
            RefreshHostInstances();
        }

        private void ConnectServer()
        {
            WriteToLog(string.Format("Connect to BizTalk: {0}.", SqlServerName));

            _catalog = BtsCatalog.Connect(SqlServerName, BizTalkDatabaseName);

            lbl_server_c.Text = _catalog.Instance;
            lbl_database_c.Text = _catalog.Database;
            lbl_group_c.Text = _catalog.Name;

            WriteToLog("Connection success.");
        }

        private void SetHealthInformation()
        {
            _catalog.Refresh();
            
            lbl_suspendedinstances_c.ResetForeColor();

            WriteToLog("Set HealthInformation.");
            gb_health.Enabled = true;

            var instances = new BtsServiceInstanceCollection(_catalog);

            WriteToLog(string.Format("Found {0} Running Service Instances.", instances.Where(x => x.ErrorCategory == 0).ToList().Count));
            WriteToLog(string.Format("Found {0} Suspended Service Instances.", instances.Where(x => x.ErrorCategory != 0).ToList().Count));

            lbl_runninginstances_c.Text = instances.Where(x => x.ErrorCategory == 0).ToList().Count.ToString();
            lbl_suspendedinstances_c.Text = instances.Where(x => x.ErrorCategory != 0).ToList().Count.ToString();

            if (instances.Count > 0)
            {
                btn_health_terminate.Enabled = true;
                lbl_suspendedinstances_c.ForeColor = Color.Red;
            }
        }

        private void btn_hostinstances_refresh_Click(object sender, EventArgs e)
        {
            RefreshHostInstances();
        }

        private void RefreshHostInstances()
        {
            _catalog.Refresh();
            
            btn_hostinstances_refresh.Enabled = false;
            _hostInstances.Clear();

            WriteToLog("Refresh Host Instances...");
            gb_hostinstances.Enabled = true;

            lbl_health_hostinstances_c.Text = _catalog.HostInstances.Count.ToString();

            foreach (var instance in _catalog.HostInstances)
            {
                if (instance.HostType != BtsHostType.Isolated && !instance.IsDisabled)
                {
                    WriteToLog(String.Format("HostInstance: {0}.", instance.HostName));

                    var hi = new HostInstance
                    {
                        Selected = true,                        
                        Name = instance.HostName,
                        Server = instance.RunningServer,                        
                        Status = instance.ServiceState.ToServiceState(),
                        Type = instance.HostType.ToHostType()                        
                    };
                    
                    _hostInstances.Add(hi);
                }
            }

            WriteToLog(string.Format("Found {0} Host Instances.", _catalog.HostInstances.Count));

            btn_hostinstances_refresh.Enabled = true;
            btn_hostinstances_restart.Enabled = true;
            btn_hostinstances_stop.Enabled = true;
            btn_applications_refresh.Enabled = true;
        }

        private void btn_applications_refresh_Click(object sender, EventArgs e)
        {
            RefreshApplications();
        }

        private void RefreshApplications()
        {
            _catalog.Refresh();
            
            btn_applications_refresh.Enabled = false;
            _applications.Clear();

            WriteToLog("Refresh Applications...");
            gb_applications.Enabled = true;

            lbl_health_applications_c.Text = _catalog.Applications.Count.ToString();

            foreach (var app in _catalog.Applications)
            {
                WriteToLog(String.Format("Application: {0}", app.Name));

                if (!_btsAppsToIgnore.Contains(app.Name))
                {
                    var appp = new BApplication
                    {
                        Name = app.Name,                        
                        Selected = true,
                        Status = app.Status.ToApplicationStatus(),
                        BackReferences = app.References.Any(),
                        References = app.References.Any(),
                        Resources = new List<string>()
                    };

                    foreach (var res in app.Resources)
                    {
                        if (res.ResourceType.Contains("Assembly"))
                        {
                            appp.Resources.Add(res.Name);

                            WriteToLog(String.Format("Application: {0} - Resource: {1}.dll", app.Name,
                                res.Name.Split(',')[0]));
                        }
                    }

                    _applications.Add(appp);
                }
            }

            WriteToLog(string.Format("Found {0} Applications.", _catalog.Applications.Count));

            btn_applications_refresh.Enabled = true;
            btn_applications_stop.Enabled = true;
            btn_applications_start.Enabled = true;
            btn_applications_remove.Enabled = true;
            btn_applications_export.Enabled = true;
        }

        private void btn_applications_stop_Click(object sender, EventArgs e)
        {
            StopApplications();

            RefreshApplications();
        }

        private void StopApplications()
        {
            btn_applications_stop.Enabled = false;

            WriteToLog("Stop Applications.");
            
            foreach (var app in _applications.Where(x => x.Selected))
            {
                WriteToLog(String.Format("Application: {0}.", app.Name));

                var appRef = _catalog.Applications[app.Name];

                if (appRef.Status == BtsApplicationStatus.Started ||
                    appRef.Status == BtsApplicationStatus.PartiallyStarted)
                {
                    app.Status = BApplicationStatus.PartiallyStarted;
                    WriteToLog(String.Format("Stopping Application '{0}'...", app.Name));

                    appRef.Stop(BtsApplicationStopOption.StopAll);

                    WriteToLog(String.Format("Application '{0}' Stopped.", app.Name));
                    app.Status = BApplicationStatus.Stopped;
                }
                else
                {
                    WriteToLog(String.Format("Application '{0}' Already Stopped.", app.Name));
                }
            }

            _catalog.SaveChanges();
            _catalog.Refresh();

            WriteToLog("Applications Stopped.");

            btn_applications_stop.Enabled = false;
        }
        
        private void StartApplications()
        {
            btn_applications_start.Enabled = false;

            WriteToLog("Start Applications.");

            foreach (var app in _applications.Where(x => x.Selected))
            {
                var exists = _catalog.Applications.TryExists(app.Name);

                if (exists)
                {
                    WriteToLog(String.Format("Application: {0}.", app.Name));

                    var appRef = _catalog.Applications[app.Name];

                    WriteToLog(String.Format("Starting Application '{0}'...", app.Name));

                    appRef.Start(BtsApplicationStartOption.StartAll);

                    WriteToLog(String.Format("Application '{0}' Started.", app.Name));

                }
            }

            _catalog.SaveChanges();
            
            WriteToLog("Applications Started.");

            btn_applications_start.Enabled = false;
        }

        private void StopHostInstances(object sender, DoWorkEventArgs e)
        {
            var bgWorker = (BackgroundWorker)sender;
            bgWorker.ReportProgress(1, "Stop HostInstances.");

            int countStopped = 0;

            foreach (var instance in _hostInstances.Where(x => x.Selected))
            {
                var instanceRef = _catalog.HostInstances.SingleOrDefault(n => n.HostName == instance.Name);
                
                if (instanceRef.ServiceState == BtsServiceState.NotApplicable)
                {
                    bgWorker.ReportProgress(1, String.Format("Host Instance {0} Stop not possible.", instance.Name));
                }
                else if (instanceRef.ServiceState == BtsServiceState.Stopped)
                {
                    bgWorker.ReportProgress(1, String.Format("Host Instance {0} Already Stopped.", instance.Name));
                }
                else
                {
                    instance.Status = ServiceState.StopPending;
                    bgWorker.ReportProgress(1, String.Format("Stopping Host Instance {0} ...", instance.Name));

                    instanceRef.Stop();

                    countStopped ++;

                    bgWorker.ReportProgress(1, String.Format("Host Instance {0} Stopped.", instance.Name));
                    instance.Status = ServiceState.Stopped;
                }
            }

            bgWorker.ReportProgress(100, string.Format("{0} Host Instances Stopped.", countStopped));
        }


        private void btn_hostinstances_stop_Click(object sender, EventArgs e)
        {
            btn_hostinstances_stop.Enabled = false;

            _workerStopHostInstances.RunWorkerAsync();
        }

        private void btn_hostinstances_restart_Click(object sender, EventArgs e)
        {
            btn_hostinstances_restart.Enabled = false;

            _workerRestartHostInstances.RunWorkerAsync();
        }

        private void RestartHostInstances(object sender, DoWorkEventArgs e)
        {
            var bgWorker = (BackgroundWorker)sender;
            bgWorker.ReportProgress(1, "Start/Restart Host Instances.");

            int countStarted = 0;
            int countRestarted = 0;

            foreach (var instance in _hostInstances.Where(x => x.Selected))
            {
                var instanceRef = _catalog.HostInstances.SingleOrDefault(n => n.HostName == instance.Name);

                if (instanceRef.ServiceState == BtsServiceState.NotApplicable)
                {
                    bgWorker.ReportProgress(1, String.Format("Restart Host Instances {0} not possible.", instanceRef.HostName));
                }
                else if (instanceRef.ServiceState == BtsServiceState.Stopped)
                {
                    instance.Status = ServiceState.StartPending;
                    bgWorker.ReportProgress(1, String.Format("Starting Host Instance {0}...", instanceRef.HostName));

                    instanceRef.Start();
                    
                    countStarted++;
                    
                    bgWorker.ReportProgress(1, String.Format("Host Instance {0} Started.", instanceRef.HostName));
                    instance.Status = ServiceState.Running;
                }
                else if ((instanceRef.ServiceState == BtsServiceState.Running))
                {
                    instance.Status = ServiceState.StopPending;
                    bgWorker.ReportProgress(1, String.Format("Restart Host Instance {0}...", instanceRef.HostName));

                    instanceRef.Restart();

                    countRestarted++;
                    
                    bgWorker.ReportProgress(1, String.Format("Host Instance {0} Restarted.", instanceRef.HostName));
                    instance.Status = ServiceState.Running;
                }
            }

            bgWorker.ReportProgress(1, String.Format("{0} Host Instances Started.", countStarted));
            bgWorker.ReportProgress(100, String.Format("{0} Host Instances Restarted.", countRestarted));
        }

        private void TerminateInstances()
        {
            WriteToLog("Terminate Service Instances.");

            var instances = new BtsServiceInstanceCollection(_catalog);

            int count = instances.Count;

            foreach (var instance in instances)
            {
                WriteToLog(String.Format("Terminating Service Instance with ID '{0}'...", instance.Identifier));

                instance.Terminate();

                WriteToLog(String.Format("Service Instance with ID {0} terminated.", instance.Identifier));
            }

            _catalog.SaveChanges();
            _catalog.Refresh();

            WriteToLog(String.Format("{0} Service Instances Terminated.", count));

            SetHealthInformation();
        }

        private void btn_applications_remove_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("The applications will be removed from BizTalk. \n"
                + " Are you sure about this? "
                , "Confirmation"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;

            StopApplications();
            TerminateInstances();

            btn_applications_remove.Enabled = false;

            _workerRemoveApplications.RunWorkerAsync();
        }

        private void ExportApplications(object sender, DoWorkEventArgs e)
        {
            var bgWorker = (BackgroundWorker)sender;

            bgWorker.ReportProgress(1, String.Format("Export Bindings."));

            foreach (var app in _applications.Where(x => x.Selected))
            {
                var exists = _catalog.Applications.TryExists(app.Name);

                if (exists)
                {
                    var s = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

                    var sp = s + "\\BTF.GUI\\Binding Files\\";
                    var spp = sp + app.Name + string.Format(".{0:yyyy-MM-dd_HH-mm-ss}", DateTime.Now) +
                              ".BindingInfo.xml";
                    _catalog.Applications[app.Name].ExportBinding(spp, true);

                    bgWorker.ReportProgress(1, String.Format("Binding for Application '{0}' Exported to '{1}'.", app.Name, spp));
                }
            }

            bgWorker.ReportProgress(100, "Bindings Exported.");
        }

        private void RemoveApplications(object sender, DoWorkEventArgs e)
        {
            var bgWorker = (BackgroundWorker)sender;

            bgWorker.ReportProgress(1, String.Format("Remove Applications."));

            foreach (var app in _applications.Where(x => x.Selected))
            {
                var exists = _catalog.Applications.TryExists(app.Name);

                if (exists)
                {
                    var s = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

                    var sp = s + "\\BTF.GUI\\Binding Files\\";
                    var spp = sp + app.Name + string.Format(".{0:yyyy-MM-dd_HH-mm-ss}", DateTime.Now) +
                              ".BindingInfo.xml";
                    _catalog.Applications[app.Name].ExportBinding(spp, true);

                    bgWorker.ReportProgress(1, String.Format("Binding for Application '{0}' Exported to '{1}'.", app.Name, spp));
                }
            }

            var loop = true;

            while (loop)
            {
                foreach (var app in _applications.Where(x => x.Selected))
                {
                    var exists = _catalog.Applications.TryExists(app.Name);
                    
                    if (exists)
                    {
                        bgWorker.ReportProgress(1, String.Format("Removing Application '{0}'...", app.Name));

                        try
                        {
                            _catalog.RemoveApplication(app.Name, true);
                            bgWorker.ReportProgress(1, String.Format("Application '{0}' Removed.", app.Name));
                        }
                        catch (Exception ex)
                        {
                            if (ex.InnerException.Message == "Failed to delete resource(s).")
                            {
                                bgWorker.ReportProgress(1,
                                    String.Format(
                                        "Application '{0}' is referenced by other applications, will retry later.", app.Name));

                                // possible endless loop!!!
                                // should check for references and retry only 3 times
                                // stupid to try to delete the generic applications...
                            }
                            else
                            {
                                throw ex;
                            }
                        }
                    }
                }

                if (!_catalog.Applications.Select(s => s.Name).Intersect(_applications.Select(x => x.Name)).Any())
                {
                    loop = false;
                }
            }

            _catalog.SaveChanges();
            _catalog.Refresh();

            bgWorker.ReportProgress(100, "Applications Removed.");
        }

        private void btn_health_terminate_Click(object sender, EventArgs e)
        {
            TerminateInstances();
        }

        private void btn_server_disconnect_Click(object sender, EventArgs e)
        {
            WriteToLog(string.Format("Disconnect BizTalk."));

            SetGui();
            _catalog = null;

            //btn_server_connect.Enabled = true;

            WriteToLog(string.Format("Disconnected."));
        }

        private void btn_health_refresh_Click(object sender, EventArgs e)
        {
            SetHealthInformation();
        }

        private void btn_applications_start_Click(object sender, EventArgs e)
        {
            StartApplications();

            RefreshApplications();
        }

        public void HandleException(Exception ex)
        {
            if (ex == null || string.IsNullOrWhiteSpace(ex.Message))
            {
                return;
            }
            WriteToLog(string.Format(CultureInfo.CurrentCulture, ExceptionFormat, ex.Message));
            if (ex.InnerException != null && !string.IsNullOrWhiteSpace(ex.InnerException.Message))
            {
                WriteToLog(string.Format(CultureInfo.CurrentCulture, InnerExceptionFormat, ex.InnerException.Message));
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connectForm = new ConnectForm(SqlServerName, BizTalkDatabaseName))
                {
                    if (connectForm.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }

                    SqlServerName = connectForm.SqlServerName;
                    BizTalkDatabaseName = connectForm.BizTalkDatabaseName;

                    ConnectServer();
                    
                    SetHealthInformation();
                    RefreshApplications();
                    RefreshHostInstances();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteToLog(string.Format("Disconnect BizTalk."));

            SetGui();
            _catalog = null;

            WriteToLog(string.Format("Disconnected."));

            Close();
        }

        private void clearLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_log.Clear();
        }

        private void btn_applications_export_Click(object sender, EventArgs e)
        {
            btn_applications_export.Enabled = false;

            _workerExportApplications.RunWorkerAsync();
        }
    }
}
