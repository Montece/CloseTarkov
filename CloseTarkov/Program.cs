using System.Diagnostics;

namespace CloseTarkov
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Process p in Process.GetProcesses()) if (p.ProcessName == "EscapeFromTarkov") p.Kill();
        }
    }
}
