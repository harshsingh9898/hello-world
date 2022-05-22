using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class TwoPow
    {
        public static void pow()
        {

            Console.WriteLine("Enter Powers to be printed");
            int i = Convert.ToInt32(Console.ReadLine());
            if (31> i && i >= 0)
            {
                for (int j = 0; j < i; j++)
                {
                    double two = Math.Pow(2, j);
                    Console.WriteLine(two);
                }
            }
        }
    }
}