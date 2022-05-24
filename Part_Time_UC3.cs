using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWage_UC3
    {
        public static void Wage()
        {
            for (int i = 1; i <= 10; i++)
            {
                Random random = new Random();
                int check = random.Next(3);
                if (check == 1)
                {
                    Console.WriteLine("Full Time wage for Day " + i + " is " + 20 * 8);
                }
                else if (check==2)
                {
                    Console.WriteLine("Part Time wage for Day " + i + " is " + 20 * 4);
                }
                else
                {
                    Console.WriteLine("Employee wage for Day " + i + " is " + 0);
                }

            }
        }
    }
}
