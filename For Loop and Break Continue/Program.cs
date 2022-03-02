
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ekrana yazılan sayıya kadar olan tek sayıları alma
            Console.Write("Bir sayı giriniz:");
            int sonuc = int.Parse(Console.ReadLine());
            for (int i = 1; i < sonuc; i++)
            {
                if(i % 2 == 1){
                    Console.WriteLine(i);
                }
            }

            // 1 ile 1000 arasındaki çift ve tek sayıları kendi içlerinde toplama

            int tekToplam= 0;
            int ciftToplam = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if(i % 2 == 1)
                    tekToplam += i; // tekToplam = tekToplam + i;
                else
                    ciftToplam += i;
            }

            Console.WriteLine("Tek sayıların toplamı:" + tekToplam);
            Console.Write("Çift sayıların toplamı" + ciftToplam);

            //Keywords: Break: Döngüyü sonlandırmak için kullanılır, Continue: İstenilen aşamayı atlar.
            // Break: içinde olduğu loop sonlanır. İç içe 3 döngü old. düşünelim en içte yer alan döngüye break eklersen sadece o döngü çalışmaz, diğer iki döngü çalışmasını sürdürür.
            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                    break;  
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}