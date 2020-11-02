using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_
{
    class Bank
    {
        public delegate void BankCheck(string massege);
        public event BankCheck Notify;

        public string Id { get; set; }
        private double Balance;
        enum Currency
        {
            Dollars=2,
            Euro=5,
            rubles=50,
            bel_rubels=1,
            MAX_CURRENCY=4
        }
        int Kof = (int)Currency.bel_rubels;
        public Bank(double balance)
        {
            Balance = balance;
            Notify += ShowMes;
        }
        public bool Withdraw(double sum)
        {
            if (sum <= Balance)
            {
                Balance -= sum;
                Notify?.Invoke($"Balance reduced by {sum}");
                return true;
            }
            else
            {
                Notify?.Invoke("Your balance is lower than withdraw sum");
                return false;
            }

        }

        private void ShowMes(string message)
        {
            Console.WriteLine(message);
        }

        public double ShowBalance()
        {
            return Balance;
        }

        public void Add(double sum)
        {
            if(sum < 0)
            {
                Notify?.Invoke("Sum is lower than 0");
            }
            else
            {
                Balance += sum;
                Notify?.Invoke($"Added {sum} to your balance");
            }
        }


        public void BalanceTo()
        {
            Console.WriteLine("Choose currency to transfer your balance:");
            Console.WriteLine("1:Dollars\n2:Euro\n3:Russian rubels\n4:Fucking luckashenko currency");
            var i = Convert.ToInt32(Console.ReadLine());
            if (Kof == 50)
            {
                switch (i)
                {
                    case 1:
                        Balance /= Kof;
                        Kof = (int)Currency.Dollars; Balance /= Kof;
                        break;
                    case 2:
                        Balance /= Kof;
                        Kof = (int)Currency.Euro; Balance /= Kof;
                        break;
                    case 3:
                        Balance /= Kof;
                        Kof = (int)Currency.rubles; Balance *= Kof;
                        break;
                    case 4:
                        Balance /= Kof;Kof = (int)Currency.bel_rubels;
                        break;
                }
            }
            else
            {
                switch (i)
                {
                    case 1:
                        Balance *= Kof;
                        Kof = (int)Currency.Dollars; Balance /= Kof;
                        break;
                    case 2:
                        Balance *= Kof;
                        Kof = (int)Currency.Euro; Balance /= Kof;
                        break;
                    case 3:
                        Balance *= Kof;
                        Kof = (int)Currency.rubles; Balance *= Kof;
                        break;
                    case 4:
                        Balance /= Kof;
                        break;
                }
            }


        }
        public int ReturnKof()
        {
            return Kof;
        }
    }
    public class Try
    {
        public static void Fun()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BankForm());


        }
    }
}
