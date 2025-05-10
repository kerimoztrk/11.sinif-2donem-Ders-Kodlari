using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2donemForm11A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3, ortalama;


            sinav1 = Convert.ToInt32(textBox1.Text);

            sinav2 = Convert.ToInt32(textBox2.Text);

            sinav3 = Convert.ToInt32(textBox3.Text);




            ortalama = (sinav1 + sinav2 + sinav3) / 3;


            MessageBox.Show("Ortalama= " + ortalama);


            if (ortalama > 50)
                label5.Text = "Geçti";
            else label5.Text = "Kaldı";
        }
    }
}
