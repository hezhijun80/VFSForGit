using GVFS.Tests;
using System;
using System.Diagnostics;

namespace GVFS.UnitTests.Linux
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NUnitRunner runner = new NUnitRunner(args);
            Environment.ExitCode = runner.RunTests(null, null);

            if (Debugger.IsAttached)
            {
                Console.WriteLine("Tests completed. Press Enter to exit.");
                Console.ReadLine();
            }
        }
    }
}