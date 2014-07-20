using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using MySql.Data.MySqlClient;

namespace SQLScriptExecutor
{
    public partial class frmServerConnector : Form, IServerConnector
    {
        private ServerConnectorPresenter m_Presenter;

        public frmServerConnector()
        {
            InitializeComponent();
        }

        #region Getters and Setters

        public string ServerName
        {
            get { return txtServerAddress.Text; }
            set { txtServerAddress.Text = value; }
        }

        public string DatabaseName
        {
            get { return txtDatabaseName.Text; }
            set { txtDatabaseName.Text = value; }
        }

        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public Server Server { get; set; }

        public MySqlConnection MySqlConn { get; set; }

        public ServerType ServerType { get; set; }

        public bool ConnectionSuccessful { get; set; }

        public DialogResult Form
        {
            get { return this.DialogResult; }
            set { this.DialogResult = value; }
        }

        public bool ConnectButtonEnabled
        {
            set { btnConnect.Enabled = value; }
        }

        #region private methods

        private void Connect()
        {
            if (radioSqlServer.Checked)
            {
                ConnectToSqlServer();
            }
            else if (radioMySql.Checked)
            {
                ConnectToMySql();
            }
            else if (radioOracleDB.Checked)
            {
                ConnectToOracleDB();
            }
        }

        #endregion

        #endregion

        public event VoidHandler ConnectToSqlServer;
        public event VoidHandler ConnectToMySql;
        public event VoidHandler ConnectToOracleDB;
        public event VoidHandler Cancel;

        #region Events

        private void frmServerConnector_Load(object sender, EventArgs e)
        {
            m_Presenter = new ServerConnectorPresenter(this);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        #endregion
    }
}
