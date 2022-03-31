using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
            tohumluBitkiler.TohumlaCogalma();

            Console.WriteLine("******************");

            Surungenler surungenler = new Surungenler();
            surungenler.SogukKanlı();


            
        }
    }
}