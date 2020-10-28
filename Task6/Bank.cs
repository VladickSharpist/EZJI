using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    class Bank
    {
        public delegate void BankCheck(string massege);
        public event BankCheck Notify;

        public string Id { get; set; }
        private double Balance;
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
    }
}
