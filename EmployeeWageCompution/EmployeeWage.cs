using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCompution
{
    class EmployeeWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public static void Compute(string CompanyName,int WagePerHr,int MaxWorkingDays,int MaxWorkingHrs)
        {
            Random random = new Random();
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int empWorkingHrs = 0;
            while (day <= MaxWorkingDays && empWorkingHrs < MaxWorkingHrs)
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
                empWage = empHrs * WagePerHr;
                empWorkingHrs += empHrs;
                totalWage += empWage;
                if (empInput != 0)
                    day++;
            }
            Console.WriteLine("Wage for "+CompanyName+" employees for " + day + " working days per month : " + totalWage);
        }
    }
}
