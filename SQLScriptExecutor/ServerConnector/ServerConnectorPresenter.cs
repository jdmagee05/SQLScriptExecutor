using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using MySql.Data.MySqlClient;

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
            MySqlConnection conn = new MySqlConnection(MySQLConnectionString());
            try
            {
                conn.Open();
                m_View.MySqlConn = conn;
                m_View.Form = DialogResult.OK;
                m_View.ConnectButtonEnabled = false;
                m_View.ServerType = ServerType.MySql;
                m_View.ConnectionSuccessful = true;
            }
            catch
            {
                m_View.Form = DialogResult.Abort;
                m_View.ConnectionSuccessful = false;
            }
            
        }

        private void ConnectToOracleDB()
        {
            //TODO implement Connection code
            m_View.ConnectButtonEnabled = false;
            m_View.ServerType = ServerType.Oracle;
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

        private string MySQLConnectionString()
        {
            string connectionString = "SERVER=" + m_View.ServerName + ";" +
                                      "DATABASE=" + m_View.DatabaseName + ";" +
                                      "UID=" + m_View.Username + ";" +
                                      "PASSWORD=" + m_View.Password + ";";

            return connectionString;
        }
    }
}
