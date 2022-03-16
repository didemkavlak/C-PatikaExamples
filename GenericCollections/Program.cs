using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T --> object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(7);
            sayiListesi.Add(25);
            sayiListesi.Add(99);
            sayiListesi.Add(55);
            sayiListesi.Add(48);
            sayiListesi.Add(3);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Mor");
            renkListesi.Add("Mavi");
            renkListesi.Add("Sarı");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.forEach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(23);
            renkListesi.Remove("Mor");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama
            if(sayiListesi.Contains(99))
                Console.WriteLine("99 liste içinde bulundu");

            //Eleman ile index'e erişim
            Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

            //Diziyi List'e çevirme
            string[] hayvanlar = {"Kediş", "Köpek", "Ördek", "Kuş"};
            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            //listeyi temizleme
            hayvanlarListesi.Clear();

            //List içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcılarListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1= new Kullanıcılar();

            kullanıcı1.Isım = "Ayşe";
            kullanıcı1.Soyisim = "Yılmaz";
            kullanıcı1.Yas = 30;

            Kullanıcılar kullancı2 = new Kullanıcılar();

            kullancı2.Isım = "Ali";
            kullancı2.Soyisim = "Yılmaz";
            kullancı2.Yas = 12;

            kullanıcılarListesi.Add(kullanıcı1);
            kullanıcılarListesi.Add(kullancı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar() {
                Isım = "Deniz",
                Soyisim = "Derya",
                Yas = 3,
            });

            foreach (var kullanıcı in kullanıcılarListesi)
            {
                Console.WriteLine("Kullanıcı Adı: " + kullanıcı.Isım);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı YAşı: " + kullanıcı.Yas);
            }
        }
    }
    public class Kullanıcılar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isım { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }


    }
}