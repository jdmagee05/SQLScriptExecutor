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

namespace SQLScriptExecutor
{
    public partial class frmServerConnector : Form, IServerConnector
    {
        private ServerConnectorPresenter m_Presenter;
        private Server m_Server;

        public frmServerConnector()
        {
            InitializeComponent();
        }

        private void frmServerConnector_Load(object sender, EventArgs e)
        {
            m_Presenter = new ServerConnectorPresenter(this);
        }

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

        public Server Server
        {
            get { return m_Server; }
            set { m_Server = value; }
        }

        public DialogResult Form
        {
            get { return this.DialogResult; }
            set { this.DialogResult = value; }
        }

        public event VoidHandler Connect;
        public event VoidHandler Cancel;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
    }
}
