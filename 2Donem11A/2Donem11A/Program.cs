using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2Donem11A
{
    internal class Program
    {


        class Savasci: Kahramann
        {
            public Savasci(string ad):base(ad) { }

            public override void Saldir()
            {
                Console.WriteLine($"{Ad} , kılıç salladı");
            }
        }


        class Buyucu : Kahramann
        {
            public Buyucu(string ad) : base(ad) { }

            public new void Saldir()
            {
                Console.WriteLine($"{Ad} , büyü yaptı !!!!!");
            }
        }
        class Yazilimci : Calisan
        {
            public override void Calis()
            {
                Console.WriteLine("Yazılımcı kod yazıyor");

            }
        }

        class Muhendis : Calisan {
            public override void Calis()
            {
                Console.WriteLine("Mühendis proje çiziyor.");

            }
        }

        class Telefon3
        {
            public void AramaYap()
            {
                Console.WriteLine("Numara Aranıyor.");
            }
        }

        class AkilliTelefon:Telefon3
        {
            public new void AramaYap()
            {
                Console.WriteLine("Whatsapp araması yapılıyor.");
            }
        }


        class Kedi : Hayvan
        {
            public void Miyavla()
            {
                Console.WriteLine("Miyav!");
            }
        }

        class Kopek : Hayvan
        {
            public void Havla()
            {
                Console.WriteLine("Hav Hav!");
            }
        }


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

        //class Telefon
        //{
        //    public string marka;
        //    public int pilSeviyesi;

        //    public Telefon (string markAdi)
        //    {
        //        marka = markAdi;
        //        pilSeviyesi = 100; //varsayılan şarj seviyesi
        //        Console.WriteLine($"{marka} telefonu açıldı. Pil {pilSeviyesi}%");
        //    }
        //}



        class Telefon2
        {
            public string marka;
            public Telefon2(string markAdi)
            {
                marka = markAdi;
                Console.WriteLine($"{marka} telefonu açıldı.");
            }

            ~Telefon2()
            {
                Console.WriteLine($"{marka} kapatıldı, hadıaz temizlendi");
                ;
            }
        }

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

            #region Yapıcı yıkıcı metotlar 

            //YAPICI ve yıkıcı METODLAR (constructor & destructor

            // Bir nesne oluşturduğumuzda bazı ayarları baştan yapmak isteriz. İşte yapıcı metotlar (constructorss bu işe yarar. Nesne kullanılmaz hale geldiğinde temizlenmesi gerekirse de yıkıcı metotlar ( destructor devreye girer.



            //yapıcı metotlar ( Constructors)

            //Telefon t1 = new Telefon("Samsung");
            //Telefon t2 = new Telefon("Xiaomi");


            //Telefon2 t1 = new Telefon2("Iphone");
            #endregion

            #region Değer ve Referans Tipler


            // referans kullanımı

            //void Degistir (ref int sayi)
            //{
            //    sayi += 10;

            //}

            //int x = 5;
            //Console.WriteLine(x);
            //Degistir(ref x);
            //Console.WriteLine(x);


            //void Hesapla(out int sonuc)
            //{
            //    sonuc = 100;
            //}

            //int notDegeri;

            //Hesapla(out notDegeri);
            //Console.WriteLine(notDegeri);


            //KONU ÖRNEĞİ

            ////savaşçının oluşturulduğu bölüm

            //Savasci savasci1 = new Savasci("Spider-man");

            ////gücünü artırma örneği referan kullanımıyla
            //savasci1.GucArtır(ref savasci1.Guc);

            ////canını öğrendiğimiz yer out kullanımı

            //int SimdikiCami;
            //savasci1.SaglikDurumu(out SimdikiCami);
            //Console.WriteLine($"{savasci1.Ad} şuanda  {SimdikiCami} ana  sahip");

            //savasci1.HasarAlma(30);
            //savasci1.HasarAlma(80);

            #endregion

            #region KALITIM (İNHERİTENCE)



            //Kedi kedi1= new Kedi();
            //kedi1.Ad = "Boncuk";
            //kedi1.SesCikar();
            //kedi1.Miyavla();

            //Kopek kopek1=new Kopek();
            //kopek1.Ad = "karabaş";
            //kopek1.SesCikar();
            //kopek1.Havla();



            // HİYERARŞİK KALITIM ( HİERARCHİCAL INHERİTANCE)

            //Araba2 araba1 =new Araba2();
            //araba1.HareketEt();
            //araba1.camAc();

            //Motosiklet motor1= new Motosiklet();
            //motor1.HareketEt();
            //motor1.TekTekerSur();


            //new operatörüyle metot gölgeleme(shadowing)

            //Telefon3 eskiTelefon= new Telefon3();
            //eskiTelefon.AramaYap();

            //AkilliTelefon yeniTelefon = new AkilliTelefon();
            //yeniTelefon.AramaYap();

            //Telefon3 telefon = new AkilliTelefon();
            //telefon.AramaYap();


            //Calisan calisan1= new Yazilimci();
            //calisan1.Calis();
            //Calisan calisan2 = new Muhendis();
            //calisan2.Calis();


            Kahramann kahraman1 = new Savasci("Master Yi");
            Kahramann kahraman2 = new Buyucu("Lux");

            kahraman1.Saldir();
            kahraman2.Saldir();

            Buyucu buyucuKahraman = new Buyucu("Jinx");
            buyucuKahraman.Saldir();


            #endregion
            Console.ReadLine();

        }
    } 
}
