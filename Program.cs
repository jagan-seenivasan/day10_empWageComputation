using System;

namespace day10_Emp_Wages_Computation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(" Welcome to Employee Wage Computation Program on Main Branch");
            Console.WriteLine("_____________________________________________________________\n");

             day10_Emp_Wages_Computation.UC1_EmpCheck uc1 = new UC1_EmpCheck;
             UC1_EmpCheck();
           
            day10_Emp_Wages_Computation.UC2_EmployeeDailyWage uc2 = new UC2_EmployeeDailyWage();
            uc2.EmpDailyWage();

            day10_Emp_Wages_Computation.UC3_PartTimeEmployeeWage uc3 = new UC3_PartTimeEmployeeWage();
            uc3.PartTimeEmpWage();

            day10_Emp_Wages_Computation.UC4_UsingSwitchCase uc4 = new UC4_UsingSwitchCase();
            uc4.EmpWageUsingSwitch();

            day10_Emp_Wages_Computation.UC5_MonthlyWages uc5 = new UC5_MonthlyWages();
            uc5.CalculateWages();

            day10_Emp_Wages_Computation.UC6_TotalWorkingHours uc6 = new UC6_TotalWorkingHours();
            uc6.CalculateWageTill100HrsOr20IsReached();

            UC7_RefactorTheCodeUsingClassMethod.ComputeEmpWage();

            ComputeEmpWageClass computeEmpWageClass = new ComputeEmpWageClass();
            computeEmpWageClass.computeEmpWage("Dmart", 20, 2, 10);

            computeEmpWageClass.computeEmpWage("Reliance", 10, 4, 20);

            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("DMART", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("RELIANCE", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total Wage For DMart Company" + empWageBuilder.getTotalWage("DMART"));




            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the program number which is to be executed \n 1.UC-1, \n 2.UC-2, \n 3.UC-3, \n 4.UC-4, \n 5.UC-5, \n 6.UC-6, \n 7.UC-7, \n 8.UC-8, \n 10.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UC1_CheckEmployee uc1 = new UC1_CheckEmployee();
                        uc1.GetAttendance();
                        break;
                    case 2:
                        day10_Emp_Wages_Computation.UC2_EmployeeDailyWage uc2 = new UC2_EmployeeDailyWage();
                        uc2.EmpDailyWage();
                        break;
                    case 3:
                        day10_Emp_Wages_Computation.UC3_PartTimeEmployeeWage uc3 = new UC3_PartTimeEmployeeWage();
                        uc3.PartTimeEmpWage();
                        break;
                    case 4:
                        day10_Emp_Wages_Computation.UC4_UsingSwitchCase uc4 = new UC4_UsingSwitchCase();
                        uc4.EmpWageUsingSwitch();
                        break;
                    case 5:
                       day10_Emp_Wages_Computation.UC5_MonthlyWages uc5 = new UC5_MonthlyWages();
                        uc5.CalculateWages();
                        break;
                    case 6:
                        day10_Emp_Wages_Computation.UC6_TotalWorkingHours uc6 = new UC6_TotalWorkingHours();
                        uc6.CalculateWageTill100HrsOr20IsReached();
                        break;
                    case 7:
                        UC7_RefactorTheCodeUsingClassMethod.ComputeEmpWage();
                        break;
                    case 8:
                        ComputeEmpWageClass computeEmpWageClass = new ComputeEmpWageClass();
                        computeEmpWageClass.computeEmpWage("Dmart", 20, 2, 10);
                        computeEmpWageClass.computeEmpWage("Reliance", 10, 4, 20);
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }
        }
    }
}
