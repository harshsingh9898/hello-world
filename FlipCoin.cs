using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class FlipCoin
    {public static void flip()
        {
            int head=0;
            int tail=0;
            Console.WriteLine("Enter the no. of flips");
            int flips=Convert.ToInt32(Console.ReadLine());
            if (flips > 0)
            {
                for (int i = 1; i <= flips; i++)
                {
                   Random virtran = new Random();
                    int random = virtran.Next(2);

                    if(random == 0)
                    {
                        head++;
                    }
                    else
                    {
                        tail++;
                    }
                }
            }
            else { Console.WriteLine("Enter a positive number"); }
            Console.WriteLine("Percentage of heads= " + (head * 100 / flips));
            Console.WriteLine("Percentage of tails= " + (tail * 100 / flips));
        }
    }
}
