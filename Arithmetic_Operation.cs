using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class Arithmetic_Operation
    {
        static void Main(string[] args)
        {
            int a = 100 + 200;
            Console.WriteLine($"a: {a}");

            int b = a - 50;
            Console.WriteLine($"b: {b}");

            int c = b * 10;
            Console.WriteLine($"c: {c}");

            int d = 10 / 5;
            Console.WriteLine($"d: {d}");

            int e = 10 % 3;
            Console.WriteLine($"e: {e}");
        }
    }
}
