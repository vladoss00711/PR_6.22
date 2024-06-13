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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 newF = new Form3();
            newF.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 newF = new Form3();
            newF.Show();
            this.Hide();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Оформляем?");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Оформляем?");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5 newF = new Form5();
            newF.Show();
            this.Hide();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(pictureBox3, "СВОБОДААА");
        }
    }
}
