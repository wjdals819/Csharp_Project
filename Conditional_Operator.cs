using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class Conditional_Operator
    {
        static void Main(string[] args)
        {
            string result = 10 - 5 > 3 ? "맞습니다" : "틀립니다";

            Console.WriteLine($"10-5는 3보다 크다:{result}");

        }
    }
}
