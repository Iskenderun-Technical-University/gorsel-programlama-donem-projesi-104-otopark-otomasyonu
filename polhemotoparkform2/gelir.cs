using FontAwesome.Sharp;
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
    public partial class gelir : Form
    {
        int musteri;

        int saat;      
        float toplamGelir = 0;
        int musteri2;
        float musteri2Gelir;
        float  musteri1Gelir1, musteri1Gelir2;
        int haftalikMusteri1, aylikMusteri1;
        float haftalikGelir1, aylikGelir1,toplamKar1;
        float fatura,aylikGider1;

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yazdılıyor!!");
        }

        int elemanMaaşlari = 60000;
       
        
        


        public gelir()
        {
            InitializeComponent();
        }
        
        private void gelir_Load(object sender, EventArgs e)
        {
            
        }

        private void gelir_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {


            /*Şu anlık veri tabanı kullanamadığımız için müşteri bilgisilerini ve 
             gelir sayfalarını random üzerinden atadığımız kodlardır.*/ 

            Random rnd = new Random();

            musteri = rnd.Next(12, 37);
            musteri2 = rnd.Next(5, 12);
            fatura = rnd.Next(10000, 16000);
            saat = rnd.Next(1, 241);
         


                musteriBilgisi.Text = musteri.ToString();
                musteriGelir.Text = toplamGelir.ToString();
            
          

            if(saat > 12)
            {
                musteri2Gelir = musteri2 * saat * 10;
                musteri2Gelir = musteri2Gelir - (musteri2Gelir / 2);
            }
            
            
            if(saat >6 && saat<12)
            {
                musteri1Gelir1 = musteri * saat * 10;
                musteri1Gelir1 = musteri1Gelir1 -(musteri1Gelir1 *35/100);

            }

            else if(saat <6 && saat > 3)
            {
                musteri1Gelir1 = musteri*saat * 10;
                musteri1Gelir1 = musteri1Gelir1 - (musteri1Gelir1 * 25 / 100);
            }
            else
            {
                musteri1Gelir2 = saat * 10;
            }


                toplamGelir = musteri2Gelir + musteri1Gelir1;
                musteriGelir.Text = toplamGelir.ToString();
                haftalikMusteri1 = (musteri+musteri2) * 7;
                haftalikGelir1 = toplamGelir * 7;

                    haftalikMusteri.Text = haftalikMusteri1.ToString();
                    haftalikGelir.Text = haftalikGelir1.ToString();
           
                aylikGelir1 = toplamGelir * 30;
                aylikMusteri1 = (musteri + musteri2) * 30;

                    aylikGelir.Text = aylikGelir1.ToString();
                    aylikMusteri.Text = aylikMusteri1.ToString();

                aylikGider1 = elemanMaaşlari + fatura;
                aylikGider.Text ="-"+ aylikGider1.ToString();

                toplamKar1 = aylikGelir1 - aylikGider1;
                toplamKar.Text = toplamKar1.ToString();

            yazdirBtn.Enabled = true;



            gelirBtn.Enabled = false;
        }
    }
}
