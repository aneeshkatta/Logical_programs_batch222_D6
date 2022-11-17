using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Function to return the square root of a number using Newtons method
// root = 0.5 * (X + (N / X)) where X is any guess which can be assumed to be N or 1.
//Tolerance limit is the maximum difference between X and root allowed.
namespace Logical_programs_batch222_D6
{
    internal class SquareRoot
    {
         public static void SquareRootValueCheck()
         { 
            double n = 111;
            double l = 0.00001;
            Console.WriteLine("{0}", squareRoot(n, l));
         }
         static double squareRoot(double n, double l)
         {
            double x = n;//assume x=n
            double root;// guess will be stored in the root
           int count = 0;//intialize iteration
            while (true)
            {
                count++;//update iteration
                root = 0.5 * (x + (n / x)); // Calculate more closed x
                if (Math.Abs(root - x) < l)// Check for closeness -tolerance limit
                break;// Update squreroot value
                x = root;//assign root value to x
            }
            return root;
         }
    }
    
}
