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
            switch(empInput)
            {
                case FULL_TIME:
                    Console.WriteLine("Full time Employee");
                    empHrs = 8;
                    break;
                case PART_TIME:
                    Console.WriteLine("Part time Employee");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    break;

            }
            empWage = empHrs * WAGE_PER_HR;
            Console.WriteLine("Employee Wage per Day : "+empWage);
        }
    }
}
