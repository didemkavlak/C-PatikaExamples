using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Nesne içerinde Staic olmayan feildlara o sınıfta oluşturulan nesne aracılığıyla erişiyor.
            //static elemanlara is oluşturulan sınıfın adıyla erişiyoruz. sınıfAdı.Metot

            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi); //Static nesnelere class ismiyle erişilebilir.

            Calisan calisan = new Calisan("Kudret", "Yıldırım", "iK"); //static olmadığı için instance yaratmamız lazım.Public propertyleri yaratılmadığı için class içinden erişebiliyoruz.
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan1 = new Calisan("Ali", "Yılmaz", "İK");
            Calisan calisan2 = new Calisan("Mehmet", "Yıldırım", "İK");

            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi: {0}", Islem.Topla(500,250));
            Console.WriteLine("Toplama işlemi: {0}", Islem.Cikar(750,300));
        }
    }

    class Calisan
    {
        private static int calisanSayisi; //Static old.için class adıyla erişebiliyoruz.

        public static int CalisanSayisi { get => calisanSayisi; } //Çalışan sayısını sadece çalışan classı içinde erişilebilr kılmak için setter'ı kapattık.

        private string Isim; //Sadece kurucusundan erişilebilir nesneler yarattık.Public propertylerini yaratmadık
        private string Soyisim;
        private string Departman;

        static Calisan() //Static kurucu (Erişim belirteçleri yoktur.Public, private vs.). Yalnız bir defa çalışır
        { 
            calisanSayisi = 0; //Başlangıçta sıfır 
        }

        public Calisan(string ısim, string soyisim, string departman) //Kurucu // Her defasında çalışır.
        {
            this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi ++;
        }

    }

    static class Islem //Static class içindeki tüm elemanlar static olmalıdır.
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}