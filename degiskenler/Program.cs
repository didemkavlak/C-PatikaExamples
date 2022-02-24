// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Atama ve İşlemli Atama*");
            // Atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            Console.WriteLine("**Mantıksal Operatörler**");
            // Mantıksal operatörler
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Prefect!");

            if(isSuccess || isCompleted)
                Console.WriteLine("Great!");
            
            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine!");


            Console.WriteLine("**İlişkisel Operatörler**");
            // İlişkisel operatörler
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 5;

            bool sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            Console.WriteLine("**Aritmetik Operatörler**");
            // Aritmetik operatörler
            // /, *, +, -

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 - sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sayi1);

            // % : mod almak için kullanılır.
            int sonuc3 = 20 % 3;
            Console.WriteLine(sonuc3);
        }
    }
}
