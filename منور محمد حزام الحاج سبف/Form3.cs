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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            button3.Visible = false; // مسار الصوره فيه
            button3.Enabled = false; // مسار الصوره فيه
            label1.Visible = false;
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "image Files|*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                button3.Text = openFileDialog1.FileName;
                Bitmap mybit = new Bitmap(button3.Text);
                pictureBox1.Image = mybit;
                button3.Visible = true;
                label1.Visible = true;
            }
            else
                MessageBox.Show("  المسار غير صالح ");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
