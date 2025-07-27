using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clickeroyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int altın = 0;
        int hit = 10;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            altın += hit;
            label2.Text = altın.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.Text = "100 altın";
            if (altın >= 100)
            {
                hit = 20;
                altın = altın - 100;
                label2.Text = altın.ToString();
                pictureBox2.BackColor = Color.Red;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.Text = "200 altın";
            if (altın >= 200)
            {
                hit = 50;
                altın = altın - 200;
                label2.Text = altın.ToString();
                pictureBox3.BackColor = Color.Red;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.Text = "300 altın";
            if (altın >= 300)
            {
                hit = 70;
                altın = altın - 300;
                label2.Text = altın.ToString();
                pictureBox4.BackColor = Color.Red;

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.Text = "400 altın";
            if (altın >= 400)
            {
                hit=1000;
                altın = altın - 400;
                label2.Text = altın.ToString();
                pictureBox5.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            altın ++;
            label2.Text = altın.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Altın_Click(object sender, EventArgs e)
        {

        }
    }
}
