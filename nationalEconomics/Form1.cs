using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nationalEconomics
{
    public partial class Form1 : Form
    {
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                flag = true;
            }
            if (checkBox2.Checked)
            {
                flag = false;
            }

            USA form = new USA(flag);
            form.Show();
        }
    }
}

