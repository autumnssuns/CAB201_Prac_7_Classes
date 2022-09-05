using System;

namespace BankAccount
{
    /// <summary>
    /// Bank account for a user.
    /// </summary>
    class BankAccount
    {
        /// <summary>
        /// The name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The age.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// The bank account number.
        /// </summary>
        public int Number { get; private set; }

        /// <summary>
        /// The money in the account.
        /// </summary>
        public double Money { get; private set; }

        /// <summary>
        /// A withdrawl
        /// </summary>
        /// <param name="withdrawl">The amount to withdrawl.</param>
        public void Withdrawl(int withdrawl)
        {
            Money -= withdrawl;
        }

        /// <summary>
        /// The deposit.
        /// </summary>
        /// <param name="despoit">The amount to despoit.</param>
        public void Deposit(int despoit)
        {
            Money += despoit;
        }


        /// <summary>
        /// The bank account.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="age">The age.</param>
        /// <param name="number">The back account number.</param>
        /// <param name="money">The money in the account.</param>
        public BankAccount(string name, int age, int number, double money)
        {
            Name = name;
            Age = age;
            Number = number;
            Money = money;
        }

    }
}
