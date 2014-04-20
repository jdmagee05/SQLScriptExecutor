using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace SQLScriptExecutor
{
    public class ServerConnectorPresenter
    {
        private IServerConnector m_View;
        private string m_SqlConnectionString;
        private Server m_Server;

        public ServerConnectorPresenter(IServerConnector view)
        {
            m_View = view;
            Initialize();
        }

        private void Initialize()
        {
            m_View.Connect += Connect;
            m_View.Cancel += Cancel;
        }

        private void Connect()
        {
            SqlConnection conn = new SqlConnection(SqlConnectionString());
            m_View.Server = new Server(new ServerConnection(conn));
            m_View.Form = DialogResult.OK;
        }

        private void Cancel()
        {
            m_View.Form = DialogResult.Cancel;
        }

        private string SqlConnectionString()
        {
            string connectionString = "Integrated Security=SSPI;" +
                                      "Persist Security Info=True;" +
                                      "Initial Catalog=" + m_View.DatabaseName + ";" +
                                      "Data Source=" + m_View.ServerName + ";";
            return connectionString;
        }
    }
}
