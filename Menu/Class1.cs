using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class Class1
    {
        public delegate void Try();
        public static void Menu()
        {
            Console.WriteLine("Enter task number");
            var k = Console.ReadLine();
            int.TryParse(k);
        }
    }
}
