using System;

namespace BankAccountTwo
{
    /// <summary>
    /// A class to test the bank account class.
    /// </summary>
    class TestBankAccountTwo
    {

        /// <summary>
        /// The main program.
        /// </summary>
        static void Main(string[] args)
        {
            BankAccountTwo account = new BankAccountTwo("Harry" ,"Potter", 2001, 7, 30, 1234, 2000.00);
            Console.WriteLine(account.FirstName + " " + account.FamilyName + " " + account.DOB.Day + "/" + account.DOB.Month + "/" + account.DOB.Year + " " + account.Number + " " + account.Money);
            account.Deposit(1000);
            Console.WriteLine(account.FirstName + " " + account.FamilyName + " " + account.DOB.Day + "/" + account.DOB.Month + "/" + account.DOB.Year + " " + account.Number + " " + account.Money);
            account.Withdrawl(500);
            Console.WriteLine(account.FirstName + " " + account.FamilyName + " " + account.DOB.Day + "/" + account.DOB.Month + "/" + account.DOB.Year + " " + account.Number + " " + account.Money);

        }

    }
}
