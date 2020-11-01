using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    public class Try
    {
        public void menu()
        {
            Console.WriteLine("Enter the date");
            string enter_data = Console.ReadLine();
            string[] Date = enter_data.Split(new char[] { '%','^'});
            DateTime birthdae = new DateTime(1998, 01, 27);
            DateTime DATE = new DateTime(int.Parse(Date[2]), int.Parse(Date[1]), int.Parse(Date[0]));
            var res = (DATE - birthdae).Duration();
            Console.WriteLine($"{(Convert.ToInt32(res.TotalDays))/365} {(Convert.ToInt32(res.TotalDays % 365))/30} {(Convert.ToInt32(res.TotalDays) % 30)}");
            if(((res.TotalDays)/ 365)>100)
            {
                Console.WriteLine("Nu ti i jivuchiy BANDIT");
            }
            else
            {
                Console.WriteLine("Vse mi ne vechni");
            }

            

            Console.ReadLine();
        }
    }
}
