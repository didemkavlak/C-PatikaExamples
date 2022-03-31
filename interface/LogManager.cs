// İşleri bir adım öteye götürüp bu log yazma işlemini hangi log sınıfının yaratılacağını (metodunun çağırılıcağını) Belirleyen log manager oluşturalım. Sadece bunu implemente etmek istiyoruz.

using System;

namespace arayüzler 
{
    public class LogManager:ILogger{

        public ILogger _logger; // Logger sınıfının (İnterface'ın) instance'ını yaratalım. 1.

        public LogManager(ILogger logger){ //interface'ın referansını alıyor. //İnterfacelerin nesneleri oluşturulamadı (Çünkü tek başlarına anlamlı değillerdir.) için new ile yaratılamayıp referans alabilirler. //Ancak interface'den türeyen sınıfların nesnelerini aşağıdaki gibi interface referansı verebiliriz. LogManager'a sms,filelogger vvs. instance'larını verebiliyor hale getirir.
            
            _logger = logger; //logger dışardan gelir.

        }

        public void WriteLog()
        {
            //throw new NotImplementedException();
            _logger.WriteLog(); //LogManager'ın WriteLog'unu çalıştırdık.
        }
    }
}

// hangi log sınıfının çağırılacağını bilmiyor, sadece bir yönetim işlemi yapıyor. ILogger'dan türeyen nesnenin writeLog'unu çalıştırıyor.