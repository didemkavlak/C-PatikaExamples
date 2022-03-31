using System;

namespace arayüzler 
{
    //ILoggerdan miras aldırır çünkü bu interface'ın ne yapacağı ILogger içerisindedir.
    public class SmsLogger : ILogger //ILogger yazdıktan sonra implemente etmeyi unutma. İnteface metotları implemente edilmelidir.
    { 
        public void WriteLog()// implemente edilen kısım
        {
            //throw new NotImplementedException(); //Gövdenin tamamını kullanmana gerek yok ve boş bırakılabilir.
            Console.WriteLine("Sms olarak log yazar.");
        }
    }

}