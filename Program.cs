using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsoleAPP
{
    internal class Program
    {
        // ******** Global Variables *********

        // our allow user input options
        public static string[] menuOptions = {"1", "2", "3", "4"};

        // User Balance of funds
        public static decimal balance = 0;

        // menu option that user has selected
        public static string userOption = "";

        private static void CheckPin()
        {
            string pin = "";
            Console.WriteLine("\t****** Welcome to the ATM Program ******\n\n\tPlease enter your pin number");

            // User input
            pin = Console.ReadLine();

            // use while loop to check pin
            while(pin != "1234")
            {
                if(pin == "1234")
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("\tPin number incorrect, enter again.");
                    pin = Console.ReadLine();
                }
            }

            Console.WriteLine("\tPin correct, Access Granted.");
            MainMenu();

        } // end CheckPin

        static void MainMenu()
        {
            Console.WriteLine("****************************************\n");
            Console.WriteLine("\t Select an Option:\n");
            Console.WriteLine("\t [1] View Balance");
            Console.WriteLine("\t [2] Withdraw Funds");
            Console.WriteLine("\t [3] Deposit Funds");
            Console.WriteLine("\t [4] Exit Application\n");
            Console.WriteLine("****************************************\n");

            // run checkinput
            CheckInput();
        }

        public static void CheckInput()
        {
            bool check = false;

            while (check == false)
            {
                Console.WriteLine("Please choose an option ([1], [2], [3], [4])");
                string userInput = Console.ReadLine();

                // loop thru each item in the array (menuOptions) save each interation in the temp variable
                foreach (string temp in menuOptions)
                {
                    // check if users input equals what is in our array (now saved as temp variable)
                    // return true or return false save result into check.
                    check = userInput.Equals(temp);

                    // break out of the foreach loop if check = true
                    if (check)
                    {
                        break;
                    }

                } // end of foreach

                if (check)
                {
                    Console.WriteLine("\tYour input " + userInput + " is valid");
                }
                else
                {
                    Console.WriteLine("\tYour input " + userInput + " is not valid\n\n");
                }

                userOption = userInput;
                ProcessMenu();
                

            } // end of while loop

        } // end of CheckInput

        static void ProcessMenu()
        {
            decimal amount;
            
            if(userOption == "1")
            {
                Console.WriteLine("\t Your balance is " + "$" + balance);
                Console.WriteLine("\n\n");
                if(balance <= 0)
                {
                    Console.WriteLine("\tYou need to deposit some money.\n\n");
                }
                MainMenu();
            }
            if (userOption == "2")
            {
                Console.WriteLine("\t Input how much you want to withdraw.\n");
                
                if(decimal.TryParse(Console.ReadLine(), out amount) && balance > amount)
                {
                    balance -= amount;
                    Console.WriteLine("\tYou withdrew $" + amount + " Your balance is now $" + balance + "\n\n");
                }
                else
                {
                    Console.WriteLine("\tInvalid Amount or you have insufficent funds.\n\n");
                }
                MainMenu();
            }
            if (userOption == "3")
            {
                Console.WriteLine("\t [3] Deposit Funds\n\n");

                if (decimal.TryParse(Console.ReadLine(), out amount))
                {
                    balance += amount;
                    Console.WriteLine("\tYou deposited $" + amount + " Your balance is now $" + balance + "\n\n");
                }
                else
                {
                    Console.WriteLine("\tInvalid Amount.\n\n");
                }
                MainMenu();
            }
            if (userOption == "4")
            {
                Environment.Exit(0);
            }
        } // end ProcessMenu

        static void Main(string[] args)
        {
            CheckPin();
        }
    }
}
