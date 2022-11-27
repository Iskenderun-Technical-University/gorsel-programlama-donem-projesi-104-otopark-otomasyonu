using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkOtomasyonu
{
    internal class Eleman
    {
        public string elemanAdi = "";
        public string elemanSoyadi = "";
        public int elemanYasi;
        public int elemanId;
        public int elemanMaasi;


        public void eleman()
        {
            this.elemanAdi = "Bilgi girilmedi!";
            this.elemanSoyadi = "Bilgi girilmedi!";
            this.elemanYasi = 0;
            this.elemanId = 0;
            this.elemanMaasi = 0;
        }

        public void eleman
            (
            string elemanAdi,
            string elemanSoyadi,
            int elemanYasi,
            int elemanMaasi,
            int elemanId
            )

        {
            this.elemanAdi = elemanAdi;
            this.elemanSoyadi = elemanSoyadi;
            this.elemanYasi = elemanYasi;
            this.elemanMaasi = elemanMaasi;
            this.elemanId = elemanId;
        }

    }
}
