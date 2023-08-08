using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class Method_Swap
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;

            Console.WriteLine("x=" + x + ",y=" + y);

            Swap(ref x, ref y);

            Console.WriteLine("x=" + x + ",y=" + y);

        }
    }
}
