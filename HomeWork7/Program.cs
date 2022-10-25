using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;

namespace HomeWork7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Console.WriteLine("Enter the radius of the circle: ");
            //double radius = Convert.ToInt32(Console.ReadLine());
            //double diameter = radius + radius;
            //double bigSquareSide = diameter;
            //double bigSquareArea = Math.Pow(bigSquareSide, 2);
            //double smallSquareDiagonal = diameter;
            //double smallSquareSide = smallSquareDiagonal / Math.Sqrt(2);
            //double smallSquareArea = Math.Pow(smallSquareSide, 2);
            //double result = Math.Round(bigSquareArea - smallSquareArea);

            //Console.WriteLine($"The result BigSquareArea subtracted SmallSquareArea is {result}");

            #endregion
            #region Task2
            //Console.WriteLine("Enter array of strings");
            //string input = Console.ReadLine();
            //char[] charArray = input.ToCharArray();

            //var query = charArray.Distinct().ToList();
            //if (query.Count == 1)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("NO");

            #endregion
            #region Task3
            //Console.WriteLine("Enter the number of win: ");
            //int userInputWin = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter tne number of draw: ");
            //int userInputDraw = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter tne number of lose game: ");
            //int userInpuLose = Convert.ToInt32(Console.ReadLine());
            //int win = 3;
            //int draw = 1;
            //int lose = 0;
            //int winGame = userInputWin * win;
            //int drawGame = userInputDraw * draw;
            //int loseGame = userInpuLose * lose;
            //int result = winGame + drawGame + loseGame;
            //Console.WriteLine($"accumulated points are {result}");
            #endregion
            #region Task4

            //var weekDays = new Dictionary<WeekDays, int>
            //{
            //    { WeekDays.Monday, 0 },
            //    { WeekDays.Tuesday, 0 },
            //    { WeekDays.Wednesday, 0 },
            //    { WeekDays.Thursday, 0 },
            //    { WeekDays.Friday, 0 },
            //    { WeekDays.Saturday, 0 },
            //    { WeekDays.Sunday, 0 }
            //};

            //int compensationWorkedDays = 10;
            //int compensationOverTime = compensationWorkedDays + 5;
            //int compensationWeekendDays = 20;
            //int sum = 0;

            //foreach (var item in weekDays)
            //{
            //    Console.Write($"Enter the worked hours for {item.Key} : ");
            //    weekDays[item.Key] = Convert.ToInt32(Console.ReadLine());
            //}

            //foreach (var item in weekDays)
            //{
            //    if (item.Key <= WeekDays.Friday)
            //    {
            //        if (weekDays[item.Key] <= 8)
            //            sum += weekDays[item.Key] * compensationWorkedDays;
            //        else
            //            sum += weekDays[item.Key] * compensationOverTime;
            //    }
            //    else
            //        sum += weekDays[item.Key] * compensationWeekendDays;
            //}
            //Console.WriteLine($"Salary is {sum}");
            #endregion
            #region Task5
            //Console.WriteLine("Enter the array of integers");
            //var numbers = Console.ReadLine().Split(',');

            //int sum = 0;
            //for (int i = 0; i < numbers.Length-1; i++)
            //{
            //    if (Convert.ToInt32(numbers[i]) < Convert.ToInt32(numbers[i+1]))
            //    {
            //        sum++;
            //    }
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Task6
            //Console.WriteLine("Enter the array of string: ");
            //var stringArray = Console.ReadLine().Split(',');
            //var list =new List<string>(stringArray);
            //Console.WriteLine("Enter the number of words: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //var listString = list.Where(x => x.Length == number).ToList();
            //foreach (var item in listString)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
        }

    }
}
