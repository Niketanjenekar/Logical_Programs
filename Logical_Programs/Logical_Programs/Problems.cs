using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class Problems
    {
        public static void Problem_Program()
        {
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine("Please Click Enter to START the StopWatch");
            Console.ReadLine();

            sw.Start();

            Console.WriteLine("Please Click Enter to STOP the StopWatch");
            Console.ReadLine();

            sw.Stop();

            TimeSpan ElapsedTime = sw.Elapsed;

            Console.WriteLine("Elasped Time is : " + ElapsedTime);
        }       
    }
}
