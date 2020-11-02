using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow_Russia
{
   

    public class Try
    {
       public static void Menu()
        {
            Console.WriteLine("Enter the name of cantry");
            string Name = Console.ReadLine();
            DoRussiaGreatAgain a = new DoRussiaGreatAgain(Name);
            a.Check_Tolerance();
            Console.ReadLine();
        }
        
    }

    class DoRussiaGreatAgain
    {

        private Lazy<Rainbow> rainbow=new Lazy<Rainbow>();
        private string CountryName;
        public DoRussiaGreatAgain(string a)
        {
            CountryName = a;
        }

        public void  Check_Tolerance()
        {
            if(CountryName=="Russia")
            {
               rainbow.Value.Touch_of_the_sun();
            }
            else
            {
                Console.WriteLine("your country has enough problems");
            }
        }
    }
    class Rainbow
    {
        public string Rainbow_Power = ("red, orange, yellow, green, lright blue, blue, purple");
        public void Touch_of_the_sun()
        {
            Console.WriteLine($"{Rainbow_Power}\n Welcom to the club, budy");
        }

    }
}
