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
    public partial class Form2 : Form
    {
        public Form2(Object Tag)
        {
            InitializeComponent();
            if(Tag == "razv")
            {
                MessageBox.Show("GOOD");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

                panel1.Controls.Add(pictureBox3);
                /*pictureBox3.Click += new EventHandler(pictureBox_Click);*/
            }
            else if (listBox1.SelectedIndex == 1)
            {
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;

                panel1.Controls.Add(pictureBox1);
            }
            else if (listBox1.SelectedIndex == 2)
            {
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;

                panel1.Controls.Add(pictureBox1);
            }
            else if (listBox1.SelectedIndex == 3)
            {
                pictureBox5.Visible = false;
                pictureBox4.Visible = true;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

                panel1.Controls.Add(pictureBox1);
            }
            else if (listBox1.SelectedIndex == 4)
            {
                pictureBox5.Visible = true;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

                panel1.Controls.Add(pictureBox1);
            }
            else if (listBox1.SelectedIndex == 5)
            {
                pictureBox5.Visible = true;
                pictureBox4.Visible = true;
                pictureBox3.Visible = true;
                pictureBox2.Visible = true;
                pictureBox1.Visible = true;

                panel1.Controls.Add(pictureBox1);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
