using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramTest
{
    public class EmployeeWageComputation
    {

        //Instance Variable
        public const int fullTime = 1;
        public const int partTime = 2;

        public string company;
        public string name;
        public int wagePerHours;
        public int dailyHours;
        public int dayPerMonth;
        public int totalHours;

        public EmployeeWageComputation(string company, string name, int wagePerHours, int dailyHours, int dayPerMonth, int totalHours)
        {
            this.company = company;
            this.name = name;
            this.wagePerHours = wagePerHours;
            this.totalHours = totalHours;
            this.dailyHours = dailyHours;
            this.dayPerMonth = dayPerMonth;
            this.totalHours = totalHours;
        }

        private int EmployMonthWage()
        {
            //Variable
            int dailyWage, totalWage = 0, dailyEmpHours = 0, hours = 0, day = 0;
            Random random = new Random();

            //Computation
            while (hours < totalHours && day < dayPerMonth)
            {
                int empCheck = random.Next(3);
                switch (empCheck)
                {
                    case fullTime:
                        dailyEmpHours = dailyHours;
                        break;
                    case partTime:
                        dailyEmpHours = dailyHours / 2;
                        break;
                    default:
                        dailyEmpHours = 0;
                        break;
                }
                hours += dailyEmpHours;
                day++;
                dailyWage = dailyEmpHours * wagePerHours;
                totalWage += dailyWage;
                Console.WriteLine("Day : " + day + "  Hours : " + hours + "  DailyWage : " + dailyWage + "  TotalWage : "
                        + totalWage);
            }
            Console.WriteLine("Employ Name " + name + " Got Total monthly wage of Rs : " + totalWage + "  and Total Hours : " + hours + "  Total Day is : " + day);
            Console.WriteLine();

            return totalWage;
        }

        public static void MEmpWageForMulComp()
        {
            Console.WriteLine("Calculating The Monthly Employ wage for multiple companies");
            Console.WriteLine();

            Console.Write("Enter The No. Of Records You Want To Enter Max is 4 : ");
            int records = int.Parse(Console.ReadLine());

            if (records <= 4)
            {
                for (int i = 1; i <= records; i++)
                {
                    Console.Write("Enter The Name Of The Company : ");
                    string company = Console.ReadLine();
                    Console.Write("Enter The Name Of The  Employ : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter The Total Daily Hour : ");
                    int dailyHours = int.Parse(Console.ReadLine());
                    Console.Write("Enter The Wage Per Hour : ");
                    int wagePerHours = int.Parse(Console.ReadLine());
                    Console.Write("Enter The Days in a Month : ");
                    int dayPerMonth = int.Parse(Console.ReadLine());
                    Console.Write("Enter The Total Hours Of That Month You Are Gonna Work : ");
                    int totalHours = int.Parse(Console.ReadLine());
                    if (i == 1)
                    {
                        EmployeeWageComputation companyOne = new EmployeeWageComputation(company, name, wagePerHours, dailyHours, dayPerMonth, totalHours);
                        Console.WriteLine("Employ Name " + name + " Got Total monthly Wage Of Rs : " + companyOne.EmployMonthWage() + " From Company Name " + companyOne.company);
                        Console.WriteLine();
                        Console.ReadLine();

                    }
                    if (i == 2)
                    {
                        EmployeeWageComputation companyTwo = new EmployeeWageComputation(company, name, wagePerHours, dailyHours, dayPerMonth, totalHours);
                        Console.WriteLine("Employ Name " + name + " Got Total monthly Wage Of Rs : " + companyTwo.EmployMonthWage() + " From Company Name " + companyTwo.company);
                        Console.ReadLine();

                    }
                    if (i == 3)
                    {
                        EmployeeWageComputation companyThree = new EmployeeWageComputation(company, name, wagePerHours, dailyHours, dayPerMonth, totalHours);
                        Console.WriteLine("Employ Name " + name + " Got Total monthly Wage Of Rs : " + companyThree.EmployMonthWage() + " From Company Name " + companyThree.company);
                        Console.ReadLine();

                    }
                    if (i == 4)
                    {
                        EmployeeWageComputation companyFour = new EmployeeWageComputation(company, name, wagePerHours, dailyHours, dayPerMonth, totalHours);
                        Console.WriteLine("Employ Name " + name + " Got Total monthly Wage Of Rs : " + companyFour.EmployMonthWage() + " From Company Name " + companyFour.company);
                        Console.ReadLine();

                    }
                }
            }
            else
            {
                Console.WriteLine("Entries Should be Less than or equal to 4 ");
                Console.ReadLine();
            }
        }
    }

}

