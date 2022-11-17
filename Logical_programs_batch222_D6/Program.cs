using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_programs_batch222_D6
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("\n Enter a Program number: \n 1.Fibonacci Series  \n 2.Perfect Number \n 3.Prime Number \n 4.Reverse a number \n 5.Coupon Numbers \n 6.Simulate Stopwatch Program \n 7.Find the Fewest Notes to be returned for Vending Machine \n 8.DayOfWeek \n 9.temperaturConversion \n 10.monthlyPayment \n 11.square root of a nonnegative number using Newton's method \n 12.Decimal number to Binary conversion \n 13.Binary swab");
            int input = Convert.ToInt32(Console.ReadLine());
            switch(input)
            {
                case 1:
                    FibonacciSeries Obj1 = new FibonacciSeries();
                    Obj1.FibonacciCheck();
                    break;
                case 2:
                    PerfectNumber Obj2 = new PerfectNumber();
                    Obj2.PerfectCheck();
                    break;
                case 3:
                    PrimeNumber Obj3 = new PrimeNumber();
                    Obj3.PrimeCheck();
                    break;
                case 4:
                    ReverseNumber Obj4 = new ReverseNumber();
                    Obj4.ReverseGenerate();
                    break;
                case 5:
                    CouponNumbers.CouponGenerate();//calling by static method
                    break;
                case 6:
                    StopwatchSimulate Obj6 = new StopwatchSimulate();
                    Obj6.StopwatchMethod();
                    break;
                case 7:
                    VendingMachine Obj7 = new VendingMachine();
                    Obj7.MinimumNotesCheck();
                    break;
                case 8:
                    DayOftheWeek.DayCheck();
                    break;
                case 9:
                    TemperaturConversion.TempCheck();
                    break;
                case 10:
                    MonthlyPayment Obj10 = new MonthlyPayment();
                    Obj10.MonthlyPayCheck();
                    break;
                case 11:
                    SquareRoot Obj11 = new SquareRoot();
                    Obj11.SquareRootValueCheck();
                    break;
                case 12:
                    ToBinary Obj12 = new ToBinary();
                    Obj12.ConvertToBinary();
                    break;
                case 13:
                    BinarySwab Obj13 = new BinarySwab();
                    Obj13.SwabAndTwoPowerValue();
                    break;
                default:
                    Console.WriteLine("Enter program number between 1-13 only");
                    break;
            }
        }
    }
}