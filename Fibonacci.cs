/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Fibonacci
    {// 5.	Define Fibonacci series - Write a program to print Fibonacci series 
        static void Main(string[] args)
        {
            int i, n, j, k;
            Console.Write("Enter a Number : ");
            n = Convert.ToInt32(Console.ReadLine());
            i = 0;
            j = 1;
            Console.Write($"{i} {j}");

            k = i + j;
            while (k <= n)
            {
                Console.Write($" {k}");

                i = j;
                j = k;
                k = i + j;

            }

        }
    }
}
*/