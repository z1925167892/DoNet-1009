using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
        private void Button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            if (comboBox1.Text == "+")
            {
                label1.Text = client.PlusNumber(num1, num2).ToString();
            }
            else if (comboBox1.Text == "-")
            {
                label1.Text = client.JianName(num1, num2).ToString();
            }
            else if (comboBox1.Text == "*")
            {
                label1.Text = client.ChengNumber(num1, num2).ToString();
            }
            else if (comboBox1.Text == "/")
            {
                label1.Text = client.ChuNumber(num1, num2).ToString();  
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
