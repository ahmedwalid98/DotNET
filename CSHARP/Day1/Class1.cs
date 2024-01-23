using System.Diagnostics;

namespace Day1
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            #region Value type

            int x = 7;
            float y = 14.55f;
            double z = 14.6;
            decimal o = 12.454M;
            int xx = x;
            ++xx;
            Console.WriteLine(x);
            Console.WriteLine(xx);


            #endregion

            #region Refrence type

            Object o1;
            
            o1 = new object();
           
            
            object o2 = new object();
            
            Console.WriteLine(o1.GetHashCode());
            Console.WriteLine(o2.GetHashCode());
            
            
            o2 = o1;
            
            
            Console.WriteLine("After Equality : ");
            Console.WriteLine(o1.GetHashCode());
            Console.WriteLine(o2.GetHashCode());

            #endregion

            #region String formationg

            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            
            string msg = string.Format($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"Equation: {msg}");

            #endregion

            #region If statement and Switch

            int input = int.Parse(Console.ReadLine());
            if (input == 5)
                Console.WriteLine("Number is 5");
            else
                Console.WriteLine("Number is not 5");

            switch (input)
            {
                case 5:
                    Console.WriteLine("Number is 5");
                    break;
                default:
                    Console.WriteLine("Number is not 5");
                    break;
            }

            #endregion

            #region Array 1D

            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr3 = new int[] { 3, 45, 5 };
            int[] arr4 = { 1, 3, 4, 5 };
            

            #endregion

            #region Array2D

            int[,] arr2d = new int[3, 4];
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    
                }
            }

            #endregion
        }
    }
}