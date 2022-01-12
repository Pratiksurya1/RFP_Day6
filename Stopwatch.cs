using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Day6LogicalProgramming
{
    public class whatch
    {
        String s;
        public void m1()
        {
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine("when you want start type start");
            s = Console.ReadLine();

            if (String.Equals(s, "start"))
                sw.Start();

            Console.WriteLine("when you want stop type stop");
            s = Console.ReadLine();
            if (String.Equals(s, "stop"))
            {

                sw.Stop();
                Console.WriteLine("Time elapsed " + sw.Elapsed);
            }
        }
        
    }
}
