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

        public ServerConnectorPresenter(IServerConnector view)
        {
            m_View = view;
            Initialize();
        }

        private void Initialize()
        {
            m_View.ConnectToSqlServer += ConnectToSqlServer;
            m_View.ConnectToMySql += ConnectToMySql;
            m_View.Cancel += Cancel;
        }

        private void ConnectToSqlServer()
        {
            SqlConnection conn = new SqlConnection(SqlServerConnectionString());
            try
            {
                conn.Open();
                m_View.Server = new Server(new ServerConnection(conn));
                m_View.Form = DialogResult.OK;
                m_View.MySqlButtonEnabled = false;
                m_View.ServerType = ServerType.SqlServer;
                m_View.ConnectionSuccessful = true;
            }
            catch (SqlException e)
            {
                m_View.Form = DialogResult.Abort;
                m_View.ConnectionSuccessful = false;
            }
        }

        private void ConnectToMySql()
        {
            //TODO -  implement connection code
            m_View.SqlServerButtonEnabled = false;
            m_View.ServerType = ServerType.MySql;
        }

        private void Cancel()
        {
            m_View.Form = DialogResult.Cancel;
        }

        private string SqlServerConnectionString()
        {
            string connectionString = "Integrated Security=SSPI;" +
                                      "Persist Security Info=True;" +
                                      "Initial Catalog=" + m_View.DatabaseName + ";" +
                                      "Data Source=" + m_View.ServerName + ";";
            return connectionString;
        }

        private string MySqlConnectionString()
        {
            //TODO - code for connection string
            return "";
        }
    }
}
