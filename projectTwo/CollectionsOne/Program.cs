using System;
using System.Collections;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Lütfen 20 adet pozitif tam sayı giriniz.");
            

            ArrayList asalListe = new ArrayList();
            ArrayList liste = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
               
                Console.WriteLine("Lütfen {0}.pozitif sayiyi giriniz: ", i+1);
                int input = Convert.ToInt32(Console.ReadLine());

                if(IsPrime(input))
                {
                    asalListe.Add(input);
                }
                else
                {
                    liste.Add(input);
                }

            }

            
            // Sorts the values of the ArrayList.
            liste.Sort();
            asalListe.Sort();

            int counter = 0;
            int counter1 = 0;
            foreach (var item in liste)
            {
                counter += Convert.ToInt32(item);
                Console.WriteLine("asal olmayan sayılar : " + item );
            }

            Console.WriteLine("Eleman Sayısı: " + liste.Count + " Ortalama: " + counter/liste.Count);

            foreach (var asal in asalListe)
            {
                counter1 += Convert.ToInt32(asal);
                Console.WriteLine("asal sayılar: " + asal );
            }
            Console.WriteLine("Eleman Sayısı: " + asalListe.Count + " Ortalama: " + counter1/asalListe.Count);
    

            // prime number or not
            static bool IsPrime(int number)
            {
                if (number <= 1) return false;
                if (number == 2) return true;
                if (number % 2 == 0) return false;

                var boundary = (int)Math.Floor(Math.Sqrt(number));
                    
                for (int i = 3; i <= boundary; i += 2)
                    if (number % i == 0)
                        return false;
                
                return true;        
            }
            
        }
    }
}