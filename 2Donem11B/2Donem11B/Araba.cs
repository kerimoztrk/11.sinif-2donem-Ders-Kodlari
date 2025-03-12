using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Donem11B
{
    internal class Araba
    {
        private string marka;
        private int hiz;



        public Araba(string marka)
        {
            this.marka = marka;
            this.hiz = 0;
        }

        public void Hizlan(int miktar)
        {
            hiz += miktar;
            Console.WriteLine(marka + " hızlandı. Yeni Hızı   " + hiz);
        }


        public void Yavasla(int miktar)
        {
            hiz -= miktar;
            Console.WriteLine(marka + " yavaşladı. Yeni Hızı:    " + hiz);
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("Arabanın Markası: " + marka + " Hızı:   " + hiz);
            ;
        }




    }
}
