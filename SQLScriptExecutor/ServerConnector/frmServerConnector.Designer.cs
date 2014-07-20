namespace SQLScriptExecutor
{
    partial class frmServerConnector
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
            this.lblServerAddress = new System.Windows.Forms.Label();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpServerTypes = new System.Windows.Forms.GroupBox();
            this.radioSqlServer = new System.Windows.Forms.RadioButton();
            this.radioMySql = new System.Windows.Forms.RadioButton();
            this.radioOracleDB = new System.Windows.Forms.RadioButton();
            this.grpServerTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServerAddress
            // 
            this.lblServerAddress.AutoSize = true;
            this.lblServerAddress.Location = new System.Drawing.Point(44, 42);
            this.lblServerAddress.Name = "lblServerAddress";
            this.lblServerAddress.Size = new System.Drawing.Size(82, 13);
            this.lblServerAddress.TabIndex = 0;
            this.lblServerAddress.Text = "Server Address:";
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.Location = new System.Drawing.Point(39, 80);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(87, 13);
            this.lblDatabaseName.TabIndex = 1;
            this.lblDatabaseName.Text = "Database Name:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(68, 124);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(73, 170);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Location = new System.Drawing.Point(152, 39);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(81, 20);
            this.txtServerAddress.TabIndex = 4;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(152, 77);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(81, 20);
            this.txtDatabaseName.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(152, 117);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(81, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(152, 163);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(81, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(71, 337);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(69, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(152, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpServerTypes
            // 
            this.grpServerTypes.Controls.Add(this.radioOracleDB);
            this.grpServerTypes.Controls.Add(this.radioMySql);
            this.grpServerTypes.Controls.Add(this.radioSqlServer);
            this.grpServerTypes.Location = new System.Drawing.Point(42, 210);
            this.grpServerTypes.Name = "grpServerTypes";
            this.grpServerTypes.Size = new System.Drawing.Size(200, 106);
            this.grpServerTypes.TabIndex = 10;
            this.grpServerTypes.TabStop = false;
            this.grpServerTypes.Text = "Select Server Type";
            // 
            // radioSqlServer
            // 
            this.radioSqlServer.AutoSize = true;
            this.radioSqlServer.Location = new System.Drawing.Point(6, 19);
            this.radioSqlServer.Name = "radioSqlServer";
            this.radioSqlServer.Size = new System.Drawing.Size(80, 17);
            this.radioSqlServer.TabIndex = 0;
            this.radioSqlServer.TabStop = true;
            this.radioSqlServer.Text = "SQL Server";
            this.radioSqlServer.UseVisualStyleBackColor = true;
            // 
            // radioMySql
            // 
            this.radioMySql.AutoSize = true;
            this.radioMySql.Location = new System.Drawing.Point(6, 54);
            this.radioMySql.Name = "radioMySql";
            this.radioMySql.Size = new System.Drawing.Size(60, 17);
            this.radioMySql.TabIndex = 1;
            this.radioMySql.TabStop = true;
            this.radioMySql.Text = "MySQL";
            this.radioMySql.UseVisualStyleBackColor = true;
            // 
            // radioOracleDB
            // 
            this.radioOracleDB.AutoSize = true;
            this.radioOracleDB.Location = new System.Drawing.Point(6, 83);
            this.radioOracleDB.Name = "radioOracleDB";
            this.radioOracleDB.Size = new System.Drawing.Size(105, 17);
            this.radioOracleDB.TabIndex = 2;
            this.radioOracleDB.TabStop = true;
            this.radioOracleDB.Text = "Oracle Database";
            this.radioOracleDB.UseVisualStyleBackColor = true;
            // 
            // frmServerConnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 382);
            this.Controls.Add(this.grpServerTypes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.txtServerAddress);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblDatabaseName);
            this.Controls.Add(this.lblServerAddress);
            this.Name = "frmServerConnector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter DB info...";
            this.Load += new System.EventHandler(this.frmServerConnector_Load);
            this.grpServerTypes.ResumeLayout(false);
            this.grpServerTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerAddress;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtServerAddress;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpServerTypes;
        private System.Windows.Forms.RadioButton radioSqlServer;
        private System.Windows.Forms.RadioButton radioOracleDB;
        private System.Windows.Forms.RadioButton radioMySql;
    }
}