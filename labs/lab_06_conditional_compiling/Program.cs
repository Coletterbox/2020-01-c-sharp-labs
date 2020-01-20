#define THISISTRUE
using System;

namespace lab_06_conditional_compiling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("always printed");

#if DEBUG
            Console.WriteLine("this is debug code");
#else
            Console.WriteLine("this is production code");
#endif
#if THISISTRUE
            Console.WriteLine("this is true");
#endif

        }
    }
}
