using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankofRomaniaProject
{
    class Checking : AccountInfo
    {
      
        public Checking()
        {

        }
        public Checking(string acctNum, double balance)
        {
            this.AcctNum = acctNum;
            this.Balance = balance;
        }
        public override double ViewBalance()
        {
            return Balance;
        }

        public override double Withdraw()
        {
            return Balance - WithdrawlAmount;
        }
    }
            
}

