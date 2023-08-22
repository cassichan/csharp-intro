
public class BankAccount
{
   public double balance = 0;
   //Constructor
   public BankAccount(double amount)
   {
      if (amount < 0)
      {
         throw new Exception("Amount cannot be negative");
      }
      balance = amount;
   }

   public double GetBalance()
   {
      return balance;
   }

   public void AddInterest()
   {
      balance = balance + 0.05 * balance;
   }

   public double Deposit(double amount)
   {
      if (amount < 0)
      {
         throw new Exception("Amount cannot be negative");
      }
      balance = balance + amount;
      return balance;
   }
}
public class CheckingAccount : BankAccount
{
   public CheckingAccount(double amount) : base(amount)
   {
      Deposit(100);
   }
}

public class SavingsAccount : BankAccount
{
   public SavingsAccount(double amount) : base(amount)
   {
      if(amount > 900)
      {
         Deposit(200);
      }
   }

}



