namespace BTF.GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gb_log = new System.Windows.Forms.GroupBox();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.gb_hostinstances = new System.Windows.Forms.GroupBox();
            this.dgv_hostinstances = new System.Windows.Forms.DataGridView();
            this.btn_hostinstances_refresh = new System.Windows.Forms.Button();
            this.btn_hostinstances_restart = new System.Windows.Forms.Button();
            this.btn_hostinstances_stop = new System.Windows.Forms.Button();
            this.gb_applications = new System.Windows.Forms.GroupBox();
            this.dgv_applications = new System.Windows.Forms.DataGridView();
            this.btn_applications_remove = new System.Windows.Forms.Button();
            this.btn_applications_refresh = new System.Windows.Forms.Button();
            this.btn_applications_start = new System.Windows.Forms.Button();
            this.btn_applications_stop = new System.Windows.Forms.Button();
            this.gb_server = new System.Windows.Forms.GroupBox();
            this.lbl_database_c = new System.Windows.Forms.Label();
            this.lbl_group_c = new System.Windows.Forms.Label();
            this.lbl_server_c = new System.Windows.Forms.Label();
            this.lbl_database = new System.Windows.Forms.Label();
            this.lbl_group = new System.Windows.Forms.Label();
            this.lbl_server = new System.Windows.Forms.Label();
            this.gb_health = new System.Windows.Forms.GroupBox();
            this.lbl_runninginstances_c = new System.Windows.Forms.Label();
            this.lbl_runninginstances = new System.Windows.Forms.Label();
            this.btn_health_refresh = new System.Windows.Forms.Button();
            this.lbl_health_applications_c = new System.Windows.Forms.Label();
            this.lbl_health_hostinstances_c = new System.Windows.Forms.Label();
            this.lbl_health_hostinstances = new System.Windows.Forms.Label();
            this.lbl_health_applications = new System.Windows.Forms.Label();
            this.lbl_suspendedinstances_c = new System.Windows.Forms.Label();
            this.lbl_suspendedinstances = new System.Windows.Forms.Label();
            this.btn_health_terminate = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorMain = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_applications_export = new System.Windows.Forms.Button();
            this.gb_log.SuspendLayout();
            this.gb_hostinstances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hostinstances)).BeginInit();
            this.gb_applications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_applications)).BeginInit();
            this.gb_server.SuspendLayout();
            this.gb_health.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_log
            // 
            this.gb_log.Controls.Add(this.tb_log);
            this.gb_log.Location = new System.Drawing.Point(10, 477);
            this.gb_log.Name = "gb_log";
            this.gb_log.Size = new System.Drawing.Size(794, 225);
            this.gb_log.TabIndex = 5;
            this.gb_log.TabStop = false;
            this.gb_log.Text = "Log";
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(6, 19);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.ReadOnly = true;
            this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_log.Size = new System.Drawing.Size(782, 200);
            this.tb_log.TabIndex = 0;
            // 
            // gb_hostinstances
            // 
            this.gb_hostinstances.Controls.Add(this.dgv_hostinstances);
            this.gb_hostinstances.Controls.Add(this.btn_hostinstances_refresh);
            this.gb_hostinstances.Controls.Add(this.btn_hostinstances_restart);
            this.gb_hostinstances.Controls.Add(this.btn_hostinstances_stop);
            this.gb_hostinstances.Location = new System.Drawing.Point(16, 12);
            this.gb_hostinstances.Name = "gb_hostinstances";
            this.gb_hostinstances.Size = new System.Drawing.Size(588, 248);
            this.gb_hostinstances.TabIndex = 6;
            this.gb_hostinstances.TabStop = false;
            this.gb_hostinstances.Text = "Host Instances";
            // 
            // dgv_hostinstances
            // 
            this.dgv_hostinstances.AllowUserToAddRows = false;
            this.dgv_hostinstances.AllowUserToDeleteRows = false;
            this.dgv_hostinstances.AllowUserToResizeColumns = false;
            this.dgv_hostinstances.AllowUserToResizeRows = false;
            this.dgv_hostinstances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hostinstances.Location = new System.Drawing.Point(7, 19);
            this.dgv_hostinstances.Name = "dgv_hostinstances";
            this.dgv_hostinstances.RowHeadersVisible = false;
            this.dgv_hostinstances.Size = new System.Drawing.Size(494, 213);
            this.dgv_hostinstances.TabIndex = 10;
            // 
            // btn_hostinstances_refresh
            // 
            this.btn_hostinstances_refresh.Location = new System.Drawing.Point(507, 209);
            this.btn_hostinstances_refresh.Name = "btn_hostinstances_refresh";
            this.btn_hostinstances_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_hostinstances_refresh.TabIndex = 4;
            this.btn_hostinstances_refresh.Text = "Refresh";
            this.btn_hostinstances_refresh.UseVisualStyleBackColor = true;
            this.btn_hostinstances_refresh.Click += new System.EventHandler(this.btn_hostinstances_refresh_Click);
            // 
            // btn_hostinstances_restart
            // 
            this.btn_hostinstances_restart.Location = new System.Drawing.Point(507, 48);
            this.btn_hostinstances_restart.Name = "btn_hostinstances_restart";
            this.btn_hostinstances_restart.Size = new System.Drawing.Size(75, 23);
            this.btn_hostinstances_restart.TabIndex = 2;
            this.btn_hostinstances_restart.Text = "Restart";
            this.btn_hostinstances_restart.UseVisualStyleBackColor = true;
            this.btn_hostinstances_restart.Click += new System.EventHandler(this.btn_hostinstances_restart_Click);
            // 
            // btn_hostinstances_stop
            // 
            this.btn_hostinstances_stop.Location = new System.Drawing.Point(507, 19);
            this.btn_hostinstances_stop.Name = "btn_hostinstances_stop";
            this.btn_hostinstances_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_hostinstances_stop.TabIndex = 1;
            this.btn_hostinstances_stop.Text = "Stop";
            this.btn_hostinstances_stop.UseVisualStyleBackColor = true;
            this.btn_hostinstances_stop.Click += new System.EventHandler(this.btn_hostinstances_stop_Click);
            // 
            // gb_applications
            // 
            this.gb_applications.Controls.Add(this.btn_applications_export);
            this.gb_applications.Controls.Add(this.dgv_applications);
            this.gb_applications.Controls.Add(this.btn_applications_remove);
            this.gb_applications.Controls.Add(this.btn_applications_refresh);
            this.gb_applications.Controls.Add(this.btn_applications_start);
            this.gb_applications.Controls.Add(this.btn_applications_stop);
            this.gb_applications.Location = new System.Drawing.Point(12, 266);
            this.gb_applications.Name = "gb_applications";
            this.gb_applications.Size = new System.Drawing.Size(592, 205);
            this.gb_applications.TabIndex = 7;
            this.gb_applications.TabStop = false;
            this.gb_applications.Text = "Applications";
            // 
            // dgv_applications
            // 
            this.dgv_applications.AllowUserToAddRows = false;
            this.dgv_applications.AllowUserToDeleteRows = false;
            this.dgv_applications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_applications.Location = new System.Drawing.Point(11, 19);
            this.dgv_applications.Name = "dgv_applications";
            this.dgv_applications.RowHeadersVisible = false;
            this.dgv_applications.Size = new System.Drawing.Size(494, 165);
            this.dgv_applications.TabIndex = 6;
            // 
            // btn_applications_remove
            // 
            this.btn_applications_remove.Location = new System.Drawing.Point(511, 90);
            this.btn_applications_remove.Name = "btn_applications_remove";
            this.btn_applications_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_applications_remove.TabIndex = 5;
            this.btn_applications_remove.Text = "Remove";
            this.btn_applications_remove.UseVisualStyleBackColor = true;
            this.btn_applications_remove.Click += new System.EventHandler(this.btn_applications_remove_Click);
            // 
            // btn_applications_refresh
            // 
            this.btn_applications_refresh.Location = new System.Drawing.Point(511, 161);
            this.btn_applications_refresh.Name = "btn_applications_refresh";
            this.btn_applications_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_applications_refresh.TabIndex = 4;
            this.btn_applications_refresh.Text = "Refresh";
            this.btn_applications_refresh.UseVisualStyleBackColor = true;
            this.btn_applications_refresh.Click += new System.EventHandler(this.btn_applications_refresh_Click);
            // 
            // btn_applications_start
            // 
            this.btn_applications_start.Location = new System.Drawing.Point(511, 48);
            this.btn_applications_start.Name = "btn_applications_start";
            this.btn_applications_start.Size = new System.Drawing.Size(75, 23);
            this.btn_applications_start.TabIndex = 3;
            this.btn_applications_start.Text = "Start";
            this.btn_applications_start.UseVisualStyleBackColor = true;
            this.btn_applications_start.Click += new System.EventHandler(this.btn_applications_start_Click);
            // 
            // btn_applications_stop
            // 
            this.btn_applications_stop.Location = new System.Drawing.Point(511, 19);
            this.btn_applications_stop.Name = "btn_applications_stop";
            this.btn_applications_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_applications_stop.TabIndex = 1;
            this.btn_applications_stop.Text = "Stop";
            this.btn_applications_stop.UseVisualStyleBackColor = true;
            this.btn_applications_stop.Click += new System.EventHandler(this.btn_applications_stop_Click);
            // 
            // gb_server
            // 
            this.gb_server.Controls.Add(this.lbl_database_c);
            this.gb_server.Controls.Add(this.lbl_group_c);
            this.gb_server.Controls.Add(this.lbl_server_c);
            this.gb_server.Controls.Add(this.lbl_database);
            this.gb_server.Controls.Add(this.lbl_group);
            this.gb_server.Controls.Add(this.lbl_server);
            this.gb_server.Location = new System.Drawing.Point(610, 12);
            this.gb_server.Name = "gb_server";
            this.gb_server.Size = new System.Drawing.Size(194, 248);
            this.gb_server.TabIndex = 8;
            this.gb_server.TabStop = false;
            this.gb_server.Text = "Server";
            // 
            // lbl_database_c
            // 
            this.lbl_database_c.AutoSize = true;
            this.lbl_database_c.Location = new System.Drawing.Point(62, 87);
            this.lbl_database_c.Name = "lbl_database_c";
            this.lbl_database_c.Size = new System.Drawing.Size(83, 13);
            this.lbl_database_c.TabIndex = 7;
            this.lbl_database_c.Text = "BizTalkMgmtDB";
            // 
            // lbl_group_c
            // 
            this.lbl_group_c.AutoSize = true;
            this.lbl_group_c.Location = new System.Drawing.Point(62, 58);
            this.lbl_group_c.Name = "lbl_group_c";
            this.lbl_group_c.Size = new System.Drawing.Size(74, 13);
            this.lbl_group_c.TabIndex = 6;
            this.lbl_group_c.Text = "BizTalk Group";
            // 
            // lbl_server_c
            // 
            this.lbl_server_c.AutoSize = true;
            this.lbl_server_c.Location = new System.Drawing.Point(62, 29);
            this.lbl_server_c.Name = "lbl_server_c";
            this.lbl_server_c.Size = new System.Drawing.Size(49, 13);
            this.lbl_server_c.TabIndex = 5;
            this.lbl_server_c.Text = "localhost";
            // 
            // lbl_database
            // 
            this.lbl_database.AutoSize = true;
            this.lbl_database.Location = new System.Drawing.Point(6, 87);
            this.lbl_database.Name = "lbl_database";
            this.lbl_database.Size = new System.Drawing.Size(56, 13);
            this.lbl_database.TabIndex = 4;
            this.lbl_database.Text = "Database:";
            // 
            // lbl_group
            // 
            this.lbl_group.AutoSize = true;
            this.lbl_group.Location = new System.Drawing.Point(8, 58);
            this.lbl_group.Name = "lbl_group";
            this.lbl_group.Size = new System.Drawing.Size(39, 13);
            this.lbl_group.TabIndex = 3;
            this.lbl_group.Text = "Group:";
            // 
            // lbl_server
            // 
            this.lbl_server.AutoSize = true;
            this.lbl_server.Location = new System.Drawing.Point(6, 29);
            this.lbl_server.Name = "lbl_server";
            this.lbl_server.Size = new System.Drawing.Size(41, 13);
            this.lbl_server.TabIndex = 2;
            this.lbl_server.Text = "Server:";
            // 
            // gb_health
            // 
            this.gb_health.Controls.Add(this.lbl_runninginstances_c);
            this.gb_health.Controls.Add(this.lbl_runninginstances);
            this.gb_health.Controls.Add(this.btn_health_refresh);
            this.gb_health.Controls.Add(this.lbl_health_applications_c);
            this.gb_health.Controls.Add(this.lbl_health_hostinstances_c);
            this.gb_health.Controls.Add(this.lbl_health_hostinstances);
            this.gb_health.Controls.Add(this.lbl_health_applications);
            this.gb_health.Controls.Add(this.lbl_suspendedinstances_c);
            this.gb_health.Controls.Add(this.lbl_suspendedinstances);
            this.gb_health.Controls.Add(this.btn_health_terminate);
            this.gb_health.Location = new System.Drawing.Point(610, 266);
            this.gb_health.Name = "gb_health";
            this.gb_health.Size = new System.Drawing.Size(194, 205);
            this.gb_health.TabIndex = 9;
            this.gb_health.TabStop = false;
            this.gb_health.Text = "Health";
            // 
            // lbl_runninginstances_c
            // 
            this.lbl_runninginstances_c.AutoSize = true;
            this.lbl_runninginstances_c.Location = new System.Drawing.Point(132, 48);
            this.lbl_runninginstances_c.Name = "lbl_runninginstances_c";
            this.lbl_runninginstances_c.Size = new System.Drawing.Size(13, 13);
            this.lbl_runninginstances_c.TabIndex = 14;
            this.lbl_runninginstances_c.Text = "0";
            // 
            // lbl_runninginstances
            // 
            this.lbl_runninginstances.AutoSize = true;
            this.lbl_runninginstances.Location = new System.Drawing.Point(8, 48);
            this.lbl_runninginstances.Name = "lbl_runninginstances";
            this.lbl_runninginstances.Size = new System.Drawing.Size(99, 13);
            this.lbl_runninginstances.TabIndex = 13;
            this.lbl_runninginstances.Text = "Running Instances:";
            // 
            // btn_health_refresh
            // 
            this.btn_health_refresh.Location = new System.Drawing.Point(11, 176);
            this.btn_health_refresh.Name = "btn_health_refresh";
            this.btn_health_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_health_refresh.TabIndex = 12;
            this.btn_health_refresh.Text = "Refresh";
            this.btn_health_refresh.UseVisualStyleBackColor = true;
            this.btn_health_refresh.Click += new System.EventHandler(this.btn_health_refresh_Click);
            // 
            // lbl_health_applications_c
            // 
            this.lbl_health_applications_c.AutoSize = true;
            this.lbl_health_applications_c.Location = new System.Drawing.Point(132, 68);
            this.lbl_health_applications_c.Name = "lbl_health_applications_c";
            this.lbl_health_applications_c.Size = new System.Drawing.Size(13, 13);
            this.lbl_health_applications_c.TabIndex = 11;
            this.lbl_health_applications_c.Text = "0";
            // 
            // lbl_health_hostinstances_c
            // 
            this.lbl_health_hostinstances_c.AutoSize = true;
            this.lbl_health_hostinstances_c.Location = new System.Drawing.Point(132, 91);
            this.lbl_health_hostinstances_c.Name = "lbl_health_hostinstances_c";
            this.lbl_health_hostinstances_c.Size = new System.Drawing.Size(13, 13);
            this.lbl_health_hostinstances_c.TabIndex = 10;
            this.lbl_health_hostinstances_c.Text = "0";
            // 
            // lbl_health_hostinstances
            // 
            this.lbl_health_hostinstances.AutoSize = true;
            this.lbl_health_hostinstances.Location = new System.Drawing.Point(8, 91);
            this.lbl_health_hostinstances.Name = "lbl_health_hostinstances";
            this.lbl_health_hostinstances.Size = new System.Drawing.Size(81, 13);
            this.lbl_health_hostinstances.TabIndex = 9;
            this.lbl_health_hostinstances.Text = "Host Instances:";
            // 
            // lbl_health_applications
            // 
            this.lbl_health_applications.AutoSize = true;
            this.lbl_health_applications.Location = new System.Drawing.Point(8, 68);
            this.lbl_health_applications.Name = "lbl_health_applications";
            this.lbl_health_applications.Size = new System.Drawing.Size(67, 13);
            this.lbl_health_applications.TabIndex = 8;
            this.lbl_health_applications.Text = "Applications:";
            // 
            // lbl_suspendedinstances_c
            // 
            this.lbl_suspendedinstances_c.AutoSize = true;
            this.lbl_suspendedinstances_c.Location = new System.Drawing.Point(132, 29);
            this.lbl_suspendedinstances_c.Name = "lbl_suspendedinstances_c";
            this.lbl_suspendedinstances_c.Size = new System.Drawing.Size(13, 13);
            this.lbl_suspendedinstances_c.TabIndex = 7;
            this.lbl_suspendedinstances_c.Text = "0";
            // 
            // lbl_suspendedinstances
            // 
            this.lbl_suspendedinstances.AutoSize = true;
            this.lbl_suspendedinstances.Location = new System.Drawing.Point(8, 29);
            this.lbl_suspendedinstances.Name = "lbl_suspendedinstances";
            this.lbl_suspendedinstances.Size = new System.Drawing.Size(113, 13);
            this.lbl_suspendedinstances.TabIndex = 6;
            this.lbl_suspendedinstances.Text = "Suspended Instances:";
            // 
            // btn_health_terminate
            // 
            this.btn_health_terminate.Location = new System.Drawing.Point(113, 176);
            this.btn_health_terminate.Name = "btn_health_terminate";
            this.btn_health_terminate.Size = new System.Drawing.Size(75, 23);
            this.btn_health_terminate.TabIndex = 1;
            this.btn_health_terminate.Text = "Terminate";
            this.btn_health_terminate.UseVisualStyleBackColor = true;
            this.btn_health_terminate.Click += new System.EventHandler(this.btn_health_terminate_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(816, 24);
            this.mainMenuStrip.TabIndex = 23;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.toolStripSeparatorMain,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.connectToolStripMenuItem.Text = "&Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // toolStripSeparatorMain
            // 
            this.toolStripSeparatorMain.Name = "toolStripSeparatorMain";
            this.toolStripSeparatorMain.Size = new System.Drawing.Size(159, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogToolStripMenuItem,
            this.saveLogToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            this.clearLogToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.clearLogToolStripMenuItem.Text = "Clear Log";
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // saveLogToolStripMenuItem
            // 
            this.saveLogToolStripMenuItem.Name = "saveLogToolStripMenuItem";
            this.saveLogToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveLogToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveLogToolStripMenuItem.Text = "Save Log As...";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "&Actions";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.aboutToolStripMenuItem.Text = "&About BTF GUI";
            // 
            // btn_applications_export
            // 
            this.btn_applications_export.Location = new System.Drawing.Point(511, 119);
            this.btn_applications_export.Name = "btn_applications_export";
            this.btn_applications_export.Size = new System.Drawing.Size(75, 23);
            this.btn_applications_export.TabIndex = 7;
            this.btn_applications_export.Text = "Export";
            this.btn_applications_export.UseVisualStyleBackColor = true;
            this.btn_applications_export.Click += new System.EventHandler(this.btn_applications_export_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 714);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.gb_health);
            this.Controls.Add(this.gb_server);
            this.Controls.Add(this.gb_applications);
            this.Controls.Add(this.gb_hostinstances);
            this.Controls.Add(this.gb_log);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BTF GUI 0.1";
            this.gb_log.ResumeLayout(false);
            this.gb_log.PerformLayout();
            this.gb_hostinstances.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hostinstances)).EndInit();
            this.gb_applications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_applications)).EndInit();
            this.gb_server.ResumeLayout(false);
            this.gb_server.PerformLayout();
            this.gb_health.ResumeLayout(false);
            this.gb_health.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_log;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.GroupBox gb_hostinstances;
        private System.Windows.Forms.Button btn_hostinstances_stop;
        private System.Windows.Forms.Button btn_hostinstances_refresh;
        private System.Windows.Forms.Button btn_hostinstances_restart;
        private System.Windows.Forms.GroupBox gb_applications;
        private System.Windows.Forms.Button btn_applications_refresh;
        private System.Windows.Forms.Button btn_applications_start;
        private System.Windows.Forms.Button btn_applications_stop;
        private System.Windows.Forms.GroupBox gb_server;
        private System.Windows.Forms.Label lbl_database_c;
        private System.Windows.Forms.Label lbl_group_c;
        private System.Windows.Forms.Label lbl_server_c;
        private System.Windows.Forms.Label lbl_database;
        private System.Windows.Forms.Label lbl_group;
        private System.Windows.Forms.Label lbl_server;
        private System.Windows.Forms.Button btn_applications_remove;
        private System.Windows.Forms.GroupBox gb_health;
        private System.Windows.Forms.Label lbl_suspendedinstances_c;
        private System.Windows.Forms.Label lbl_suspendedinstances;
        private System.Windows.Forms.Button btn_health_terminate;
        private System.Windows.Forms.Label lbl_health_applications_c;
        private System.Windows.Forms.Label lbl_health_hostinstances_c;
        private System.Windows.Forms.Label lbl_health_hostinstances;
        private System.Windows.Forms.Label lbl_health_applications;
        private System.Windows.Forms.DataGridView dgv_hostinstances;
        private System.Windows.Forms.DataGridView dgv_applications;
        private System.Windows.Forms.Button btn_health_refresh;
        private System.Windows.Forms.Label lbl_runninginstances_c;
        private System.Windows.Forms.Label lbl_runninginstances;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorMain;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btn_applications_export;
    }
}

