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


            Member Member1 = new Member("Vlad", "Impaler", "101-31-1897", "330- 101-1897", "330- 101-1897", "Transylvania", "Romania", "10666", "StickItToMe@WaysToDie.Com");
            {

            }

            double CheckBal = 666.66;
            double SavingBal = 10.31;
    
 
            Console.WriteLine("Welcome back " + Member1.FirstName + " " + Member1.LastName + ".");
            Console.WriteLine("How can we serve you today?");
            Console.WriteLine("(Please type in the letter of one of the options below.)");
            Console.WriteLine("A. View your information \nB. View account balances \nC. Deposit funds \nWithdrawl funds \nExit");
            string userAction= Console.ReadLine().ToUpper();

            switch (userAction)
            {
                case "A":
                    Member1.ViewInfo();
                    break;

                case "B":
                    Console.WriteLine("The current balance in your checking account is " + CheckBal + ". \n The current balance in your savings account is " + SavingBal + ".");
                    break;

                case "C":
                    Console.WriteLine("Which account would you like to deposit funds into?");
                    Console.WriteLine("(Please enter '1' for checking or '2' for saving.)");
                    string depAcctChoice = Console.ReadLine();

                    if (depAcctChoice == "1")
                    {
                        Console.WriteLine("Please enter deposit amount.");
                        double deposit = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Thank you for your deposit. Your current balance is " + (deposit + CheckBal) + "."); 

                    }
                    else if (depAcctChoice == "2")
                    {
                        Console.WriteLine("Please enter deposit amount.");
                        double deposit = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Thank you for your deposit. Your current balance is " + (deposit + SavingBal) +".");
                    }
                    else
                    {
                        Console.WriteLine("Thank you for visiting the Vault of Romania.");
                        
                    }
                    break;
           
                    case "D":
                    Console.WriteLine("From which account would you like to withdrawl funds from?");
                    Console.WriteLine("(Please enter '1' for checking or '2' for saving.)");
                    string withdrawlAcctChoice = Console.ReadLine();

                    if (withdrawlAcctChoice == "1")
                    {
                        Console.WriteLine("Please enter withdrawl amount.");
                        double withdrawl = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Your current balance is " + (CheckBal - withdrawl) + ". \nPlease retrieve your cash from the tray below.");
                    }
                    else if (withdrawlAcctChoice == "2")
                    {
                        Console.WriteLine("Please enter withdrawl amount.");
                        double withdrawl = Double.Parse(Console.ReadLine());

                        if(SavingBal - withdrawl < 50d)
                           {
                            Console.WriteLine("The amount currently available in your Saving Account is " + SavingBal + ". n/This amount is lower than the required minumum of $50. \nYou are not able to make a withdrawl at this time.");
                        }
                        else
                            Console.WriteLine("Your current balance is " + (SavingBal - withdrawl) + ". \nPlease retrieve your cash from the tray below.");
                            Console.WriteLine("Thank you for your deposit. Your current balance is " + ".");
                    }
                        break;
                    
                case "E":

                        break;
                }
      
        }
    }
}
