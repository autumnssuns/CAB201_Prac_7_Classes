using System;

namespace BankAccount
{

    /// <summary>
    /// A class to test the bank account class.
    /// </summary>
    class TestBankAccount
    {


        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Harry Potter", 18, 1234, 2000.00);
            Console.WriteLine(account.Name + " " + account.Age + " " + account.Number + " " + account.Money);
            account.Deposit(1000);
            Console.WriteLine(account.Name + " " + account.Age + " " + account.Number + " " + account.Money);
            account.Withdrawl(500);
            Console.WriteLine(account.Name + " " + account.Age + " " + account.Number + " " + account.Money);

        }

    }
}
