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
    public partial class yöneticiSayfasi : Form
    {
        int Move;
        int Mouse_X;
        int Mouse_Y;


        public yöneticiSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void yöneticiSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void yöneticiSayfasi_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void yöneticiSayfasi_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void yöneticiSayfasi_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Acil durum ekipleri yolda!!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Eleman eleman = new Eleman();


            
        }
    }
}
