using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Buffers;
using System.Buffers.Text;
using System.Diagnostics;
using Newtonsoft.Json;

namespace HomeWork11
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //var path = @"C:\Users\user\source\repos\HomeWorks\HomeWork11\userInput.txt";
            //Console.WriteLine("Enter the number of lines :");
            //int numberOfLines = Convert.ToInt32(Console.ReadLine());
            //File.WriteAllText(path, string.Empty);
            //for (int i = 0; i < numberOfLines; i++)
            //{
            //    Console.WriteLine("Enter Text: ");
            //    var input = Console.ReadLine();
            //    File.AppendAllText(path, input + Environment.NewLine);
            //}
            //string text = File.ReadLines(path).Last();
            //Console.WriteLine();
            //Console.WriteLine($"Output: {text}");
            #endregion

            #region Task2
            //var path = @"C:\Users\user\source\repos\HomeWorks\HomeWork11\userInput2.txt";
            //Console.WriteLine("Enter the number :");
            //int numberOfLines = Convert.ToInt32(Console.ReadLine());
            //File.WriteAllText(path, string.Empty);
            //string text = string.Empty;
            //int p = 1;
            //for (int j = 1; j <= numberOfLines; j++)
            //{
            //    for (int k = 1; k <= 9; k++)
            //    {
            //        if (j == numberOfLines)
            //            p = 0;

            //        text = $"{j} * {k} = {j * k} | {j + p} * {k} = {(j + p) * k}";
            //        File.AppendAllText(path, text + Environment.NewLine);
            //    }
            //}
            #endregion
            #region Task3

            //Console.WriteLine("Enter the string :");
            //string input = Console.ReadLine();
            //var first = input.Substring(0, input.Length / 2);
            //var last = input.Substring(input.Length / 2, input.Length / 2 + 1);
            //var path = @"C:\Users\user\source\repos\HomeWorks\HomeWork11\userInput3.XML";

            //var element1 = new XElement(first, "string 1");
            //var element2 = new XElement(last, "string 2");
            //var doc = new XDocument(new XElement("root", element1, element2));

            //doc.Save(path);
            #endregion
            #region Task4
            //var reader = new StreamReader(@"C:\Users\user\source\repos\HomeWorks\HomeWork11\MyJson.json");
            //string jsonString = reader.ReadToEnd();

            //var model = JsonConvert.DeserializeObject<MyModel>(jsonString);
            //var date = (model.BirthDay - model.CurrentDate).TotalDays;

            //Console.WriteLine(date);
            #endregion

            #region Task5
            var reader = new StreamReader(@"C:\Users\user\source\repos\HomeWorks\HomeWork11\Chiper.json");
            string jsonString = reader.ReadToEnd();
            var model = JsonConvert.DeserializeObject<MyModel>(jsonString);
            string cipherText = Encipher(model.Word,model.key);
            Console.WriteLine($"chiper is: {cipherText}");
            Console.Write("\n");

            Console.ReadKey();
        }
        public static char cipher(char character, int key)
        {
            if (!char.IsLetter(character))
            {

                return character;
            }

            char chiper = char.IsUpper(character) ? 'A' : 'a';
            return (char)((((character + key) - chiper) % 26) + chiper);

        }

        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char character in input)
                output += cipher(character, key);

            return output;
        }
        #endregion

        #region Task4,Tak5
        public class MyModel
        {
            public DateTime CurrentDate { get; set; }
            public DateTime BirthDay { get; set; }
            public string Word { get; set; }
            public int key { get; set; }
        }
        #endregion
        
    }
}
