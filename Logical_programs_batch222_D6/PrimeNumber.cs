using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programs_batch222_D6
{
    internal class PrimeNumber
    {
        public void PrimeCheck()
        {
            Console.WriteLine("Enter a number to check its a prime number or not!");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0 && num!=0 && num!=1)
                {
                    a++;
                }
            }
            if(a==1)
            {
                Console.WriteLine("{0} is Prime Number", num);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number", num);
            }

        }
    }
}
