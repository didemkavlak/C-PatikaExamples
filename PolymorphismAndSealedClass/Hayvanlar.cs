using System;

namespace MyApp 
{
    public class Hayvanlar:Canlilar{

        public void Adaptasyon(){
            Console.WriteLine("Hayvanların adaptasyon yeteneği vardır.");
        }

        public override void UyaranlaraTepki(){ //Override virtual işaretli sınıfları bulup getiriyor.
            base.UyaranlaraTepki(); //Sanal olarak yaratıldığı halde yaz.
            // Ek olarak yapmak istediklerim.
            Console.WriteLine("Hayvanlar temaasa tepki verir.");
        }
        
    }
    public class Surungenler:Hayvanlar{

        public Surungenler(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }

        public void SogukKanlı(){
            Console.WriteLine("Sürüngenler soğuk kanlı canlılardır.");
        }
    }

    public class Kuslar:Hayvanlar{

        public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }

        public void Ucmak(){
            Console.WriteLine("Kuşların tamamı olmasa da çoğu uçabilir.");
        }
    }
}