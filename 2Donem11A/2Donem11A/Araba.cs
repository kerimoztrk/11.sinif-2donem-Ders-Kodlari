using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Donem11A
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
                Console.WriteLine(marka + " Gızlandı. Yeni hızı " + hiz);
            }
            public void Yavasla(int miktar)
            {
                hiz -= miktar;
                Console.WriteLine(marka + " Yavaşladı.. Yeni hızı " + hiz);
            }
            public void BilgileriGoster()
            {
                Console.WriteLine("Arabanın markası: " + marka + " Hızı = " + hiz);

            }


        }
}
