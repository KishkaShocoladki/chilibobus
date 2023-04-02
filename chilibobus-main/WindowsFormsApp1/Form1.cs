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
        private Image razvit;
        private Image razviv;
        private Image nerazvit;

        public Form1()
        {
            InitializeComponent();

            pictureBox2.Parent = pictureBox1;
            pictureBox3.Parent = pictureBox2;


            razvit = Image.FromFile("../../Resources/razvitye.png");
            razviv = Image.FromFile("../../Resources/razvivayshiesya.png");
            nerazvit = Image.FromFile("../../Resources/neraz.png");

            FormBorderStyle = FormBorderStyle.Fixed3D;
            //прозрачность основной формы
            // this.TransparencyKey = System.Drawing.Color.DarkSlateGray;
            //this.BackColor = System.Drawing.Color.DarkSlateGray;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            /*e.Graphics.DrawImage(razvit, 0, 0);
            e.Graphics.DrawImage(razviv, 0, 0);
            e.Graphics.DrawImage(nerazvit, 0, 0);*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == 0)
            {
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

                panel2.Controls.Add(pictureBox3);
                pictureBox3.Click += new EventHandler(pictureBox_Click);
            }
            else if (listBox1.SelectedIndex == 1)
            {
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;

                panel2.Controls.Add(pictureBox1);
            }
            else if (listBox1.SelectedIndex == 2)
            {
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;

                panel2.Controls.Add(pictureBox2);
            }
            else if (listBox1.SelectedIndex == 4)
            {   
                panel2.Controls.Add(pictureBox1);
                panel2.Controls.Add(pictureBox2);
                panel2.Controls.Add(pictureBox3);

                pictureBox3.Visible = true;
                pictureBox2.Visible = true;
                pictureBox1.Visible = true;

                pictureBox2.Parent = pictureBox1;
                pictureBox3.Parent = pictureBox2;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(((PictureBox)sender).Tag);
            f.ShowDialog();
        }

        //europe = Image.FromFile("../../Resources/europe-transformed.png");
        // scand = Image.FromFile("../../Resources/scand-transformed1.png");
        // pictureBox1.Load("../../Resources/scand-transformed1.png");
        //pictureBox2.Load("../../Resources/europe-transformed.png");
    }
}
