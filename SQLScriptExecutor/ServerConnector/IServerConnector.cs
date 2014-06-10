using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;

namespace SQLScriptExecutor
{
    public interface IServerConnector
    {
        string ServerName { get; set; }
        string DatabaseName { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        Server Server { get; set; }
        ServerType ServerType { get; set; }
        bool ConnectionSuccessful { get; set; }

        DialogResult Form { get; set; }

        event VoidHandler ConnectToSqlServer;
        event VoidHandler ConnectToMySql;
        event VoidHandler Cancel;

        bool SqlServerButtonEnabled { set; }
        bool MySqlButtonEnabled { set; }
    }
}
