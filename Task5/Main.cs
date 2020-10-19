using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TC_Fig;

namespace Task5
{
    class Progarm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 using\n3 Try/Catch\n ");
            int cond = int.Parse(Console.ReadLine());

            switch (cond)
            {
                case 2:
                    {

                    }break;
                case 3:
                    {
                        TC a = new TC();
                        a.Menu();

                    }break;
                    
            }
        }
    }
}
