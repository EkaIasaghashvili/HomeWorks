using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public static class HomeWork8Func
    {
        #region Task1
        public static int ReturnResult(int minNumber, int maxNumber, int degree)
        {
            int result = 0;
            for (int i = 2; i < maxNumber; i++)
            {
                if (Math.Pow(i, degree) >= minNumber && Math.Pow(i, degree) <= maxNumber)
                {
                    result++;
                }
            }
            return result;
        }

        #endregion
        #region Task2
        public static int ReturnCount(char[] charArray)
        {
            int count = 0;
            for (int i = 0; i < charArray.Length - 1; i++)
            {
                if (charArray[i] == charArray[i + 1])
                {
                    count++;
                    i++;
                }
            }
            return count;
        }

        #endregion
        #region Task3
        public static string ReturnSameEnd(string stringOne, string stringTwo)
        {
            for (int i = 0; i < stringOne.Length; i++)
            {
                string end = stringOne.Substring(i);
                if (stringTwo.EndsWith(end))
                {
                    return end;
                }
            }
            return "";
        }
        #endregion
        #region Task4
        public static void List<T>(List<T> input)
        {
            var type = typeof(T);
            var typeName = type.Name;
            int sum = 0;
            
            switch (typeName)
            {
                case "String":
                    foreach (var item in input)
                    {
                        var str = item.ToString();
                        
                        
                        Console.WriteLine(str.ToUpper());
                    }
                        break;

                case "Int32":
                    foreach (var item in input)
                    {
                        int i = Convert.ToInt32(item);
                        
                        sum += i;

                    }
                    Console.WriteLine(sum);
                    break;

                case "Boolean":
                    bool firstElement = Convert.ToBoolean(input[0]);
                    bool lastElement= Convert.ToBoolean(input[input.Count - 1]);
                    bool middleElemnet = Convert.ToBoolean(input[input.Count / 2 + 1]);
                    Console.WriteLine($"first element is: {firstElement}");
                    Console.WriteLine($"last element is: {lastElement}");
                    Console.WriteLine($"middle element is: {middleElemnet}");
                   
                    break;
                default:
                    break;
            }

        }
        #endregion
        #region Task5
        public static void SeparateDigits(int num)
        {
            if (num < 10)
            {
                Console.Write($" {num} ");
                return;
            }
            SeparateDigits(num / 10);
            Console.Write(" {0} ", num % 10);
        }
        #endregion

       
    }
    
  

    
}

