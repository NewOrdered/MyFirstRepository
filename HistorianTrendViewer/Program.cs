using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HistorianTrendViewer.BL;

namespace HistorianTrendViewer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmServers frmServers = new FrmServers();
            HistorianServersRepository serversRepository = new HistorianServersRepository();
            ServersPresenter serversPresenter = new ServersPresenter(frmServers, serversRepository);



            Application.Run(frmServers);
        }
    }
}
