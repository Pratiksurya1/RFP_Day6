using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalProgramming
{
    internal class PrimeNum
    {
        public void primecheck()
        {
            Console.WriteLine("Enter number ;- ");
            int num = Int32.Parse(Console.ReadLine());
            bool flag= false;
            for (int i=2; i<num/2; i++)
            {
                if (num % i ==0)
                {
                    flag = true;
                }
            }
            if (flag != true)
                Console.WriteLine(num+" Prime number");
            else
                Console.WriteLine(num+" Not prime number");
        }
    }
}
