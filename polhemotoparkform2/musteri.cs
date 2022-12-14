using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon_yeni_.Formlar
{
    public partial class musteri : Form
    {
        public musteri()
        {
            InitializeComponent();
        }
       
        private void musteri_Load(object sender, EventArgs e)
        {

        }

        private void musteri_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            musteriAdSoyad.Clear();
            musteriTelefonNumarasi.Clear();
            musteriAracMarkasi.Clear();
            musteriAracPlakasi.Clear();
            musteriParkYeri.Clear();
            adSoyadGiris.Text = "";
            telefonNumarasiGiris.Text = "";
            aracPlakasiGiris.Text = " ";
            aracMarkasiGiris.Text = "";
            parkYeriGiris.Text = "";
            kaydetmeBildiri.Text = "";
            


        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            

            if(musteriAdSoyad.Text.Length>0 && 
               musteriTelefonNumarasi.Text.Length>0 &&
               musteriAracMarkasi.Text.Length>0 &&
               musteriAracPlakasi.Text.Length>0 &&
               musteriParkYeri.Text.Length>0)
            {
                musteriOnayla.Enabled = true;

                adSoyadGiris.Text = musteriAdSoyad.Text;
                telefonNumarasiGiris.Text = musteriTelefonNumarasi.Text;
                aracMarkasiGiris.Text = musteriAracMarkasi.Text;
                aracPlakasiGiris.Text = musteriAracPlakasi.Text;
                parkYeriGiris.Text = musteriParkYeri.Text;
            }
            else
            {
                kaydetmeBildiri.Text = "Tüm Alanlar Dolmak Zorundadır!!";
            }

            

        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            if(adSoyadGiris.Text.Length>0 &&
               telefonNumarasiGiris.Text.Length>0 &&
               aracMarkasiGiris.Text.Length>0 &&
               aracPlakasiGiris.Text.Length>0 &&
               parkYeriGiris.Text.Length > 0)
            {
                    MessageBox.Show("Kaydedildi!!");
            }
            else
            {
                onayBildirisi.Text = "Lütfen Alanları Doldurunuz..";
            }

        }

        private void ıconButton2_MouseHover(object sender, EventArgs e)
        {
            musteriTemizle.BackColor = Color.Lime;

        }

        private void musteriTemizle_MouseLeave(object sender, EventArgs e)
        {
            musteriTemizle.BackColor = Color.White;
            
        }

        private void musteriKaydet_MouseHover(object sender, EventArgs e)
        {
            musteriKaydet.BackColor = Color.Lime;

        }

        private void musteriKaydet_MouseLeave(object sender, EventArgs e)
        {
            musteriKaydet.BackColor = Color.White;

        }

        private void musteriOnayla_MouseHover(object sender, EventArgs e)
        {
            musteriOnayla.BackColor = Color.Lime;
        }

        private void musteriOnayla_MouseLeave(object sender, EventArgs e)
        {
            musteriOnayla.BackColor = Color.White;

        }
    }
}
