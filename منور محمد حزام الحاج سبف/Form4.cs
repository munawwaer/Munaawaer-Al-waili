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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            button1.Text = "رســــــم pictureBox ";
            button2.Text = "مـــســح pictureBox ";
            button3.Text = "رســـــم بالفــورم";
            button4.Text = "مســـح مـ الفــور";
            button5.Text = "أغــــلاقـ";

            button2.Click += Wwakening;
            button3.Click += Wwakening;
            button4.Click += Wwakening;
            button5.Click += Wwakening;

        }
        Bitmap bit ; //تهـيئة المتغير ليكون عام ونستطيع الوصول اليه 
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            bit=new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int x = 1; x < 100; x++)
            {
                
                bit.SetPixel(150+x,100 , Color.Black);
                bit.SetPixel(150,100+x  , Color.Black);
                bit.SetPixel(150 + x, 200, Color.Black);
                bit.SetPixel(250 , 200-x, Color.Black);
            }
            pictureBox1.Image = bit;
         //   BackgroundImage = bit; 
          //  bit.Dispose();
       
        }
        private void Wwakening(object sender, EventArgs e)
        {
            if (sender == button2)// تنظيف البكتشر
                pictureBox1.Image = null;
            else if (sender == button4)// تنظيف الفورم
                BackgroundImage = null;
            else if (sender == button3)//اخقاء البكتشر وعرض رسم الفورم
            {
                pictureBox1.Visible = false;
                this.BackgroundImage = bit;
            }
            else if (sender == button5)// اغلاق الفورم
                Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  pictureBox1.Image = null;
        }

      
        private void button4_Click(object sender, EventArgs e)
        {
           // BackgroundImage = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // pictureBox1.Visible = false;
          //  this.BackgroundImage = bit;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // Close();
        }
    }
}
