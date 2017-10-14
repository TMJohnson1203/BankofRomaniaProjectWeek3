using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankofRomaniaProject
{
    class Saving : AccountInfo
    {
        protected double savingBal;
        public double SavingBal { get; set; }
        double minimum = 50.00d;

        public Saving()
        {

        }

        public Saving(double savingBal)
        {
            this.SavingBal = savingBal;
        }

        public override double Withdrawl()
        {
           
        }
    }
}
