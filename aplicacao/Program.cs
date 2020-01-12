using aplicacao.Forms;
using System;
using System.Windows.Forms;

namespace aplicacao
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
#if(DEBUG)
            Application.Run(new frmPrincipal(null));
#else
            Application.Run(new frmLogin());
#endif
        }
    }
}
