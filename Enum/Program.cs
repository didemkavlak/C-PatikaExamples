using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"enum" anahtar kelimesi enumeration yani numaralandırma kelimesinden gelir. Sayısal verilerı string ifadelerle saklamanızı sağlar. Okunabilirliğe katkısı da tam olarak burdan gelir diyebiliriz.
            //Ardışık indexlerle çalışmak gerektiğinde kurtarıcı.
            /*

            enum Gunler 
                {
                    Pazartesi, 
                    Sali, 
                    Carsamba, 
                    Persembe, 
                    Cuma, 
                    Cumartesi, 
                    Pazar
                };

            */
            // Gunler.Pazartesi ifadesi ile Pazartesi'nin string ifadesine erişebiliriz. Eğer Pazartesinin 1. gün oldugu bilgisine ihtiyacımız varsa o da şu şekildedir: (int)Gunler.Pazartesi**

            Console.WriteLine(Gunler.Pazartesi);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık = 32;

            if( sıcaklık <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarı çıkmak için havanın soğumasını bekleyelim");
            else if( sıcaklık >= (int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarı çıkmak için çok sıcak bir gün");
            else if( sıcaklık >= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.CokSıcak)
                Console.WriteLine("Hadi dışarı çıkalım.");
        }
    }

    enum Gunler // Default 0'dan başlar
    {
        Pazartesi = 1, //1 ile başlattık
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi, // Pazartesi = 1 iken int olarak bize 6 döner. Arada cumayı değiştirirsek sonuç 24 olur.
        Pazar,
    }

    //Sık kullanılan sabit değişkenleri tutmak için kullanırız.
    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        CokSıcak = 30,
    }

}