using System;

namespace interface_ornek {

    public class Polo : IOtomobil
    {
        public Renkler AracRengi()
        {
            //throw new NotImplementedException();
            return Renkler.Mavi;
        }

        public Markalar HangiMarka()
        {
            //throw new NotImplementedException();
            return Markalar.Volkswagen;
        }

        public int KacTekerlek()
        {
            //throw new NotImplementedException();
            return 4;
        }
    }
}