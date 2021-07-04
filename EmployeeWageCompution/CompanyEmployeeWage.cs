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
        public LinkedList<EmployeeWage> companyWageArray;
        public Dictionary<string, EmployeeWage> companyEmpWage;

        //Object ArrayList is created
        public CompanyEmployeeWage()
        {
            companyWageArray = new LinkedList<EmployeeWage>();
            companyEmpWage = new Dictionary<string, EmployeeWage>();
        }

        //Adding the company 
        public void addCompany(string companyName,int wagePerHr,int maxWorkingDays,int maxWorkingHrs)
        {
            EmployeeWage empwage = new EmployeeWage(companyName, wagePerHr, maxWorkingDays, maxWorkingHrs);
            companyWageArray.AddLast(empwage);
            companyEmpWage.Add(companyName, empwage);
        }

        public void Compute()
        {
            //Employee wage computation is done for each company
            foreach(EmployeeWage wage in companyWageArray)
            {
                this.Compute(wage);
            }
        }

        //Employee wage computation is done for the specified company
        public void Compute(EmployeeWage empwage)
        {
            Random random = new Random();
            int empHrs = 0;
            int dailyWage = 0;
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

                dailyWage = empHrs * empwage.wagePerHr;
                empWorkingHrs += empHrs;
                totalWage += dailyWage;

                if (empInput != 0)
                {
                    Console.WriteLine("Employee wage for "+empwage.companyName+" for DAY - "+day+" is : "+dailyWage);
                    day++;
                }
            }
            //Calculating the total employee wage
            empwage.totalEmpWage = totalWage;
            Console.WriteLine("Wage for " + empwage.companyName + " employees for " + day + " working days per month : " +empwage.totalEmpWage);
            Console.WriteLine();
        }
        //Method to get total wage
        public int GetTotalWage(string companyName)
        {
            return companyEmpWage[companyName].totalEmpWage;
        }
    }
}
