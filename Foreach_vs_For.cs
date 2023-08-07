using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class Foreach_vs_For
    {
        static void Main(string[] args)
        {
            string[,] menu = new string[,] { { "떡볶이", "순대","튀김","치즈라면"},{ "참치김밥", "냉모밀", "쫄면", "돈까스" }};

            Console.WriteLine("<for문 사용>");

            for(int i = 0; i < menu.GetLength(0); i++)
            {            
                for (int j = 0; j < menu.GetLength(1); j++)
                {
                    Console.Write(menu[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("<foreach문 사용>");

            foreach(string a in menu)
            {
                Console.WriteLine(a);
            }
        }
    }
}
