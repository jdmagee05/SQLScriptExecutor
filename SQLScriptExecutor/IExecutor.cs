using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;

namespace SQLScriptExecutor
{
    public interface IExecutor
    {
        string Output { get; set; }
        List<string> Files { get; set; }
        ListView FileViewer { get; set; }
        string[] RecentlyAddedFiles { get; set; }
        Server Server { get; set; }
        ServerType ServerType { get; set; }
        string DatabaseName { get; set; }
        string ServerName { get; set; }

        bool ExecuteEnabled { set; }
        bool ClearEnabled { set; }
        bool ConnectButtonEnabled { set; }
        bool DisconnectButtonEnabled { set; }

        event VoidHandler AddFilesToFileViewer;
        event VoidHandler ClearFiles;
        event VoidHandler Execute;
        event VoidHandler OpenServerConnector;
        event VoidHandler Disconnect;
    }
}
