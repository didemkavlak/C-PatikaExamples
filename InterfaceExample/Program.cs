using System;

namespace interface_ornek 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polo polo = new Polo();
            Console.WriteLine(polo.HangiMarka().ToString()); //enum olduğu için .ToString kullandık.
            Console.WriteLine(polo.KacTekerlek());
            Console.WriteLine(polo.AracRengi().ToString()); //Enum

            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.AracRengi().ToString());
            Console.WriteLine(corolla.KacTekerlek());
            Console.WriteLine(corolla.HangiMarka().ToString());
        }
    }
}