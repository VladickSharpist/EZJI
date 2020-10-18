using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TC_Fig;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 try..catch\n");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 2:
                    {
                        Fig_Ex variable = new Fig_Ex();
                        Console.Clear();
                        variable.Menu();
                    }
                    break;

            }
        }
    }
}
