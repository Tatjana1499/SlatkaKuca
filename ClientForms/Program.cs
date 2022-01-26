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
            while (true)
            {
                try
                {
                    FrmPrijava frmPrijava = new FrmPrijava();
                    frmPrijava.ShowDialog();
                    DialogResult result = frmPrijava.DialogResult;
                    frmPrijava.Dispose();

                    if (result == DialogResult.OK)
                    {
                        Application.Run(new FrmGlavna());
                    }
                    if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska pri radu sa serverom!");
                }
            }
        }
    }
}