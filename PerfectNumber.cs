using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalProgramming
{
    public class PerfectNumber
    {
        long sum = 0;
        public void checkNum()
        {
            Console.WriteLine("Enter Number to check perfect number or not...");
            long num=Int32.Parse(Console.ReadLine());
            Console.WriteLine("-------------");
            int i = 1;
            while(i<=num/2)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }

                    i++;
            }
            if (sum == num)
            {
                Console.WriteLine(num+" number is perfect number..");
            }
            else
            {
                Console.WriteLine(num+" number is not perfect number..");
            }
        }
    }
}
