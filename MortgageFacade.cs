using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace пр_6._22
{
    internal class MortgageFacade
    {
        Bank bank  = new Bank();
        CreditHistory creditHistory = new CreditHistory();
        AccountBalance accountBalance = new AccountBalance();
        Customer customer = new Customer(); 
      
        public bool IsEligibleForMortgage(Customer customer, decimal loanAmount)
        {
            MessageBox.Show("Проверка клиента для выдачи ипотеки...");
            bool eligible = true;
            // Проверяем кредитную историю
            if (!creditHistory.HasGoodCreditHistory(customer.Name))
                eligible = false;
            // Проверяем баланс аккаунта
            else if (customer.Balance < loanAmount)
            {
                eligible = false;
                MessageBox.Show("Недостаточно средств на балансе для выдачи займа.");
            }
            return eligible;
        }
    }
}
