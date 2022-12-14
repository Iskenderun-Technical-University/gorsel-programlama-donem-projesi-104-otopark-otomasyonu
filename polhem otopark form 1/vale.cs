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
    public partial class vale : Form
    {
        public vale()
        {
            InitializeComponent();
        }

        private void vale_Load(object sender, EventArgs e)
        {

        }

        private void valeParkEtmeBtn_Click(object sender, EventArgs e)
        {
            if(parkEtmeAd.Text.Length >0 &&
               parkEtmeSoyad.Text.Length >0 &&
               parkEtmeAracPlakasi.Text.Length>0 &&
               parkEtmeAracMarkasi.Text.Length>0 &&
               parkEtmeParkYeri.Text.Length>0) 
            {
                MessageBox.Show("Valeye İletildi !!");
            }

            else
            {
                parkEtmeBildiri.Text = "Hepsini doldurunuz !!";
            }
        }

        private void valeTeslimEtmeBtn_Click(object sender, EventArgs e)
        {
            if (teslimEtmeAd.Text.Length > 0 &&
                TeslimEtmeSoyad.Text.Length > 0 &&
                teslimEtmeAd.Text.Length > 0 &&
                teslimEtmeAracPlakasi.Text.Length > 0 &&
                teslimEtmeParkYeri.Text.Length > 0)
            {
                MessageBox.Show("Valeye İletildi!!");
            }

            else 
            
            {
                teslimEtmeBildiri.Text = "Hepsini doldurunuz !!";
            }
        }
    }
}
