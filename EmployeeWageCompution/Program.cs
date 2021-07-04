using System;

namespace EmployeeWageCompution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Wage Computation");
            CompanyEmployeeWage companyempwage = new CompanyEmployeeWage();
            companyempwage.addCompany("Dmart",20,20,100);
            companyempwage.addCompany("Reliance",50,20,75);
            companyempwage.Compute();
            Console.WriteLine("Total wage of Dmart is : "+companyempwage.GetTotalWage("Dmart"));
            Console.WriteLine("Total wage of Reliance is : " + companyempwage.GetTotalWage("Reliance"));
        }
    }
}
