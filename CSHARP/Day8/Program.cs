namespace Day8;

class Program
{
    static void Main(string[] args)
    {
        // var p1 = new Player { Name = "Ahmed", Team = "Ahly" };
        // var p2 = new Player { Name = "Kareem", Team = "Ahly" };
        // var p3 = new Player { Name = "Mohammed", Team = "Ahly" };
        //
        // var r1 = new Referee { Name = "Mostafa" };
        // var b1 = new Ball { Name = "ball" };
        // b1.BallHasMoved += p1.Move;
        // b1.BallHasMoved += p2.Move;
        // b1.BallHasMoved += p3.Move;
        // b1.BallHasMoved += r1.Observe;
        // b1.Location = new Location {X = 22,Y = 33, Z = 55};
        //
        // Console.WriteLine("----->");
        // b1.Location = new Location {X = 44,Y = 33, Z = 55};

        var b1 = new Bank { AccountNo = 10, AccountName = "ahmed", Balance = 9000 };
        var b2 = new Bank { AccountNo = 20, AccountName = "mohammed", Balance = 10000 };
        var b3 = new Bank { AccountNo = 30, AccountName = "youssif", Balance = 7000 };

        var a1 = new BankAccountAgent {Name = "HSBC"};

        b1.UnderBalance += a1.WarnBacnkAccount;
        b2.UnderBalance += a1.WarnBacnkAccount;
        b3.UnderBalance += a1.WarnBacnkAccount;
        
        b1.UnderBalance += BlackListAccounts.AddToBlackList;
        b2.UnderBalance += BlackListAccounts.AddToBlackList;
        b3.UnderBalance += BlackListAccounts.AddToBlackList;

        b1.Credit(20000);
        b2.Credit(20000);
        b3.Credit(20000);

        Console.WriteLine(BlackListAccounts.ShowList());
        
    }
}