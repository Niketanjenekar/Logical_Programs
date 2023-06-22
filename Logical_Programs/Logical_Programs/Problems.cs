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
            int num, reverse = 0, remainder;
            
            Console.WriteLine("Please Enter the Number whch you want to reverse : ");

            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                remainder = num % 10;

                reverse = reverse * 10 + remainder;

                num = num / 10;

            }
            Console.WriteLine("Reversed Number : " + reverse + " ");
        }
        
        
    }
}
