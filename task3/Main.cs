using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utki;
using Seif;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Utochka duck = DuckFun.RandomDuck();
            duck.Krua();

            Saef<int> element1 = new Saef<int>(123);
            Saef<string> element2 = new Saef<string>("g4h5d");
            element1.Chek_id();
            element2.Chek_id();
        }

    }
}
