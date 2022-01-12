using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalProgramming
{
    internal class MonthlyPayment
    {
        public void monthlyPayment()
        {
            Console.WriteLine("Enter principal loan amount :- ");
            double principalAmount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter year :- ");
            double year=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter interst rate :- ");
            double rateInterest = Int32.Parse(Console.ReadLine());

            year = 12 * year;
            rateInterest = rateInterest / (12 * 100);

            double emi = (principalAmount * rateInterest*Math.Pow(1 + rateInterest,year)) / (Math.Pow(1 + rateInterest, year)-1);
            Console.WriteLine("Amount to pay " + emi + " for per year " + year);
        }
    }
}
