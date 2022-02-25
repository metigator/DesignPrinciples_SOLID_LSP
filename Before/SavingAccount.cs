namespace SOLID.LSP.Before
{
    class SavingAccount : Account
    {
        public SavingAccount(string name, decimal balance) 
            : base(name, balance)
        {
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
