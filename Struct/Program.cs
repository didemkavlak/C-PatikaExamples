using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class'lar referans(head'de tutulur) tipinde iken, struct'lar değer(stack'de tutulur) tipindedir.
            // Class'de inition değerleri kendi atama yapanilrken(int görünce 0 vermek gibi), Struct Bu değerleri atayamaz.

            Dikdörtgen dikdörtgen = new Dikdörtgen();
            dikdörtgen.KısaKenar = 3;
            dikdörtgen.UzunKenar = 4;

            Console.WriteLine("Dikdörtgen Alanı: {0}", dikdörtgen.AlanHesapla());

            //Dikdörtgen_Struct dikdörtgen_struct = new Dikdörtgen_Struct();
            Dikdörtgen_Struct dikdörtgen_struct; // new yerine başka bir erişme şekli
            dikdörtgen_struct.UzunKenar = 3;
            dikdörtgen_struct.KısaKenar = 4;

            Console.WriteLine("Dikdörtgen Alanı: {0}", dikdörtgen_struct.AlanHesapla());

            Dikdörtgen_Struct dikdörtgen_struct_1 = new Dikdörtgen_Struct(4,6);
            Console.WriteLine("Dikdörtgen Alanı: {0}", dikdörtgen_struct_1.AlanHesapla());
        }
    }

    class Dikdörtgen
    {
        public int KısaKenar;
        public int UzunKenar;

        public  Dikdörtgen(){ //Kendimiz default belirleyebildik. Ancak bunu struck içerisinde yapamayız.
            KısaKenar = 5;
            UzunKenar = 6;
        }

        public long AlanHesapla(){
            return this.UzunKenar * this.KısaKenar;
        }
    }

    struct Dikdörtgen_Struct
    {
        public int KısaKenar;
        public int UzunKenar;

        public Dikdörtgen_Struct(int kısaKenar, int uzunKenar) // Bu kullanıma izin verir.
        {
           this.KısaKenar = kısaKenar;
           this.UzunKenar =  uzunKenar;
        }

        public long AlanHesapla(){
            return this.KısaKenar * this.UzunKenar;
        }
    }
}