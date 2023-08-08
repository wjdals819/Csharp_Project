using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class Caculator
    {
        //매개변수를 포함한 메소드
        public static int Plus(int a,int b)
        {
            int result = a + b;
            return result;
        }
    }

    class Method
    {
        public static void Main()
        {
            int x = 10;
            int y = 20;

            Console.WriteLine(x + "+" + y + "="+Caculator.Plus(x,y));
   


        }
    }
}
