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

            Console.WriteLine("Find the Number is Pefect Number Or Not");
            
            num = Convert.ToInt32(Console.ReadLine());

            bool Perfect_Number = Perfect_Nmb(num);
            if (Perfect_Number)
            {
                Console.WriteLine("The Number you provided is the Perfect Number");
            }
            else
            {
                Console.WriteLine("The Number you provided is Not the Perfect Number");
            }
        }
        public static bool Perfect_Nmb(int num)
        {
            int sum = 0 ;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i ;
                }
            }   
            return sum == num;
        }
    }
}
