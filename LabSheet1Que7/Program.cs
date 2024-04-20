using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet1Que7
{
    internal class Program
    {
        static double balance = 1000; // Initial balance

        static void Main()
        {
            bool continueTransaction = true;

            while (continueTransaction)
            {
                Console.WriteLine("Welcome to the ATM machine!");
                Console.WriteLine("1 Check Balance");
                Console.WriteLine("2 Deposit Money");
                Console.WriteLine("3 Withdraw Money");
                Console.WriteLine("4 Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        continueTransaction = false;
                        Console.WriteLine("Thank you for using the ATM machine");
                        break;
                    default:
                        Console.WriteLine("Invalid ");
                        break;
                }
            }
        }

        static void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: ${balance}");
        }

        static void DepositMoney()
        {
            Console.Write("Enter the amount you want to deposit: $");
            double depositAmount = double.Parse(Console.ReadLine());
            balance += depositAmount;
            Console.WriteLine($"${depositAmount} has been successfully deposited" +
                $" Your new balance is: ${balance}");
        }

        static void WithdrawMoney()
        {
            Console.Write("Enter the amount you want to withdraw: $");
            double withdrawAmount = double.Parse(Console.ReadLine());
            if (withdrawAmount > balance)
            {
                Console.WriteLine("Insufficient funds. Withdrawal failed.");
            }
            else
            {
                balance -= withdrawAmount;
                Console.WriteLine($"${withdrawAmount} has been successfully withdrawn. Your new balance is: ${balance}");
            }
        }
    }
}