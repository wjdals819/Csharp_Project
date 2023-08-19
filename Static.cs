using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class CountA
    {
        public static int Count = 0;
    }

    class CountB
    {
        public CountB()
        {
            CountA.Count++;
            //생성자
        }
    }

    class CountC
    {
        public CountC()
        {
            CountA.Count++;
            //생성자
        }
    }

    class MainApp
    {
        static void Main()
        {
            Console.WriteLine($"CountA의 Count: {CountA.Count}");

            new CountB(); //생성자
            new CountC(); //생성자
            new CountB(); //생성자
            new CountC(); //생성자

            Console.WriteLine($"CountA의 Count: {CountA.Count}");
        }
    }
}
