namespace Day8;

public static class BlackListAccounts
{
    public static List<string> BlackListAccount { get; set; } = new List<string>();

    public static void AddToBlackList(object sender, UnderBalanceEventArgs e)
    {
        if (sender is Bank b && e.DifferentAmount > 100)
        {
            Console.WriteLine($"proceed to add {b.AccountName} to black list");
            BlackListAccount.Add(b.AccountName);
        }
    }

    public static string ShowList()
    {
        string str = "";
        foreach (var s in BlackListAccount)
        {
            str += s;
            str += Environment.NewLine;
        }
        return str;
    }
}