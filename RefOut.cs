using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class RefOut
    {
        static void Calculator(int a, int b,out int add, out int subtract,out int multiply,out int divide)
        {
            add = a + b;
            subtract = a - b;
            multiply = a * b;
            divide = a / b;
        }

        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;


            Calculator(x, y, out int a, out int b, out int c, out int d);

            Console.WriteLine(x + "+" + y+"= "+a);
            Console.WriteLine(x + "-" + y + "= " + b);
            Console.WriteLine(x + "x" + y + "= " + c);
            Console.WriteLine(x + "/" + y + "= " + d);
        }
    }
    
}
