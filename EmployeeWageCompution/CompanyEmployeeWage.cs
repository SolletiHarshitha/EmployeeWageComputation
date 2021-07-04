using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCompution
{
    //Interface is implemented
    public interface ICompanyEmpWage
    {
        public void addCompany(string companyName, int wagePerHr, int maxWorkingDays, int maxWorkingHrs);
        public void Compute();
    }
    class CompanyEmployeeWage : ICompanyEmpWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public int numberOfCompanies = 0;
        public EmployeeWage[] companyWageArray;

        //Object array is created
        public CompanyEmployeeWage()
        {
            companyWageArray = new EmployeeWage[10];
        }

        //Adding the company 
        public void addCompany(string companyName,int wagePerHr,int maxWorkingDays,int maxWorkingHrs)
        {
            companyWageArray[numberOfCompanies] = new EmployeeWage(companyName, wagePerHr, maxWorkingDays, maxWorkingHrs);
            numberOfCompanies++;
        }

        public void Compute()
        {
            //Employee wage computation is done for each company
            for(int i=0;i<numberOfCompanies;i++)
            {
                Compute(this.companyWageArray[i]);
            }
        }

        //Employee wage computation is done for the specified company
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
            //Calculating the total employee wage
            empwage.totalEmpWage = totalWage;
            Console.WriteLine("Wage for " + empwage.companyName + " employees for " + day + " working days per month : " +empwage.totalEmpWage);
        }
    }
}
