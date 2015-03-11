namespace BTFGui
{
    partial class ConnectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectForm));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grouperConnectionSettings = new System.Windows.Forms.GroupBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.txtSqlServerName = new System.Windows.Forms.TextBox();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.lblSqlServerName = new System.Windows.Forms.Label();
            this.grouperConnectionSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(237, 102);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(319, 102);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grouperConnectionSettings
            // 
            this.grouperConnectionSettings.Controls.Add(this.txtDatabaseName);
            this.grouperConnectionSettings.Controls.Add(this.txtSqlServerName);
            this.grouperConnectionSettings.Controls.Add(this.lblDatabaseName);
            this.grouperConnectionSettings.Controls.Add(this.lblSqlServerName);
            this.grouperConnectionSettings.Location = new System.Drawing.Point(3, 4);
            this.grouperConnectionSettings.Name = "grouperConnectionSettings";
            this.grouperConnectionSettings.Size = new System.Drawing.Size(391, 92);
            this.grouperConnectionSettings.TabIndex = 2;
            this.grouperConnectionSettings.TabStop = false;
            this.grouperConnectionSettings.Text = "BizTalk Connection Settings";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(122, 51);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(174, 20);
            this.txtDatabaseName.TabIndex = 3;
            // 
            // txtSqlServerName
            // 
            this.txtSqlServerName.Location = new System.Drawing.Point(122, 24);
            this.txtSqlServerName.Name = "txtSqlServerName";
            this.txtSqlServerName.Size = new System.Drawing.Size(174, 20);
            this.txtSqlServerName.TabIndex = 2;
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.Location = new System.Drawing.Point(10, 54);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(85, 13);
            this.lblDatabaseName.TabIndex = 1;
            this.lblDatabaseName.Text = "Database name:";
            // 
            // lblSqlServerName
            // 
            this.lblSqlServerName.AutoSize = true;
            this.lblSqlServerName.Location = new System.Drawing.Point(10, 27);
            this.lblSqlServerName.Name = "lblSqlServerName";
            this.lblSqlServerName.Size = new System.Drawing.Size(94, 13);
            this.lblSqlServerName.TabIndex = 0;
            this.lblSqlServerName.Text = "SQL Server name:";
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 136);
            this.Controls.Add(this.grouperConnectionSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to BizTalk Server";
            this.grouperConnectionSettings.ResumeLayout(false);
            this.grouperConnectionSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grouperConnectionSettings;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.TextBox txtSqlServerName;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.Label lblSqlServerName;
    }
}