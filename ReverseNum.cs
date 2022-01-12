using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalProgramming
{
    internal class ReverseNum
    { 
        public void checkNum()
        {
            int rev=0;   
            Console.WriteLine("Enter Number :- ");
            int num = Int32.Parse(Console.ReadLine());  
            while(num != 0)
            {
                int rem = num % 10;
                rev=rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine(" ReverseNum number is "+rev);

        }
    
    }
}
