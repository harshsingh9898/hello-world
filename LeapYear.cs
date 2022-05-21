using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Year
    {
        public static void Leap()
        {
            Console.WriteLine("Enter the year ");
            int year= Convert.ToInt32(Console.ReadLine());
            if (year % 100==0)
            {
                Console.WriteLine("Not a leap year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("It's a leap year");
            }
        }
    }
}
