using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu
{

    public partial class anasayfa : Form
    {

        string yoneticiId = "Yonetici";
        string musteriId = "Musteri";
        string gorevliId = "Gorevli";

        string yoneticiSifre ="Yonetici123";
        string musteriSifre="Musteri123";
        string gorevliSifre = "Gorevli123";

        string yoneticiAdi = "Levent";

        
        public anasayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gorevliGirisi.Text = "";
            gorevliSifresi.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(yoneticiId == gorevliGirisi.Text && yoneticiSifre== gorevliSifresi.Text) 
            {
                yöneticiSayfasi yöneticiSayfasi = new yöneticiSayfasi();

                yöneticiSayfasi.Show();

                 this.Hide();
            }
            else if(gorevliId == gorevliGirisi.Text && gorevliSifre== gorevliSifresi.Text)
            {
                görevliSayfasi görevlisayfasi = new görevliSayfasi();

                görevlisayfasi.Show();
                this.Hide();
            }
            else if(gorevliGirisi.Text == "" && gorevliSifresi.Text == "" ) 
            {
                label10.Text = "Alanlar doldurmak zorunda!!";
            }
            
            
            else
            {
                label10.Text = "Yanlış Giriş Yapıldı!!";
            }
                
        }

        private void gorevliSifresi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            musteriGirisi.Text = "";
            musteriSifresi.Text = "";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (musteriId == musteriGirisi.Text && musteriSifre == musteriSifresi.Text)
            {
              müşteriSayfasi musterisayfasi = new müşteriSayfasi  ();

                musterisayfasi.Show();
                this.Hide(); 
                
            }
          

            else if (musteriGirisi.Text == "" && musteriSifresi.Text == "")
            {
                label11.Text = "Alanlar doldurmak zorunda!!";
            }


            else
            {
                label11.Text = "Yanlış Giriş Yapıldı!!";
            }

        }
    }
    }

