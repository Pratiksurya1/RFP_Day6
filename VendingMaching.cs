using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalProgramming
{
    internal class VendingMaching
    {
        static int[] note = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
        public void vendingMachine()
        {
            int chenge,tem,i=0;
            Console.WriteLine("Enter chenge vlaue :- ");
            chenge=Int32.Parse(Console.ReadLine());

            while(chenge>0)
            {
                if(chenge>=note[i])
                {
                    int noteCount=chenge/note[i];
                    tem=chenge % note[i];
                    chenge = tem;
                    Console.WriteLine(note[i] + " Notes :: " + noteCount);
                }
                i++;
            }

        }
    }
}
