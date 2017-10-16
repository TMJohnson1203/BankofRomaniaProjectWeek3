using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankofRomaniaProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // instantiate new bank member requirement = member info in Parent Class

            Member Member1 = new Member();

            // instantiate new checking acct
            Checking Checking1 = new Checking("10311897", 18.87d);


            // instantiate new saving acct

            Saving Saving1 = new Saving("6661897", 1031d);

            // opening display menu
            Console.WriteLine("Welcome back " + Member1.FirstName + " " + Member1.LastName + ".");
            Console.WriteLine("How can we serve you today?");
            Console.WriteLine("(Please type in the letter of one of the options below to continue.)");
            Console.WriteLine("A. View your information \nB. View account balances \nC. Deposit funds \nWithdrawl funds \nExit");
            string userAction = Console.ReadLine().ToUpper();

            do

                switch (userAction)
                {
                    case "A":
                        Member1.ViewInfo();
                        Console.WriteLine("(Please type in the letter of one of the options below to continue.)");
                        Console.WriteLine("A. View your information \nB. View account balances \nC. Deposit funds \nWithdrawl funds \nExit");
                        break;

                    case "B":
                        Console.WriteLine("Which account balance would you like to view?");
                        Console.WriteLine("(Please enter '1' for checking or '2' for saving.)");
                        string acctChoice = Console.ReadLine();
                        if (acctChoice == "1")
                        {
                            Checking1.ViewBalance();
                            Console.WriteLine("The current balance in your checking account is " + Balance + ".");
                            Console.WriteLine("(Please type in the letter of one of the options below to continue.)");
                        }
                        else if (acctChoice == "2")
                        {
                            Saving1.ViewBalance();
                            Console.WriteLine(" The current balance in your savings account is " + Balance + ".");
                        }
                        else
                        {
                            Console.WriteLine("Thank you for visiting the Vault of Romania.");
                            Console.WriteLine("Farewell.");
                            Environment.Exit(0);
                        }

                        break;

                    case "C":
                        Console.WriteLine("Which account would you like to deposit funds into?");
                        Console.WriteLine("(Please enter '1' for checking or '2' for saving.)");
                        string depAcctChoice = Console.ReadLine();

                        if (depAcctChoice == "1")
                        {
                            Console.WriteLine("Please enter deposit amount.");
                            double depositAmount = Double.Parse(Console.ReadLine());
                            Checking1.Deposit();
                            Console.WriteLine("Thank you for your deposit. Your current balance is " + (depositAmount + Balance) + ".");

                        }
                        else if (depAcctChoice == "2")
                        {
                            Console.WriteLine("Please enter deposit amount.");
                            double depositAmount = Double.Parse(Console.ReadLine());
                            Saving1.Deposit();
                            Console.WriteLine("Thank you for your deposit. Your current balance is " + (depositAmount + Balance) + ".");
                        }
                        else
                        {
                            Console.WriteLine("Thank you for visiting the Vault of Romania.");
                            Console.WriteLine("Farewell.");
                            Environment.Exit(0);
                        }
                        break;

                    case "D":
                        Console.WriteLine("From which account would you like to withdrawl funds from?");
                        Console.WriteLine("(Please enter '1' for checking or '2' for saving.)");
                        string withdrawlAcctChoice = Console.ReadLine();

                        if (withdrawlAcctChoice == "1")
                        {
                            Console.WriteLine("Please enter withdrawl amount.");
                            double withdrawlAmount = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Your current balance is " + (Balance - withdrawlAmount) + ". \nPlease retrieve your cash from the tray below.");
                        }
                        else if (withdrawlAcctChoice == "2")
                        {
                            Console.WriteLine("Please enter withdrawl amount.");
                            double withdrawlAmount = Double.Parse(Console.ReadLine());

                            if (Balance - withdrawlAmount < 50d)
                            {
                                Console.WriteLine("The amount currently available in your Saving Account is " + Balance + ". n/This amount is lower than the required minumum of $50. \nYou are not able to make a withdrawl at this time.");
                            }
                            else
                                Console.WriteLine("Your current balance is " + (Balance - withdrawlAmount) + ". \nPlease retrieve your cash from the tray below.");
                            Console.WriteLine("Thank you for your deposit. Your current balance is " + ".");
                        }
                        else
                        {
                            Console.WriteLine("Thank you for visiting the Vault of Romania.");
                            Console.WriteLine("Farewell.");
                            Environment.Exit(0);
                        }
                        break;
                
                   Console.WriteLine("(Please type in the letter of one of the options below to continue.)");
                   Console.WriteLine("A. View your information \nB. View account balances \nC. Deposit funds \nWithdrawl funds \nExit");
                   string nextUserAction =  Console.ReadLine();

                    while (nextUserAction != "E")

                            Console.WriteLine("Thank you for visiting the Vault of Romania.");
                            Console.WriteLine("Farewell.");
                            Environment.Exit(0);
                  

                        //Console.WriteLine("(Please type in the letter of one of the options below to continue.)");
                        //Console.WriteLine("A. View your information \nB. View account balances \nC. Deposit funds \nWithdrawl funds \nExit");

                        while (userAction != "E") ;
      
             }
        }
    }
}