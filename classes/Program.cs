using Classes;

public class Program
{
    public static void Main(string[] args)
    {
        BankAccount invalidAccount;
        BankAccount account;

        // Test opening account with -ve balance
        // try
        // {
        //     invalidAccount = new BankAccount("Taiwo", -1500);
        // }
        // catch (ArgumentOutOfRangeException e)
        // {
        //     Console.WriteLine("Exception caught creating account with -ve balance");
        //     Console.WriteLine(e.ToString());
        //     // return;
        // }


        // Test withdrawal - overdraw
        try
        {
            account = new BankAccount("Taiwo", 1500);
            Console.WriteLine($"New balance => {account.Balance}");
            decimal deposit = account.MakeDeposit(2500, DateTime.Now, "Savings");
            Console.WriteLine($"{account.Owner} with {account.Number} made a deposit of {deposit}");
            decimal withdrawal = account.MakeWithdrawal(1090, DateTime.Now, "Rent");
            Console.WriteLine($"{account.Owner} with {account.Number} made a withdrawal of {withdrawal}");
            
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("Exception caught - overdraw");
            Console.WriteLine(e.ToString());
            return;    
        }
        Console.WriteLine(account.GetAccountHistory());
    }
}
