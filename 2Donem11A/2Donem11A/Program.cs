using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _2Donem11A
{

    enum Gunler { pazartesi,salı,carsamba,perşebe,cuma,cumartesi,pazar}
    
    internal class Program
    {

        //partial Classes parçalı sınıflar

        partial class OkulOgrenci
        {
            public string Ad { get; set; }
        }

        partial class OkulOgrenci
        {
            public void BilgiYazdir()
            {
                Console.WriteLine($"Ogrenci : {Ad}");
            }
        }




        //mühürlü sınıflar 

        //Tanım: sealed anahtar kelimesi , bir sınıgın başka  sınıflar tarafından miras alınmasını engeller.
        //böylece sınıfın yapısı korunur.

        sealed class Ucak
        {
           public void Sur()
            {
                Console.WriteLine("Ucak sürülüyor.");
            }
        }
        

        


        //STATİK SINIFLAR ( STATİC CLASSES)

        static class Matematik
        {
            public static int Topla(int a, int b) => a + b;
        }







        //çOK BİCİMLİLİK (POLYmORPGİSM

        // Çok biçimlilik bir metodun farklı şekillerde uygulanabilmesini sağlar.Temel 
        //sınıftaki metotlar alt sınıflarda farklı işlevlerle değiştirilebilir(override)



        class Sekilll
        {
            public virtual void Ciz()
            {
                Console.WriteLine("Bir şekil çizildi");
            }
        }

        class Kare : Sekilll
        {
            public override void Ciz()
            {
                Console.WriteLine("Kare çizildi");
            }

        }



            //interface (arayüzler)

            interface ICalisan
            {
                void Calis();
            }


            class Programci : ICalisan
            {
                public void Calis()
                {
                    Console.WriteLine("Programcı kod yazıyor.");
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

                class Savasci : Kahramann
                {
                    public Savasci(string ad) : base(ad) { }

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

                class Muhendis : Calisan
                {
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

                class AkilliTelefon : Telefon3
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
                        Console.WriteLine("Merhaba " + ad);
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


                //Kahramann kahraman1 = new Savasci("Master Yi");
                //Kahramann kahraman2 = new Buyucu("Lux");

                //kahraman1.Saldir();
                //kahraman2.Saldir();

                //Buyucu buyucuKahraman = new Buyucu("Jinx");
                //buyucuKahraman.Saldir();


                #endregion


                #region Soyut Sınıflar (Abstract Classes)


                //Daire daire1 = new Daire();

                //daire1.RenkBelirle("kırmızı");
                //daire1.Ciz();




                //POLİMORFİZM

                //    Sekilll sekil1 = new Kare();
                //sekil1.Ciz();

                //int sonuc = Matematik.Topla(5, 12);
                //Console.WriteLine(sonuc);


                //isimsiz Sınıflar ( ANONYMOUS CLASSES=

                //var ogrencii = new { Ad = "ali", Yas = 15 };
                //Console.WriteLine($"Ad: {ogrencii.Ad}, yas= {ogrencii.Yas}");


                //mühürlü sınıfar örneği

                //Ucak ucak1 = new Ucak();
                //ucak1.Sur();

                //OkulOgrenci ogrenciokul=new OkulOgrenci();
                //ogrenciokul.BilgiYazdir();


                //Gunler bugun = Gunler.carsamba;
                //Console.WriteLine($"Bugun günlerde {bugun}");
                #endregion


                #region Diziler ve Koleksiyonlar (Arrays and Collections)

                //Diziler , aynı veri tipindeki birden fazla değer isaklamak için kullanılan veri yapılarıdır.



                //Bir boyutlu dizi : en temel dizi türüdür ve belirli veri tipindeki elemanları tek sıra halinde saklmaka için kullanılır
                //                   Bu diziler indeksleme yöntemiyle elemanlara erişim sağları1

                int[] sayilar = new int[5];  // 5 elemanlı bir tamsayı dizisi oluşturan kod.


                //Bir boyutlu dizilerin oluşturulması


                int[] sayilar1 = new int[3];

                int[] sayilar2 = { 10, 20, 30, 59 }; // dizi elemanları tanımlama sırasında belirtilmiştir.

                int[] sayilar3 = new int[] { 10, 20, 50, 69, 70, 5043 }; //dizinin boyutu belirtilmeden değer atanmıştır.



                //Bir boyutlu dizilere değer aktarma 


                sayilar1[0] = 5;
                sayilar1[1] = 20;
                sayilar1[2] = 10;


                // Bir boyutlu dizi elemanlarına erişim

                //Console.WriteLine(sayilar2[3]);
                //Console.WriteLine(sayilar2[2]);
                //Console.WriteLine(sayilar2[1]);
                //Console.WriteLine(sayilar2[0]);


                //dongü ile erişmek için

                //for (int i = 0;i < sayilar2.Length; i++)
                //{
                //    Console.WriteLine(sayilar2[i]);
                //}





                // ÖRNEK


                //int[] notlar = { 60, 70, 80, 85, 90 };
                //int toplam = 0;

                //for (int i = 0; i < notlar.Length; i++)
                //{
                //    Console.WriteLine($"{i+1}. öğrencinin notu: {notlar[i]}");
                //    toplam = toplam+ notlar[i];

                //}

                //int ortalama = toplam / notlar.Length;

                //Console.WriteLine($"Sınıfın ortalaması: {ortalama}");



                // Dizilerde foreach döngüsü kullanımı

                //Dizi elemanlarıı sırasıyla alır ve her seferinde bir değişkene atayarak  işlemler yapmamozo sağlar

                //Tek tek elemanlara ulaşır
                // Dizinin boyutunu bilmenize gerek yok
                //elemanlara sadece okuma işlemi yaplılır.



                string[] meyveler = { "Elam", "Armut", "Muz", "kKiraz" };


                //foreach (string meyve in meyveler)
                //{
                //    Console.WriteLine(meyve);
                //}

                //Bir Boyutlu dizilerde kullanılan özellikler ve metotlar


                // Length : dizinin eleman sayısını verir.

                //Rank : Dizinin boyut sayısnı verir.

                int[] borclar = { 3, 7, 8, 9 };
                //Console.WriteLine("Eleman sayısı :" + borclar.Length);
                //Console.WriteLine("Dizinin boyut sayısı :" + borclar.Rank);

                //bazı metotlar
                // Array.Sort(dizi)  : diziyi küçükten büyüğe sıralar
                // 
                // Array.Reverse(dizi) : Diziyi tersine çevirir.
                // 
                // Array.IndexOf(dizi,değer) : Belirtilen değerin indeksini döner.
                //
                //Array.Clear(dizi,baslangıc,adet) : belirtilen yerden başlayarak elemanları sıfırlar.


                int[] klavye = { 7, 2, 9, 1 };

                //Array.Sort(klavye); // [1,2,7,9]
                //Array.Reverse(klavye); // [9,7,2,1]
                //int index = Array.IndexOf(klavye, 7); // 1
                //Array.Clear(klavye, 1, 2); // [9,0,0,1}



                ////sepetteki ürünler diziye eklenmiş
                //string[] sepet = { "Ekmek", "Süt", "Peynir", "Yumurta", "Çikolata" };

                //Console.WriteLine("Sepetinizdeki ürünler: ");

                //foreach(string urun in sepet) 
                //{
                //    Console.WriteLine("- "+urun);
                //}


                ////küöükten büyüğe alfabetik olarak sıralyıorum
                //Array.Sort(sepet);

                ////sıralanmıs halini ekrana yazdırdığım kod
                //Console.WriteLine("\n Alfabetik şekilde sıralanmış sepet listesi:");
                //foreach(string urun in sepet)
                //{
                //    Console.WriteLine("- " + urun);
                //}

                //Console.WriteLine($"\n Toplam Sepetteki ürün sayısı: {sepet.Length}");




                #endregion


                #region Çok Boyutlu Diziler

                //Tanım : Çok boyutlu diziler satır ve sütun yapısına sahip olan verileri tablo gibi saklayan dizi türleridir.


                int[,] tablo = new int[3, 2]; // 3 satır 2 sütundan oluşan dizi.

                int[,] notlar = new int[2, 3]; // 2 satır, 3 sutunluk dizi örneği

                int[,] matris =
                {
                    {10,20,30 },
                    {40,59,69 }
                };


                //iki boyutlu dizilerde diziye değer atama

                //yöntem 1: tek tek değer atama

                //notlar[0, 0] = 85;
                //notlar[0, 1] = 90;
                //notlar[1, 0] = 75;


                //// yöntem 2 : Tanımlarken değer verme

                //int[,] sinavNotlari =
                //{
                //    {85,90},
                //    {75,60}
                //};

                //// İki boyutlu dizi elemanlarına erişim

                //Console.Write(sinavNotlari[0,0]);
                //Console.Write(",");
                //Console.WriteLine(sinavNotlari[0,1]);
                //Console.Write(sinavNotlari[1,0]);
                //Console.Write(",");
                //Console.Write(sinavNotlari[1, 1]);


                //örnek 

                // senaryo olarak 2 öğrencinin 3 farklı sınav notunu saklayacak  bir sistem

                // - öğrencilerin notları 2 boyutlu dizide saklansın
                // notlar tablo gibi görünsün
                //Ortalamalar hesaplansın. Not

                int[,] notlar1 =
                {
                    {80,90,85 },
                    {70,60,75 }
                };


                // Console.WriteLine("Öğrenci Not Tablosu:");
                // Console.WriteLine(" ");

                //for (int i = 0; i < 2; i++)
                // {
                //     Console.Write("Öğrenci"+(i+1)+" :  ");

                //     int toplam = 0;


                //     for (int j = 0; j < 3; j++)
                //     {
                //         Console.Write(notlar1[i,j]+" ");
                //         toplam += notlar1[i, j];
                //     }

                //     double ortalama = toplam / 3.0;
                //     Console.WriteLine($"=>   Ortalama: {ortalama:F1}");

                //}

                //Örnek 2 Sinema salonu koltuk rezervasyon sistemi

                //Sinema salonu 3 sıra 4 er koltuktan oluşmaktadır.
                // Boş koltuklar 'O' harfiyle Dolu koltuklar ise 'X' harfiyele gösterilecektir.
                // kullanıcıya çıktı verilecek



                //char[,] koltuklar = new char[3, 4]; // 3 sıra 4 er koltuktan oluşan 3x4 bir dizi oluşturduk

                //for (int i = 0; i < 3; i++) //satırları yani sıra numaralarını belirtir.
                //{
                //    for (int j = 0; j < 4; j++) //sutunları ( koltuk numaralarını gösterir
                //    {
                //        koltuklar[i, j] = 'O';
                //    }

                //}

                ////rezerve edilen koltuklar
                //koltuklar[0, 1] = 'X';
                //koltuklar[1, 2] = 'X';
                //koltuklar[2, 3] = 'X';


                //// ekrana çıktı verelim.

                //Console.WriteLine("Gop OKULLARI SİNEMA SALONU \n");
                //for (int i = 0;i < 3; i++)
                //{

                //    Console.Write("Sıra " +(i+1)+": "); //sıra bilgisinin verildği yer

                //    for(int j = 0; j < 4; j++)
                //    {
                //        Console.Write(koltuklar[i,j]+" ");
                //    }

                //    Console.WriteLine();
                //}







                #endregion


                #region Koleksiyonlar

                //Koleksiyonlar(collections) esnek ve dinamik yapılardır.
                //Farklı veri türlerini saklamak yöetmek ve işlemek için kullanılır.


                //Boxing (kutulama) ve Unboxing ( Kutu açma)

                //Boxing: Bir değer tipini (örneğin int) object türüne dönüştürmektir.

                // unboxing: object türünden tekrar değer tioine  dönüştürülmesidir.


                //int sayi = 42;

                //object obj = sayi; //bocing işlemi örneğidir.

                //int YeniSayi = Convert.ToInt32(obj); //Unboxing işlemi örenğidir.


                ////Arraylist kullanımı




                //ArrayList liste=new ArrayList();

                //liste.Add(10);
                //liste.Add("Merhaba");
                //liste.Add(3.14);


                //foreach(var item in liste)
                //{
                //    Console.WriteLine(item);
                //}


                //List Koleksiyonu

                //List<string> sehirler = new List<string>();

                //sehirler.Add("Ankara");
                //sehirler.Add("İstanbul");
                //sehirler.Add("İzmir");

                //foreach( string sehir in sehirler)
                //{
                //    Console.WriteLine(sehir);
                //}


                //Queue (kuyruk) - Stack (yığın) koleksiyonları 


                //queue (kuyruk)

                // ilk giren, ilk çıkar ( FİFO ) (First in First out) mantığıyla çalışır.

                //Queue<string> kuyruk = new Queue<string>();

                //kuyruk.Enqueue("Ali");
                //kuyruk.Enqueue("Ayşe"); //enqueue fonksiyonu kuyruğa eleman eklemeye yarar.
                //kuyruk.Enqueue("Mehmet");


                //Console.WriteLine(kuyruk.Dequeue()); //dequeue fonksiyonu elemanı kuyuruktan çıkarır.
                //Console.WriteLine(kuyruk.Peek());
                //Console.WriteLine(kuyruk.Dequeue()) ;
                //Console.WriteLine(kuyruk.Peek()) ;



                //Stack (Yığın)

                //Son giren ilk çıkar mantığıyla yani LİFO mantığıla çalısır (last in First out)



                //Stack <string> yigin = new Stack<string>();

                //yigin.Push("Kitap 1");
                //yigin.Push("Kitap 2");
                //yigin.Push("Kitap 3");


                //Console.WriteLine(yigin.Pop());

                //Console.WriteLine(yigin.Peek());
                //Console.WriteLine(yigin.Pop());
                //Console.WriteLine(yigin.Peek());



                //Dictionary Koleksiyonları

                //key ve value yani anahtar değer ilişkisi vardır
                //herhangi bir sıra yoktur liste gibi
                //hızlı erişim özelliği

                //Dictionary<int,string> ogrenci= new Dictionary<int,string>();

                //ogrenci.Add(2709, "Fırat B");
                //ogrenci.Add(2708, "eymen B");


                //Console.WriteLine(ogrenci[2709]);
                //Console.WriteLine(ogrenci[2708]);



                //Hashtable Koleksiyonu
                //anahtar değer ikilisi verdır. Tip güvenliği yoktur.

                //Hashtable telefonRehberi = new Hashtable();
                //telefonRehberi.Add("Ahmet", "05395949494");
                //telefonRehberi.Add(123, "Nuamara");

                //Console.WriteLine(telefonRehberi[123]);



                //SortedList Koleksiyonu

                //anahtar değer çiftlerini anahtarlara göre sıralı tutar.

                //SortedList sinif = new SortedList();

                //sinif.Add(3, "Mehmet");
                //sinif.Add(1, "ayşe");
                //sinif.Add(2, "ali");

                //foreach (DictionaryEntry entry  in sinif)
                //{
                //    Console.WriteLine($"{entry.Key}: {entry.Value}");
                //}


                //koleksiyon örnek

                //dizi kullanma mantığı

                string[] kitapTurleri = { "Roman", "Hikaye", "Bilim", "Tarih", "Cocuk" };
                Console.WriteLine("Kütüphane bulunan kitap türleri:");
                Console.WriteLine();

                foreach(string tur in kitapTurleri)
                {
                    Console.WriteLine("-"+ tur);
                }

                //liste kullanımı örneği

                List<string> KitapListesi = new List<string>() { "Sefiller", "Kürk Mantolu Madonna", "Suç ve Ceza" };


                // Dictionary Kullanımı Kitap numarası - kitap adı eşleşmesi

                Dictionary<int, string> kitapListesi = new Dictionary<int, string>()
                {
                    {1,"Sefiller" },
                    {2,"Kürk Mantolu Madonna" },
                    {3,"Suç ve CEza" }
                };

                //queue mantıgı : Ödünç alan öğrenciler sırayla

                Queue<string> oduncAlanlar=new Queue<string>();
                oduncAlanlar.Enqueue("Ahmet");
                oduncAlanlar.Enqueue("ayşe");
                oduncAlanlar.Enqueue("melih");

                //Stack yıgın mantıgı iade edilen kitaplar (son giren ilk çıkar)

                Stack<string> iadeListesi = new Stack<string>();

                iadeListesi.Push("Kürk mantolu madonna");
                iadeListesi.Push("Sefiller");

                //Hashtavle kullanımı kitap raf numarası eşleşmesi

                Hashtable raflar=new Hashtable();
                raflar["Sefiller"] = 101;
                raflar["Suç ve Ceza"] = 102;

                //sortedList: alfabetik sıralı kitap listesi

                SortedList sıralanmisKitaplar = new SortedList();
                sıralanmisKitaplar.Add("a101", "Anna Karenina");
                sıralanmisKitaplar.Add("B203", "Bir gün");
                sıralanmisKitaplar.Add("c110", "Cesur Bir Dünya");


                Console.WriteLine("\n Kütühanedeki Kitap listesi:");
                foreach(var kitap in kitapListesi)
                {
                    Console.WriteLine($"Kitap NoÇ: {kitap.Key}, Adı: {kitap.Value}");


                }
                Console.WriteLine("\n Ödünc lanlar sırası (queue)");
                foreach(var ogrenci in oduncAlanlar)
                {
                    Console.WriteLine("- "+ogrenci);
                }

                Console.WriteLine("\n En son iade edilen kitap :" + iadeListesi.Peek());
                Console.WriteLine("\nKitap - Raf eşleşmesi (Hashtable):");
                foreach (DictionaryEntry raf in raflar)
                {
                    Console.WriteLine($"{raf.Key} kitabı, {raf.Value} numaralı rafta.");
                }

                Console.WriteLine("\nAlfabetik Kitap Listesi (SortedList):");
                foreach (DictionaryEntry kitap in sıralanmisKitaplar)
                {
                    Console.WriteLine($"{kitap.Key}: {kitap.Value}");
                }

                
            
        



            #endregion
            Console.ReadLine();
                }
            }
        }
    }
