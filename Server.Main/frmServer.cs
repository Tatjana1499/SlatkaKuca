using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Main
{
    public partial class frmServer : Form
    {
        Server server;
        public frmServer()
        {
            InitializeComponent();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            txtStatus.Text = "Server je zaustavljen!";
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            server = new Server();
            if (server.Start())
            {
                btnStart.Enabled = false;
                btnStop.Enabled = true;
                Thread thread = new Thread(server.HandleClient);
                thread.IsBackground = true;
                thread.Start();
                txtStatus.Text = "Server je pokrenut!";
            }
            else
            {
                MessageBox.Show("Server nije pokrenut!");
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            server?.Stop();
            server = null;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            txtStatus.Text = "Server je zaustavljen!";
        }
        private void frmServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}