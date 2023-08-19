using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class ClassA
    {
        public static void MethodA()
        {
            Console.WriteLine("스태틱 메소드 호출");
        }
        public void MethodB()
        {
            Console.WriteLine("일반 메소드 호출");
        }
    }

    class MainApp
    {
        public static void Main()
        {
            ClassA.MethodA(); //스태틱 메소드 호출

            ClassA classA = new ClassA();
            classA.MethodB(); //일반 메소드 호출

        }
    }
}
