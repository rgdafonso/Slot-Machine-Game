using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_Caça_Frutas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a;
        int b;
        int c;


        private void Button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random random = new Random();
            
            a = random.Next(1, 4);
            b = random.Next(1, 4);
            c = random.Next(1, 4);

            switch (a)
            {
                case 1:
                    PictureBox1.Image = Properties.Resources.apple;
                    break;
                case 2:
                    PictureBox1.Image = Properties.Resources.banana;
                    break;
                case 3:
                    PictureBox1.Image = Properties.Resources.morango;
                    break;
            }

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            switch (b)
            {
                case 1:
                    PictureBox2.Image = Properties.Resources.apple;
                    break;
                case 2:
                    PictureBox2.Image = Properties.Resources.banana;
                    break;
                case 3:
                    PictureBox2.Image = Properties.Resources.morango;
                    break;
            }
        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            switch (c)
            {
                case 1:
                    PictureBox3.Image = Properties.Resources.apple;
                    break;
                case 2:
                    PictureBox3.Image = Properties.Resources.banana;
                    break;
                case 3:
                    PictureBox3.Image = Properties.Resources.morango;
                    break;
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                timer1.Enabled = false;

                if (a == b && b == c && a == c)
                {
                    textBox1.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    button3.Visible = true;
                    label1.Text = "Parabéns você ganhou!!";

                }
                else
                {
                    label1.Visible = true;
                    label1.Text = "Não foi dessa vez, tente denovo";

                }
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            boxW.Items.Add(textBox1.Text);
            textBox1.Visible = false;
            label1.Visible = true;
            label2.Visible = false;
            button3.Visible = false;
            label1.Text = "Parabéns, " + textBox1.Text + " seu nome foi registrado";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
