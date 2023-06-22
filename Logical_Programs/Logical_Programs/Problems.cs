using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class Problems
    {
        public static void Problem_Program()
        {
            int num, sum =0 ;

            Console.WriteLine("Find the Number is Prime Number Or Not");
            
            num = Convert.ToInt32(Console.ReadLine());

            bool Prime_Number = Prime_Nmb(num);
            if (Prime_Number)
            {
                Console.WriteLine("The Number you provided is the Prime Number");
            }
            else
            {
                Console.WriteLine("The Number you provided is Not the Prime Number");
            }
        }
        public static bool Prime_Nmb(int num)
        {
            if (num < 1) 
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false ;
                }
            }   
            return true;
        }
    }
}
