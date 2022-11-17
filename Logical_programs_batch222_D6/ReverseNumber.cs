using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programs_batch222_D6
{
    internal class ReverseNumber
    {
        public void ReverseGenerate()
        {
            Console.WriteLine("Enter a No. to reverse");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;int remainder ;
            while(number>0)
            {
                remainder = number % 10;
                reverse = (reverse*10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reverse No. is {0}", +reverse);
        }
    }
}
