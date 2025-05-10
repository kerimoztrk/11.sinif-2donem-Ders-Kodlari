using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dortIslemHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;

            sayi1=double.Parse(textBox2.Text);

            sayi2= double.Parse(textBox3.Text);

            string secilenIslem=textBox1.Text;

            if (secilenIslem == "/")
                MessageBox.Show("BÖlme işleminin sonucu " + (sayi1 / sayi2));
            else if (secilenIslem == "*")
                MessageBox.Show("Çarpma işleminin sonucu " + (sayi1 * sayi2));
            else if (secilenIslem == "-")
                MessageBox.Show("Çıkarma işleminin sonucu " + (sayi1 - sayi2));
            else if (secilenIslem == "+")
                MessageBox.Show("Toplama işleminin sonucu " + (sayi1 + sayi2));
            else
                MessageBox.Show("Hatalı Giriş");

        }
    }
}
