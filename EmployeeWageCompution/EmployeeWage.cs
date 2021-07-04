using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCompution
{
    class EmployeeWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        private string companyName;
        private int wagePerHr;
        private int maxWorkingDays;
        private int maxWorkingHrs;
        public EmployeeWage(string companyName,int wagePerHr,int maxWorkingDays,int maxWorkingHrs)
        {
            this.companyName = companyName;
            this.wagePerHr = wagePerHr;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }
        public void Compute()
        {
            Random random = new Random();
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int empWorkingHrs = 0;
            while (day <= maxWorkingDays && empWorkingHrs < maxWorkingHrs)
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
                empWage = empHrs * wagePerHr;
                empWorkingHrs += empHrs;
                totalWage += empWage;
                if (empInput != 0)
                    day++;
            }
            Console.WriteLine("Wage for "+companyName+" employees for " + day + " working days per month : " + totalWage);
        }
    }
}
