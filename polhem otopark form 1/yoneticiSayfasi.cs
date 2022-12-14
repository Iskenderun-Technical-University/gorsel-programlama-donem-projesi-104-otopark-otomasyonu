using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon_yeni_.Formlar
{
    public partial class yoneticiSayfasi : Form
    {
        Anasayfa anasayfa = new Anasayfa();

        
        public yoneticiSayfasi()
        {
            InitializeComponent();
        }

        private void yoneticiSayfasi_Load(object sender, EventArgs e)
        {
            /* Veri Tabanı kullanmadığımız için maaşlar ve isimleri manuel olarak giriyoruz.
               Normalde nesne yönelimli olarak yazmaya çalıştık ama çözemediğiz bir sürü bug meydana 
            geldiğinden dolayı uygulama çalışsın diye böyle yapmaya karar verdik*/
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            calisan1AdSoyad.Enabled = true;
            calisan1Telefon.Enabled = true;
            calisan1Numarasi.Enabled = true;
            calisan1Maasi.Enabled = true;

            calisan2AdSoyad.Enabled = true;
            calisan2Numarasi.Enabled = true;
            calisan2Telefon.Enabled = true;
            calisan2Maasi.Enabled = true;

            calisan3AdSoyad.Enabled = true;
            calisan3Numarasi.Enabled = true;
            calisan3Telefon.Enabled = true;
            calisan3Maasi.Enabled = true;

            calisan4AdSoyad.Enabled = true;
            calisan4Maasi.Enabled = true;
            calisan4Numarasi.Enabled = true;
            calisan4Telefon.Enabled = true;

            calisan5AdSoyad.Enabled = true;
            calisan5Numarasi.Enabled = true;
            calisan5Telefon.Enabled = true;
            calisan5Maasi.Enabled = true;

            calisan6AdSoyad.Enabled = true;
            calisan6Telefon.Enabled = true;
            calisan6Numarasi.Enabled = true;
            calisan6Maasi.Enabled = true;



        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            calisan1AdSoyad.Enabled = false;
            calisan1Telefon.Enabled = false;
            calisan1Numarasi.Enabled = false;
            calisan1Maasi.Enabled = false;

            calisan2AdSoyad.Enabled = false;
            calisan2Numarasi.Enabled = false;
            calisan2Telefon.Enabled = false;
            calisan2Maasi.Enabled = false;

            calisan3AdSoyad.Enabled = false;
            calisan3Numarasi.Enabled = false;
            calisan3Telefon.Enabled = false;
            calisan3Maasi.Enabled = false;

            calisan4AdSoyad.Enabled = false;
            calisan4Maasi.Enabled = false;
            calisan4Numarasi.Enabled = false;
            calisan4Telefon.Enabled = false;

            calisan5AdSoyad.Enabled = false;
            calisan5Numarasi.Enabled = false;
            calisan5Telefon.Enabled = false;
            calisan5Maasi.Enabled = false;

            calisan6AdSoyad.Enabled = false;
            calisan6Telefon.Enabled = false;
            calisan6Numarasi.Enabled = false;
            calisan6Maasi.Enabled = false;

        }

        private void calisan1AdSoyad_TextChanged(object sender, EventArgs e)
        {
        }

        private void calisan1Numarasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void calisan1Maasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void calisan1Telefon_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
