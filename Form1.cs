using System;
using System.Drawing;
using System.Windows.Forms;

namespace pk31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int newBtn1Y = 0;
        int newBtn2Y = 0;
        int newBtn3Y = 0;
        int score = 1;
        bool canChange = true;
        private void button1_Click(object sender, EventArgs e)
        {
            newBtn1Y = 0;
            button1.Location = new Point(218, newBtn1Y);
            score++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newBtn2Y = 0;
            button2.Location = new Point(463, newBtn2Y);
            score++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Location = new Point(218, newBtn1Y);
            button2.Location = new Point(463, newBtn2Y);
            button3.Location = new Point(692, newBtn3Y);
            newBtn1Y += 1;
            newBtn2Y += 3;
            newBtn3Y += 4;
            label1.Text = score.ToString();
            if (score % 10==0 & canChange==true)
            {
                Random random = new Random();
                button1.Size = new Size(random.Next(50, 150), random.Next(20, 70));
                button2.Size = new Size(random.Next(50, 150), random.Next(20, 70));
                button3.Size = new Size(random.Next(50, 150), random.Next(20, 70));
                canChange = false;
            }
            if (score % 10==1)
            {
                canChange = true;
            }
            if (button1.Location.Y > 550 || button2.Location.Y > 550 || button3.Location.Y > 550)
            {
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            newBtn3Y = 0;
            button3.Location = new Point(692, newBtn3Y);
            score++;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            score--;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            score = 0;
            newBtn1Y = 0;
            newBtn2Y = 0;
            newBtn3Y = 0;
            button1.Location = new Point(221, 12);
            button2.Location = new Point(463, 12);
            button3.Location = new Point(692, 12);
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Visible = false;
            timer1.Enabled = true;
        }
    }
}
