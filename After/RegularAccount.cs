namespace SOLID.LSP.After
{
    abstract class RegularAccount :Account
    {
        protected RegularAccount(string name, decimal balance)
            : base(name, balance)
        {
            Name = name;
            Balance = balance;
        }

        public abstract void Withdraw(decimal amount);
    }
}
