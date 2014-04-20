using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;

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
            //subscribe to events
            m_View.AddFilesToFileViewer += AddFilesToFileViewer;
            m_View.ClearFiles += ClearFiles;
            m_View.Execute += Execute;
            m_View.OpenServerConnector += OpenServerConnector;

            m_View.ExecuteEnabled = false;
            m_View.ClearEnabled = false;
        }

        private void AddFilesToFileViewer()
        {
            foreach(string file in m_View.RecentlyAddedFiles)
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
            DisableButtons();
        }

        private void Execute()
        {
            foreach (string file in m_View.Files)
            {
                var fileInfo = new FileInfo(file);
                string script = fileInfo.OpenText().ReadToEnd();
                try
                {
                    m_View.Server.ConnectionContext.ExecuteNonQuery(script);
                    m_View.Output += Path.GetFileNameWithoutExtension(file) + "executed successfully\n";
                }
                catch (NullReferenceException)
                {
                    m_View.Output += "CONNECT TO SERVER";
                    break;
                }
                catch (ExecutionFailureException ex)
                {
                    m_View.Output += "FAILURE EXECUTING: " + Path.GetFileNameWithoutExtension(file) + "\n";
                    m_View.Output += ex.Message + "\n";
                    break;
                }
            }
        }

        private void OpenServerConnector()
        {
            frmServerConnector serverConnection = new frmServerConnector();
            serverConnection.ShowDialog();
            m_View.Server = serverConnection.Server;
        }

        private void EnableExecuteAndClearButtons()
        {
            m_View.ExecuteEnabled = true;
            m_View.ClearEnabled = true;
        }

        private void DisableButtons()
        {
            m_View.ExecuteEnabled = false;
            m_View.ClearEnabled = false;
        }
    }
}
