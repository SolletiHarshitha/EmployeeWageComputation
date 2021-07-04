using System;

namespace EmployeeWageCompution
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Wage Computation");
            EmployeeWage dmart = new EmployeeWage("Dmart",20,20,100);
            EmployeeWage reliance = new EmployeeWage("Reliance",50,20,75);
            dmart.Compute();
            reliance.Compute();
        }
    }
}
