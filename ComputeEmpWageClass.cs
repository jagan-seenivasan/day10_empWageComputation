using System;
using System.Collections.Generic;
using System.Text;

namespace day10_Emp_Wages_Computation
{
    class ComputeEmpWageClass : UC8_MultipleCompany
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int MaxHoursPerMonth)
        {
            //Variables
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingHrs = 0;

            while (totalWorkingHrs < numOfWorkingDays && totalEmpHrs <= MaxHoursPerMonth)
            {
                totalWorkingHrs++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day# : " + totalWorkingHrs + " Emp Hrs : " + empHrs);

            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company: " + company + " is " + totalEmpWage);
            return totalEmpWage;
        }
    }

}
    //static void Main(String[] args)
    //{
    //    ComputeEmpWage("DMart", 20, 2, 10);
    //    ComputeEmpWage("Reliance", 10, 4, 20);
    //}
