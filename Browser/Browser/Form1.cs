using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gecko; // Gecko yu using olarak ekledik


namespace Browser
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox"); // Geckoyu başlatıcak firefox klasörünü belirttik. Projemizin içerisinde mevcut bu
        }
        

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void Geckowb_Navigated(object sender, GeckoNavigatedEventArgs e) 
        {
            
        }

        
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void pictureBox_refresh_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox_forward_Click(object sender, EventArgs e)
        {
       
        }

        private void pictureBox_back_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_go_Click(object sender, EventArgs e)
        {
           
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        private void pictureBox_gecmis_Click(object sender, EventArgs e) /// geçmiş panelini aç kapa
        {
        }

        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // Bu ProcessCmdKey her türlü ihtimalde klavyeden tuşa basıldığında çalışır.
        {
            
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void Mouse_Hover(object sender, EventArgs e)// Butonların üstüne gelince efekt veriyoruz
        {
            
        }
        private void Mouse_Leave(object sender, EventArgs e) // Butonların üstünden gidince 
        {
            
        }

        private void AraclarYeniSekmeClick(object sender, EventArgs e) // Araçlar kutusu yenisekme açma
        {
            
        }

        private void tümSekmeleriKapatClick(object sender, EventArgs e) // Araçlar kutusu sekme kapatma
        {
        }
        private void anasayfaOlsunClick(object sender, EventArgs e) // Araçlar kutusu anasayfa ayarlama
        {
            
        }
        
    }
}

