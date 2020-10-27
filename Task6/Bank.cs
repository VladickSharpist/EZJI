using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
        public void Withdraw(double sum)
        {
            if (sum <= Balance)
            {
                Balance -= sum;
                Notify?.Invoke($"Balance reduced by {sum}");
            }
            else
            {
                Notify?.Invoke("Your balance is lower than withdraw sum");

            }

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
