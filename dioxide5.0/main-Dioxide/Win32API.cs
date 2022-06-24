using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace DIOXIDE
{
    public class Win32API
    {
        [DllImport( "user32.dll", SetLastError = true )]
        public static extern bool DrawIconEx( IntPtr hdc, int xLeft, int yTop, IntPtr hIcon,
   int cxWidth, int cyHeight, int istepIfAniCur, IntPtr hbrFlickerFreeDraw,
   int diFlags );
        [DllImport( "user32.dll" )]
        public static extern IntPtr LoadIcon( IntPtr hInstance, int lpIconName );

        public static int IDI_APPLICATION = 32512,
                     IDI_HAND = 32513,
                     IDI_QUESTION = 32514,
                     IDI_EXCLAMATION = 32515,
                     IDI_ASTERISK = 32516,
                     IDI_WINLOGO = 32517,
                     IDI_WARNING = IDI_EXCLAMATION,
                     IDI_ERROR = IDI_HAND,
                     IDI_INFORMATION = IDI_ASTERISK;

        [DllImport( "msvcrt.dll", CallingConvention = CallingConvention.Cdecl )]
        public static extern int rand();
        [DllImport( "gdi32.dll" )]
        public static extern IntPtr CreateDIBSection( IntPtr hdc, [In] BITMAPINFOHEADER pbmi, uint pila, IntPtr ppvBits, IntPtr hSection, uint dwOffset );

        [System.Runtime.InteropServices.DllImportAttribute( "gdi32.dll", EntryPoint = "SetWorldTransform" )]
        [return: System.Runtime.InteropServices.MarshalAsAttribute( System.Runtime.InteropServices.UnmanagedType.Bool )]
        public static extern bool SetWorldTransform( System.IntPtr hdc, ref XFORM lpxf );
        [System.Runtime.InteropServices.DllImportAttribute( "gdi32.dll", EntryPoint = "SetGraphicsMode" )]
        public static extern int SetGraphicsMode( System.IntPtr hdc, int iMode );
        public const int GM_ADVANCED = 2;

        [System.Runtime.InteropServices.StructLayoutAttribute( System.Runtime.InteropServices.LayoutKind.Sequential )]
        public struct XFORM
        {

            /// FLOAT->float
            public float eM11;

            /// FLOAT->float
            public float eM12;

            /// FLOAT->float
            public float eM21;

            /// FLOAT->float
            public float eM22;

            /// FLOAT->float
            public float eDx;

            /// FLOAT->float
            public float eDy;
        }

        [DllImport( "advapi32.dll", SetLastError = true )]
        public static extern bool CryptGenRandom( IntPtr hProv, uint dwLen, byte pbBuffer );
        [DllImport( "advapi32.dll", CharSet = CharSet.Auto, SetLastError = true )]
        [return: MarshalAs( UnmanagedType.Bool )]
        public static extern bool CryptAcquireContext( ref IntPtr hProv, string pszContainer, string pszProvider, uint dwProvType, uint dwFlags );
        public static uint CRYPT_NEWKEYSET = 0x8;

        public static uint CRYPT_DELETEKEYSET = 0x10;

        public static uint CRYPT_MACHINE_KEYSET = 0x20;

        public static uint CRYPT_SILENT = 0x40;

        public static uint CRYPT_DEFAULT_CONTAINER_OPTIONAL = 0x80;

        public static uint CRYPT_VERIFYCONTEXT = 0xF0000000;

        public static uint PROV_RSA_FULL = 1;

        [DllImport( "gdi32.dll", EntryPoint = "CreateCompatibleBitmap" )]
        public static extern IntPtr CreateCompatibleBitmap( [In] IntPtr hdc, int nWidth, int nHeight );

        [System.Runtime.InteropServices.DllImportAttribute( "msimg32.dll", EntryPoint = "AlphaBlend" )]
        [return: System.Runtime.InteropServices.MarshalAsAttribute( System.Runtime.InteropServices.UnmanagedType.Bool )]
        public static extern bool AlphaBlend( System.IntPtr hdcDest, int xoriginDest, int yoriginDest, int wDest, int hDest, System.IntPtr hdcSrc, int xoriginSrc, int yoriginSrc, int wSrc, int hSrc, _BLENDFUNCTION ftn );

        [System.Runtime.InteropServices.StructLayoutAttribute( System.Runtime.InteropServices.LayoutKind.Sequential )]
        public struct _BLENDFUNCTION
        {

            /// BYTE->char
            public byte BlendOp;

            /// BYTE->char
            public byte BlendFlags;

            /// BYTE->char
            public byte SourceConstantAlpha;

            /// BYTE->char
            public byte AlphaFormat;
        }
        public const int AC_SRC_OVER = 0;
        [DllImport( "ntdll.dll", SetLastError = true )]
        public static extern int NtSetInformationProcess( IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength );

        [DllImport( "kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true )]
        public static extern IntPtr GetProcAddress( IntPtr hModule, string procName );
        [DllImport( "kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true )]
        public static extern IntPtr GetModuleHandle( [MarshalAs( UnmanagedType.LPWStr )] in string lpModuleName );
        public const UInt32 TOKEN_ADJUST_PRIVILEGES = 0x0020;
        [DllImport( "kernel32.dll", SetLastError = true )]
        public static extern IntPtr GetCurrentProcess();
        [DllImport( "advapi32.dll", SetLastError = true )]
        [return: MarshalAs( UnmanagedType.Bool )]
        public static extern bool OpenProcessToken( IntPtr ProcessHandle,
    UInt32 DesiredAccess, out IntPtr TokenHandle );
        [DllImport( "gdi32.dll" )]
        public static extern bool LineTo( IntPtr hdc, int nXEnd, int nYEnd );
        [DllImport( "gdi32.dll" )]
        public static extern bool RoundRect( IntPtr hdc, int nLeftRect, int nTopRect,
    int nRightRect, int nBottomRect, int nWidth, int nHeight );
        [DllImport( "gdi32.dll" )]
        public static extern IntPtr CreateEllipticRgn( int nLeftRect, int nTopRect,
   int nRightRect, int nBottomRect );
        [DllImport( "gdi32.dll" )]
        public static extern IntPtr CreateRectRgn( int nLeftRect, int nTopRect, int nRightRect, int nBottomRect );
        [DllImport( "gdi32.dll" )]
        public static extern int SelectClipRgn( IntPtr hdc, IntPtr hrgn );
        [DllImport( "user32.dll" )]
        public static extern IntPtr SetProcessDPIAware();

        public delegate bool EnumWindowsProc(
IntPtr hwnd,
bool lParam
);
        [DllImport( "user32.dll" )]
        [return: MarshalAs( UnmanagedType.Bool )]
        public static extern bool EnumWindows( EnumWindowsProc lpEnumFunc, IntPtr lParam );
        [DllImport( "user32.dll" )]
        [return: MarshalAs( UnmanagedType.Bool )]
        public static extern bool EnumChildWindows( IntPtr hwndParent, EnumWindowsProc lpEnumFunc, IntPtr lParam );
        [DllImport( "user32.dll", SetLastError = true, CharSet = CharSet.Unicode )]
        public static extern bool SetWindowTextW( IntPtr hwnd, String lpString );
        [DllImport( "user32.dll", SetLastError = true )]
        internal static extern bool MoveWindow( IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint );
        [DllImport( "gdi32.dll" )]
        public static extern bool PlgBlt( IntPtr hdcDest, POINT lpPoint, IntPtr hdcSrc,
   int nXSrc, int nYSrc, int nWidth, int nHeight, IntPtr hbmMask, int xMask,
   int yMask );
        [DllImport( "user32.dll", SetLastError = true )]
        public static extern bool GetWindowRect( IntPtr hwnd, out RECT lpRect );
        [DllImport( "gdi32.dll" )]
        public static extern bool Rectangle( IntPtr hdc, int nLeftRect, int nTopRect, int nRightRect, int nBottomRect );
        [StructLayout( LayoutKind.Sequential )]
        public class Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }
        [DllImport( "user32.dll" )]
        public extern static int ClipCursor( ref Rect lpRect );
        [DllImport( "user32.dll", SetLastError = true )]
        public static extern bool DrawIcon( IntPtr hdc, int xLeft, int yTop, IntPtr hIcon );
        [DllImport( "user32.dll", SetLastError = true )]
        [return: MarshalAs( UnmanagedType.Bool )]
        public static extern bool GetCursorPos( out POINT lpPoint );
        [StructLayout( LayoutKind.Sequential )]
        public struct CURSORINFO
        {
            public Int32 cbSize;        // Specifies the size, in bytes, of the structure.
                                        // The caller must set this to Marshal.SizeOf(typeof(CURSORINFO)).
            public Int32 flags;         // Specifies the cursor state. This parameter can be one of the following values:
                                        //    0             The cursor is hidden.
                                        //    CURSOR_SHOWING    The cursor is showing.
                                        //    CURSOR_SUPPRESSED    (Windows 8 and above.) The cursor is suppressed. This flag indicates that the system is not drawing the cursor because the user is providing input through touch or pen instead of the mouse.
            public IntPtr hCursor;          // Handle to the cursor.
            public POINT ptScreenPos;       // A POINT structure that receives the screen coordinates of the cursor.
        }

        /// <summary>Must initialize cbSize</summary>
        [DllImport( "user32.dll" )]
        public static extern bool GetCursorInfo( ref CURSORINFO pci );
        [DllImport( "user32.dll" )]
        public static extern bool DestroyCursor( IntPtr hCursor );

        private const Int32 CURSOR_SHOWING = 0x00000001;
        private const Int32 CURSOR_SUPPRESSED = 0x00000002;
        [StructLayout( LayoutKind.Sequential )]
        public struct POINT
        {
            public Int32 x;
            public Int32 y;

            public static explicit operator IntPtr( POINT v )
            {
                throw new NotImplementedException();
            }
        }
        [DllImport( "Kernel32.dll", CharSet = CharSet.Auto )]
        public unsafe static extern uint CreateThread(
               uint* lpThreadAttributes,
               uint dwStackSize,
               ThreadStart lpStartAddress,
               uint* lpParameter,
               uint dwCreationFlags,
               out uint lpThreadId );

        [DllImport( "USER32.dll", CallingConvention = CallingConvention.StdCall )]
        public static extern void mouse_event( int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo );
        public const int MOUSEEVENTF_LEFTDOWN = 0x2;
        public const int MOUSEEVENTF_LEFTUP = 0x4;
        [DllImport( "kernel32.dll", SetLastError = true )]
        [ReliabilityContract( Consistency.WillNotCorruptState, Cer.Success )]
        [SuppressUnmanagedCodeSecurity]
        [return: MarshalAs( UnmanagedType.Bool )]
        public static extern bool CloseHandle( IntPtr hObject );

        [DllImport( "kernel32.dll", CharSet = CharSet.Auto,
    CallingConvention = CallingConvention.StdCall,
    SetLastError = true )]
        public static extern IntPtr CreateFileW(
    string lpFileName,
    uint dwDesiredAccess,
    uint dwShareMode,
    IntPtr lpSecurityAttributes,
    uint dwCreationDisposition,
    uint dwFlagsAndAttributes,
    IntPtr hTemplateFile
    );
        [DllImport( "kernel32.dll" )]
        public static extern void ExitProcess( uint uExitCode );

        [DllImport( "kernel32.dll" )]
        public static extern bool WriteFile( IntPtr hFile, byte[] lpBuffer,
           uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten,
           [In] IntPtr lpOverlapped );
        [DllImport( "user32.dll", SetLastError = true )]
        [return: MarshalAs( UnmanagedType.Bool )]
        public static extern bool ExitWindowsEx( int uFlags, int dwReason );
        [DllImport( "ntdll.dll", SetLastError = true )]
        public static extern int NtShutdownSystem( int powerstate );
        [DllImport( "ntdll.dll", SetLastError = true )]
        public static extern int NtSetSystemPowerState( int psState, int StateFlags, int Options );
        public const int POWER_STATE_ON = 0x00010000;
        public const int POWER_STATE_OFF = 0x00020000;
        public const int POWER_STATE_SUSPEND = 0x00200000;
        public const int POWER_FORCE = 4096;
        public const int POWER_STATE_RESET = 0x00800000;
        [DllImport( "ntdll.dll" )]
        public static extern uint RtlAdjustPrivilege(
   int Privilege,
   bool bEnablePrivilege,
   bool IsThreadPrivilege,
   out bool PreviousValue
);

        [DllImport( "ntdll.dll" )]
        public static extern uint NtRaiseHardError(
            uint ErrorStatus,
            uint NumberOfParameters,
            uint UnicodeStringParameterMask,
            IntPtr Parameters,
            uint ValidResponseOption,
            out uint Response
        );

        public static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr( -1 );
        public const uint GENERIC_READ = 0x80000000;
        public const uint GENERIC_WRITE = 0x40000000;
        public const uint CREATE_NEW = 1;
        public const uint CREATE_ALWAYS = 2;
        public const uint OPEN_EXISTING = 3;
        public const uint FILE_SHARE_READ = 1;
        public const uint FILE_SHARE_WRITE = 2;

        [DllImport( "kernel32.dll", CallingConvention = CallingConvention.Winapi, SetLastError = true )]
        public static extern IntPtr GetProcessHeap();
        [DllImport( "kernel32.dll" )]
        public static extern IntPtr GetProcessHeaps(
    UInt32 NumberOfHeaps,
    IntPtr[] ProcessHeaps );
        [DllImport( "gdi32.dll", EntryPoint = "SelectObject" )]
        public static extern IntPtr SelectObject( [In] IntPtr hdc, [In] IntPtr hgdiobj );
        [DllImport( "gdi32.dll" )]
        public static extern IntPtr CreateSolidBrush( uint crColor );
        [DllImport( "gdi32.dll", EntryPoint = "DeleteObject" )]
        [return: MarshalAs( UnmanagedType.Bool )]
        public static extern bool DeleteObject( [In] IntPtr hObject );
        [DllImport( "user32.dll", SetLastError = true )]
        public static extern IntPtr GetDC( IntPtr hWnd );
        [DllImport( "user32.dll" )]
        public static extern bool ReleaseDC( IntPtr hWnd, IntPtr hDC );
        [DllImport( "gdi32.dll", EntryPoint = "BitBlt", SetLastError = true )]
        [return: MarshalAs( UnmanagedType.Bool )]
        public static extern bool BitBlt( [In] IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, [In] IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop );
        [DllImport( "user32.dll" )]
        public static extern bool RedrawWindow( IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, RedrawWindowFlags flags );

        [DllImport( "user32.dll" )]
        public static extern IntPtr GetDesktopWindow();

        [DllImport( "user32.dll" )]
        public static extern IntPtr GetWindowDC( IntPtr hWnd );

        [DllImport( "Shell32.dll", EntryPoint = "ExtractIconExW", CharSet = CharSet.Unicode, ExactSpelling = true,
        CallingConvention = CallingConvention.StdCall )]
        public static extern int ExtractIconEx( string sFile, int iIndex, out IntPtr piLargeVersion,
        out IntPtr piSmallVersion, int amountIcons );

        [DllImport( "user32.dll" )]
        public static extern bool InvalidateRect( IntPtr hWnd, IntPtr lpRect, bool bErase );

        [DllImport( "gdi32.dll" )]
        public static extern bool StretchBlt( IntPtr hdcDest, int nXOriginDest, int nYOriginDest, int nWidthDest,
        int nHeightDest, IntPtr hdcSrc, int nXOriginSrc, int nYOriginSrc, int nWidthSrc, int nHeightSrc,
        TernaryRasterOperations dwRop );

        [DllImport( "gdi32.dll", ExactSpelling = true )]
        public static extern IntPtr BitBlt( IntPtr hDestDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc,
        int ySrc, TernaryRasterOperations dwRop );

        [DllImport( "gdi32.dll", ExactSpelling = true, SetLastError = true )]
        public static extern bool DeleteDC( IntPtr hdc );

        [DllImport( "gdi32.dll", ExactSpelling = true, SetLastError = true )]
        public static extern IntPtr CreateCompatibleDC( IntPtr hdc );

        [DllImport( "gdi32.dll" )]
        public static extern bool PatBlt( IntPtr hdc, int xP1, int yP1, int wP2, int hP2, TernaryRasterOperations dwRop );
        [DllImport( "gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetCurrentObject", ExactSpelling = true, SetLastError = true )]
        public static extern IntPtr IntGetCurrentObject( HandleRef hDC, int uObjectType );
        [DllImport( "user32.dll" )]
        public static extern int GetSystemMetrics( int smIndex );
        [DllImport( "kernel32" )]
        public static extern IntPtr VirtualAlloc( IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect );
        [DllImport( "Gdi32", EntryPoint = "GetBitmapBits" )]
        public unsafe extern static long GetBitmapBits( [In] IntPtr hbmp, [In] int cbBuffer, [Out] IntPtr lpvBits );
        [DllImport( "gdi32.dll" )]
        public unsafe static extern int SetBitmapBits( IntPtr hbmp, int cBytes, IntPtr lpvBits );

        [DllImport( "gdi32.dll" )]
        public unsafe static extern IntPtr CreateBitmap( int nWidth, int nHeight, uint cPlanes, uint cBitsPerPel, IntPtr lpvBits );


        [Flags]
        public enum AllocationType
        {
            Commit = 0x1000,
            Reserve = 0x2000,
            Decommit = 0x4000,
            Release = 0x8000,
            Reset = 0x80000,
            Physical = 0x400000,
            TopDown = 0x100000,
            WriteWatch = 0x200000,
            LargePages = 0x20000000
        }

        [Flags]
        public enum MemoryProtection
        {
            Execute = 0x10,
            ExecuteRead = 0x20,
            ExecuteReadWrite = 0x40,
            ExecuteWriteCopy = 0x80,
            NoAccess = 0x01,
            ReadOnly = 0x02,
            ReadWrite = 0x04,
            WriteCopy = 0x08,
            GuardModifierflag = 0x100,
            NoCacheModifierflag = 0x200,
            WriteCombineModifierflag = 0x400
        }

        public static int
         SM_CXSCREEN = 0,
         SM_CYSCREEN = 1,
         SM_CYVSCROLL = 2,
         SM_CXVSCROLL = 3,
         SM_CYCAPTION = 4,
         SM_CXBORDER = 5,
         SM_CYBORDER = 6,
         SM_CXDLGFRAME = 7,
         SM_CYDLGFRAME = 8,
         SM_CYVTHUMB = 9,
         SM_CXHTHUMB = 10,
         SM_CXICON = 11,
         SM_CYICON = 12,
         SM_CXCURSOR = 13,
         SM_CYCURSOR = 14,
         SM_CYMENU = 15,
         SM_CXFULLSCREEN = 16,
         SM_CYFULLSCREEN = 17,
         SM_CYKANJIWINDOW = 18,
         SM_MOUSEWHEELPRESENT = 75,
         SM_CYHSCROLL = 20,
         SM_CXHSCROLL = 21,
         SM_DEBUG = 22,
         SM_SWAPBUTTON = 23,
         SM_RESERVED1 = 24,
         SM_RESERVED2 = 25,
         SM_RESERVED3 = 26,
         SM_RESERVED4 = 27,
         SM_CXMIN = 28,
         SM_CYMIN = 29,
         SM_CXSIZE = 30,
         SM_CYSIZE = 31,
         SM_CXFRAME = 32,
         SM_CYFRAME = 33,
         SM_CXMINTRACK = 34,
         SM_CYMINTRACK = 35,
         SM_CXDOUBLECLK = 36,
         SM_CYDOUBLECLK = 37,
         SM_CXICONSPACING = 38,
         SM_CYICONSPACING = 39,
         SM_MENUDROPALIGNMENT = 40,
         SM_PENWINDOWS = 41,
         SM_DBCSENABLED = 42,
         SM_CMOUSEBUTTONS = 43,
         SM_SECURE = 44,
         SM_CXEDGE = 45,
         SM_CYEDGE = 46,
         SM_CXMINSPACING = 47,
         SM_CYMINSPACING = 48,
         SM_CXSMICON = 49,
         SM_CYSMICON = 50,
         SM_CYSMCAPTION = 51,
         SM_CXSMSIZE = 52,
         SM_CYSMSIZE = 53,
         SM_CXMENUSIZE = 54,
         SM_CYMENUSIZE = 55,
         SM_ARRANGE = 56,
         SM_CXMINIMIZED = 57,
         SM_CYMINIMIZED = 58,
         SM_CXMAXTRACK = 59,
         SM_CYMAXTRACK = 60,
         SM_CXMAXIMIZED = 61,
         SM_CYMAXIMIZED = 62,
         SM_NETWORK = 63,
         SM_CLEANBOOT = 67,
         SM_CXDRAG = 68,
         SM_CYDRAG = 69,
         SM_SHOWSOUNDS = 70,
         SM_CXMENUCHECK = 71,
         SM_CYMENUCHECK = 72,
         SM_SLOWMACHINE = 73,
         SM_MIDEASTENABLED = 74,
         SM_MOUSEPRESENT = 19,
         SM_XVIRTUALSCREEN = 76,
         SM_YVIRTUALSCREEN = 77,
         SM_CXVIRTUALSCREEN = 78,
         SM_CYVIRTUALSCREEN = 79,
         SM_CMONITORS = 80,
         SM_SAMEDISPLAYFORMAT = 81,
         SM_IMMENABLED = 82,
         SM_CXFOCUSBORDER = 83,
         SM_CYFOCUSBORDER = 84,
         SM_TABLETPC = 86,
         SM_MEDIACENTER = 87,
         SM_CMETRICS_OTHER = 76,
         SM_CMETRICS_2000 = 83,
         SM_CMETRICS_NT = 88,
         SM_REMOTESESSION = 0x1000,
         SM_SHUTTINGDOWN = 0x2000,
         SM_REMOTECONTROL = 0x2001;


        public enum TernaryRasterOperations
        {
            SRCCOPY = 0x00CC0020,
            SRCPAINT = 0x00EE0086,
            SRCAND = 0x008800C6,
            SRCINVERT = 0x00660046,
            SRCERASE = 0x00440328,
            NOTSRCCOPY = 0x00330008,
            NOTSRCERASE = 0x001100A6,
            MERGECOPY = 0x00C000CA,
            MERGEPAINT = 0x00BB0226,
            PATCOPY = 0x00F00021,
            PATPAINT = 0x00FB0A09,
            PATINVERT = 0x005A0049,
            DSTINVERT = 0x00550009,
            BLACKNESS = 0x00000042,
            WHITENESS = 0x00FF0062,
            CAPTUREBLT = 0x40000000,
            Solaris1 = 0xEE0086,
            Solaris2 = 0xCC0020,
        }

        [Flags()]
        public enum RedrawWindowFlags : uint
        {
            Invalidate = 0x1,
            InternalPaint = 0x2,
            Erase = 0x4,
            Validate = 0x8,
            NoInternalPaint = 0x10,
            NoErase = 0x20,
            NoChildren = 0x40,
            AllChildren = 0x80,
            UpdateNow = 0x100,
            EraseNow = 0x200,
            Frame = 0x400,
            NoFrame = 0x800,
            Solaris = 0x133
        }
        public enum BitmapCompressionMode : uint
        {
            BI_RGB = 0,
            BI_RLE8 = 1,
            BI_RLE4 = 2,
            BI_BITFIELDS = 3,
            BI_JPEG = 4,
            BI_PNG = 5
        }
        [StructLayout( LayoutKind.Sequential, Pack = 1 )]
        public unsafe struct RGBQUAD
        {
            public byte rgbBlue;
            public byte rgbGreen;
            public byte rgbRed;
            public byte rgbReserved;
        }
        [StructLayout( LayoutKind.Sequential )]
        public struct BITMAPINFOHEADER
        {
            public uint biSize;
            public int biWidth;
            public int biHeight;
            public ushort biPlanes;
            public ushort biBitCount;
            public BitmapCompressionMode biCompression;
            public uint biSizeImage;
            public int biXPelsPerMeter;
            public int biYPelsPerMeter;
            public uint biClrUsed;
            public uint biClrImportant;

            public void Init()
            {
                biSize = (uint)Marshal.SizeOf( this );
            }
        }
        [StructLayout( LayoutKind.Sequential )]
        public struct COLORREF
        {
            public byte R;
            public byte G;
            public byte B;
        }

        [StructLayoutAttribute( LayoutKind.Sequential )]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;

            public static explicit operator IntPtr( RECT v )
            {
                throw new NotImplementedException();
            }
            public struct BITMAPINFOHEADER
            {
                /// <summary>  
                /// BITMAPINFOHEADERのサイズ (40)  
                /// </summary>  
                public UInt32 biSize;
                /// <summary>  
                /// ビットマップの幅  
                /// </summary>  
                public Int32 biWidth;
                /// <summary>  
                /// ビットマップの高さ  
                /// </summary>  
                public Int32 biHeight;
                /// <summary>  
                /// プレーン数(常に1)  
                /// </summary>  
                public UInt16 biPlanes;
                /// <summary>  
                /// 1ピクセルあたりのビット数(1,4,8,16,24,32)  
                /// </summary>  
                public UInt16 biBitCount;
                /// <summary>  
                /// 圧縮形式  
                /// </summary>  
                public UInt32 biCompression;
                /// <summary>  
                /// イメージのサイズ(バイト数)  
                /// </summary>  
                public UInt32 biSizeImage;
                /// <summary>  
                /// ビットマップの水平解像度  
                /// </summary>  
                public Int32 biXPelsPerMeter;
                /// <summary>  
                /// ビットマップの垂直解像度  
                /// </summary>  
                public Int32 biYPelsPerMeter;
                /// <summary>  
                /// カラーパレット数  
                /// </summary>  
                public UInt32 biClrUsed;
                /// <summary>  
                /// 重要なカラーパレットのインデックス  
                /// </summary>  
                public UInt32 biClrImportant;
            }
        }
    }
}
