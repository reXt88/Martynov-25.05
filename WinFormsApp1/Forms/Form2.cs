using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int sum = 0;
            if (n != 0)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    listBox1.Items.Add(sum + " + " + i + " = " + (sum + i));
                    sum += + i;
                }
            }
            if (n == 0)
            {
                label1.Text = ("n не может быть равен 0");
            }
            if (n < 0)
            {
                label1.Text = ("n не может быть отрицательным");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
