using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2Donem11A
{
    internal class Program
    {


        //class SinifAdi
        //{

        //}
        //static void Yazdir(int sayi)
        //{
        //    Console.WriteLine("SAyi= " + sayi);
        //}

        //static void Yazdir(string bilgi)
        //{
        //    Console.WriteLine(bilgi);
        //}


        class Sinifim
        {
            public void Selamla(string ad = "Emre")
            {
                Console.WriteLine("Merhaba "+ad);
            }
        }
        


        static void Main(string[] args)
        {
            #region OOP Giris
            //Dikdortgen ilkDikdortgen = new Dikdortgen(3,4);
            //Dikdortgen ikinciDikdortgen = new Dikdortgen(5, 6);

            //Console.WriteLine("Dikdortgen alanı:{0}", ilkDikdortgen.AlanHesapla());
            //Console.WriteLine("Dikdörgenin çevresi: {0}", ilkDikdortgen.CevreHesapla());

            //Console.WriteLine("Dikdortgen alanı:{0}", ikinciDikdortgen.AlanHesapla());
            //Console.WriteLine("Dikdörgenin çevresi: {0}", ikinciDikdortgen.CevreHesapla());

            //Kahraman kahraman1 = new Kahraman("BATMAN", 10, 100);
            //Kahraman kahraman2 = new Kahraman("IRON MAN ", 14, 90);
            //Kahraman kahraman3 = new Kahraman("Fırat MAN", 99, 299);

            //kahraman1.BilgileriGoster();
            //kahraman2.BilgileriGoster();
            //kahraman3.BilgileriGoster();

            //Araba araba1 = new Araba("Toyota");

            //araba1.Hizlan(29);
            //araba1.Yavasla(10);
            //araba1.BilgileriGoster();

            //Ucgen ucgen1 = new Ucgen();
            //Ucgen ucgen2 = new Ucgen();
            //ucgen1.A = -3;
            //ucgen1.B = 0;
            //ucgen1.C = -1231241;

            //Console.WriteLine("Ucgenin a kenar uzunlugu {0}",ucgen1.A);
            //Console.WriteLine("Ucgenin b kenar uzunlugu {0}", ucgen1.B);
            //Console.WriteLine("Ucgenin c kenar uzunlugu {0}", ucgen1.C);


            //ucgen2.A = 3;
            //ucgen2.B = 4;
            //ucgen2.C = 5;


            //Console.WriteLine("Üçgenin çevresi {0}",ucgen2.Cevre);

            #endregion

            #region Metotlar
            //metotlar (methods)

            // dönüş tipi : Metodun döndüreceği değerein tipini tanımlar /int,string vb.
            // Değer döndürmek için return anahtar kelimesi kullanılır. Eğer değer döndürülmetecekse dönüş tipi void anahtar kelimesi kullanılır.

            // Metodun adı  ve parametre listesi METODUN İMZASI olarak adlandırlır.


            //void SelaöVer()
            //{
            //    Console.WriteLine("Merhbaa");
            //}

            //SelaöVer();
            //SelaöVer();
            //SelaöVer();


            //Varsayılan değerli parametreler (optional Parameters)


            //void SelamVerr(string isim = "Ziyaretçi")
            //{
            //    Console.WriteLine("Merhba ," + isim);
            //}

            //SelamVerr();
            //SelamVerr("eymen");


            // İSİMLENDİRİLMİŞ PARAMETRELER ( Named Parameters)

            //void BilgiYaz(string ad, int yas)
            //{
            //    Console.WriteLine($"Ad: {ad}, Yas {yas}");

            //}

            //BilgiYaz("Kerim", 23);

            //BilgiYaz(yas: 17, ad: "Demir");


            // PARAMETRE DİZİLERİ ( params)


            //void SayilariTopla(params int[] sayilar)
            //{
            //    int Toplam = 0;

            //    foreach ( int sayi in sayilar)
            //    {
            //        Toplam = Toplam + sayi;
            //    }
            //    Console.WriteLine("Toplam = "+Toplam);

            //}

            //SayilariTopla(1,2,3);
            //SayilariTopla(1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 123, 123, 123, 13,123,21312);


            //METODU SONLANDRMA (return)

            //int KareAl (int sayi)
            //{
            //    return sayi * sayi;
            //}

            //int sonuc = KareAl(12);
            //Console.WriteLine(sonuc);


            //metodun aşırı yüklenmesi ( METHOD OVERLOADS)

            // Aynı isimde, fakat farklı paramerelerle birden fazla metot olabilir.
            // Buna aşırı yükleme (overloading) denir.


            //Yazdir(12);
            //Yazdir("Fırat");


            //SayiBulucu sb = new SayiBulucu();

            //int a = 50;
            //int b = 75;
            //int sonuc = sb.BuyukOlaniBul(a, b);
            //Console.WriteLine("Büyük olan sayı: {0}",sonuc);


            //Sinifim s = new Sinifim();

            //s.Selamla();
            //s.Selamla("ishak");
            #endregion





            //YAPICI METODLAR





            Console.ReadLine();

        }
    } 
}
