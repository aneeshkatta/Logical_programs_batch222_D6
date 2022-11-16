using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programs_batch222_D6
{
    internal class FibonacciSeries
    {
        public void FibonacciCheck()
        {
            Console.WriteLine("Enter a number A to get Fibannoci series");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number B to get Fibannoci series");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a length of  Fibannoci series");
            int Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", A);
            Console.WriteLine("{0}", B);
            for (int i=1;i<= Length-2; i++)
            {
                int C = A + B;
                Console.WriteLine("{0}", C);
                A = B;
                B = C;            
            }

        }
    }
}
