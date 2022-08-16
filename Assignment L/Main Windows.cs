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
    public partial class Main_Windows : Form
    {
        public Main_Windows()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if(active != null)
            {
                active.Close();
            }

            Form1 form = new Form1();
            form.MdiParent = this;
            form.Show();
        }
    }
}
