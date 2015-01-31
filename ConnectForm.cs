using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTF.GUI
{
    public partial class ConnectForm : Form
    {
        public string SqlServerName { get; set; }
        public string BizTalkDatabaseName { get; set; }
        
        public ConnectForm(string dbServer, string dbName)
        {
            InitializeComponent();
            
            if (!string.IsNullOrEmpty(dbServer))
            {
                txtSqlServerName.Text = dbServer;
            }

            if (!string.IsNullOrEmpty(dbName))
            {
                txtDatabaseName.Text = dbName;
            }

           
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlServerName = txtSqlServerName.Text;
            BizTalkDatabaseName = txtDatabaseName.Text;

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
