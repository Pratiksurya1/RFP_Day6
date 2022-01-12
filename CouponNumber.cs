using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalProgramming
{
    internal class CouponNumber
    {
        public void GenerateCouponCode()
        {
            Random random = new Random();
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToArray();
            int randomNum =random.Next(0,100000000);

            StringBuilder stringBuilder = new StringBuilder();

            while(randomNum>0)
            {
                stringBuilder.Append(chars[randomNum% chars.Length]);
                randomNum/=chars.Length;
            }
            String code=stringBuilder.ToString();
            Console.WriteLine("Coupon code is "+code);
        }
    }
}
