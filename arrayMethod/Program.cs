using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //sort
           int[] sayiDizisi = {22,07,04,20,21,17,14,12};

           Console.WriteLine("****Sırasız Sayı Dizisi****");
           foreach (var sayi in sayiDizisi)
           {
               Console.WriteLine(sayi);
           }

           Console.WriteLine("****Sıralı Sayı Dizisi****");
           Array.Sort(sayiDizisi); //Void fonksiyon olduğu için verilen dizi üzerinde küçükten büyüğe sıralama yapar.

           foreach (var sayi in sayiDizisi)
           {
               Console.WriteLine(sayi);
           }

           //Clear
           Console.WriteLine("****Array Clear****");
            // sayiDizisi elemanları kullanılarak 2. indexten itibaren 3 tane elemanı 0'lar.
           Array.Clear(sayiDizisi,2,3);

           foreach (var sayi in sayiDizisi)
           {
               Console.WriteLine(sayi);
           }

           //Reverse
           Console.WriteLine("****Array Reverse****");

           Array.Reverse(sayiDizisi); // Tersine çevirme işlemi, ilk elemanı son eleman yapar.

           foreach (var sayi in sayiDizisi)
           {
               Console.WriteLine(sayi);
           }

           //IndexOf
           Console.WriteLine("****Array IndexOf****");
           // Verdiğiniz elemanın eğer içinde varsa indexini döner.

           Console.WriteLine(Array.IndexOf(sayiDizisi, 20));

           //Resize
           Console.WriteLine("****Array Resize****");
           //Yeniden boyutlandırma yapar.
           
           Array.Resize<int>(ref sayiDizisi, 9);

           sayiDizisi[8] = 3;

           foreach (var sayi in sayiDizisi)
           {
               Console.WriteLine(sayi);
           }
           
             
        }
    }
}
