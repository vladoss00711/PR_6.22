using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пр_6._22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Войти?");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(pictureBox2, "Уйти?");
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(pictureBox3, "Уйти?");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
