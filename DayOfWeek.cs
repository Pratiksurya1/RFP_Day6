using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day6LogicalProgramming
{
    internal class DayOfWeek
    {
        public void checkDayOfWeek()
        {
            int day, month, year,y,x,m,d;
            Console.WriteLine("Enter date Date : ");
            day = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter date Month : ");
            month = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter date Year : ");
            year = Int32.Parse(Console.ReadLine());

            y = year - (14 - month) / 12;
            x = y + (y / 4) - (y / 100) + (y / 400);
            m = month + 12 * ((14 - month) / 12) - 2;
            d = (day + x + 31 * m / 12) % 7;

            switch (d)
            {
                case 0:
                    Console.WriteLine("Day is sunday");
                    break;
                case 1:
                    Console.WriteLine("Day is monday");
                    break;
                case 2:
                    Console.WriteLine("Day is tuesday");
                    break;
                case 3:
                    Console.WriteLine("Day is wednesday");
                    break;
                case 4:
                    Console.WriteLine("Day is thursday");
                    break;
                case 5:
                    Console.WriteLine("Day is friday");
                    break;
                case 6:
                    Console.WriteLine("Day is saturday");
                    break;
            }
        }
    }
}
