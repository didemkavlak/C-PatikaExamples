using System;
using System.Collections;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            ArrayList liste = new ArrayList();
            ArrayList maxListe = new ArrayList();
            
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz.", i+1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Smallest three numbers: " +  numbers[i]);
                liste.Add(numbers[i]);
            }

            int toplam = 0;
            int toplam1 = 0;

            foreach (var item in liste)
            {
                toplam += Convert.ToInt32(item);
            }
            Console.WriteLine("Average of smallest three numbers: " + toplam/liste.Count);


            for (int i = 19; i > 16; i--)
            {
                Console.WriteLine("Three largest numbers " + numbers[i]);
                maxListe.Add(numbers[i]);
            }

            foreach (var item in maxListe)
            {
                toplam1 += Convert.ToInt32(item);
            }

            Console.WriteLine("Average of largest three numbers: " + toplam1/maxListe.Count);

        }
    }
}