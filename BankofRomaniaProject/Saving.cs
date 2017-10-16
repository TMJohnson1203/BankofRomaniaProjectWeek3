using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankofRomaniaProject
{
    class Saving : AccountInfo
    {


        public Saving(string AcctNum, double Balance)
        {
            this.AcctNum = acctNum;
            this.Balance = balance;
        }

        public Saving()
        {
        }

        public override double ViewBalance()
        {
            return Balance;
        }

        public override double Withdraw()
        {
            if (Balance - withdrawlAmount < 200d)
            {
                return Balance;
                Console.WriteLine("Amount currently available in your Saving Account. n/This amount is lower than the required minumum of $50. \nYou are not able to make a withdrawl at this time.");
            }
            else
                Console.WriteLine("Your current balance is ");
            return Balance - withdrawlAmount;
            Console.WriteLine("Please retrieve your cash from the tray below.");
            //Console.WriteLine("Thank you for your deposit. Your current balance is " + ".");

        }
    }
}

