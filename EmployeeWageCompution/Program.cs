using System;

namespace EmployeeWageCompution
{
    class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int WAGE_PER_HR = 20;
        static void Main(string[] args)
        {
            Random random = new Random();
            int empInput = random.Next(0, 3);
            int empHrs = 0;
            int empWage = 0;
            if(empInput==FULL_TIME)
            {
                Console.WriteLine("Full Time Employee");
                empHrs = 8;
            }
            else if(empInput==PART_TIME)
            {
                Console.WriteLine("Part Time Employee");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent"); ;
            }
            empWage = empHrs * WAGE_PER_HR;
            Console.WriteLine("Employee Wage per Day : "+empWage);
        }
    }
}
