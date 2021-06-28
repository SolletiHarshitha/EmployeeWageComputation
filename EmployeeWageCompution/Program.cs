using System;

namespace EmployeeWageCompution
{
    class Program
    {
        public const int FULL_TIME = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Random random = new Random();
            int empInput = random.Next(0, 2);
            if(empInput==FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent"); ;
            }
        }
    }
}
