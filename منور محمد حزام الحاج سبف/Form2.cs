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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //label1.Text = "";
            //button2.Text = "";
            //button3.Text = "";
            //button4.Text = "";
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
                pictureBox1.Image = Image.FromFile(@textBox1.Text.Trim());
            else
                MessageBox.Show(" ادخل مسار الصوره ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
               // pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
           // pictureBox1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
