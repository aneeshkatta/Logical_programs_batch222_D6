using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programs_batch222_D6
{
    internal class CouponNumbers
    {
        public static void CouponGenerate()
        {
            Console.WriteLine("--------------Coupon Numbers-------------");
            Console.WriteLine("Enter a three digit number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[number];
            int count = 0;
            for (int i = 0; i < number; i++)
            {
                bool same = false;
                Random random = new Random();
                int randomNum = random.Next(100, 999);
                foreach (int data in Array)
                {
                    if (data == randomNum)
                    {
                        same = true;

                    }
                    break;
                }
                if (same == true && i > 0)
                {
                    i--;
                }
                else
                {
                    Array[i] = randomNum;
                }
                count++;
            }
            Console.WriteLine($"total number of iterations: {count}");
            Console.WriteLine(String.Join(" ",Array));
        }
    }
}
