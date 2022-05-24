using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWage_UC5
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;

        public static void Wage()
        {
            int empHRS = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for(int i = 0; i < NUM_OF_WORKING_DAYS; i++)
            {
                Random random = new Random();
                int empCheck = random.Next(3);

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHRS=8;
                        break;
                    case IS_PART_TIME:
                        empHRS = 4;
                        break;
                    default:
                        empHRS = 0;
                        break;

                }
                
                empWage = empHRS * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;

                Console.WriteLine("Emp Wage : " + empWage);
            }
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
        }

    }
}
