using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр_6._22
{
    internal class CreditHistory
    {
        public bool HasGoodCreditHistory(string Name)
        {          
            Random random = new Random();
            return random.Next(2) == 0; 
        }
    }
}
