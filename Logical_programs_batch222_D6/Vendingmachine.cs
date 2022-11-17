using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programs_batch222_D6
{
    internal class VendingMachine
    {
        public void MinimumNotesCheck()
        {
            Console.WriteLine("Enter an Amount to get Minimum Notes and its Values:");
            int amount = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[8] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int remainder =amount;
            foreach (int note in array)
            {
                int i = 0;
                while (remainder >= note)
                {
                    remainder = remainder - note;
                    i++;
                }
                if (i > 0)
                {
                    Console.WriteLine("{0} X {1} = {2}", +note, +i, +(note * i));
                }
            }
             

        }

    }
}


