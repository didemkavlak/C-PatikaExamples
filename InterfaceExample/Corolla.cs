using System;

namespace interface_ornek 
{
    public class Corolla : IOtomobil
    {
        public Renkler AracRengi()
        {
            //throw new NotImplementedException();
            return Renkler.Mavi;
        }

        public Markalar HangiMarka()
        {
            //throw new NotImplementedException();
            return Markalar.Toyota;
        }

        public int KacTekerlek()
        {
            //throw new NotImplementedException();
            return 4;
        }
    }
}