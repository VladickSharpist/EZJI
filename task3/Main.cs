using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utki;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Utochka duck = DuckFun.RandomDuck();
            duck.Krua();
        }
    }
}
