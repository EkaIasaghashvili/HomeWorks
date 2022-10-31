using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10.FinanceOperations
{
    public interface IFinanceOperations
    {
        double CalculateLoanPercent(int month, double amountPerMonth);
        bool CheckUserHistory();

    }
}
