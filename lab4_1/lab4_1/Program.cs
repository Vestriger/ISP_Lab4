using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
public class MemoryStatus
{
    public readonly int Length;
    public int PercentMemoryLoad;
    public long TotalPhys;
    public long AvailPhys;
    public long TotalPageFile;
    public long AvailPageFile;
    public long TotalVirtual;
    public long AvailVirtual;
    public long AvailExtendedVirtual;

    public MemoryStatus()
    {
        Length = Marshal.SizeOf(typeof(MemoryStatus));
    }
}


namespace lab4_1
{
    static class Program
    {
        static void Main()
        {
            SystemInfo systemInfo = new SystemInfo();
            Console.WriteLine("Information about system's memory:\n");
            systemInfo.ShowMemory();
        }
    }

    class SystemInfo
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool GlobalMemoryStatusEx(MemoryStatus buffer);

        public void ShowMemory()
        {
            MemoryStatus memStatus = new MemoryStatus();
            GlobalMemoryStatusEx(memStatus);

            Console.WriteLine("Memory Length: " + memStatus.Length);
            Console.WriteLine("Memory Load: " + memStatus.PercentMemoryLoad + " %");
            Console.WriteLine("Total Physical: " + memStatus.TotalPhys / Math.Pow(2, 30) + " GB");
            Console.WriteLine("Avail Physical: " + memStatus.AvailPhys / Math.Pow(2, 30) + " GB");
            Console.WriteLine("Total Page File: " + memStatus.TotalPageFile / Math.Pow(2, 30) + " GB");
            Console.WriteLine("Avail Page File: " + memStatus.AvailPageFile / Math.Pow(2, 30) + " GB");
            Console.WriteLine("Total Virtual: " + memStatus.TotalVirtual / Math.Pow(2, 30) + " GB");
            Console.WriteLine("Avail Virtual: " + memStatus.AvailVirtual / Math.Pow(2, 30) + " GB");
            Console.WriteLine("Avail Extended Virtual: " + memStatus.AvailExtendedVirtual / Math.Pow(2, 30) + " GB");
        }
    }
}
