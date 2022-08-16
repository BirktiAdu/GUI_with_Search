using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_L
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Birukti" && textBox2.Text == "Adugna")
            {
                this.Hide();
                Main main = new Main(textBox1.Text);
                //main.txt_username = textBox1.Text;
                main.ShowDialog();
                main.Show();
            }

            else
            {
                MessageBox.Show("Username or Password is incorrect.");
            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                button4.BringToFront();
                textBox2.PasswordChar = '\0';
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                button3.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
