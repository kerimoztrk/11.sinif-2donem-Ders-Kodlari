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
            //yapıcı metotlar (consructor) bu işe yarar.

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


            //Gunler bugun = Gunler.Çarsamba;
            //Console.WriteLine($"Bugun Günlerden {bugun}");

            #endregion


            #region Diziler ( Arrays) ve koleksiyonlar ( Collections)

            // diziler aynı veri tipinde birden fazla değeri saklamak için kullanılan ver iyapılarıdı.

            //Bir Boyutlu Diziler


            int[] sayilar = new int[5];  // Buradaki örnek 5 elemanlı bir tamsayı(int) dizisi oluşturmuştur.


            //Bir boyutlu dizi oluşturma

            int[] sayilar1 = new int[3];

            int[] sayilar2 = { 10, 20, 30 };  // Burdaki kullaımda dizinin elemanları tanımlanırken belirlenmiştir.

            int[] sayilar3 = new int[] { 20, 30, 59, 600 };


            //Bir boyutlu dizilere değer aktarma

            sayilar1[0] = 15;
            sayilar1[1] = 10;
            sayilar1[2] = 20;


            //Bir boyutlu dizi elemanlarına erişim

            //Console.WriteLine(sayilar1[0]);
            //Console.WriteLine(sayilar1[1]);
            //Console.WriteLine(sayilar1[2]);



            //for (int i= 0; i< sayilar2.Length; i++)
            //{
            //    Console.WriteLine(sayilar2[i]);
            //}


            //int[] notlar = { 60, 70, 80, 90, 100 };

            //int toplam = 0;

            //for (int i = 0; i < notlar.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}. öğrencinin notu: {notlar[i]}");
            //    toplam = toplam+ notlar[i];
            //}


            //int ortalama= toplam /notlar.Length;
            //Console.WriteLine($" Sınıf ortalamsı : {ortalama}");



            //DİZİLERDE FOREACH DÖNGÜSÜ KULLANIMI

            //dizi elemanlarını sırayla alır ve bir değişkene atayarak işlemler yapmamızı sağlar.


            string[] meyveler = { "Elma", "Armut", "Muz", "Kiraz" };

            //foreach (string meyve in meyveler)
            //{
            //    Console.WriteLine(meyve);
            //}


            //foreach dongü özellikleri

            // elemanlara tek tek ve sırayla ulaşır.
            // dizinin boyutunu bilmeye gerek yok
            // elamannlara sadece okuma işlemi uygulanır, değiştirilmez.


            //Length : Dizinin eleman sayısını veri.
            //Rank : Dizinin boyut sayısını verir ( tek boyutluysa 1 döner)


            int[] ogrenciNot = { 222, 23, 7, 59 };

            //Console.WriteLine("elaman sayısı: "+ ogrenciNot.Length);
            //Console.WriteLine("dizin boyut sayısı: " + ogrenciNot.Rank);


            //Array.Sort(dizi) : Diziyi küçükten büyüğe dosğru sıralıyor

            //Array.Reverse(dizi) : Dizi tersine çevrilir.

            // Array.IndexOf(dizi,değer)  : Belirtilen değerin indeksini doner.

            //Array.Clear(dizi,baslangıc,adet) : Belirtilen konumdan başlayarak elemanları sıfırlar.


            //int[] dizi = { 7, 2, 9, 1 };



            //Array.Sort(dizi); // [1,2,7,9}

            //Array.Reverse(dizi); // [0,7,2,1]

            //int index = Array.IndexOf(dizi, 7); // 1

            //Array.Clear(dizi, 1, 2);  // [9,0,0,1]



            //örnek


            ////ürünler
            //string[] sepet = { "Ekmek", "Süt", "Peynir", "Yumurta", "Çikolata"};

            //Console.WriteLine("Sepetinizdeki ürünler :");

            ////foreach ile ürünleri ekrana yazdırıyorum
            //foreach (string urun in sepet)
            //{
            //    Console.WriteLine("- " + urun);
            //}

            ////ürünleri alfavetik sıralaıyor
            //Array.Sort(sepet);
            //Console.WriteLine(" ");
            ////sıralanmış elemanları yazdırmak içn aşağıdak ikoldarı yazalım

            //Console.WriteLine("Alfabetik olarak sepetimiz:");

            //foreach(string urun in sepet)
            //{
            //    Console.WriteLine("-" + urun);
            //}

            ////ürün sayısını gösterelim

            //Console.WriteLine(" ");
            //Console.WriteLine($"Toplam sepetteki ürün sayısı: {sepet.Length}");






            #endregion

            #region Çok Boyutlu Diziler


            // Tanım: Çok boyutlu diziler,satır ve sutun yapısına sahip olan içerisindeki verileri tablo gibi saklayan dizi türleridir.

            //int[,] tablo = new int[3, 2];   // 3 satır , 2 sutün dan oluşan çok boyutlu dizi tanımlama örneği


            ////iki boyutlu dizileri tanımlama örneklerimiz

            //int[,] notlar = new int[2, 3]; // 2satır, 3 sütundan oluşan dizi

            ////verileri tanımlama kısmı

            //int[,] matris =
            //{
            //    {10,20,30 },
            //    {40,50,60 }
            //};



            ////yöntem 1 tanımlama : Tek tek atama işleme
            //notlar[0,0] = 85;
            //notlar[0, 1] = 90;
            //notlar[1, 0] = 75;

            ////yöntem 2 tanımlama: Tanımlarken değer verme

            //int[,] sinavNotları =
            //{
            //    {85,90},
            //    {75,80}
            //};


            ////İki Boyutlu dizilerin elemanlarına erişim
            //Console.Write(sinavNotları[0,0]);
            //Console.Write(",");
            //Console.WriteLine(sinavNotları[0,1]);
            //Console.Write(sinavNotları[1,0]);
            //Console.Write(",");
            //Console.Write(sinavNotları[1,1]);





            //örnek 


            //örneğin senaryosu gereği 2 öğrencinin 3 farklı sınav notu olacak dizide saklanacak
            //notlar tablo gibi görünücek
            //her öğrencinin ortalamasını hesaplanacak

            int[,] notlar1 =
            {
                {80,90,86},
                {70,50,75}
            };

            //Console.WriteLine("Öğrenci Not Tablosu:");
            //Console.WriteLine(" ");

            //for (int i = 0; i < 2; i++) //öğrenciler burada yazdırılır.
            //{

            //    Console.Write("Öğrenci " + (i + 1) + ": ");

            //    int toplam = 0;


            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(notlar1[i, j] + " ");
            //        toplam += notlar1[i, j];
            //    }

            //    double ortalama = toplam / 3.0;
            //    Console.WriteLine($" Ortalama= {ortalama:F1}");


            //}




            //ÖRnek 2 : Sinemada koltuk rezervasyonu sistemi

            // sinema salonun 3 sıra ve 4 koltuk bulunmaktadır.
            //Boş koltuklar 'o' dolu koltuklar 'x' şeklinde gösterilsin.
            // en son kullanıca bilgi verilsin



            char[,] koltuklar = new char[3, 4];  //3 sıra 4 koltuk mantığıyla 3z4 bir dizi

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    koltuklar[i, j] = 'O';
                }
            }

            //bazı koltukları dolduralım

            koltuklar[0, 1] = 'X';
            koltuklar[1, 2] = 'X';
            koltuklar[2, 3] = 'X';


            Console.WriteLine(" Gop okulları Sinema koltuk Durumu:\n");


            for(int i = 0; i < 3; i++)
            {

                Console.Write("Sıra "+ (i+1)+":  "); //sıra bilgisi

                for (int j = 0; j < 4; j++)
                {
                    Console.Write(koltuklar[i,j]+" "); //koltuk durumu o harfiyle veya x harfiyle gösterildi.

                }
                Console.WriteLine(); // bir alt satıra geçnesini istiyruz.





            }


            





            #endregion

            Console.ReadLine();


        }
    }
}