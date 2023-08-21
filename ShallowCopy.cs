using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class ShallowCopy
    {
        public int ShallowField;
        public int ShallowField2;
    }

    class MainApp 
    {
        public static void Main()
        {
            ShallowCopy source = new ShallowCopy();
            source.ShallowField = 1;
            source.ShallowField2 = 2;

            ShallowCopy source2 = source; //source를 source2에 복사
            source2.ShallowField2 = 3;

            Console.WriteLine("source.ShallowField1: {0} / source.ShallowField2: {1}", source.ShallowField, source.ShallowField2);
            Console.WriteLine("source2.ShallowField1: {0} / source2.ShallowField2: {1}", source2.ShallowField, source2.ShallowField2);
        }
        

    }
}
