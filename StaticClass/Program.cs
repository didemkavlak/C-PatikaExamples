using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi); //Static nesnelere class ismiyle erişilebilir.

            Calisan calisan = new Calisan("Kudret", "Yıldırım", "iK"); //
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
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string ısim, string soyisim, string departman)
        {
            this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi ++;
        }

    }

    static class Islem
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