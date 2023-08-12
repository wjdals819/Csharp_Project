using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project
{
    class Menu
    {
        public Menu()
        {
            Name = "";
            Price = 0;
        }

        public Menu(string _Name, int _Price)
        {
            Name = _Name;
            Price = _Price;
        }

        //필드
        public string Name;
        public int Price;

        //메소드
        public void Order()
        {
            Console.WriteLine("{0}를 주문했습니다.", Name);
        }
    }
    class Class_EX_2_
    {
        static void Main(string[] args)
        {
            Menu pizza = new Menu();
            pizza.Name = "피자";
            pizza.Price = 15000;
            pizza.Order();
            Console.WriteLine("{0}의 가격은 {1}원 입니다.", pizza.Name, pizza.Price);

            Menu coke = new Menu("콜라", 2000);
            coke.Order();
            Console.WriteLine("{0}의 가격은 {1}원 입니다.", coke.Name, coke.Price);
        }
    }
}
