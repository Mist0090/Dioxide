using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using static DIOXIDE.Win32API;

namespace DIOXIDE
{
    public static class Functions
    {
        public const float PI = 3.1415926535897931f;

        public const float PI2 = PI * 2.0f;
        public const int TABLE_SIZE = 1024 * 128;
        public const float TABLE_SIZE_D = (float)TABLE_SIZE;
        public const float FACTOR = TABLE_SIZE_D / PI2;
        public static float[] _CosineDoubleTable;
        public static float[] _SineDoubleTable;

        public static string TempPath = Path.GetTempPath();
        public static string exePath = Application.ExecutablePath;

        public static void AdminProcessStart( string FileName, string CmdLine )
        {
            ProcessStartInfo ps = new ProcessStartInfo();

            ps.FileName = FileName;
            ps.Arguments = CmdLine;
            ps.Verb = "runas";
            Process.Start( ps );

            return;
        }
        public static void Sleep( uint dwMilliseconds )
        {
            Thread.Sleep( (int)dwMilliseconds );
        }
        public static void CreateThreadStart( ThreadStart thread )
        {
            new Thread( new ThreadStart( thread ) ).Start();
        }
        static int xs;
        public static void SeedXorshift32( IntPtr dwSeed )
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
        public static int RotateDC( IntPtr hdc, int Angle, POINT ptCenter )
        {
            int nGraphicsMode = SetGraphicsMode( hdc, GM_ADVANCED );
            XFORM xform;
            if (Angle != 0)
            {
                double fangle = (double)Angle / 180 * 3.1415926;
                xform.eM11 = (float)Math.Cos( fangle );
                xform.eM12 = (float)Math.Sin( fangle );
                xform.eM21 = (float)-Math.Sin( fangle );
                xform.eM22 = (float)Math.Cos( fangle );
                xform.eDx = (float)(ptCenter.x - Math.Cos( fangle ) * ptCenter.x + Math.Sin( fangle ) * ptCenter.y);
                xform.eDy = (float)(ptCenter.y - Math.Cos( fangle ) * ptCenter.y - Math.Sin( fangle ) * ptCenter.x);
                SetWorldTransform( hdc, ref xform );
            }
            return nGraphicsMode;
        }
        public static float Sin2( float Value )
        {
            Value %= PI2;
            if (Value < 0) Value += PI2;
            int index = (int)(Value * FACTOR);
            return _SineDoubleTable[index];
        }
        public static float Sin( float x ) //x in radians
        {
            float sinn;
            if (x < -3.14159265f)
                x += 6.28318531f;
            else
            if (x > 3.14159265f)
                x -= 6.28318531f;

            if (x < 0)
            {
                sinn = 1.27323954f * x + 0.405284735f * x * x;

                if (sinn < 0)
                    sinn = 0.225f * (sinn * -sinn - sinn) + sinn;
                else
                    sinn = 0.225f * (sinn * sinn - sinn) + sinn;
                return sinn;
            }
            else
            {
                sinn = 1.27323954f * x - 0.405284735f * x * x;

                if (sinn < 0)
                    sinn = 0.225f * (sinn * -sinn - sinn) + sinn;
                else
                    sinn = 0.225f * (sinn * sinn - sinn) + sinn;
                return sinn;

            }
        }
        public static float Cos( float x ) //x in radians
        {
            return Sin( x + 1.5707963f );
        }
        public static Bitmap CaptureScreen()
        {
            //プライマリモニタのデバイスコンテキストを取得
            IntPtr disDC = GetDC( IntPtr.Zero );
            //Bitmapの作成
            Bitmap bmp = new Bitmap( Screen.PrimaryScreen.Bounds.Width,
                Screen.PrimaryScreen.Bounds.Height );
            //Graphicsの作成
            Graphics g = Graphics.FromImage( bmp );
            g.SmoothingMode = SmoothingMode.HighSpeed;
            g.PixelOffsetMode = PixelOffsetMode.HighSpeed;

            //Graphicsのデバイスコンテキストを取得
            IntPtr hDC = g.GetHdc();
            //Bitmapに画像をコピーする
            BitBlt( hDC, 0, 0, bmp.Width, bmp.Height,
                disDC, 0, 0, TernaryRasterOperations.SRCCOPY );
            //解放
            g.ReleaseHdc( hDC );
            g.Dispose();
            ReleaseDC( IntPtr.Zero, disDC );

            return bmp;
        }
    }
}