namespace Day8;

public class BankAccountAgent
{
    public string Name { get; set; }

    public void WarnBacnkAccount(object sender, UnderBalanceEventArgs e)
    {
        if (sender is Bank b && e.DifferentAmount > 100) 
            Console.WriteLine($"Bank: {Name} warns {b.AccountName} of bankrupt");
    }
}