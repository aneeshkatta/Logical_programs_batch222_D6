using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programs_batch222_D6
{
    internal class DayOftheWeek
    {
        public static void DayCheck()
        {
            Console.WriteLine("enter day");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter month");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter year");
            int y = Convert.ToInt32(Console.ReadLine());
            Getday(d, m, y);
        }
        public static void Getday(int d,int m,int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = ((d + x + 31 * m0) / 12) % 7;
            switch(d0)
            {
                case 0:
                    Console.WriteLine("sunday");
                    break;
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
            }

        }
    }
}
