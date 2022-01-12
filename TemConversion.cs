using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalProgramming
{
    internal class TemConversion
    {
        public void Conversion()
        {
            Console.WriteLine("Enter temperature in ferenheit :- ");
            double ferenheit=Int32.Parse(Console.ReadLine());
            double tempInCelcius = ((ferenheit - 32) * 5 / 9);
            Console.WriteLine("Ferenheit Temperature " + ferenheit + " in celcius " + tempInCelcius);

            Console.WriteLine("Enter temperature in celcius :- ");
            double celcius = Int32.Parse(Console.ReadLine());
            double tempInFerenheit = ((celcius * 9) / 5 +32);
            Console.WriteLine(" Celcius Temperature " + celcius + " in Ferenheit " + tempInFerenheit);



        }
    }
}
