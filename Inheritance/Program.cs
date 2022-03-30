using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nesneler oluşturarak kalıtım alma yapısına bakalım.

            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler(); // Nesne oluşturduk.
            //tohumluBitkiler.Beslenme();// Nesnesi aracılıyla metotlarına erişelim
            //tohumluBitkiler.Bosaltım(); // Kurucu içerisinde base tanımı sayasinde her birini tek tek yazmaya gerek kalmadı.
            //tohumluBitkiler.Solunum();
            //tohumluBitkiler.Fotosentez(); // Erişim belirteçleri publicten protected yapıldıktan sonra bu şekilde erişilemez.
            tohumluBitkiler.TohumlaCogalma();

            Console.WriteLine("***********************");

            Surungenler surungenler = new Surungenler();
            //surungenler.Adaptasyon(); // Erişim belirteçleri publicten protected yapıldıktan sonra bu şekilde erişilemez.
            //surungenler.Beslenme();
            //surungenler.Bosaltım();
            //surungenler.Solunum();
            surungenler.SogukKanlı();

        }
    }
}