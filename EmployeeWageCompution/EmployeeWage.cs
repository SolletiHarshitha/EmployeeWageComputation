using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageCompution
{
    class EmployeeWage
    {
        public string companyName;
        public int wagePerHr;
        public int maxWorkingDays;
        public int maxWorkingHrs;
        public int totalEmpWage;
        public EmployeeWage(string companyName,int wagePerHr,int maxWorkingDays,int maxWorkingHrs)
        {
            this.companyName = companyName;
            this.wagePerHr = wagePerHr;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }
        
    }
}
