using System;
using System.Diagnostics;

namespace VSWhereStats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var processStartInfo = new ProcessStartInfo();
            processStartInfo.Arguments = " -latest -products * -requires Microsoft.Component.MSBuild -property installationPath";
            processStartInfo.FileName = @"C:\Program Files (x86)\Microsoft Visual Studio\Installer\vswhere.exe";
            using (var process = Process.Start(processStartInfo))
            {
                process.WaitForExit();
                Console.ReadLine();
            }
        }
    }
}
