using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class PrimeFactors
    { public static void Prime()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            for(i=2;i>1;i++) { 
            while (num % i == 0)
            {
                Console.WriteLine(i);
                num = num / i;
            }
            }
        }
    }
}
