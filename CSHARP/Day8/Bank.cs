namespace Day8;

public class Bank
{
    public int AccountNo { get; set; }
    public string AccountName { get; set; }
    public decimal Balance { get; set; }

    public Bank()
    {
        
    }

    public Bank(int accountNo, string accountName, decimal balance)
    {
        AccountNo = accountNo;
        AccountName = accountName;
        Balance = balance;
    }

    public override string ToString()
    {
        return $"{AccountNo}:{AccountName},{Balance}";
    }

    public bool Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            return true;
        }

        return false;
    }

    public bool Credit(decimal amount)
    {
        if (amount > 0 && Balance > amount)
        {
            Balance -= amount;
            return true;
        }
        else
        {
            var diff = amount - Balance;
            OnUnderBalance(new UnderBalanceEventArgs{DifferentAmount = diff});
            return false;
        }
    }

    #region EventHandler V1

    // public event EventHandler UnderBalance;
    //
    // protected virtual void OnUnderBalance(EventArgs e)
    // {
    //     UnderBalance?.Invoke(this, e);
    // } 

    #endregion

    #region EventHandlerv2

    public event EventHandler<UnderBalanceEventArgs> UnderBalance;
    protected virtual void OnUnderBalance(UnderBalanceEventArgs e)
    {
        UnderBalance?.Invoke(this, e);
    } 
    #endregion
}