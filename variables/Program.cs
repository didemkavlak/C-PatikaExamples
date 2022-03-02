// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi giriniz");
            string name = Console.ReadLine();
            //Console.WriteLine("Soyisminizi giriniz");
            string name2 = Console.ReadLine();
            //Console.WriteLine(name + " " + name2);

            int deger ;
            //daha sonra atama yapılacak ise;
            //string deger = null 
            deger = 5;
            //Console.WriteLine(deger);

            byte b =5; //1 byte
            sbyte c = 10; //1 byte

            short s = 15; //2 byte
            ushort us = 20; //2 byte

            int i = 35; //4 byte
            Int16 i16 = 40; //2 byte
            Int32 i32 = 45; //4 byte
            Int64 i64 = 50; //8 byte

            uint ui = 55; //4 byte
            long l = 60; //8 byte
            ulong lu = 65; //8 byte

            //Reel sayılar
            float f = 70; //4 byte
            double d = 75; // 8 byte
            decimal de = 80; //16 byte

            char ch = 'a'; //2 byte
            string str = "name"; //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "a";
            object o2 = 'b';
            object o3 = 78;
            object o4 = 7.8;

            // String ifadeler
            string str1 = string.Empty;
            str1 = "your name";
            string ad = "your first name";
            string soyad = "your last name";
            string tamIssim = ad + " " + soyad;

            //integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 10;
            int integer3 = integer1 + integer2;

            //Değişken dönüşümleri

            string str20 = "20";
            int int20 = 20;

            string yeniDegisken = str20 + int20.ToString();
            Console.WriteLine(yeniDegisken); // çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // çıktısı 40

            int int22 = int20 + int.Parse(str20); // çıktısı 40 yalnızca string alır!!!!!

            //Datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            //Hour
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);


        }
    }
}