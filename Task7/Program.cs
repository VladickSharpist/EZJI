using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rainbow_Russia;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ne bei za menu\n1: raduga\n2:Borba s geuami(ne redi)\n3:Potoki(ne redi)");
            var k = Convert.ToInt32(Console.ReadLine());
            switch (k)
            {
                case 1:Try.Fun();
                    break;
                case 2:
                    Try.Menu();
                    break;
            }
        }
    }
}
