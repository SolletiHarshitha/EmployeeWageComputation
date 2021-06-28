using System;

namespace EmployeeWageCompution
{
    class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int WAGE_PER_HR = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;
        static void Main(string[] args)
        {
            Random random = new Random();
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int empWorkingHrs = 0;
            while(day <= MAX_WORKING_DAYS && empWorkingHrs < MAX_WORKING_HRS)
            {
                int empInput = random.Next(0, 3);
                switch (empInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                empWage = empHrs * WAGE_PER_HR;
                empWorkingHrs += empHrs;
                totalWage += empWage;
                if (empInput != 0)
                    day++;
            }
            Console.WriteLine("Employee Wage for " + day + " working days per month : " + totalWage);

        }
    }
}
