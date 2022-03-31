using System;

namespace arayüzler 
{
    public class FileLogger : ILogger // interface'den kalıtım aldım.Ve İmplemente ettim.
    {
        public void WriteLog() // İmplemente kısmı.
        {
            //throw new NotImplementedException();
            Console.WriteLine("Dosyaya log yazar.");
        }
    }

}