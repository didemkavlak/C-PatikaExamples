using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // out parametre, bir işlem yaptırıp bunu kullanmak istersek out kullanılır.
            // string olarak verilen sayının int.'a doğru parse edilip edilmediğini kontrol edelim.
            // TryParse ile sayıyı çevirip çeviremediğine bak çevirebiliyorsa int outsayi ile geri dön.

            string sayi = "999";
            // int outsayi; // dışarıda da tanımlayabilirsin.

            bool sonuc = int.TryParse(sayi ,out int outsayi);
            if (sonuc) Console.WriteLine("işlem başarılı:  " + outsayi);
            else Console.WriteLine("işlem başarısız");

            //instances yaratma

            Metotlar instance = new Metotlar();

            instance.Topla(2,3, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            // Overloading : Fonksiyonun imzasını değiştirerek o fonksiyonu birden fazla kez kullanma. Metot imzasına göre karar verir.
            // Metot İmzası: metotAdı + parametreSayisi + parametreTipleri (üçü aynı ise izin vermez.

            int ifade = 111;

            instance.EkranaYazdir(ifade);

            instance.EkranaYazdir("Didem ", "Kavlak ", "Gedik");

        }
    }

    class Metotlar
    {
        public void Topla(int b, int c, out int toplam) // toplama set ettiğimiz için return'e gerek kalmadı.
        {
            toplam = b + c;
        }

        //overloading
        // Aşağıdaki fonksiyonun hem string hem int parametresi olabilir durumda oldu.
        public void EkranaYazdir (string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir (int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir (string veri1, string veri2, string veri3)
        {
            Console.WriteLine(veri1 + veri2 + veri3);
        }
    }
}
