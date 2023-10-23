using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0; 
        double sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (count < 20)
                {
                    int number = int.Parse(textBox1.Text);
                    listBox1.Items.Add(number.ToString());
                    textBox1.Clear();
                    sum += number;
                    count++;
                    double average = sum / count;
                    label1.Text = "میانگین : " + average.ToString();
                }
                else
                {
                    label1.Text = "تعداد مجاز قد وارد شده به 20 رسیده است.";
                }
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}
