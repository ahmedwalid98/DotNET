namespace Day8;

public class UnderBalanceEventArgs: EventArgs
{
    public decimal DifferentAmount { get; set; }
    public DateTime TimeStamp { get; } = DateTime.Now; 
}