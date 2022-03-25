using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            class Ogrenci
                {
                    private string name; //field

                    public string Name //property
                    {
                        get { return name; }
                        set { name = value; }
                    }
                }
            */

            /*
            Aşağıdaki örnekte yaş olarak negatif bir değer atamasına engel olan property tanımını görebilirsiniz.

                class Person
                    {
                        private int age=0;
                        public int Age
                        {
                            get { return age; }
                            set {
                                if (value > 0)
                                age = value;
                            }
                        }
                    }
            */

            // Erişim belirleyiciler ile bir nesnenin özelliklerini, işlev veya metotlarını diğer classlardan ve nesnelerden korumak.
            // Property'leri kullanarak sınıfın üyelerini (feildlarını) koruyabiliriz.
            // Property'ler ise 'get' ve 'set'lerden oluşur. Yani property'lerle field'ı istedğimiz kadar erişilebilir yapıyoruz.

            Ogrenci ogrenci1 = new Ogrenci();

            ogrenci1.Ad = "Aslı";
            ogrenci1.Soyad = "Yıldırım";
            ogrenci1.OgrenciNo = 987;
            ogrenci1.Sınıf = 5;

            ogrenci1.OgrenciBilgileriniGetir();

            ogrenci1.sinifAtlat();
            ogrenci1.OgrenciBilgileriniGetir();


            Ogrenci ogrenci2 = new Ogrenci("Ahmet","Şimşk", 252 , 2);
            ogrenci2.OgrenciBilgileriniGetir();

            ogrenci2.sinifDusur();
            ogrenci2.sinifDusur();
            ogrenci2.sinifDusur();
            ogrenci2.sinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();

            


        }
    }

    class Ogrenci
    {
        private string ad; // Private değişkenleri küçük harfle başlatmak daha iyi. Ölçülü şekilde erişilebilir olmaları için public propertylerini benzer isimler oluşturalım.
        private string soyad; //CTRL + . ile kapsülle and use property olanı seçersen public olarak aşağı set ve get oluşacaktır.
        private int ogrenciNo;
        private int sınıf;

        public string Ad { get => ad; set => ad = value; } // get ile ismi return ederken set ile value atar.
        public string Soyad // Bu şekilde get ve set işlemlerinin birer metot old. görmüş olduk ve istersek bunları genişletebiliriz.
        {
            get {return soyad;}  
            set {soyad = value;} 
        }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sınıf //Fonksiyona çevirdik ve değerinin 1'den küçük olmamasını sağladık.
        {
            get => sınıf;
            set 
            {
                if(value < 1 )
                {
                    Console.WriteLine("Sınıf 1'den küçük olamaz.");
                    sınıf = 1;
                }
                else
                    sınıf = value;
            } 
        }

        //OverLoad
        //Kurucu (değer alan) // public popertyde CRTL + . Kullandık. Add parameter to constructor -> add to Ogrenci()
        public Ogrenci(string ad, string soyad, int ogrenciNo, int sınıf)
        {
            Ad = ad;
            Soyad = soyad;
            OgrenciNo = ogrenciNo;
            Sınıf = sınıf;
        }

        //OverLoad
        //Kurucu Boş
        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("*********Öğrenci Bilgileri Aşağıda Yer Almaktadır*********");
            Console.WriteLine("Oğrenci Adı:{0}", this.Ad); //Public property'ye eriştik.
            Console.WriteLine("Oğrenci Soyadı:{0}", this.Soyad);
            Console.WriteLine("Oğrenci Öğrenci No:{0}", this.OgrenciNo);
            Console.WriteLine("Oğrenci Sınıfı:{0}", this.Sınıf);
        }

        //Yardımcı Metotlar
        
        //Ogrenci sınıfı atlar
        //Set'tır olamsaydı biz sadece get (okuma) işlemi yapardık set (yazma) işlemi yapamazdık. Sadece okunmasını istediğin değişkenler için set kapatılır.
            public void sinifAtlat()
            {
                this.Sınıf = this.Sınıf + 1;
            }

        //Ogrenci sınıfı düşür
        // Sınıfın 1'den küçük olmamasını sağlamak için ve bunu her sınıf gördüğünde yapmak için burda değil Sınıf Property'si içerinde yapmak daha doğru olur.

            public void sinifDusur()
            {
                this.Sınıf = this.Sınıf - 1;
            }
    }
}