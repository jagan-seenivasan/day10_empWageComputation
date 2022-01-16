using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wages_Computation
{
    class UC2_DailyWage
    {
        public static void CheckDailySalary()
        {

            Random random = new Random();
            int number = random.Next(2);

            if (number == 0)
            {
                int empRatePerHr = 20;
                int empHrs = 8;
                int salary = (empRatePerHr * empHrs);
                Console.WriteLine("Employeee Daily Salary is " + salary);
            }
            else
            {
                int salary = 0;
                Console.WriteLine("Employee Daily Salary is " + salary);
            }
        }
    }
}
