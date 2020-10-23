using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utki;
using Seif;
using Counter;

namespace task3
{
    class Program
    {

        public void TrySeif()
        {
            Console.WriteLine("Enter Id");
            var k = Convert.ToInt32(Console.ReadLine());
            var z = Console.ReadLine();
            Saef<int> element1 = new Saef<int>(k);
            Saef<string> element2 = new Saef<string>(z);
            element1.Chek_id();
            element2.Chek_id();
        }

        public void TryDuck()
        {
            Utochka duck = DuckFun.RandomDuck();
            duck.Krua();
        }

        public void TryCounter()
        {
            Cou.MyFun();
        }

        public delegate void Try();

        public Try ReturnDelegate()
        {
            Try menu = TrySeif;
            menu += TryDuck;
            menu += TryCounter;
            return menu;
        }
    }
}
