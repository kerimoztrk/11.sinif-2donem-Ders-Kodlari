using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;


            sayi1 = Convert.ToInt32(textBox1.Text);

            sayi2 = Convert.ToInt32(textBox2.Text);


            if (sayi1 != sayi2)
            {

                if (sayi1 > sayi2)
                    MessageBox.Show("Birinci sayi en büyük sayıdır.");
                else
                    MessageBox.Show("İkinci sayı en büyük sayıdır.");


            }
            else MessageBox.Show("Sayılar birbirine eşittir.");



        }
    }
}
