namespace Day3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region One Employee

            // Employee e1 = new Employee();
            // Console.WriteLine("Enter your id: ");
            // e1.Id = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter your name: ");
            // e1.Name = Console.ReadLine();
            // Console.WriteLine("Enter your age: ");
            // e1.Age = int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter your salary: ");
            // e1.Salary = decimal.Parse(Console.ReadLine());
            //
            // Console.WriteLine(e1);
            #endregion

            #region Three Employees

            // Employee[] employees = new Employee[3];
            //
            // for (int i = 0; i < employees.Length; i++)
            // {
            //     employees[i] = new Employee();
            //     Console.WriteLine("Enter your id: ");
            //     employees[i].Id = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Enter your name: ");
            //     employees[i].Name = Console.ReadLine();
            //     Console.WriteLine("Enter your age: ");
            //     employees[i].Age = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Enter your salary: ");
            //     employees[i].Salary = decimal.Parse(Console.ReadLine());
            // }
            //
            // for (int i = 0; i < employees.Length; i++)
            // {
            //     Console.WriteLine(employees[i]);
            // }
            #endregion

            #region Named param

            // Employee e1 = new Employee(_name: "ahmed", _id: 2, _salary: 2323, _age: 30);
            

            #endregion

            #region Property parma

            // Employee e1 = new Employee { Id = 1, Age = 35, Name = "ahmed", Salary = 250000 };

            #endregion

            #region Pass by value vs Pass by ref

            // int x = 3;
            // int z = 5;
            
            // Utility.SwapByValue(x, z);
            // Console.WriteLine(x); // 3
            // Console.WriteLine(z); // 5
            
            // we use the keyword ref to pass ny reference
            // Utility.SwapByRef(ref x, ref z);
            // Console.WriteLine(x); // 5
            // Console.WriteLine(z); //3
            #endregion
 
            #region ref vs out

            // out used to pass reference of unassigned local variables
            // int x = 2;
            // int y = 7;
            // int z;
            // Utility.Add(ref x, ref y, out z);
            // Console.WriteLine(z); // 9

            #endregion

            #region Foreach

            // int[] arr = { 1, 2, 3, 4, 5 };
            // foreach (var num in arr)
            // {  
            //     // num++ gives compile error because its read only
            //     Console.WriteLine(num);
            // }
            //
            // Employee[] employees = new Employee[]
            // {
            //     new Employee { Id = 1, Age = 35, Name = "ahmed", Salary = 250000 },
            //     new Employee { Id = 1, Age = 35, Name = "menna", Salary = 250000 },
            //     new Employee { Id = 1, Age = 35, Name = "mohammed", Salary = 250000 },
            //     new Employee { Id = 1, Age = 35, Name = "yamen", Salary = 250000 },
            // };
            //
            // foreach (var employee in employees)
            // {
            //     Console.WriteLine(employee);
            // }
            #endregion
        }
    }
}
 
