using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Date;
using IndividualWord;
using Bank_;

namespace Task6
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Ne bei za menu\n1: Data\n2:Date\n3:Bank");
            var k = Convert.ToInt32(Console.ReadLine());
            switch (k)
            {
                case 3:
                    Bank_.Try.Fun();
                    break;
                case 2:
                    IndividualWord.Try.main();
                    break;
                case 1:
                    Date.Try.menu();
                    break;
            }


        }
    }
}
