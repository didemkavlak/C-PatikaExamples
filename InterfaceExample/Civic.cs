using System;

namespace interface_ornek 
{
    public class Civic : IOtomobil
    {
        public Renkler AracRengi()
        {
            //throw new NotImplementedException();
            return Renkler.Kırmızı;
        }

        public Markalar HangiMarka()
        {
            //throw new NotImplementedException();
            return Markalar.Honda;
        }

        public int KacTekerlek()
        {
            //throw new NotImplementedException();
            return 4;
        }
    }
}