namespace BankAccountSimulator.Accounts
{
    public class Checking
    {
        private decimal balance;
        public string Owner { get; set; }

        public Checking(string owner, decimal balance)
        {
            Owner = owner;
            Deposit(balance);
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }

            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw amount must be positive.");
            }

            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }

            balance -= amount;
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
