using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGAme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rando = new Random();
        int oyuncu1puan=0;
        int oyuncu2puan=0;
        int temp1;
        int temp2;

        private void zarAt()
        {
            temp1 = rando.Next(1, 7);
            temp2 = rando.Next(1, 7);

            if (temp1==1)
            {
                pictureBox1.ImageLocation = "image\\1.png";
            }
            if (temp1 == 2)
            {
                pictureBox1.ImageLocation = "image\\2.png";
            }
            if (temp1 == 3)
            {
                pictureBox1.ImageLocation = "image\\3.png";
            }
            if (temp1 == 4)
            {
                pictureBox1.ImageLocation = "image\\4.png";
            }
            if (temp1 == 5)
            {
                pictureBox1.ImageLocation = "image\\5.png";
            }
            if (temp1 == 6)
            {
                pictureBox1.ImageLocation = "image\\6.png";
            }
            if (temp2 == 1)
            {
                pictureBox2.ImageLocation = "image\\1.png";
            }
            if (temp2 == 2)
            {
                pictureBox2.ImageLocation = "image\\2.png";
            }
            if (temp2 == 3)
            {
                pictureBox2.ImageLocation = "image\\3.png";
            }
            if (temp2 == 4)
            {
                pictureBox2.ImageLocation = "image\\4.png";
            }
            if (temp2 == 5)
            {
                pictureBox2.ImageLocation = "image\\5.png";
            }
            if (temp2 == 6)
            {
                pictureBox2.ImageLocation = "image\\6.png";
            }


        }
        private void oyuncuSkor()
        {
            if(oyuncu1puan>= Convert.ToInt32(txtPuan.Text))
            {
                label2.Visible = true;
                label2.Text = "Oyuncu1 Kazandı!";
                button_tekrar.Visible = true;
                button_oyuncu2.Enabled = false;
            }
            if (oyuncu2puan >= Convert.ToInt32(txtPuan.Text))
            {
                label2.Visible = true;
                label2.Text = "Oyuncu2 Kazandı!";
                button_tekrar.Visible = true;
                button_oyuncu1.Enabled = false;
            }
        }

        private void button_oyuncu1_Click(object sender, EventArgs e)
        {
            txtPuan.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button_oyuncu1.Enabled = false;
            button_oyuncu2.Enabled = true;
            zarAt();
            oyuncu1puan = oyuncu1puan + temp1 + temp2;
            label_oyuncu1.Text = oyuncu1puan.ToString();
            oyuncuSkor();

        }

        private void button_oyuncu2_Click(object sender, EventArgs e)
        {
            txtPuan.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            button_oyuncu2.Enabled = false;
            button_oyuncu1.Enabled = true;
            zarAt();
            oyuncu2puan = oyuncu2puan + temp1 + temp2;
            label_oyuncu2.Text = oyuncu2puan.ToString();
            oyuncuSkor();
        }

        private void button_tekrar_Click(object sender, EventArgs e)
        {
            txtPuan.Enabled = true;
            txtPuan.Text = "100";
            button_oyuncu1.Enabled = true;
            button_oyuncu2.Enabled = true;
            label2.Visible = false;
            oyuncu1puan = 0;
            oyuncu2puan = 0;
            label_oyuncu1.Text = "0";
            label_oyuncu2.Text = "0";
            button_tekrar.Visible = false;
        }
    }
}
