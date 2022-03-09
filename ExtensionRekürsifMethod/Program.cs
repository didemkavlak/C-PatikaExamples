using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - Recursive
            // 3^4 = 3*3*3*3

            int result = 1;

            for (int i = 1; i < 5; i++)
                result = result * 3;
            Console.WriteLine(result);

            islemler instance = new(); // Bu şekilde de farklı class tanıtması yapabilirsin (instances oluşturma işlemi c# 9 ile beraber gelen bir özellik).

            int üsAlma = instance.expo(3,4);
            Console.WriteLine(üsAlma);
            // Yukardaki işlemi tek satırda yapmak istersen Console.WriteLine(instance.expo(3,4)); işe yarar.

            // Extension Metodlar
            
            string ifade = "Didem Kavlak Gedik";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if(sonuc)
                Console.WriteLine(ifade.removeWhiteSpaces());

            Console.WriteLine(ifade.becomeApperCase());
            Console.WriteLine(ifade.makeLowerCase());
            
            //int diziyi extension metot ile sıralayalım.

            int[] dizi = {0,8,9,5,3,1};
            //Dizi sıralama
            dizi.SortArray();
            
            //Dizi Ekrana Yazdırma
            dizi.EkranaYazdir();

            //Sayinin çift olup olmadığının kontrolü
            int sayi = 9;
            Console.WriteLine(sayi.IsEvenNumber());

            //Verilen string'in ilk karakterini alma
            Console.WriteLine(ifade.GetFirstChacater());

        }
    }

    public class islemler
    {
        public int expo (int sayi, int üs)
        {
            if(üs<2)
                return sayi;
            return expo( sayi, üs-1) * sayi;
        }

        //Yukarıda rekürsif fonk. nasıl çalışır.
        // expo (3,4)
        // expo (3,3) * 3;
        // expo (3,2) * 3 * 3;
        // expo (3,1) * 3 * 3 *3 ;
        // 3 * 3 * 3 * 3 = 3^4;  
    }

    // Extension metotlar ve classlar mutlaka Static olmalı!!! Çünkü nesnesi olmadan erişilebilir olmalı.
    
    public static class Extension{

        // Boşluk kontrolü yapan metot yazalım. İçinde boşluk varsa bize dönecek.
        public static bool CheckSpaces(this string param){ //Bu ifadeyi extension yapan 'this'dir.
           return param.Contains(" "); // Contains string kütüphanesinin metotdu.
        }

        //Boşluk varsa silen ya da farklı karakterle değiştiren başka bir extension metot yazalım.

        public static string removeWhiteSpaces(this string param){
            
            string[] dizi = param.Split(" "); // Dizi oluşturup splitle boşlukları belirle. split("*") yaparsak boşluları * ile değiştirir.
            return string.Join("",dizi); // Boşluk olmadan join ile birleştir.
        }

        // Verilen ifadeyi büyük harflerle yazalım.
        
        public static string becomeApperCase(this string param){
           return param.ToUpper();
        }

        // Verilen ifadeyi küçük harflerle yazalım.

        public static string makeLowerCase(this string param){
            return param.ToLower();
        }

        //int array sıralama
        public static int[] SortArray(this int[] param){
            Array.Sort(param); //Direk array metotlarını kullandık
            return param;
        }

        //int array'ı string olarak ekrana yazdırma
        public static void EkranaYazdir(this int[] param)
        {
            foreach (int item in param)
            Console.WriteLine(item);
        }

        //Verilen int. değerin çift olup olmadığını kontrol edelim.
        public static bool IsEvenNumber (this int param){
            return param%2 == 0;
        }

        //Verilen string'in ilk karakterini alma
        public static string GetFirstChacater(this string param){
            return param.Substring(0,5);
        }    

    }

}