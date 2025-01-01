using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace OddEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            PrintNumbers("Numbers" , numbers);
            PrintNumbers("even" , numbers.Where(x => IsEven(x)));
            PrintNumbers("odd", numbers.Where(x => IsOdd(x)));
            
            Console.WriteLine("Hello World!");
        }
        static void PrintNumbers(string title ,IEnumerable<int> num) 
        {
            Console.Write($"{title} [");
            foreach (var n in num)
            {
                Console.Write($" {n} ");
            }
            Console.Write($" ] ");
            Console.WriteLine();
        }
        static bool IsEven(int number)
        {
            if (number % 2== 0) 
            {
               return true;
            }
            else
            {
                return false;
            }
        }
        static bool IsOdd(int number)
        {
            if (number % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
