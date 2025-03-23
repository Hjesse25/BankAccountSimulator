using BankAccountSimulator.Accounts;

var account1 = new Checking("Timmy", 200);

account1.Deposit(100);
account1.Deposit(500);
account1.Withdraw(250);
account1.AddInterest(0.03M);

decimal account1Balance = account1.GetBalance();
Console.WriteLine($"The total balance for {account1.Owner} is {account1Balance}");

var account2 = new Premium("John", 500);

account2.Deposit(1000);
account2.Withdraw(300);
account2.Deposit(1000);
account2.AddInterest(0.03M);

decimal account2Balance = account2.GetBalance();
Console.WriteLine($"The total balance for {account2.Owner} is {account2Balance}");