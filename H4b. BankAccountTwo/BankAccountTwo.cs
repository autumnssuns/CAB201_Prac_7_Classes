namespace BankAccountTwo
{
    /// <summary>
    /// Bank account for a user.
    /// </summary>
    class BankAccountTwo
    {

        /// <summary>
        /// The first name.
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// The family name.
        /// </summary>
        public string FamilyName { get; private set; }

        /// <summary>
        /// The date of a person's birth
        /// </summary>
        public MyDate DOB { get; private set; }

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
        /// <param name="firstname">The first name.</param>
        /// <param name="familyname">The family name.</param>
        /// <param name="year">The year.</param>
        /// <param name="month">The month.</param>
        /// <param name="day">The day.</param>
        /// <param name="number">The back account number.</param>
        /// <param name="money">The money in the account.</param>
        public BankAccountTwo(string firstname, string familyname, int year, int month, int day, int number, double money)
        {
            FirstName = firstname;
            FamilyName = familyname;

            DOB = new MyDate(day, month, year);
            Number = number;
            Money = money;
        }

    }
}

