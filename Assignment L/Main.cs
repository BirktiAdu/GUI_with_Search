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
    public partial class Main : Form
    {
        static List<Main> list = new List<Main>();
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public Main(string name)
        {
            InitializeComponent();
            label6.Text = name;
        }
        public List<Main> GetMain()
        {
            return list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // dataGridView1.DataSource = list;
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
           // label6 =
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            c.fname =textBox1.Text ;
           c.lname=textBox2.Text;
            c.age =int.Parse(textBox3.Text);
            c.phoneNo =textBox4.Text;
            c.email =textBox5.Text;
            c.gender = groupBox1.Text;
            c.save();

            List<int> items = new List<int> { 1, 2, 3 };



            dataGridView1.DataSource = null;
            dataGridView1.DataSource = c.GetProduct();


            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            List<Class1> Data = new List<Class1>();
          
            Class1 cl = Class1.findOne(textBox6.Text);
           if(cl == null)
            {
                MessageBox.Show("User not found!");

            }
            else
            {
                Data.Add(cl);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Data;
            }
           
        }

        private void txt_fname_Click(object sender, EventArgs e)
        {

        }
    }
}
