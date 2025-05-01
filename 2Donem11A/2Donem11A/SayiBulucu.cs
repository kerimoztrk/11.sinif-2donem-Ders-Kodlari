using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Donem11A
{
    internal class SayiBulucu
    {
        public int BuyukOlaniBul(int sayi1, int sayi2)
        {
            int sonuc;
            if (sayi1 < sayi2)
                sonuc = sayi2;
            else
                sonuc = sayi1;

            return sonuc;
        }

    }
}
