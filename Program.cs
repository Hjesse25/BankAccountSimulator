using BankAccountSimulator;

BankAccount bankAccount = new BankAccount("John", 200);

bankAccount.Deposit(300);
bankAccount.Deposit(500);
bankAccount.Withdraw(200);

decimal balance = bankAccount.GetBalance();
Console.WriteLine($"Your current balance is: {balance}");
