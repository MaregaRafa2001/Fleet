using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Fleet
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppSettingsReader readerSettings = new AppSettingsReader();
            GLOBAL_BLL.stringConexaoBanco = System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoFleet"].ConnectionString;

            Login frmLogin = new Login();
            DialogResult result = frmLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                frmLogin.Close();
                frmLogin.Dispose();

                Application.Run(new frmPrincipal());
            }
        }
    }
}
