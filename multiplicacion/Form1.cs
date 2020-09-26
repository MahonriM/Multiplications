using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int num,mul;

        private void button2_Click(object sender, EventArgs e)
        {
            num = int.Parse(txtnum.Text);
            for (int i = 10; i >= 1; i--)
            {
                mul = num * i;
                lst.Items.Add(num + "X" + i + "=" + mul);
              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lst.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num =int.Parse(txtnum.Text);
            for (int i = 1; i <= 10; i++)
            {
                mul=num* i;
                lst.Items.Add(num + "X" + i + "=" + mul);
              
            }
        }
    }
}
