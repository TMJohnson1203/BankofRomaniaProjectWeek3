using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankofRomaniaProject
{
    class Saving : AccountInfo
    {
        protected new string acctNum;
        protected new double balance;
        public override string AcctNum { get; set; }
        public override double Balance { get; set; }

        public Saving(string acctNum, double balance)
        {
            this.AcctNum = acctNum;
            this.Balance = balance;
        }

        public override void ViewBalance()
        {

        }

        public override double Withdrawl()
        {
            if (Balance - withdrawlAmount < 200d)
            {

            }
        }
    }
}
