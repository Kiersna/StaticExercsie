public class BankAccount
{
    private string AccountNumber;
    private decimal Balance;
    private static int totalAccounts;
    public BankAccount(string accountNumber, decimal starting_balance)
    {
        AccountNumber = accountNumber;
        Balance = starting_balance;
        totalAccounts++;
    }
    public void Deposit(decimal kwota)
    {
        Balance += kwota;
    }
    public void Withdraw(decimal kwota)
    {
        if (Balance > kwota)
        {
            Balance -= kwota;
        }
        else
        {
            throw new InvalidOperationException("brak kaski");
        }
    }
    public string GetAccountInfo()
    {
        return($"Numer konta to: {AccountNumber}, Stan konta to: {Balance}");
    }

    public static string GetTotalAccounts()
    {
        return($"Łącznie jest utworzonych {BankAccount.totalAccounts} kont");
    }
    public static void Main()
    {
        BankAccount account1 = new BankAccount("123456", 500);
        account1.Deposit(200);
        account1.Withdraw(50);
        Console.WriteLine(account1.GetAccountInfo());  // "Account: 123456, Balance: 650.00"

        BankAccount account2 = new BankAccount("789101", 1000);
        Console.WriteLine(account2.GetAccountInfo());  // "Account: 789101, Balance: 1000.00"

        Console.WriteLine("Total Accounts: " + BankAccount.GetTotalAccounts());  // np. "Total Accounts: 2"
    }
}