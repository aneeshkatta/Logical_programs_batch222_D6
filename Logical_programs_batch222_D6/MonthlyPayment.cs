using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programs_batch222_D6
{
    internal class MonthlyPayment
    {
        public static void MonthlyPayCheck()
        {
            Console.WriteLine(" Enter  principal balance (P):"); 
            double Principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Enter  Number of years (Y) of interest calculation:");
            double year = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Enter  Rate of interest (R):");
            double rateInterestPerMonth = Convert.ToDouble(Console.ReadLine());
            double r =(rateInterestPerMonth / (12 * 100));
            double n = (12 * year);
            double payment = (Principal * r) / (1 - Math.Pow((1 + r), (-n)));
            Console.WriteLine("Payment: {0}", payment);
        }
    }
}
