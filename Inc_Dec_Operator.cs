using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class Inc_Dec_Operator
    {
        static void Main(string[] args) 
        {
            int a = 100;
            Console.WriteLine(a++);
            Console.WriteLine(a--);

            int b = 100;
            Console.WriteLine(++b);
            Console.WriteLine(--b);
        }
    }
}
