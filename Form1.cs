using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaşKağıtMakasOyunu
{
    public partial class Form1 : Form
    {
        int tur = 3;
        int turbasinasüre = 6;
        Boolean oyunDurum=false;
        string[] bilgisayarSecimList = {"taş","kağıt","makas"};
        int sayi = 0;
        Random rnd = new Random();
        string bilisayarSecim, oyuncuSecim;
        int oyuncuSkor, bilgisayarSkor;
        public Form1()
        {
            InitializeComponent();
            zamanSay.Enabled=true;
            oyuncuSecim = "none";
            lblGeriSay.Text = "5";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnTaş_Click(object sender, EventArgs e)
        {
            pictureOyuncu.Image = Properties.Resources.taş;
            oyuncuSecim = "taş";
        }

        private void btnKağıt_Click(object sender, EventArgs e)
        {
            pictureOyuncu.Image = Properties.Resources.kağıt;
            oyuncuSecim = "kağıt";
        }

        private void btnMakas_Click(object sender, EventArgs e)
        {
            pictureOyuncu.Image = Properties.Resources.image;
            oyuncuSecim = "makas";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ZamanSayEvent(object sender, EventArgs e)
        {
            turbasinasüre --;
            lblGeriSay.Text=turbasinasüre.ToString();
            lblTur.Text = "Tur: " + tur;

            if (turbasinasüre<1)
            
                zamanSay.Enabled = false;
            
            sayi = rnd.Next(0,bilgisayarSecimList.Length);
            bilisayarSecim = bilgisayarSecimList[sayi];

            switch (bilisayarSecim)
            {
                case "taş":
                    pictureBilgisayar.Image = Properties.Resources.taş;
                    break;

                case "kağıt":
                    pictureBilgisayar.Image = Properties.Resources.kağıt;
                    break;

                case "makas":
                    pictureBilgisayar.Image = Properties.Resources.image;
                    break;
            }

            if (tur > 0)
            {
                oyunKontrol();
            }
            else
            {
                if (oyuncuSkor > bilgisayarSkor)
                {
                    MessageBox.Show("Oyuncu oyunu kazandı");
                }
                else
                {
                    MessageBox.Show("Bilgisayar oyunu kazandı");
                }
            }
        }

        private void btnTekrarBaşlat_Click(object sender, EventArgs e)
        {
            oyuncuSkor = 0;
            bilgisayarSkor = 0;
            lblGeriSay.Text = "5";
            int turbasinasure = 6;
            tur = 3;
            lblSkor.Text = "Oyuncu: " + oyuncuSkor.ToString() + "Bilgisayar: " + bilgisayarSkor.ToString();
            oyuncuSecim = "none";
            zamanSay.Enabled = true;
            pictureOyuncu.Image = Properties.Resources.s_504ecae4068d96f71612316757fbf40f04324854;
            pictureBilgisayar.Image = Properties.Resources.s_504ecae4068d96f71612316757fbf40f04324854;
            oyunDurum=false;
        }

        private void oyunKontrol()
        {
            //bilgisayar
            if (oyuncuSecim =="taş" && bilisayarSecim == "kağıt")
            {
                bilgisayarSkor += 1;
                tur--;
                MessageBox.Show("Bilgisayar kazandi");
            }
            else if (oyuncuSecim == "makas" && bilisayarSecim == "taş")
            {
                bilgisayarSkor += 1;
                tur--;
                MessageBox.Show("Bilgisayar kazandi");
            }
            else if (oyuncuSecim == "kağıt" && bilisayarSecim == "makas")
            {
                bilgisayarSkor += 1;
                tur--;
                MessageBox.Show("Bilgisayar kazandi");
            }


            //oyuncu
            if (oyuncuSecim == "kağıt" && bilisayarSecim == "taş")
            {
                oyuncuSkor += 1;
                tur--;
                MessageBox.Show("Oyuncu kazandi");
            }
            else if (oyuncuSecim == "taş" && bilisayarSecim == "makas")
            {
                oyuncuSkor += 1;
                tur--;
                MessageBox.Show("Oyuncu kazandi");
            }
            else if(oyuncuSecim == "makas" && bilisayarSecim == "kağıt")
            {
                oyuncuSkor += 1;
                tur--;
                MessageBox.Show("Oyuncu kazandi");
            }
            else if (oyuncuSecim == "none")
            {
                MessageBox.Show("seçim yap");
            }
            else
            {
                MessageBox.Show("berabere");
            }
            yeniTur();
        }
        private void yeniTur()
        {
            if(oyunDurum == true)
            {
                return;
            }
            lblSkor.Text = "Oyuncu: " + oyuncuSkor.ToString() + "Bilgisayar: " + bilgisayarSkor.ToString();
            oyuncuSecim = "none";
            zamanSay.Enabled= true;
            pictureOyuncu.Image = Properties.Resources.s_504ecae4068d96f71612316757fbf40f04324854;
            pictureBilgisayar.Image = Properties.Resources.s_504ecae4068d96f71612316757fbf40f04324854;

        }
        

        
    }
}
