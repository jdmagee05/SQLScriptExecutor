using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using MySql.Data.MySqlClient;

namespace SQLScriptExecutor
{
    public class ExecutorPresenter
    {
        private IExecutor m_View;

        public ExecutorPresenter(IExecutor view)
        {
            m_View = view;
            Initialize();
        }

        private void Initialize()
        {
            m_View.AddFilesToFileViewer += AddFilesToFileViewer;
            m_View.ClearFiles += ClearFiles;
            m_View.Execute += Execute;
            m_View.OpenServerConnector += OpenServerConnector;
            m_View.Disconnect += Disconnect;

            m_View.ExecuteEnabled = false;
            m_View.ClearEnabled = false;
            m_View.DisconnectButtonEnabled = false;
        }

        private void AddFilesToFileViewer()
        {
            foreach (string file in m_View.RecentlyAddedFiles)
            {
                if (Path.GetExtension(file) == ".sql")
                {
                    m_View.Files.Add(file);
                    m_View.FileViewer.Items.Add(Path.GetFileNameWithoutExtension(file));
                }
                EnableExecuteAndClearButtons();
            }
        }

        private void ClearFiles()
        {
            m_View.Files.Clear();
            m_View.FileViewer.Clear();
            DisableExecuteAndClearButtons();
        }

        private void Execute()
        {
            switch (m_View.ServerType)
            {
                case ServerType.None:
                    m_View.Output += "CONNECT TO A SERVER\n";
                    break;

                case ServerType.SqlServer:
                    foreach (string file in m_View.Files)
                    {
                        ExecuteSqlServer(file);
                    }
                    break;

                case ServerType.MySql:
                    foreach (string file in m_View.Files)
                    {
                        ExecuteMySql(file);
                    }
                    break;
            }

        }

        private void ExecuteSqlServer(string file)
        {
            var fileInfo = new FileInfo(file);
            string script = fileInfo.OpenText().ReadToEnd();
            try
            {
                m_View.Server.ConnectionContext.ExecuteNonQuery(script);
                m_View.Output += Path.GetFileNameWithoutExtension(file) + " executed successfully!\n";
            }
            catch (NullReferenceException)
            {
                m_View.Output += "CONNECT TO A SERVER\n";
            }
            catch (ExecutionFailureException ex)
            {
                m_View.Output += "FAILURE EXECUTING: " + Path.GetFileNameWithoutExtension(file) + "\n";
                m_View.Output += ex.Message + "\n";
            }
        }

        private void ExecuteMySql(string file)
        {
            var fileInfo = new FileInfo(file);
            string script = fileInfo.OpenText().ReadToEnd();
            try
            {
                MySqlScript mySqlScript = new MySqlScript(m_View.MySqlConn, script);
                mySqlScript.Execute();
                m_View.Output += Path.GetFileNameWithoutExtension(file) + " executed successfully!\n";
            }
            catch(NullReferenceException)
            {
                m_View.Output += "CONNECT TO A SERVER\n";
            }
            catch (MySqlException ex)
            {
                m_View.Output += "FAILURE EXECUTING: " + Path.GetFileNameWithoutExtension(file) + "\n";
                m_View.Output += ex.Message + "\n";
            }

        }

        private void OpenServerConnector()
        {
            frmServerConnector serverConnection = new frmServerConnector();
            serverConnection.ShowDialog();
            if (serverConnection.ConnectionSuccessful)
            {
                m_View.ServerType = serverConnection.ServerType;
                CreateServerOrSqlConnection(serverConnection);
                m_View.DatabaseName = serverConnection.DatabaseName;
                m_View.ServerName = serverConnection.ServerName;
                m_View.Output = "Connected to " + m_View.DatabaseName + " on " + m_View.ServerName + "\n";
                m_View.ConnectButtonEnabled = false;
                m_View.DisconnectButtonEnabled = true;
            }
            else if (serverConnection.Form == DialogResult.Cancel)
            {
                m_View.Output += "Server connection cancelled\n";
            }
            else
            {
                m_View.Output += "CONNECTION FAILED!\n";
            }
        }

        private void CreateServerOrSqlConnection(frmServerConnector serverConnection)
        {
            if (m_View.ServerType == ServerType.SqlServer)
            {
                m_View.Server = serverConnection.Server;
            }
            else if (m_View.ServerType == ServerType.MySql)
            {
                m_View.MySqlConn = serverConnection.MySqlConn;
            }
        }

        private void EnableExecuteAndClearButtons()
        {
            m_View.ExecuteEnabled = true;
            m_View.ClearEnabled = true;
        }

        private void DisableExecuteAndClearButtons()
        {
            m_View.ExecuteEnabled = false;
            m_View.ClearEnabled = false;
        }

        private void Disconnect()
        {
            switch (m_View.ServerType)
            {
                case ServerType.SqlServer:
                    DisconnectFromSqlServer();
                    break;

                case ServerType.MySql:
                    DisconnectFromMySql();
                    break;
            }

            m_View.Output += "Disconnected from " + m_View.ServerName + "\n";
            m_View.ConnectButtonEnabled = true;
            m_View.DisconnectButtonEnabled = false;
            ResetCommonInformation();
        }

        private void DisconnectFromSqlServer()
        {
            m_View.Server.ConnectionContext.Disconnect();
            ResetSqlServerInformation();
        }

        private void DisconnectFromMySql()
        {
            m_View.MySqlConn.Close();
            ResetMySqlInformation();
        }

        private void ResetSqlServerInformation()
        {
            m_View.Server = null;
        }

        private void ResetMySqlInformation()
        {
            m_View.MySqlConn = null;
        }

        private void ResetCommonInformation()
        {
            m_View.ServerType = ServerType.None;
            m_View.ServerName = null;
            m_View.DatabaseName = null;
        }
    }
}

