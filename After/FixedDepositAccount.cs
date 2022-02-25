using System;

namespace SOLID.LSP.After
{
    class FixedDepositAccount : Account
    {
        public FixedDepositAccount(string name, decimal balance) 
            : base(name, balance)
        {
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}
