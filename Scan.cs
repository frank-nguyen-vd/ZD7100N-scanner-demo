using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace scanner_demo
{
    class Scan
    {

        [DllImport("ZDSCANLIB.dll", EntryPoint = "OpenScaner", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int OpenScaner(int port, int bandrate);

        [DllImport("ZDSCANLIB.dll", EntryPoint = "ScanStart", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ScanStart(int handle);

        [DllImport("ZDSCANLIB.dll", EntryPoint = "ScanClose", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ScanClose(int handle);

        [DllImport("ZDSCANLIB.dll", EntryPoint = "ScanDateReceiced", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]        
        public static extern int ScanDateReceiced(int handle, ref byte buf);

        [DllImport("ZDSCANLIB.dll", EntryPoint = "VersionScaner", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int VersionScaner(int handle, ref byte buf);

        [DllImport("ZDSCANLIB.dll", EntryPoint = "GetSN", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetSN(int handle, ref byte buf);
        
        [DllImport("ZDSCANLIB.dll", EntryPoint = "CloseScaner", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int CloseScaner(int handle);


    }
}
