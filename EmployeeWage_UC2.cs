using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWage_UC2
    {
        public static void Wage()
        {
            for(int i = 1; i <= 10; i++)
            {
                Random random = new Random();
                int check = random.Next(2);
                if(check == 1)
                {
                    Console.WriteLine("Employee wage for Day " + i +" is "+ 20 * 8);
                }
                else
                {
                    Console.WriteLine("Employee wage for Day " + i + " is " + 0);
                }

            }
        }
    }
}
