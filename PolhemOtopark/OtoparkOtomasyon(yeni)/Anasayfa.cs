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
using System.Windows.Media;
using FontAwesome.Sharp;
using OtoparkOtomasyon_yeni_.Formlar;
using Color = System.Drawing.Color;

namespace OtoparkOtomasyon_yeni_
{
    public partial class Anasayfa : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;


        public Anasayfa()
        {

            // anasayfada tıklandığında buttonun yanında beliren minik işaretçi.

            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 75);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

        }

        private void OpenChildForm(Form childForm)
        {

            // Anasayfa ortasında butonlara tıklandığında yan formların açılmasını sağlar.

            if(currentChildForm != null)
            {
                currentChildForm.Close();   
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

           // homeLabel.Text = childForm.Text;


        }

        private void ActivateButton(object senderBtn, Color color)
        {

            // basılan anasayfa butonlarının aktif olduğunda değişimin kodlarıdır.

            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();

                IconBox1.IconChar = currentBtn.IconChar;
                IconBox1.IconColor = color;
            }
        }

        private void DisableButton()
        {

            //Başka bir butona tıklandığında önceki haline dönmesini sağlar.

            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private struct RGB
        {
            public static Color color = Color.Lime;
            
        }            


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
             
        }

        private void parkYerleri_Click(object sender, EventArgs e)
        {

            // Bu ve bunun aşağısında toplam 6 tane aynı olan kod tuşa basıldığında
            // yan formların açılmasını ve aktiflik değişimini sağlar 

            ActivateButton(sender, RGB.color);
            OpenChildForm(new parkYerleri());
                homeLabel.Text = "Park Yerleri";
            home.Enabled = true;
        }

        private void musteri_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGB.color);
            OpenChildForm(new musteri());
                homeLabel.Text = "Müşteri İşlemleri";
            home.Enabled = true;
        }

        private void Gelir_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGB.color);
            OpenChildForm(new gelir());
                homeLabel.Text = "Gelir";
            home.Enabled = true;
        }

        private void gecmis_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGB.color); 
            OpenChildForm(new gecmis());
                homeLabel.Text = "Geçmiş";
            home.Enabled = true;
        }

        private void Vale_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGB.color);
            OpenChildForm(new vale());
                homeLabel.Text = "Vale";
            home.Enabled = true;

        }

        private void acil_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGB.color);
            DisableButton();
           
               
            home.Enabled = true;
           
            MessageBox.Show("Acil Durum Ekipleri yolda!!");
            // Burada ambulansı, polisi ve itfayeyi aramakta ve lokasyonu söylemekte...
           
        }

        private void closingBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            reset();
            currentChildForm.Close();
        }       

        private void reset()
        {

            // Adı da üstünde olduğu gibi her şeyin anasayfaya dönmesini sağlayıp resetler.

            DisableButton ();
            leftBorderBtn.Visible = false;
            IconBox1.IconChar = IconChar.Home;
            IconBox1.IconColor = Color.Gainsboro;
                homeLabel.Text = "Anasayfa";
            

        }

        private void yoneticiGirisi_Click(object sender, EventArgs e)
        {
            home.Enabled = true;
            ActivateButton(sender, RGB.color);
            OpenChildForm (new yoneticiGirisi());
                homeLabel.Text = "Yönetici Girişi";
        }

        // Aşağıdaki kod windows kodlarıdır ve sürüklemeyi tam ekran yan ekran yapma gibi olayları mümkün kılar

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Anasayfa_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void closingBtn_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGB.color);
            Application.Exit();
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
            
            timer2.Start();
        }

        private void kucultmeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tarih.Text = DateTime.Now.ToString();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            if 
                (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
            

            
        }
    }
}
