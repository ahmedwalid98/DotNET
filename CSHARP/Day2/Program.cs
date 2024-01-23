namespace day2
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Enum v1

            // Gender g1 = Gender.Male;
            // Gender g2 = Gender.Female;
            // Console.WriteLine(g1);
            // Console.WriteLine(g2);
            // Branch b1 = Branch.Menofuia;
            // Console.WriteLine(b1);

            #endregion

            #region Enum_v2

            // Gender g1;
            // string input;
            //
            // Console.WriteLine("Enter f or m");
            // input = Console.ReadLine();
            //
            // if (input == "f")
            // {
            //     g1 = Gender.Female;
            // }
            // else
            // {
            //     g1 = Gender.Male;
            // }
            //
            // Console.WriteLine($"Your gender is {g1}");
            #endregion

            #region casting bet. numeric values
            // implicit casting done by compiler
            // safe casting
            /*
            int x = 22;
            decimal y = 33;

            y = x;
            Console.WriteLine(x);
            Console.WriteLine(y);
            */
            
            // explicit casting unsafe casting
            /*
            int x = 22;
            decimal y = Decimal.MaxValue;

            x = (int) y;
            Console.WriteLine(x);
            */
            #endregion

            #region var
            /*
            var x = 32; // int32 data type;
            var str = "ahmed"; // string data type
            var z; // compile error var must be initialized
            */

            #endregion

            #region Nullable value type

            int? x = null;
            // Console.WriteLine(x);
            // x = 22;
            // Console.WriteLine(x);
            // v1
            // if (x != null)
            //     Console.WriteLine(x);
            // else
            //     Console.WriteLine("Emptyy");
            
            //v2
            // if (x.HasValue)
            //     Console.WriteLine(x);
            // else
            //     Console.WriteLine("Empty");
            
            // v3
            // int res = x.HasValue ? x.Value : -1;
            // Console.WriteLine(res);
            
            // v4
            // int res = x ?? -1;
            // Console.WriteLine(res);

            #endregion

            #region Struct

            // Point p1 = new Point();
            // Console.WriteLine(p1);

            #endregion
        }
    }
}

