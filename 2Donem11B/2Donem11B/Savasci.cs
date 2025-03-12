using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Donem11B
{
    internal class Savasci
    {
        public string Ad;
        public int Saglik;
        public int Guc;

        //Yapıcı metott (karakter oluşturulunca çalışır)

        public Savasci (string ad)
        {

            Ad = ad;
            Saglik=100;
            Guc = 10;
            Console.WriteLine($"{Ad} savaşa katıldıı. Can {Saglik} , Güç: {Guc}"); ;
        }

        public void GucArtır(ref int guc)
        {
            guc += 5;
            Console.WriteLine($"{Ad} güçlendi. Yeni güç: {guc}");
        }

        public void SaglikDurumu( out int saglik)
        {
            saglik = this.Saglik;
        }

        public void HasarAlma(int hasar)
        {
            Saglik -= hasar;
            Console.WriteLine($"{Ad}, {hasar}  hasar yedi ! Kalan Can : {Saglik}");
            if (Saglik <= 0)
            {
                Console.WriteLine($" {Ad} vefat etti!"); ;
            }
        }

        ~Savasci()
        {
            Console.WriteLine($"{Ad} savas alanından ayrıldı.");

        }

    }
}
