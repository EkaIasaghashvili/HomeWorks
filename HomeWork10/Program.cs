using HomeWork10.AbstractFileWorker;
using HomeWork10.FinanceOperations;
using System;
using System.Collections.Generic;

namespace HomeWork10
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            var fileWorker = new FileWorker();
            fileWorker.FileExpansion = "txt";
            fileWorker.FileMaxSize = 128;

            fileWorker.Print();
            #endregion
            #region Task2
            var bank = new Bank();
            double bankReturn = bank.CalculateLoanPercent(5, 200);

            var microFinance = new MicroFinance();
            double microFinanceReturn = microFinance.CalculateLoanPercent(7, 300);

            Console.WriteLine($"Bank Return is {bankReturn}");
            Console.WriteLine($"MicroFinance Return is {microFinanceReturn}");
            #endregion
        }
    }
}
