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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            button1.Text = "Start";
            button2.Text = "Stop";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();
            //timer.Enabel=true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        int s = -1, m =0, h =0, y = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if (h >= 23 &&m>=59&&s>=59)
            {
                s = m = h = 0;
                label4.Text = "00 :";
                label2.Text = "00 :";
                y++;
               
                if (y > 9)
                    label5.Text = y.ToString()+" :";
                else
                    label5.Text ="0"+ y.ToString()+" :";
            }
            if (m >= 59&&s>=59)
            {
                s = 0;
                m = 0;
                label2.Text = "00 :";
                h++;
                if (h > 9)
                    label4.Text = h.ToString() + " :";
                else
                    label4.Text = "0" + h.ToString() + " :";
            }
            
            if (s >= 59)
            {
                s = 0;
                m++;
                if (m > 9)
                    label2.Text = m.ToString() + " :";
                else
                    label2.Text = "0" + m.ToString() + " :";
            }
            if (s > 9)
                label1.Text = s.ToString();
            else
                label1.Text = "0" + s.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


       
    }
}
