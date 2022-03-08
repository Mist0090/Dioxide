using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DIOXIDE
{
    public partial class Freeze : Form
    {
        public Freeze()
        {
            InitializeComponent();
        }

        private void Freeze_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void Freeze_Load(object sender, EventArgs e)
        {
            while (true)
            {
                this.Select();
            }
        }
    }
}
