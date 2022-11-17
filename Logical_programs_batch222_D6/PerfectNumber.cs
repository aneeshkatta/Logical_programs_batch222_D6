using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programs_batch222_D6
{
    internal class PerfectNumber
    {
        public  void PerfectCheck()
        {
            Console.WriteLine("Enter a number to check its a perfect number or not!");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i =1;i<num;i++)
            {
                if(num%i==0)
                {
                    sum = sum + i;
                }
            }
            if(sum==num)
            {
                Console.WriteLine("{0} is Perfect Number", num);
            }
            else
            {
                Console.WriteLine("{0} is not a Perfect Number", num);
            }
        }
    }
}
