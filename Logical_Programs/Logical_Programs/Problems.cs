using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class Problems
    {
        public static void Problem_Program()
        {
            Console.WriteLine("Please Enter the Number of Distinct Coupon Numbers: ");

            int num = Convert.ToInt32(Console.ReadLine());

            int coupon_number = GetCouponNumber(num);

            Console.WriteLine("The Random Coupon Number is : "+  coupon_number);

        }
        public static int GetCouponNumber(int num)
        {
            Random random = new Random();

            HashSet<int> numbers = new HashSet<int>();
            
            int RandomNumbers = 0;
            
            while(numbers.Count < num)
            {
                int random_coupon = random.Next(1, num +1);
                RandomNumbers++;
                numbers.Add(random_coupon);
            }
            return RandomNumbers;
        }
        
    }
}
