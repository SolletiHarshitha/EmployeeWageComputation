using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCompution
{
    class CompanyEmployeeWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public int numberOfCompanies = 0;
        public EmployeeWage[] companyWageArray;
        public CompanyEmployeeWage()
        {
            companyWageArray = new EmployeeWage[10];
        }
        public void addCompany(string companyName,int wagePerHr,int maxWorkingDays,int maxWorkingHrs)
        {
            companyWageArray[numberOfCompanies] = new EmployeeWage(companyName, wagePerHr, maxWorkingDays, maxWorkingHrs);
            numberOfCompanies++;
        }
        public void ComputeEmpWage()
        {
            for(int i=0;i<numberOfCompanies;i++)
            {
                Compute(this.companyWageArray[i]);
            }
        }
        public void Compute(EmployeeWage empwage)
        {
            Random random = new Random();
            int empHrs = 0;
            int empWage = 0;
            int totalWage = 0;
            int day = 1;
            int empWorkingHrs = 0;
            while (day <= empwage.maxWorkingDays && empWorkingHrs < empwage.maxWorkingHrs)
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
                empWage = empHrs * empwage.wagePerHr;
                empWorkingHrs += empHrs;
                totalWage += empWage;
                if (empInput != 0)
                    day++;
            }
            empwage.totalEmpWage = totalWage;
            Console.WriteLine("Wage for " + empwage.companyName + " employees for " + day + " working days per month : " +empwage.totalEmpWage);
        }
    }
}
