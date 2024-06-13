using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр_6._22
{
    internal class Customer
    {    
            public string Name { get; set; }
            public decimal Balance { get; set; }
        public string GetCustomerInfo()
        {
            return $"Имя: {Name}, Баланс: {Balance}";
        }
        
    }
}
