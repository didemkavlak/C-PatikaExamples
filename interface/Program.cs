using System;

namespace arayüzler 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kalıtım aldırdıktan sonra artık nesnesini oluşturabiliriz.
            FileLogger fileLogger = new FileLogger(); // instance
            fileLogger.WriteLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            SmsLogger smsLogger = new(); // Bu şekilde de instance oluşturulabilir.
            smsLogger.WriteLog();

            //LogManager ile yazma

            LogManager logManager = new LogManager( new FileLogger()); //Başlangıçta bunu yazıp, her yerdem writelog metodunu her yerden kullanbiliriz.
            logManager.WriteLog();

            //Yukarıdaki işlemle new FileLogger() ile instance'ını yarattığımız ILogger'dan türeyen sınıfın writeLog metodunu çağırdık.
        }
    }
}