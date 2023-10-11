namespace Classes;

public class BankAccount
{
    private static int s_accountNumberSeed = 1234567890;

    public string Number {get;}
    public string Owner {get; set;}

    public decimal Balance
    {
        get
        {
            decimal currentBalance = 0;
            foreach (var item in _allTransactions)
            {
                currentBalance += item.Amount;
            }
            return currentBalance;
        }
    }

    public BankAccount(string name, decimal initialBalnce)
    {
        Owner = name;
        Number = s_accountNumberSeed.ToString();
        s_accountNumberSeed++;

        MakeDeposit(initialBalnce, DateTime.Now, "Initial Balance");
    }

    private List<Transaction> _allTransactions = new List<Transaction>();

    public decimal MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        }
        var deposit = new Transaction(amount, date, note);
        _allTransactions.Add(deposit);
        return deposit.Amount;
    }

    public decimal MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
        }
        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Insufficient funds for this wihdrawal");
        }
        var withdrawal = new Transaction(-amount, date, note);
        _allTransactions.Add(withdrawal);
        return -1 * withdrawal.Amount;
    }

    public string GetAccountHistory()
    {
        decimal balance = 0;

        var report = new System.Text.StringBuilder();
        report.AppendLine("Date\tAmount\tBalance\tNote");
        foreach (var account in _allTransactions)
        {
            balance += account.Amount;
            report.AppendLine($"{account.Date.ToShortDateString()}\t{account.Amount}\t{balance}\t{account.Notes}");
        }
        return report.ToString();
    }
}