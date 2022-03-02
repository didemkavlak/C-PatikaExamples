
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While
            //1'den başlayarak kullanıcıdan alınan sayıya kadar olan toplamı yazma(alınan sayı dahil)

            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
                Console.WriteLine(toplam);
            }
            Console.WriteLine(toplam/sayac);

            //'a'dan 'z'ye kadar olan harfleri yazdır.

            char character = 'a';

            while (character <= 'z')
            {
                Console.Write(character);
                character ++;

            }

            // ForEach

            string[] markalar = {"Koton", "Mango", "Zara", "İpek Yol"};

            foreach (var marka in markalar)
            {
                Console.WriteLine(marka);
            }

        }
    }
}