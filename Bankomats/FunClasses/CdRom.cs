using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Bankomats.FunClasses
{
    public class CdRom
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA")]
        public static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        public static void Open()
        {
            mciSendString("set CDAudio door open", null, 127, 0);
        }
        public static void Close()
        {
            mciSendString("set CDAudio door closed", null, 127, 0);
        }
    }
}
