using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalProgramming
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            //FibonacciSeries f = new FibonacciSeries();
            //f.FibonacciNum();

            //PerfectNumber perfectNumber = new PerfectNumber();
            //perfectNumber.checkNum();

            //PrimeNum num = new PrimeNum();  
            //num.primecheck();

            //ReverseNum reverseNum = new ReverseNum();
            //reverseNum.checkNum();

            //whatch whatch = new whatch();
            //whatch.m1();

            //VendingMaching vendingMaching = new VendingMaching();
            //vendingMaching.vendingMachine();

            //DayOfWeek dayOfWeek = new DayOfWeek();
            //dayOfWeek.checkDayOfWeek();

            //TemConversion temConversion = new TemConversion();
            //temConversion.Conversion();

            //MonthlyPayment payment = new MonthlyPayment();
            //payment.monthlyPayment();

            CouponNumber couponNumber = new CouponNumber();
            couponNumber.GenerateCouponCode();
        }
    }
}
