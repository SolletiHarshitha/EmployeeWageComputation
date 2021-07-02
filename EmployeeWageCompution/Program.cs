using System;

namespace EmployeeWageCompution
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Wage Computation");
            EmployeeWage.Compute("Dmart",20,20,100);
            EmployeeWage.Compute("Reliance", 50, 20, 75);
        }
    }
}
