using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reverse_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n,  reverse = 0, rem;
            n = Convert.ToInt32(textBox1.Text);
            

            while (n != 0)
            {
                rem = n % 10;

                reverse = (reverse * 10) + rem;
               
                n = n/10;

                textBox2.Text = reverse.ToString();
                
            }

            
        }
    }
}
