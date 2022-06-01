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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double b = Convert.ToInt32(textBox2.Text);
            for (double i = Convert.ToDouble(textBox1.Text); i <= b; i++)
            {
                sum += Math.Pow(i,2);
                listBox1.Items.Add($"{i} в квадрате = {Math.Pow(i,2)}");
            }
            listBox1.Items.Add($"Сумма квадратов чисел = {sum}");
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
