using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Harmonic
    {
        public static void Har() {
            double term = 1;
            Console.WriteLine("Enter the number for nth harmonic");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                for(int i = 2; i <= num; i++)
    {
                    term += (float)1 / i;
                }
            }
            else { Console.WriteLine("Enter a positive number");
            }
            Console.WriteLine(term);
        }

    }
}
