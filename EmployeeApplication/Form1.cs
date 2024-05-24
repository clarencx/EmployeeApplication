using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PartTimeEmployee m = new PartTimeEmployee(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

            double rateperHour = Convert.ToDouble(textBox5.Text);
            int totalhoursWorked = Convert.ToInt32(textBox6.Text);

            m.computeSalary(totalhoursWorked ,rateperHour);
     

            label9.Text = textBox1.Text;
            label10.Text = textBox2.Text;
            label12.Text = Convert.ToString(m.getSalary());



            

            
           
        }
    }
}
