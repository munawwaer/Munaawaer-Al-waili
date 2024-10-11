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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Width=pictureBox1.Height=300;
            pictureBox1.BackColor = Color.Red;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(@"2.jpg");//هي لها الاولويه بالعرض
            pictureBox1.BackgroundImage = Image.FromFile(@"F:\image\imagr1\-6036449863513781407_120.jpg");//
            toolTip1.SetToolTip(pictureBox1, "pictureBox1 اداة");
            AutoSize = true;// this.autosize=true;
            button1.Width = 300;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Image = null;

        }
    }
}
