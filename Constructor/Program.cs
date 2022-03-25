using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kurucu metotların isimleri class isimleriyle aynı olmalıdır.
            //Erişim belirleyicileri Public olmak zorunda
            //Geri dönüş tipleri yoktur, burada geri dönüş tipi yazmıyoruz.
            //Kurucu metotlar default olarak var olmasını istediğimiz durumlarda kullanılır.Yeni nesle oluştuğunda otonatik olarak çalışır.
            //Kurucu fonksiyonlar overload edilebilir.

            Calisan calisan1 = new Calisan("Elif","Yılmaz", 123456, "İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine("*********");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Aslı";
            calisan2.Soyad = "Deneme";
            calisan2.No = 654321;
            calisan2.Departman = "Muhasebe";
            calisan2.CalisanBilgileri();

            Console.WriteLine("*********");

            Calisan calisan3 = new Calisan("Mehmet","Can");
            calisan3.CalisanBilgileri();
            //Çıktısında no sıfır ve departman boş gelir. Çünkü biz değerleri atamadan önce arkda bu popertyler için stringse null, int 0 ve boolean ise false değer atanmış durumdadır.Bunları yazıdırınca da 0 ve boş değerler bize döndü.
            //Varsayılan Kurucu Metot
            //Her sınıfın biz tanımlamasakta bir tane kurucu metotu vardır. Buna varsayılan kurucu metot (default constructor) denir.
            //Default constructor'ın görevi sınıfın içerindeki özelliklere ilk değer ataması yapılmadığında onların default değerlerini set etmektir. Şöyle düşünebilirsiniz; sınıf içerisinde string veri tipinde bir özellik varsa ve siz ilk değer atamasını yapmazsanız varsayılan kurucu onun atamasını arka planda null olarak yapar. Aynı integer tipinde bir özelliğin ilk değer atamasını 0 olarak yapar.

           
        }
    }

    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

         //Nesneye değer atama işlemini kurucu fonk. ile yapalım. Refactor(iyileştirmek)
        public Calisan(string ad, string soyad, int no, string departman) //Kurucu Fonksiyon
        {
            //Ad = ad;
            this.Ad = ad; //Parametre tanımlama
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;

        }

        //OverLoad.
        //Önceki derste yazdıklarımız çalışabilsin diye nesne almayan aynı kurucu metodu burada yazdık.
        public Calisan(){}

        //OverLoad.
        //Sadece ad ve soyad ile çalışan oluşturabiliyor olmalıyım.Her zaman no. ya da departman belirli olmayabilir.
        public Calisan(string ad, string soyad){
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public void CalisanBilgileri(){
            Console.WriteLine("Çalışan adı: {0}", Ad);
            Console.WriteLine("Çalışan soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan No: {0}", No);
            Console.WriteLine("Çalışan Derpartman: {0}", Departman);
        }
    }
}
