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
    public partial class yoneticiGirisi : Form
    {

        string yoneticiAdSoyad = "Levent KARACAN";
        string yoneticiSifre = "LeventKaracan123";

        private Form currentChildForm;
        public yoneticiGirisi()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

            // homeLabel.Text = childForm.Text;


        }

        private void yoneticiTemizleBtn_Click(object sender, EventArgs e)
        {
            

        }

        private void yoneticiGirisi_Load(object sender, EventArgs e)
        {

        }

        private void yoneticiGirisBtn_Click(object sender, EventArgs e)
        {
            if(yoneticiSifresi.Text == yoneticiSifre && yoneticiAdiSoyadi.Text == yoneticiAdSoyad)
            {
                OpenChildForm(new yoneticiSayfasi());
            }
        }

        private void yoneticiGirisBtn_Click_1(object sender, EventArgs e)
        {
            // Giriş kontrolü

            if (yoneticiSifresi.Text == yoneticiSifre && yoneticiAdiSoyadi.Text == yoneticiAdSoyad)
            {
                OpenChildForm(new yoneticiSayfasi());
            }

            else if(yoneticiAdiSoyadi.Text.Length==0 && yoneticiSifresi.Text.Length == 0)
            {
                yoneticiLabel.Text = "Tüm Alanları Doldurunuz!!";
            }

            else 
            {
                yoneticiLabel.Text = "Yanlış Giriş Yapıldı!!";
            }


        }

        private void yoneticiAdiSoyadi_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void yoneticiTemizleBtn_Click_1(object sender, EventArgs e)
        {
            // temizleme tuşu 

            yoneticiAdiSoyadi.Text = "";
            yoneticiSifresi.Text = "";
            yoneticiLabel.Text = "";
        }

        private void yoneticiGirisBtn_MouseHover(object sender, EventArgs e)
        {
            yoneticiGirisBtn.BackColor = Color.Lime;
            
        }

        private void yoneticiGirisBtn_MouseLeave(object sender, EventArgs e)
        {
            yoneticiGirisBtn.BackColor = Color.White;
           
        }

        private void yoneticiTemizleBtn_MouseHover(object sender, EventArgs e)
        {
            yoneticiTemizleBtn.BackColor = Color.Lime;
        }

        private void yoneticiTemizleBtn_MouseLeave(object sender, EventArgs e)
        {
            yoneticiTemizleBtn.BackColor = Color.White;
        }

        private void ıconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
