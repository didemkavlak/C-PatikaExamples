using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan pozitif sayı al ve o kadar sayı girmesini iste
            Console.WriteLine("Kaç adet sayi girmek istrsiniz? : ");
            int adet = int.Parse(Console.ReadLine());
            int[] dizi = new int[adet];

            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine("Lütfen {0}.pozitif sayiyi giriniz: ", i+1);

                dizi[i] = int.Parse(Console.ReadLine());
                
            }

            foreach (var item in dizi)
            {
                if(item % 2 == 0){
                    Console.WriteLine(" Yazdığınız çift sayılar: " + item);
                }else
                {
                    Console.WriteLine("Çift sayı yer almamaktadır.");
                }
            }
            
            //İki adet sayı alıp karşılaştırma
            
            Console.WriteLine("Lütfen iki sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
    
            int[] yeniDizi = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen {0}. sayiyi giriniz: ",i+1);
                yeniDizi[i]=int.Parse(Console.ReadLine());
            }

            foreach (var item in yeniDizi)
            {
             if(item == m || item % m == 0)
                Console.WriteLine(item);  
            }
            

            // Tersten kelime yazdırma
            
            Console.WriteLine("Lütfen bir pozitif sayı giriniz: ");
            int arrayLength = int.Parse(Console.ReadLine());
            string[] kelimeDizisi = new string[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("{0}. kelimenizi giriniz: ",i+1);
                kelimeDizisi[i]= Console.ReadLine();
                
            }

            Array.Reverse(kelimeDizisi);

            foreach (var kelime in kelimeDizisi)
            {
                Console.Write(kelime +" ");
            }

            
            //Kelime ve harf sayma
            
            Console.WriteLine("Lütfen bir cümle giriniz.");
            string sentence = Console.ReadLine();
            Console.WriteLine("Karakter sayısı: "+ sentence.countSentence().Length);
            Console.WriteLine("Kelime Sayısı: " + sentence.countCharacter());
            
        }
    }

    public static class islem {
        public static string countCharacter(this string param){

           string[] dizi = param.Split(" ");
           return string.Join("",dizi.Length);//kelime saydı         
        }

        public static string countSentence(this string param){

           string[] dizi = param.Split(" ");
           return string.Join("",dizi);//kelime saydı         
        }
    }
}