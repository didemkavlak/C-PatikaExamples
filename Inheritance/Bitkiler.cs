using System;

namespace MyApp 
{
    public class Bitkiler:Canlilar // Bitkilerin canlılar sınıfından kalıtım aldığını belirttik.
    {
        protected void Fotosentez() //Sadece kalıtım verdiği sınıflar tarafından erişilebiilmesi için protected erişim belirteci kullanılır. Bu durumda program.cs bu metoda erişemez. Bunun önüne geçmek içinde de Kalıtım verilecek sınıfta based ile yeni kurucu metot oluştururuz.
        {
            Console.WriteLine("Yeşil bitkiler fotosentez yapabilir.");
        }
    }

    // Bitkilerin miras verdiği sınıfları tanımlayalım.

    public class TohumluBitkiler:Bitkiler // Tohumlu bitkilerin bitkiler sınıfından kalıtım aldığını belirttik.
    {
        public TohumluBitkiler(){ //kurucu içerinde base ile üst sınıf metotlarına erişim imkanı sağlar. Üst sınıf sınırı yoktur. 2 üst sınıftan da kalıtım almışsa kurucu metot içinde base kullanılarak erişim sağlanır. Böylece her kurucu çağırıldığında aşağıdakiler default çağrılacak ve tek tek yazmaya gerek kalmayacak.
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }
        public void TohumlaCogalma(){
            Console.WriteLine("Tohumlu bitkiler tohumla çogalır.");
        }
    }

    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler(){// kurucu içerisinden base ile üst sınıfa erişme
            base.Fotosentez();
            base.Beslenme();
            base.Solunum();
            base.Bosaltım();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }
}