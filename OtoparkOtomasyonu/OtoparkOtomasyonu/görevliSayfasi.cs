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
    public partial class görevliSayfasi : Form
    {
        public görevliSayfasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Close();
                }

        private void button3_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
              

        }

        private void button6_Click(object sender, EventArgs e)
        {
           

        }

        private void button8_Click(object sender, EventArgs e)
        {
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(" Acil durum ekipleri yolda!!");
        }
    }
}
