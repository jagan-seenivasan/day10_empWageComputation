using System;
using System.Collections.Generic;
using System.Text;

namespace Day10_EmployeeWageComputation
{
    class UC10_CompanyEmpWage
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalEmpWage;

        public UC10_CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string toString()
        {
            return "Total Emp Wage for company : " + this.company + " is : " + this.totalEmpWage;
        }
    }
}
