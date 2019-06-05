using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label9.Text = "SIGN UP";
            button1.Text = "SIGN UP";
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            richTextBox1.Visible = true;
            richTextBox2.Visible = true;
            richTextBox3.Visible = true;
            richTextBox4.Visible = true;
            richTextBox5.Visible = true;
            button1.Visible = true;




        }

        private void label2_Click(object sender, EventArgs e)
        {

            label9.Text = "SIGN IN";
            button1.Text = "SIGN IN";
            label4.Visible = true;
            label5.Visible = true;
            label9.Visible = true;
            richTextBox1.Visible = true;
            richTextBox2.Visible = true;
            button1.Visible = true;
           
        }
    }
}
