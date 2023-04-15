using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class Relational_Operator
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Console.WriteLine($"1>2: {a > b}");
            Console.WriteLine($"1>=2: {a >= b}");
            Console.WriteLine($"1<2: {a<b}");
            Console.WriteLine($"1<=2: {a <= b}");
            Console.WriteLine($"1==2: {a == b}");
            Console.WriteLine($"1!=2: {a != b}");

        }
    }
}
