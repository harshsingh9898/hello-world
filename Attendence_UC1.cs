using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Attendence_UC1
    {
        public static void attendence_check()
        {
            Random random = new Random();
            int check = random.Next(2);
            if(check == 1)
            {
                Console.WriteLine("Emloyee present");
            }
            else { Console.WriteLine("Employee absent");
            }
        }
    }
}
