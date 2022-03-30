using System;

namespace MyApp 
{
    public class Hayvanlar:Canlilar // Hayvanların canlılar sınıfından kalıtım aldığını belirttik.
    {
        protected void Adaptasyon() //Sadece kalıtım verdiği sınıflardan erişilebilir olsun diye public erişim belirteci Protected yaptık
        {
            Console.WriteLine("Hayvanların adaptasyon yeteneği vardır.");
        }
       
    }

    // Hayvanların miras verdiği sınıfları tanımlayalım.
    public class Surungenler:Hayvanlar // ":" ile üstn sınıftan kalıtım alır.Sürüngen sınıfının hayvanlar sınıfından kalıtım aldığını belirttik.
    {
        public Surungenler(){ //Protected olan metoda erişm sağlamak için
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }
        public void SogukKanlı()
        {
            Console.WriteLine("Sürüngenler soğukkanlı canlılardır.");
        }
    }

    public class Kuslar:Hayvanlar
    {
        public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }
        public void Ucmak(){
            Console.WriteLine("Kuşlar uçabilir.");
        }
    }

}