using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр_6._22
{
    internal class AccountBalance
    {
    public decimal balance { get; private set; }
    private bool isBalanceGenerated = false;

    public void GenerateBalance()
    {
        if (!isBalanceGenerated)
        {
            Random rand = new Random();
            balance = rand.Next(0,800000);
            isBalanceGenerated = true;
        }
    }
        public decimal GetBalance()
        {
            return balance;
        }
    }
}
