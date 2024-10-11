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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile("0.png");
            pictureBox1.Image = Image.FromFile("0.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        int i = -1;
        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if (i < 9)
            {
                pictureBox1.Image = Image.FromFile(i.ToString() + ".jpg");
                BackgroundImage = Image.FromFile(i.ToString() + ".jpg");
            }
            else
            {
                i = 0;
                pictureBox1.Image = Image.FromFile(i.ToString() + ".jpg");
                BackgroundImage = Image.FromFile(i.ToString() + ".jpg");
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = 9;
            pictureBox1.Image = Image.FromFile(i.ToString() + ".jpg");
            BackgroundImage = Image.FromFile(i.ToString() + ".jpg");
        }

    }
}
