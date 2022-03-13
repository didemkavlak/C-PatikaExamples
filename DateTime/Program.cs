using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DateTime

            Console.WriteLine(DateTime.Now); //  Tarih + saat
            Console.WriteLine(DateTime.Now.Date); // Tarih
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);


            Console.WriteLine(DateTime.Now.ToLongDateString()); // 13 Mart 2022 Pazar
            Console.WriteLine(DateTime.Now.ToShortDateString()); // 13.03.2022
            Console.WriteLine(DateTime.Now.ToLongTimeString()); // 23:22:46
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // 23:22

            Console.WriteLine(DateTime.Now.AddDays(3));
            Console.WriteLine(DateTime.Now.AddHours(4));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(2));
            Console.WriteLine(DateTime.Now.AddYears(5));
            Console.WriteLine(DateTime.Now.AddMilliseconds(60));

            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //13
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Sun
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Sunday

            Console.WriteLine(DateTime.Now.ToString("MM")); //03
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Mar
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //March

            Console.WriteLine(DateTime.Now.ToString("yy")); //22
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2022

            Console.WriteLine("*** Math Kütüphanesi ***");

            //Math Kütüphanesi

            Console.WriteLine(Math.Abs(-25)); //Mutlak değer
            Console.WriteLine(Math.Sin(30));
            Console.WriteLine(Math.Cos(45));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(22.3)); // Yukarı yuvarlar //23
            Console.WriteLine(Math.Round(22.3)); // .5'e göre: Hasas yuvarlar //22
            Console.WriteLine(Math.Round(22.7)); // .5'e göre: Hasas yuvarlar //23
            Console.WriteLine(Math.Floor(22.7)); //Aşağı yuvarlar //22

            Console.WriteLine(Math.Max(16,2)); //16
            Console.WriteLine(Math.Min(16,2)); //2

            Console.WriteLine(Math.Pow(3,4)); //3^4
            Console.WriteLine(Math.Sqrt(9)); //Karakök alma
            Console.WriteLine(Math.Log(9)); // 9'un e tabanındaki logaritmik karşığını getirir.
            Console.WriteLine(Math.Exp(2)); // e üzeri 2'yi verir.
            Console.WriteLine(Math.Log10(10)); // 10 sayısının log 10 tabanındaki karşılığı.


            
            




            
        }
    }
}