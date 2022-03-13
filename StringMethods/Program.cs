using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Dersimiz csharp, Hoş geldiniz!";
            string sentence1 = "CSHARP";

            //Length : Karakter sayısına erişim.
            Console.WriteLine(sentence.Length);
            Console.WriteLine(sentence1.Length);

            //ToUpper, ToLower
            Console.WriteLine(sentence1.ToLower());
            Console.WriteLine(sentence.ToUpper());

            //Concat: birleştirme işlemi yapar.(Birden fazla değer alabilir.)
            Console.WriteLine(string.Concat(sentence1, " öğreniyorum"));

            //Compare, CompareTo : 
            Console.WriteLine(sentence.CompareTo(sentence1)); //Eşit ise :0, Birinci değişken karakter sayısı > ikinci değişken karakter sayısı: 1, Birinci değişken karakter sayısı < ikinci değişken karakter sayısı:-1
            Console.WriteLine(string.Compare(sentence,sentence1,true)); //Büyük küçük harfe duyarsız. //0,1,-1
            Console.WriteLine(string.Compare(sentence,sentence1,false)); //Büyük küçük harfe duyarlı. //0,1,-1

            //Contains : İçerisinde olup olmadığını kontrol eder.
            Console.WriteLine(sentence.Contains(sentence1)); // True, False
            Console.WriteLine(sentence.EndsWith("geldiniz!")); // geldiniz! le bitiyor mu ?
            Console.WriteLine(sentence.StartsWith("Hellooo")); // Hellooo ile başlıyor mu ?

            //IndexOf: Bulamazsa -1 döner
            Console.WriteLine(sentence.IndexOf("Hoş")); // H'nin indexini döner.
            Console.WriteLine(sentence.IndexOf("Dido"));
            Console.WriteLine(sentence.LastIndexOf("e")); // Son indexdeki e'yi getirir.

            //Insert: verilen indexden başlayarak string'in başına verilen değeri ekler.
            Console.WriteLine(sentence.Insert(0,"Merhaba "));

            //PadLeft, PadRight
            Console.WriteLine(sentence + sentence1.PadLeft(30)); //String'in sol tarafa 30'a tamamlayacak kadar boşluk ekler. Karakter Sayısı + boşluk = 30 olur, Karakter sayısı 30'dan büyükse hiçbir ekleme yapmaz.
            Console.WriteLine(sentence + sentence1.PadLeft(30,'*')); //String'in sol tarafa 30'a tamamlayacak kadar * ekler.
            Console.WriteLine(sentence.PadRight(50) + sentence1);
            Console.WriteLine(sentence.PadRight(50,'/') + sentence1);

            //Remove: Silme
            Console.WriteLine(sentence.Remove(10)); // 10. indexden başlayarak sonuna kadar siler.
            Console.WriteLine(sentence.Remove(5,3)); //5. indexden başlar 3 karakter siler.
            Console.WriteLine(sentence.Remove(0,1)); //Baştaki karakteri sildi.

            //Replace : Değiştir
            Console.WriteLine(sentence.Replace("CSharp","C#"));
            Console.WriteLine(sentence.Replace(" ", "--"));

            //Split: 
            Console.WriteLine(sentence.Split(" ")[1]); // Boşluklara göre parçala, bir diziye ata ve 1. İndexi getir.

            //Substring
            Console.WriteLine(sentence.Substring(14)); // Verilen indexden başlayarak sonuna kadar getir.
            Console.WriteLine(sentence.Substring(4,9)); // Verilen indexden başlayarak 9 karakter getir.
        }
    }
}