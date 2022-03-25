using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                class SinifAdi : Metot ve property(özelliklerden oluşabilir.)
                    {
                        [Erişim Belirleyici][Veri Tipi] ÖzellikAdı; //Property
                        [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler]) //Metot
                        {
                            //Metot Gövdesi
                        }
                    }
            */

            /*
                Erişim Belirleyiciler

                Erişim belirleyiciler önüne geldiği öğenin projenin nerelerinden erişilebileceğini belirler. Öğeleri korur gibi düşünebilirsiniz.

                1. Public : Her yerden erişilebilir.

                2. Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.

                3. Internal : Sadece bulunduğu proje içerisinden erişilebilir

                4. Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
            */

            //instance yaratma
            Calisan calisan1 = new Calisan();

            calisan1.Ad = "Ayşe"; //property tanımlama
            calisan1.Soyad = "Yılmaz";
            calisan1.No = 123456;
            calisan1.Departman = "İnsan Kaynakları";

            calisan1.CalisanBilgileri(); // Nesne aracılığı le popertylere erişilebildiği gibi metotlara da erişilebilir.

            Console.WriteLine("************");

            //Yeni nesne için yeni instance yaratılır
            Calisan calisan2 = new Calisan();

            calisan2.Ad = "John";
            calisan2.Soyad = "Smith";
            calisan2.No = 654321;
            calisan2.Departman = "Customer Support";

            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad; //Property
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri() // Method
        {
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
            Console.WriteLine("Çalışan Numarası:{0}",No);
            Console.WriteLine("Çalışan Depratman:{0}",Departman);
        }
    }
}