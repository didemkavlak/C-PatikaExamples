using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try // Hata alması muhtemel ve kontrol etmek istediğiniz kod bloğu yer alır
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı:" + sayi1);
            }
            catch (Exception ex) // O hatayı aldığınızda yapmak istediğiniz şeyi yaparsınız.
            {
                Console.WriteLine("HATA: " + ex.Message.ToString());
            
            }
            finally // Koşuldan bağımsız çalışmasını istediğiniz kod. // Zorunlu bir alan değildir.
            {
                Console.WriteLine("İşlem tamamlandı");
            }
           
           // Özel exception tipleri

           try
           {
               // int a = int.Parse(null); // ArgumentNullException hatası döner
               //int a = int.Parse("test"); //FormatException hatası döner. Çünkü "test" string değerini int dönüştüremedi.
               int a = int.Parse("-20000000000"); // OverflowException hatası döner. Çünkü int değerleri dışında max. min değeri dışında bir değer girdiğimizde aldığımız hata.
           }
           // catch (ArgumentNullException ex) // Boş değer geldiğinde bu hatanın verildiğini biliyoruz.
           //{
               //Console.WriteLine("Boş değer girdiniz");
               //Console.WriteLine(ex); // Hatanın içeriğini görmüş olduk.
           //}
        //    catch (FormatException ex)
        //    {
        //        Console.WriteLine("Yanlış veri tipi girdiniz.");
        //        Console.WriteLine(ex);
        //    }
        catch (OverflowException ex)
        {
            Console.WriteLine("Çok büyük veya çok küçük bir değer girdiniz.");
            Console.WriteLine(ex);
        }

        }
    }
}
