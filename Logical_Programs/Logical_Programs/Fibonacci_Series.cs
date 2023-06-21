using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class Fibonacci_Series
    {
        public static void Fibonacciseriesproblem()
        {
            int n, first = 0, second = 1, next;

            Console.WriteLine("Please write the number that you wanted the Fibonacci Series : ");

            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Fibonacci Series for " + n + " numbers is : ");

            for (int i = 0; i < n; i++)
            {
                if (i < 1)
                {
                    next = i;
                }
                else
                {
                    next = first + second;

                    first = second;
                    
                    second = next;
                }
                Console.Write(next + " ");
            }
        }
    }
}
