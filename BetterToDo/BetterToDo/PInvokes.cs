using System;
using System.Runtime.InteropServices;

namespace BetterToDo
{
    public static class PInvokes
    {
        public static void SetInBackground(IntPtr hWnd)
        {
            uint options = SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE | SWP_SHOWWINDOW;
            SetWindowPos(hWnd, HWND_BOTTOM, 0, 0, 0, 0, options);

            int windowStyle = GetWindowLong(hWnd, GWL_EXSTYLE);
            SetWindowLong(hWnd, GWL_EXSTYLE, windowStyle | WS_EX_TOOLWINDOW);
        }

        [DllImport("user32", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr window, int index);
        [DllImport("user32", SetLastError = true)]
        public static extern int SetWindowLong(IntPtr hWnd, int index, int value);
        [DllImport("user32", SetLastError = true)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        [DllImport("user32", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 SWP_NOACTIVATE = 0x0010;
        const UInt32 SWP_SHOWWINDOW = 0x0040;
        const int GWL_EXSTYLE = -20;
        const int WS_EX_TOOLWINDOW = 0x00000080;
        static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
    }
}
