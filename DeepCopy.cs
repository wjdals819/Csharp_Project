using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class DeepCopy
    {
        public int DeepField1;
        public int DeepField2;

        public DeepCopy Copy()
        {
            DeepCopy newCopy = new DeepCopy();
            newCopy.DeepField1 = this.DeepField1; 
            newCopy.DeepField2 = this.DeepField2;

            return newCopy;
        }
    }

    class MainApp
    {
        public static void Main()
        {
            DeepCopy source = new DeepCopy();
            source.DeepField1 = 1;
            source.DeepField2 = 2;

            DeepCopy source2 = source.Copy();
            source2.DeepField2 = 3;

            Console.WriteLine("source.DeepField1: {0} / source.DeepField2 {1}", source.DeepField1, source.DeepField2);
            Console.WriteLine("source2.DeepField1: {0} / source2.DeepField2 {1}", source2.DeepField1, source2.DeepField2);

        }
    }
}
