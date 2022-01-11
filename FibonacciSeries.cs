using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalProgramming
{
    public class FibonacciSeries
    {
       public void FibonacciNum()
        { 
            int num1=0,num2=1,num3=0;
            Console.WriteLine("Enter series count :- ");
            int count = Int32.Parse(Console.ReadLine());
            Console.WriteLine("----------------\n"+num1);
            Console.WriteLine(num2);       
            for(int i=0; i<count; i++)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                Console.WriteLine(num3);
            }

        }
    }
}
