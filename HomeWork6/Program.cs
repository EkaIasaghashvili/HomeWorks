using System;

namespace HomeWork6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Console.Write("Enter array size: ");
            //int sizeOfArray = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[sizeOfArray];
            //int[] evenNumbes = new int[sizeOfArray];
            //int[] oddNumbers = new int[sizeOfArray];
            //int j = 0; int k = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Enter number for index {i} : ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        evenNumbes[j] = numbers[i];
            //        j++;
            //    }
            //    else
            //    {
            //        oddNumbers[k] = numbers[i];
            //        k++;
            //    }
            //}
            //Console.WriteLine($"Even numbers Array from array UserInput : ");
            //for (int i = 0; i < j; i++)
            //{
            //    Console.WriteLine(evenNumbes[i]);
            //}
            //Console.WriteLine($"Odd numbers Array from array UserInput: ");
            //for (int i = 0; i < k; i++)
            //{
            //    Console.WriteLine(oddNumbers[i]);
            //}
            #endregion

            #region Task2
            //Console.Write("Enter array size: ");
            //int sizeOfArray = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[sizeOfArray];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Enter number for index {i} : ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //var query = numbers
            //           .GroupBy(x => x)
            //           .Select(y => new { Element = y.Key, Count = y.Count(), Sum = y.Sum() })
            //           .ToList();

            //foreach (var item in query)
            //{
            //    Console.WriteLine($" {item.Element} appears {item.Count} times , sum is {item.Sum}");
            //}

            #endregion

            #region Task3
            //Console.Write("Enter array size: ");
            //int sizeOfArray = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[sizeOfArray];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Enter number for index {i} : ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("How many participant result do you want?");
            //int userInput = Convert.ToInt32(Console.ReadLine());

            //var top = numbers.OrderByDescending(a => a).Take(userInput); 

            //foreach (var data in top)
            //{
            //    Console.WriteLine($"Top three data is :  {data}");
            //}
            #endregion
        }
    }
}
