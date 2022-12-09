using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyonu
{
    internal class Müşteri
    {
        public string musteriAdi = "";
        public string musteriSoyadi = "";
        public int musteriYasi;
        public int musteriId;
       


        public void eleman()
        {
            this.musteriAdi = "Bilgi girilmedi!";
            this.musteriSoyadi = "Bilgi girilmedi!";
            this.musteriYasi = 0;
            this.musteriId = 0;
           
        }

        public void eleman
            (
            string musteriAdi,
            string musteriSoyadi,
            int musteriYasi,
            int musteriMaasi,
            int musteriId
            )

        {
            this.musteriAdi = musteriAdi;
            this.musteriSoyadi = musteriSoyadi;
            this.musteriYasi = musteriYasi;
            this.musteriId = musteriId;
        }
    }
}
