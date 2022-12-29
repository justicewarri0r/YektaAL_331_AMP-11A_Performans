using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int at, kopek, kedi;
        int tahmin;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //MessageBox.Show("Tahminler Kapandı!!!","YARIŞ BAŞLADI");
            buttonTahminAt.Enabled = false;
            buttonTahminKöpek.Enabled = false;
            buttonTahminKedi.Enabled = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelBitis_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxKopek_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBoxAt.Location = new Point(0,24);
            pictureBoxKopek.Location = new Point(0,121);
            pictureBoxKedi.Location = new Point(0,218);
            tahmin = 0;
            buttonTahminAt.Enabled = true;
            buttonTahminKöpek.Enabled = true;
            buttonTahminKedi.Enabled = true;

        }

        private void buttonTahminAt_Click(object sender, EventArgs e)
        {
            tahmin = 1;
        }

        private void buttonTahminKöpek_Click(object sender, EventArgs e)
        {
            tahmin = 2;
        }

        private void buttonTahminKedi_Click(object sender, EventArgs e)
        {
            tahmin = 3;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            pictureBoxAt.Left += rd.Next(1, 50);
            pictureBoxKopek.Left += rd.Next(1, 50);
            pictureBoxKedi.Left += rd.Next(1, 50);
            if (pictureBoxAt.Right >  labelBitis.Left)
            {
                timer1.Stop();
                if (tahmin == 1)
                {
                    MessageBox.Show("Tahminiz Doğru At kazandı","TEBRİKLER");
                }
                else if (tahmin == 2)
                {
                    MessageBox.Show("Tahminiz Yanlış At kazandı","KAYBETTİNİZ");
                }
                else if (tahmin == 3)
                {
                    MessageBox.Show("Tahminiz Yanlış At kazandı","KAYBETTİNİZ");
                }
                else if (tahmin == 0)
                {
                    MessageBox.Show("Tahmin Yapılmadı At kazandı","YARIŞ BİTTİ");
                }
            }
            else if (pictureBoxKopek.Right > labelBitis.Left)
            {
                timer1.Stop();
                if (tahmin == 1)
                {
                    MessageBox.Show("Tahminiz Yanlış Köpek kazandı","KAYBETTİNİZ");
                }
                else if (tahmin == 2)
                {
                    MessageBox.Show("Tahminiz Doğru Köpek kazandı","TEBRİKLER");
                }
                else if (tahmin == 3)
                {
                    MessageBox.Show("Tahminiz Yanlış Köpek kazandı","KAYBETTİNİZ");
                }
                else if (tahmin == 0)
                {
                    MessageBox.Show("Tahmin Yapılmadı Köpek kazandı","YARIŞ BİTTİ");
                }
            }
            else if (pictureBoxKedi.Right >  labelBitis.Left)
            {
                timer1.Stop();
                if (tahmin == 1)
                {
                    MessageBox.Show("Tahminiz Yanlış Kedi kazandı","KAYBETTİNİZ");
                }
                else if (tahmin == 2)
                {
                    MessageBox.Show("Tahminiz Yanlış Kedi kazandı","KAYBETTİNİZ");
                }
                else if (tahmin == 3)
                {
                    MessageBox.Show("Tahminiz Doğru Kedi kazandı","TEBRİKLER");
                }
                else if (tahmin == 0)
                {
                    MessageBox.Show("Tahmin Yapılmadı Kedi kazandı","YARIŞ BİTTİ");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            at = pictureBoxAt.Left;
            kopek = pictureBoxKopek.Left;
            kedi = pictureBoxKedi.Left;
        }
    }
}
