using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Menu
    {
        public delegate void ForMenu();

        public static  void ShowMenu(Delegate[] Delegates)
        {
            Console.WriteLine("Choose Task to check\n Enter a task digit for example 3 for task 3 :)");
            int k=Convert.ToInt32(Console.ReadLine());
            Delegates(k);
        }
    }
}
