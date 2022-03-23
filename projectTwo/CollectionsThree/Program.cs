
using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

            Console.WriteLine("Bir cümle yazınız: ");
            string ifade = Console.ReadLine().ToLower();

            char[] vowels = {'a', 'e', 'i', 'ı', 'u', 'ü', 'o', 'ö'};
            List<char> charList =new List<char>();

            foreach (var item in ifade)
            {
                foreach (var vowel in vowels)
                {
                    if(item == vowel)
                        charList.Add(vowel);
                }
                
            }

            foreach (var lists in charList)
            {
                Console.WriteLine("Sesli Harfler:" + lists);
            }

            
            
        }
    }
}


