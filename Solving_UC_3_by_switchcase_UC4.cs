using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Solving_UC_3_by_switchcase_UC4
    {
        public static void _switch_()
        {
            for (int i = 1; i <= 10; i++) {
                Random random = new Random();
                int check = random.Next(3);

                switch (check)
                {
                    case 1:
                        Console.WriteLine("Full Time wage for Day " + i + " is " + 20 * 8);
                        break;
                    case 2:
                        Console.WriteLine("Part Time wage for Day " + i + " is " + 20 * 4);
                        break;
                    default:
                        Console.WriteLine("Employee wage for Day " + i + " is " + 0);
                        break;
                }
            } 
        }
    }
}
