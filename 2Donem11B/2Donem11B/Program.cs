using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2Donem11B
{

    enum Gunler { Pazartesi,Sali,Çarsamba,Perşembe,Cuma,Cumartesi,Pazar}
    internal class Program
    {



        //Parçalı Sınıflar( Partial Classes)

        //Tanım: partial anahtar kelimesi, bir sınıfın farklı dosyalarda tanımlanmasına olanak sağlar.
        //Büyük projelerde sınıfları bölmek için kullanılır.

        partial class OkulOgrenci
        {
            public string Ad { get; set;}
        }

        partial class OkulOgrenci
        {
            public void BilgiYazdir()
            {
                Console.WriteLine($"Ogrenci : {Ad}");
            }
        }

        //Mühürlü Sınıflar ( Sealed Classes)

        //Mührülü sınıflar sealed anahtar kelimesi ile bir sınıfın başka sınıflar tarafından miraas alınmasını engeller.
        //Bmylece sınıfn yapısı korunur.

        sealed class Ucak
        {
            public void Sur()
            {
                Console.WriteLine("Ucak sürülüyor");
            }
        }






        //Statik Sınıflar (STATİC CLASSES)

        static class Matematik
        {
            public static int Topla(int a, int b) => a + b;
        }



        //Arayüzler ( INTERFACES)

        interface ICalisan
        {
            void Calis();
        }


        class Programci:ICalisan
        {
            public void Calis()
            {
                Console.WriteLine("Programcı kod yazılıyor.");
            }
        }



        //polimorphisim

        class Sekil2
        {
            public virtual void Ciz()
            {
                Console.WriteLine("Bir şekil çizildi");
            }
        }
        class Kare : Sekil2
        {
            public override void Ciz() {
                Console.WriteLine("Kare çizildi");
            }
        }

        abstract class Sekil
        {
            public abstract void Ciz();

            public void RenkBelirle(string renk)
            {
                Console.WriteLine($"Şeklin rengi: {renk}");
            }
        }


        class Daire : Sekil
        {
            public override void Ciz()
            {
                Console.WriteLine("Daire Çizildi");
            }
        }


       




        class Telefon3
        {
            public void AramaYap()
            {
                Console.WriteLine("Numara aranıyor...");
            }

        }

        class AkilliTelefon : Telefon3
        {
            public new void AramaYap() //new anahtar kelimesi ile shadowing gölgeleme
            {
                Console.WriteLine("Whatsapp görüntülü arama yapılıyor.");
            }
        }

        class Kedi : Hayvan
        {
            public void Miyavla()
            {
                Console.WriteLine("Miyav!");
            }
        }

        class Kopek: Hayvan
        {
            public void Havla()
            {
                Console.WriteLine("Hav hav!!");
            }
        }

        //class Telefon
        //{
        //    public string marka;
        //    public int pilSeviyesi;


        //    //Yapıcı metot Constructor
        //    public Telefon(string markaAdi)
        //    {
        //        marka = markaAdi;
        //        pilSeviyesi = 100; //varsayılan pil seviyesi
        //        Console.WriteLine($"{marka} telefonu açıldı. Pil : {pilSeviyesi}%");
        //    }
        //}


        class Telefon2
        {
            public String marka;

            public Telefon2 (string markAdi)
            {
                this.marka = markAdi;
            }

            ~Telefon2()
            {
                Console.WriteLine($"{marka} kapatıldı., hafıza temizlendi.");

            }
        }


        //class Ogrenci
        //{
        //    public string Ad; // her yerden erişilebilri.
        //    private int Yas1; // Yalnızca sınıf içinde erişieblir.
        //    protected string Okul;  // Bu sınıf ve ondan türetilen sınıflar erişebilir
        //    internal string Numara;  // Aynı projedeki sınıflar erişebilir.
        //    public int Yas;
        //    public void BilgileriGoster()
        //    {
        //        Console.WriteLine("Ad:" + Ad);
        //        Console.WriteLine("Yas:" + Yas1);
        //        Console.WriteLine("Okul:" + Okul);
        //    }

        //}

        //class SinifAdi
        //{

        //}
         static void Yazdir(int sayi)
        {
            Console.WriteLine("Sayi = " + sayi);
        }
        static void Yazdir(string bilgi)
        {
            Console.WriteLine(bilgi);
        }
        static void Main(string[] args)
        {

            #region OOP Giriş
            //Dikdortgen ilkDikdortgen = new Dikdortgen(3,4);
            //Dikdortgen ikinciDikdortgen = new Dikdortgen(8, 6);

            //Console.WriteLine("Dikdotgen alanı:{0}", ilkDikdortgen.AlanHesapla());
            //Console.WriteLine("Dikdörgenin çevresi {0}", ilkDikdortgen.CevreHesapla()); 

            //Console.WriteLine("Dikdotgen alanı:{0}", ikinciDikdortgen.AlanHesapla());
            //Console.WriteLine("Dikdörgenin çevresi {0}", ikinciDikdortgen.CevreHesapla());



            //Kahraman kahraman1 = new Kahraman("SuperMAN", 5, 100);
            //Kahraman kahraman2 = new Kahraman("SpiderMAN", 7, 120);
            //Kahraman kahraman3 = new Kahraman("BatMAN", 10, 90);

            //kahraman1.BilgileriGoster();
            //kahraman2.BilgileriGoster();
            //kahraman3 .BilgileriGoster();



            //Araba araba1 = new Araba("Toyota");

            //araba1.Hizlan(20);
            //araba1.Yavasla(10);
            //araba1.BilgileriGoster();

            //Console.WriteLine(  );


            //açıklama  Erişim Belirleyiciler
            // public = Public olarak tanımlanan öğeler üzerinde herhangi bir kısıtlama yoktur. Her yerden erişilebilirdir.

            // private = En katı erişim belirleyicidir. Öğeler sadece tanımlandığı sınıf içinde erişilebilirir. Bir başka deyişle öğeler sadece tanımlandığı küme parantezleri arasında kullanılabilir.

            // protected = Öğeler, bulunduğu sınıf içinde yada vu sınıftan türeyen diğer sınıflarda erişilebilirdir.

            //internal = İnternal olarak tanımlanan öğeler sadece aynı program içinden erişilebilir.


            //public string AD;
            //private string ad;
            //protected string Ad;


            //Ogrenci MeteCirisoglu = new Ogrenci();
            //MeteCirisoglu.Ad = "Mete";
            //MeteCirisoglu.Yas = 17;

            //Ogrenci MeteCirisoglu1 = new Ogrenci();
            //MeteCirisoglu1.Ad = "Mete";
            //MeteCirisoglu1.Yas = 17;

            //Ucgen ucgen1 = new Ucgen();

            //ucgen1.A = -3;
            //ucgen1.B = 0;
            //ucgen1.C = -1232145;

            //Console.WriteLine("Üçgenin a kenar uzunluğu {0}", ucgen1.A);
            //Console.WriteLine("Üçgenin b kenar uzunluğu {0}", ucgen1.B);
            //Console.WriteLine("Üçgenin c kenar uzunluğu {0}", ucgen1.C);

            //Ucgen  cevreucgen =new Ucgen();

            //cevreucgen.A = 3;
            //cevreucgen.B = 4;
            //cevreucgen.C = 5;
            //Console.WriteLine("Üçgenin çevresi: {0}", cevreucgen.Cevre);
            #endregion


            #region methods
            //METOTLAR ( METHODS ) 

            // dönüş tiği: metodun dondüreceği değerin tiğini tanımlar (string,int vb)
            //değer döndürmek içinreturn anahtar kelimesi kullanılır. Eğer değer döndürülmeyecekse dnoüş tipi void olarak kullanılır.

            // metodun adı ve parametre listesi METODUN İMZASI olarak adlandırılır.



            //void SelamVer()
            //{
            //    Console.WriteLine("MERHABA");
            //}

            //SelamVer();
            //SelamVer();
            //SelamVer();

            //varsayılan değerli parametreler ( Optional Parameters)

            //void SelamVerrr(string isim = "Ziyaretçi ")
            //{
            //    Console.WriteLine("Merhaba, " + isim); ;
            //}

            //SelamVerrr();
            //SelamVerrr("Kerim");

            //İSİMLENDİRİLMİŞ PARAMETRELER (NAMED PARAMETERS)

            //void BilgiYaz(string isim, int yas)
            //{
            //    Console.WriteLine($"Ad: {isim}, Yaş: {yas}");
            //}

            //BilgiYaz("Adnan",20);
            //BilgiYaz(yas:20,isim:"Adnan");


            // PARAMETRE DİZİLERİ (PARAMS)


            //void SayilariTopla(params int[] sayilar)
            //{
            //    int toplam = 0;

            //    foreach (int sayi in sayilar)
            //    {
            //        toplam += sayi;
            //    }
            //    Console.WriteLine("Toplam = " + toplam); ;
            //}


            //SayilariTopla();
            //SayilariTopla(1,2,3);
            //SayilariTopla(1, 2, 3, 4, 5, 6, 123, 213, 213, 213, 231, 2213, 231, 213, 2321, 132);


            // Metodu Sonlandırma (Return)

            //int KareAl(int sayi)
            //{
            //    return sayi * sayi;
            //}

            //KareAl(12);

            //int sonuc = KareAl(12);
            //Console.WriteLine(sonuc);


            //Metodun aşırı yüklenmesi ( Method Overloads)

            //Aynı isimde, fakat farklı parametrelerle birden fazla metot olabilir.
            //Buna aşırı yükleme (overloading) denir.


            //Yazdir("baha");

            //Yazdir(12);
            #endregion




            #region YAPICI VE YIKICI METOTLAR (Constructors) and (Destructors)

            //Sııflar çalışırken, bir nesne oluşturdugumuzda bazı ayarları baştan yapmak isteriz.
            //yapıcı metotlar (consructor) bu iğşe yarar.

            //Nesne kullanılmaz hale geldiğinde temizlenmesi gerekirse de yıkıcı metotlar( destructor) devreyer girer.


            // Yapıcı Metotlar (Constructors)


            //Telefon t1 = new Telefon("Samsung");
            //Telefon t2 = new Telefon("Xiaomi");
            //Telefon r3 = new Telefon("Iphone");



            //Yıkıcı MEtotlar /destructors)

            //Telefon2 telefon1 = new Telefon2("Iphone");
            //// Nesne silindiğinde (çöp toplayıcı ( garbage Collector çalıştırında otomatik olarak hafızadan silinir.





            #endregion


            #region DEĞER Ve REFERANS TİPLER

            ////referans

            //void Degistir ( ref int sayi)
            //{
            //    sayi += 10;

            //}

            //int x = 5;
            //Degistir(ref x);
            //Console.WriteLine(x);

            //out kullanımı

            //void Hesapla(out int sonuc)
            //{
            //    sonuc = 100;
            //}

            //int notDegeri;
            //Hesapla(out notDegeri);
            //Console.WriteLine(notDegeri);

            //Konu örneği


            ////savaci oluşturma blmüm
            //Savasci savasci1 = new Savasci("Thor");

            //// gücünü artırma ornegi refereans kullanımıyla
            //savasci1.GucArtır(ref savasci1.Guc);

            ////canını öğrendiğimiz yer (out örneği)

            //int SimdikiCani;
            //savasci1.SaglikDurumu(out SimdikiCani);
            //Console.WriteLine($"{savasci1.Ad} şuanda  {SimdikiCani} cana sahip.");

            //// Hasar örneği hasar alma
            //savasci1.HasarAlma(30);
            //savasci1.HasarAlma(80);







            #endregion


            #region KALITIM (INHERITENCE)

            //Kedi kedi1 = new Kedi();
            //kedi1.Ad = "Garfield";
            //kedi1.SesCikar();
            //kedi1.Miyavla();


            //Kopek kopek1 = new Kopek();
            //kopek1.Ad = "Karabaşa";
            //kopek1.SesCikar();
            //kopek1.Havla();



            //HİYERARŞİK KALITIM ( HİERARCHİCAL İNHERİTANCE)

            //Araba2 arabam = new Araba2();
            //arabam.HareketEt();
            //arabam.CamAc();

            //Motosiklet motorum = new Motosiklet();
            //motorum.HareketEt();
            //motorum.TekTekerSur();



            //new operatoru ile metot Gölgeleme ( Shadowing)

            //Telefon3 eskiTelefon = new Telefon3 ();
            //eskiTelefon.AramaYap();

            //AkilliTelefon yeniTelefon= new AkilliTelefon ();
            //yeniTelefon.AramaYap();

            //Telefon3 telefon = new AkilliTelefon();
            //telefon.AramaYap();


            #endregion

            #region SOYUT SINIFLAR ( ABSTRACT cLASSES)

            //Daire daire =new Daire();


            //daire.Ciz();
            //daire.RenkBelirle("Kırmızı");



            //interfacce örnekleri

            //Programci programci = new Programci();
            //programci.Calis();


            //polimorphisimde kaldık.
            //Sekil2 sekillll = new Kare();
            //sekillll.Ciz();


            //int sonuc = Matematik.Topla(5, 12);

            //Console.WriteLine(sonuc);




            //İsimsiz Sınıflar ( Anonymous Classes) 

            //var ogrenci = new { Ad = "ali", Yas = 19 };

            //Console.WriteLine($" Ad: {ogrenci.Ad}, Yas: {ogrenci.Yas}");


            //mühürlü sınıflar

            //Ucak ucak1=new Ucak();
            //ucak1.Sur();


            //Parçalı Sınıflar

            //OkulOgrenci ogrenciOkul=new OkulOgrenci {Ad="Ahmet"};

            //ogrenciOkul.BilgiYazdir();




            //NUMARALANDIRMALAR (ENUMS)


            //Enum yapısı sabit değerleri gruplamak için kullanılır. Daha okunaklı ve yönetilebilir kod yazmayı sağlar.


            Gunler bugun = Gunler.Çarsamba;
            Console.WriteLine($"Bugun Günlerden {bugun}");

            #endregion

            Console.ReadLine();


        }
    }
}