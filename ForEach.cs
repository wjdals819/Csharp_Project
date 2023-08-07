using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class ForEach
    {
        
        static int multiply(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            int[] numberArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int a in numberArr)
            {
                Console.WriteLine(2 + "X" + a + "=" + multiply(2, a));
            }


        }

    }
}
