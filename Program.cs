using System;

namespace EmployeeSalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Salary Calculator!");
            Console.WriteLine("Choose employee type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");

            int employeeType = Convert.ToInt32(Console.ReadLine());

            switch (employeeType)
            {
                case 1:
                    Console.WriteLine("Enter working hour:");
                    int workingHourHR = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter number of working days:");
                    int workingDaysHR = Convert.ToInt32(Console.ReadLine());
                    CalculateSalary(workingHourHR, workingDaysHR);
                    break;
                case 2:
                    Console.WriteLine("Enter working hour:");
                    int workingHourAdmin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter number of working days:");
                    int workingDaysAdmin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter project handles:");
                    int projectHandlesAdmin = Convert.ToInt32(Console.ReadLine());
                    CalculateSalary(workingHourAdmin, workingDaysAdmin, projectHandlesAdmin);
                    break;
                case 3:
                    Console.WriteLine("Enter working hour:");
                    int workingHourDev = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter number of working days:");
                    int workingDaysDev = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter project handles:");
                    int projectHandlesDev = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter extras:");
                    int extrasDev = Convert.ToInt32(Console.ReadLine());
                    CalculateSalary(workingHourDev, workingDaysDev, projectHandlesDev, extrasDev);
                    break;
                default:
                    Console.WriteLine("Invalid employee type!");
                    break;
            }

            Console.ReadLine();
        }

        static void CalculateSalary(int workingHour, int workingDays, int projectHandles = 0, int extras = 0)
        {
            int baseSalary = workingHour * workingDays * 100;
            int projectBonus = projectHandles * 3000;
            int extrasBonus = extras * 2000;
            int totalSalary = baseSalary + projectBonus + extrasBonus;

            Console.WriteLine("Total Salary: $" + totalSalary);
        }
    }
}

