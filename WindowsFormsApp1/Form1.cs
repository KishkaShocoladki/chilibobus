using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Евразия1;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Южная_Америка;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.Северная_Америка;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.Африка__1_;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.Австралия__1_;
        }

    }
}
