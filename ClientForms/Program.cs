using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                try
                {
                    FrmPrijava frmPrijava = new FrmPrijava();
                    frmPrijava.ShowDialog();
                    DialogResult rez = frmPrijava.DialogResult;
                    frmPrijava.Dispose();
                    if (rez == DialogResult.OK)
                    {
                        Application.Run(new FrmGlavna());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri radu sa serverom!");
                }
        }
    }
}