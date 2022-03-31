using System;

namespace MyApp 
{
    public class Canlilar{ //public sealed class Canlilar{} Sealed classlarla kullanılır ve kalıtım verilmesini engeller.

        protected void Beslenme(){
            Console.WriteLine("Tüm canlılar beslenir.");
        }

        protected void Bosaltim(){
            Console.WriteLine("Tüm canlılar boşaltım yapar.");
        }

        protected void Solunum(){
            Console.WriteLine("Tüm canlılar solunum yapar.");
        }

        //Virtual metot yazıp alt sınıflarda metot değiştireceğiz.
        //Bu sınıftan kalıtım alan alt sınıfta override ile o sınıfta kullanıp biçimini değiştirebileceğiz.
        // Hayvanlar alt sınıfından devam edelim.
        public virtual void UyaranlaraTepki(){
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }
}