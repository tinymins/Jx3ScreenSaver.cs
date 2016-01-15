using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Jx3ScreenSaver
{
    class WinAPI
    {
        [DllImport("User32.dll")]
        public static extern IntPtr SetParent(IntPtr hChild, IntPtr hNewParent);

        [DllImport("User32.dll")]
        public static extern Int32 GetClientRect(IntPtr hWnd, out Rectangle rect);

        [DllImport("User32.dll")]
        public extern static Int32 SetWindowLong(IntPtr hWnd, int nIndex, Int32 dwNewLong);

        [DllImport("User32.dll")]
        public extern static Int32 GetWindowLong(IntPtr hWnd, int nIndex);

        public const int
            GWL_STYLE = (-16),
            WS_CHILD = 0x40000000;
    }
}
