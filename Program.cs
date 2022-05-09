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
        public static decimal balance;

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
        }
        
        static void Main(string[] args)
        {
            CheckPin();
        }
    }
}
