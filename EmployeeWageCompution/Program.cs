using System;

namespace EmployeeWageCompution
{
    class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int WAGE_PER_HR = 20;
        public const int WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            Random random = new Random();
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int daysAbsent = 0;
            for(int day = 1;day <= WORKING_DAYS;day++)
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
                        daysAbsent++;
                        break;

                }
                empWage = empHrs * WAGE_PER_HR;
                totalWage += empWage;
            }
            Console.WriteLine("Employee Wage for " + (WORKING_DAYS-daysAbsent) + " working days per month : " + totalWage);

        }
    }
}
