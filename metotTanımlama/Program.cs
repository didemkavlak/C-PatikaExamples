using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 2;
            int c = 3;
            Console.Write(b + c);

            // Same Class

            int sonuc = toplama(b,c);
            Console.WriteLine(sonuc);

            //Diffence Class

            Metotlar nesne = new Metotlar();
            nesne.EkranaYazdir(Convert.ToString(sonuc));

            // Use ref

            int sonuc2 = nesne.ArttırVeTopla(ref b, ref c);
            nesne.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));


        }

        static int toplama (int deger1, int deger2)
        {
            return deger1 + deger2;
        }
    }

    class Metotlar 
    {
        public void EkranaYazdir (string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla (ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}