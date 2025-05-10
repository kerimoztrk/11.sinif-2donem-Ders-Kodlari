using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifreKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = "gopokulları11a@hotmail.com";
            string sifre = "11a_11a";


            string giris = textBox1.Text;
            string kullanininGirdigiSifre= textBox2.Text;


            if (kullaniciAdi == giris & sifre == kullanininGirdigiSifre)
                MessageBox.Show("Giriş Yapıldı. Hem kullanıcı adı Hem de şfre doğrudur.");
            else
                MessageBox.Show("Hatalı kullanıcı adı veya hatalı şifre Tekrar Deneyiniz.");
        }
    }
}
