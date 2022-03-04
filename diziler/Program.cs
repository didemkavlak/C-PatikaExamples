using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizileri tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedin", "Köpek", "Kuş", "Fare"};

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişme

            renkler[1] = "Mavi";

            dizi[3] = 10;

            Console.WriteLine(hayvanlar[3]);
            Console.WriteLine(renkler[1]);
            Console.WriteLine(dizi[3]);

            // Döngülerde dizi kullanımı
            // Klavyeden girilen n tane sayının ortalmasını hesaplayan program

            Console.Write("Lütfen dizi uzunluğunu giriniz: ");
            int diziUzunluğu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunluğu];

            for (int i = 0; i < diziUzunluğu; i++)
            {
                Console.Write("Lütfen {0}. diziyi giriniz: ", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
                
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            
            Console.WriteLine("Ortalama: " + toplam/diziUzunluğu);

        }
    }
}