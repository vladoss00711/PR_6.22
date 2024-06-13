using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace пр_6._22
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelLoanAmount.Text = "Сумма Вашего займа =  " + trackBar1.Value.ToString();
            if (trackBar1.Value > 800000)
            {
                MessageBox.Show("Простите, у нас нет таких денег!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                trackBar1.Value = 800000;
            }
        }
        public void MainForm()
        {
            InitializeComponent();
            trackBar1.Scroll += trackBar1_Scroll;
        }
        private void labelLoanAmount_Click(object sender, EventArgs e)
        {

        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            AccountBalance accountBalance = new AccountBalance();
            Bank bank = new Bank();
            MortgageFacade mortgageFacade = new MortgageFacade();
            string name = Prompt.ShowDialog("Введите Ваше имя: ", "Имя клиента");

            if (!string.IsNullOrEmpty(name))
            {
                decimal balance = accountBalance.balance;

                Customer customer = new Customer() { Name = name, Balance = balance };

                if (mortgageFacade.IsEligibleForMortgage(customer, trackBar1.Value))
                {
                    bank.ApproveMortgage(customer, trackBar1.Value);
                    MessageBox.Show("Ипотека успешно выдана!", "Ура", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Клиент не прошел проверку на выдачу ипотеки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                trackBar1.Enabled = false;
            }
            else
                MessageBox.Show("Не оставляйте поле `Имя` пустым!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Form5 newF = new Form5();
            newF.Show();
            this.Hide();
        }
        private AccountBalance account = new AccountBalance();
        private void button1_Click(object sender, EventArgs e) // баланс
        {      
        account.GenerateBalance();
            decimal balance = account.GetBalance();
            MessageBox.Show("Ваш текущий баланс: " + balance.ToString("C"), "Баланс аккаунта",
            MessageBoxButtons.OK, MessageBoxIcon.Information);          
        }
        private void checkCreditButton_Click(object sender, EventArgs e)
        {
            CreditHistory creditHistory = new CreditHistory();
            bool hasGoodCreditHistory = creditHistory.HasGoodCreditHistory("");

            if (hasGoodCreditHistory)
            {
                MessageBox.Show("У вас хорошая кредитная история!", "Результат проверки",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("У вас плохая кредитная история!", "Результат проверки",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            prompt.Width = 370;
            prompt.Height = 170;
            prompt.Text = caption;
            prompt.MaximizeBox = false;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;

            Label textLabel = new Label() { Left = 70, Top = 20, Width = 170,Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 270 };
            Button confirmation = new Button() { Text = "ОК", Left = 150, Width = 100, Top = 90 };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.ShowDialog();

            return textBox.Text;
        }
    }


