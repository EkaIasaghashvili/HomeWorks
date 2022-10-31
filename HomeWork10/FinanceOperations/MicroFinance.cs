using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10.FinanceOperations
{
    public class MicroFinance : IFinanceOperations
    {
        const int Percent = 10;
        const int Commission = 4;
        public bool CheckUserHistory()
        {
            return true;
        }
        public double CalculateLoanPercent(int month, double amountPerMonth)
        {
            double maxAmount = amountPerMonth * month + month * Commission;
            double sumAmountPrecent = maxAmount * Percent / 100 * month;
            double sumAmountTotal = sumAmountPrecent + maxAmount;
            return sumAmountTotal;
        }
    }
}
