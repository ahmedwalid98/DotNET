namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        #region Point test

        // Point3D p1 = new Point3D();
        // Point3D p2 = new Point3D();
        //
        // Console.WriteLine("Enter Point 1 coordinates");
        // p1.X = decimal.Parse(Console.ReadLine());
        // p1.Y = decimal.Parse(Console.ReadLine());
        // p1.Z = decimal.Parse(Console.ReadLine());
        // Console.WriteLine("Enter Point 2 coordinates");
        // p2.X = decimal.Parse(Console.ReadLine());
        // p2.Y = decimal.Parse(Console.ReadLine());
        // p2.Z = decimal.Parse(Console.ReadLine());
        // Console.WriteLine(p1);
        // Console.WriteLine(p2);
        // Console.WriteLine(p1.Equals(p2));

        #endregion

        #region Math class test

        // Console.WriteLine(Math.Add(2,4));
        // Console.WriteLine(Math.Divide(4, 2));
        // Console.WriteLine(Math.Subtract(2, 1));
        // Console.WriteLine(Math.Multiply(2, 2));

        #endregion

        #region NIC (singelton design pattern) test

        // NIC nic1 = NIC.Instance;
        // NIC nic2 = NIC.Instance;
        //
        // Console.WriteLine(nic1.GetHashCode());
        // Console.WriteLine(nic2.GetHashCode());
        #endregion

        #region Duration class test
        // var d1 =new Duration (1,59,15);
        // Console.WriteLine(d1);
        // var duration = new Duration(3600);
        // Console.WriteLine(duration);
        // var d2 =new Duration (7800);
        // Console.WriteLine(d2);
        // var d3 = new Duration(666);
        // Console.WriteLine(d3);
        // var d4 = duration + d3;
        // Console.WriteLine(d4);
        // var d5 = d1++;
        // Console.WriteLine(d5);
        // var d6 = duration--;
        // Console.WriteLine(d6);

        #endregion
    }
}