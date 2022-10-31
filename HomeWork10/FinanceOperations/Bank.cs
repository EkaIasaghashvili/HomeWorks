using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10.FinanceOperations
{
    public class Bank : IFinanceOperations
    {
        const int Percent = 5;
        public bool CheckUserHistory()
        {
            var random = new Random();
            int randomNumber = random.Next(2);
            if (randomNumber == 0)
                return true;

            return false;
        }

        public double CalculateLoanPercent(int month, double amountPerMonth)
        {
            double maxAmount = amountPerMonth * month;
            bool userHistory = CheckUserHistory();

            double sumPercentAmount = maxAmount * Percent / 100 * month;
            if (userHistory)
                return sumPercentAmount;

            return 0;
        }
    }
}
