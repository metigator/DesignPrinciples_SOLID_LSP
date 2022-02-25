using System;

namespace SOLID.LSP.Before
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

        public override void Withdraw(decimal amount)
        {
            throw new NotSupportedException($"You can not withdraw from Fixed Deposit Account!!!");
        }
    }
}
