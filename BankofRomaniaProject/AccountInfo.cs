using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankofRomaniaProject
{
    abstract class AccountInfo
    {

        protected string acctNum;
        protected double balance;
        public abstract string AcctNum { get; set; }
        public abstract double Balance { get; set; }

        public AccountInfo(string acctNum, double balance)
        {
            this.AcctNum = acctNum;
            this.Balance = balance;
        }

        public virtual void ViewBalance()
        {

        }

        public double Deposit()
        {
            return Balance + depositAmount; 

        }

        public virtual double WithDrawl() 
        {
       
        }
    }
}
