using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пр_6._22
{
    internal class Bank
    {
        public void ApproveMortgage(Customer customer, decimal loanAmount)
        {
            if (customer.Balance >= loanAmount)
                // Одобрение ипотеки
                MessageBox.Show($"Ипотека для клиента {customer.Name} на сумму {loanAmount} одобрена.", "Ипотека одобрена");
            else
                // Отказ в выдаче ипотеки из-за недостаточного баланса
                MessageBox.Show($"К сожалению, ипотека для клиента {customer.Name} на сумму {loanAmount} не может быть одобрена из-за недостаточного баланса.", "Отказ в выдаче ипотеки");
        }
    }
}
