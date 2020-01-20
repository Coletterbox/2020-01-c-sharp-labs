using System;
using System.Diagnostics;
using System.IO; // input/output

namespace lab_04_debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            x = x + 10;
            int y = x * x;
            Console.WriteLine(x);
            Console.WriteLine(y);
            for (int i = 0; i < 1000; i++)
            { 
                Console.WriteLine(i);
                Trace.WriteLine($"Your number is {i}");
                Debug.WriteLine($"Debug WriteLine {i}");
                Debug.WriteLineIf(i == 6, "i is 6");
                File.AppendAllText("c:\\log\\log.dat", $"\nlogging i={i} at {DateTime.Now}");
            }
            Console.ReadLine();
        }
    }
}
