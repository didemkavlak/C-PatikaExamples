using System;
using System.Collections.Generic;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //system.collection.generic
            // Dictionary key, value şeklinde veri tipleri belirtilerek tanımlanır. value = değer, key = index ve bunlara ayrı ayrı erişilebilir.
            // Keyler unique olmak zorunda, compaliertime da hata vermezken runtime de hata döner.

            Dictionary<int, string> kullanıcılar = new Dictionary<int,string>();

            kullanıcılar.Add(10,"Ayşe Yılmaz");
            kullanıcılar.Add(12,"Ahmet Yılmaz");
            kullanıcılar.Add(18,"Derya Deniz");
            kullanıcılar.Add(20,"Ali Yılmaz");

            //Dizi Elemanlarına erişim
            Console.WriteLine("*** Elemanlara Erişim ***");

            Console.WriteLine(kullanıcılar[12]);

            foreach (var item in kullanıcılar)
                Console.WriteLine(item);
            
            //Count;
            Console.WriteLine("*** Count ***");

            Console.WriteLine(kullanıcılar.Count);

            //Contains
            Console.WriteLine("*** Contains ***");

            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Fatma Yılmaz"));

            //Remove
            Console.WriteLine("*** Remove ***");

            kullanıcılar.Remove(12);

            foreach (var item in kullanıcılar)
                //Console.WriteLine(item);
                Console.WriteLine(item.Value);// Sadece key ya da sadece value erişim sağlanabilir.
            
            //Keys
            Console.WriteLine("*** Keys ***");
            foreach (var item in kullanıcılar.Keys)
                Console.WriteLine(item);

            //Values
            Console.WriteLine("*** Values ***");
            foreach (var item in kullanıcılar.Values)
                Console.WriteLine(item);
        }
    }
}