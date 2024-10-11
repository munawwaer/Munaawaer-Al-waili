using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace منور_محمد_حزام_المحاظره_السادسه
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }
        int i = -1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i = i + 1; ;
            if (i < 9)
            {
                pictureBox1.Image = Image.FromFile(i.ToString() + ".png");
               
            }
            else
            {
                i = 0;
                pictureBox1.Image = Image.FromFile(i.ToString() + ".png");
         
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
