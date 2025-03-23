namespace BankAccountSimulator.Accounts
{
    public class Premium : Checking
    {
        public Premium(string owner, decimal balance) : base(owner, balance)
        {
        }

        public override void AddInterest(decimal percent)
        {
            decimal interest = (1 * 500 * percent) + 0.01M;
            balance += interest;
        }
    }
}