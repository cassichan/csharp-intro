try
{
   BankAccount myBankAccount = new BankAccount(100);
   Console.WriteLine($"My bank account balance is {myBankAccount.balance}");

   CheckingAccount myAccount = new CheckingAccount(300);
   Console.WriteLine($"My checking account balance is {myAccount.balance}");


   SavingsAccount mySavings = new SavingsAccount(2000);
   // mySavings.balance = 1000;
   double balance = mySavings.Deposit(10);

   // Console.WriteLine($"My savings balance is {mySavings.balance}");
   // Console.WriteLine($"My savings balance is {mySavings.GetBalance()}");
   Console.WriteLine($"My savings balance after deposit is {balance}");
}

catch (Exception err)
{
   Console.WriteLine(err.Message);
}
