using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankofRomaniaProject
{
    class Checking : AccountInfo
    {
        protected string checkAcctNum;
        protected double checkBal;
        public string CheckAcctNum;
        public double CheckBal {get; set;}

        public Checking()
        {

        }

        public Checking(double checkBal)
        {
            this.CheckBal = checkBal;
        }

        public double CheckCheckBal()
        {
            return CheckBal;
        }
    }
}
