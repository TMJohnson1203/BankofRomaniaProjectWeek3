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
        protected double depositAmount;
        protected double withdrawlAmount;

        public string AcctNum { get; set; }
        public double Balance { get; set; }
        public double DepositAmount { get; set; }
        public double WithdrawlAmount { get; set; }

        public AccountInfo()
        {

        }

        public AccountInfo(string AcctNum, double Balance, double DepositAmount, double WithdrawlAmount)
        {
            this.AcctNum = acctNum;
            this.Balance = balance;
            this.DepositAmount = depositAmount;
            this.WithdrawlAmount = withdrawlAmount;
        }

        public virtual double ViewBalance()
        {
            return Balance;
        }

        public virtual double Deposit()
        {
            return Balance + depositAmount; 

        }

        public virtual double WithDraw();
        {
         return Balance - WithdrawlAmount;
        }
    }
}
