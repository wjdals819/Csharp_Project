using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class Params
    {
        static int Sum(params int[] args)
        {
            int sum = 0;

            for(int i = 0; i < args.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write("+");
                }
                Console.Write(args[i]);
                sum += args[i];
            }
            Console.WriteLine();

            return sum;
        }

        static void Main(string[] args)
        {
            int sum = Sum(1, 3, 5, 7, 9);
            Console.WriteLine("=" + sum);
        }
    }
}
