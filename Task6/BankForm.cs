using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_
{
    public partial class BankForm : Form
    {
        Bank account;
        public BankForm()
        {
            InitializeComponent();
            account = new Bank(0);
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Enter sum to withdraw");
            double sum = Convert.ToDouble(Console.ReadLine());
            if (account.Withdraw(sum))
            {
                MessageBox.Show($"Balance reduced by {sum}", "SMS!!!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Enter sum to Add");
            double sum = Convert.ToDouble(Console.ReadLine());
            account.Add(sum);
            MessageBox.Show($"Added {sum} to your balance", "SMS!!!");
        }

        private void ShowBalance_Click(object sender, EventArgs e)
        {
            string currency = "0";
            switch (account.ReturnKof())
            {
                case 1:
                    currency = "lucashenkos";
                    break;
                case 2:
                    currency = "Dollars";
                    break;
                case 5:
                    currency = "Euro";
                    break;
                case 50:
                    currency = "russian rubels";
                    break;
            }
            MessageBox.Show($"{account.ShowBalance().ToString()} {currency}", "SMS!!!");
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            account.BalanceTo();
            string currency="0";
            switch(account.ReturnKof())
            {
                case 1:
                    currency = "lucashenkos";
                    break;
                case 2:currency = "Dollars";
                    break;
                case 5:currency = "Euro";
                    break;
                case 50:currency = "russian rubels";
                        break;
            }
            Console.WriteLine($"Your balance is now {account.ShowBalance()} {currency}");
            MessageBox.Show($"Your balance was transfered into {currency}","SMS!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EnterID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string UserID = IDField.Text;
            account.Id = UserID;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(account.Id, "SMS!!!");
        }
    }
}
