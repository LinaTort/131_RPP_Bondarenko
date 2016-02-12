using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131_RPP_Bondarenko
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Please enter x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter y");
            y = Convert.ToInt32(Console.ReadLine());
            int z = x + y;
            Console.WriteLine("the value of z = {0}", z);

            if (z > 0)
            {
                Console.WriteLine("is positive");
            }
            if (z < 0)
            {
                Console.WriteLine("is negative");
            }
            if (z % 2 == 0)
            {
                Console.WriteLine("is an even number");
            }
            else
            {
                Console.WriteLine("is not an even number");
            }
            for (int i = 5; i <= 20; i *= 2)
            {
                if (z % i == 0)
                {
                    Console.WriteLine("number is divisible by {0}", i);
                }
                else
                {
                    Console.WriteLine("the number is not divisible by {0}", i
                        );
                }
            }
            takeAway:
            Console.WriteLine("z-1={0}", z--);//!
            if (z > 0)
            {
                goto takeAway;//с постусловием
            }//??
            int j = z;//?
            do //!?+? постусловие
            {
                Console.WriteLine(j--);
            }
            while (z > 0);

            //предусловие

            takeAway1:
            if (z > 0)
            {
                Console.WriteLine("z-1={0}", z--);
                goto takeAway1;

            }
            while (z > 0)
            {
                Console.WriteLine("value z={0}", z--);

            }
            
            
            for (int i = z; i > 0; i--)
            {
                Console.WriteLine("value z={0}", i);
            }
            Console.ReadKey();

        }
    }
}
