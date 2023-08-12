using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class Menu
    {
        public string Name;
        public int Price;

        public void Order()
        {
            Console.WriteLine("{0}를 주문했습니다.", Name);            
        }
    }

    class Class_Ex
    {
        static void Main(string[] args)
        {
            Menu pizza = new Menu();
            pizza.Name = "피자";
            pizza.Price = 20000;
            pizza.Order();
            Console.WriteLine("{0}의 가격은 {1}원 입니다.", pizza.Name, pizza.Price);

            Menu coke = new Menu();
            coke.Name = "콜라";
            coke.Price = 1500;
            coke.Order();
            Console.WriteLine("{0}의 가격은 {1}원 입니다.", coke.Name, coke.Price);
        }
        
    }
}
