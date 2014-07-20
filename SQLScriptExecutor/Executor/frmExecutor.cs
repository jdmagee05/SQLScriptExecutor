using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using MySql.Data.MySqlClient;

namespace SQLScriptExecutor
{
    public partial class frmExecutor : Form, IExecutor
    {
        private List<string> m_Files = new List<string>();
        private string[] m_RecentlyAddedFiles;
        private ExecutorPresenter m_Presenter;
        private string m_ServerName;

        public frmExecutor()
        {
            InitializeComponent();
            lvFileViewer.AllowDrop = true;
            lvFileViewer.DragEnter += lvFileViewer_DragEnter;
            lvFileViewer.DragDrop += lvFileViewer_DrapDrop;
        }

        public event VoidHandler AddFilesToFileViewer;
        public event VoidHandler ClearFiles;
        public event VoidHandler Execute;
        public event VoidHandler OpenServerConnector;
        public event VoidHandler Disconnect;

        #region  Getters and Setters

        public List<string> Files
        {
            get { return m_Files; }
            set { m_Files = value; }
        }

        public string Output
        {
            get { return txtOutput.Text; }
            set { txtOutput.Text = value; }
        }


        public ListView FileViewer
        {
            get { return lvFileViewer; }
            set { lvFileViewer = value; }
        }

        public string[] RecentlyAddedFiles
        {
            get { return m_RecentlyAddedFiles; }
            set { m_RecentlyAddedFiles = value; }
        }

        public Server Server { get; set; }

        public MySqlConnection MySqlConn { get; set; }

        public ServerType ServerType { get; set; }

        public string DatabaseName { get; set; }

        public string ServerName { get; set; }

        public bool ExecuteEnabled
        {
            set { btnExecute.Enabled = value; }
        }

        public bool ClearEnabled
        {
            set { btnClear.Enabled = value; }
        }

        public bool ConnectButtonEnabled
        {
            set { btnSqlConnect.Enabled = value; }
        }

        public bool DisconnectButtonEnabled
        {
            set { btnDisconnect.Enabled = value; }
        }

        #endregion

        #region Events

        private void frmExecutor_Load(object sender, EventArgs e)
        {
            m_Presenter = new ExecutorPresenter(this);
        }

        private void lvFileViewer_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lvFileViewer_DrapDrop(object sender, DragEventArgs e)
        {
            m_RecentlyAddedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            AddFilesToFileViewer();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFiles();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            Execute();
        }

        private void btnSqlConnect_Click(object sender, EventArgs e)
        {
            OpenServerConnector();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        #endregion
    }
}
