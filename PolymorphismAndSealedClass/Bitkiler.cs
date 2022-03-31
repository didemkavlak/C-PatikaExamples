using System;

namespace MyApp 
{
    public class Bitkiler:Canlilar{

        protected void Fotosentez(){
            Console.WriteLine("Kloroplast sahibi bitkiler fotosentez yapabilir.");
        }

        public override void UyaranlaraTepki(){
           // base.UyaranlaraTepki(); //Dilersek bunu yazdırmayabilliriz.Böylece biçimini değiştirmiş olduk.
            Console.WriteLine("Bitkiler güneşe tepki verir.");

        }
        
    }

    public class TohumluBitkiler:Bitkiler{

        public TohumluBitkiler(){
            base.Fotosentez();
            base.Solunum();
            base.Beslenme();
            base.Bosaltim();
            base.UyaranlaraTepki(); //Virtual tanımladığımız metodu nesnesi oluştuğunda çağırmak için buraya da eklemeliyiz.
        }

        public void TohumlaCogalma(){
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
    }

    public class TohumsuzBitkiler:Bitkiler{

        public TohumsuzBitkiler(){
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        
        public void SporlaCogalma(){
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }
}