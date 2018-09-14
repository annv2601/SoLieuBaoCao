using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using daoSLPH.DataClient;

namespace LaySoLieu
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
            //Application.Run(new frmTheoDoi());
            frmTheoDoi csTD = new frmTheoDoi();

            RegistryKey rk = Registry.CurrentUser.OpenSubKey
            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rk.SetValue("LayDuLieuTuDong", Application.ExecutablePath);



            /*daDuLieuPayPost dDLPP = new daDuLieuPayPost();
            dDLPP.Xoa(DateTime.Now.AddDays(-1));
            dDLPP.Dispose();
            dDLPP = null;*/

            Application.Run();
            csTD.Hide();

            
        }
    }
}
