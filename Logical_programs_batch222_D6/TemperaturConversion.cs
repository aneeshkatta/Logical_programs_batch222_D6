using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programs_batch222_D6
{
    internal class TemperaturConversion
    {
        
        public static void TempCheck()
        {
            Console.WriteLine("Enter a program number \n 1.Celcius to Fahrenheit \n 2.Fahrenheit to Celcius");
            int num= Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("Enter Celcius :");
                double celcius = Convert.ToDouble(Console.ReadLine());
                TemperaturConversion.ToFahrenheit(celcius);
            }
            else
            {
                Console.WriteLine("Enter Fahrenheit :");
                double Fahrenheit = Convert.ToDouble(Console.ReadLine());
                TemperaturConversion.ToCelcius(Fahrenheit);
            }
        }
        public static void ToFahrenheit(double celcius)
        {
            Console.WriteLine("------------ Celcius to Fahrenheit -------------");
            //(°C × 9/5) + 32 = °F
            double Fahrenheit =  (celcius * 9 / 5) + 32 ;
            Console.WriteLine("Fahrenheit:{0}",Fahrenheit);
        }
        public static void ToCelcius(double Fahrenheit)
        {
            Console.WriteLine("------------ Fahrenheit to Celcius -------------");
            // (°F − 32) x 5 / 9 = °C
            double celcius = ((Fahrenheit - 32) * 5 )/ 9;
            Console.WriteLine("Celcius:{0}", celcius);
        }
    }
}
