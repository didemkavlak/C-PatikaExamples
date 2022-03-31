using System;

namespace interface_ornek 
{
    public interface IOtomobil{

        Markalar HangiMarka(); //Sistemde sabit old. için enum kullanalım. Değişse bile, sürekli değişen bir bilgi değil.Bunları sabitler klasörü içerisine yazalım. String yerini enuma verdiğimiz ad Markalar aldı.
        int KacTekerlek();
        Renkler AracRengi(); //Sistemde sabit old. için enum kullanalım. String yerini enuma verdiğimiz ad Renkler aldı.
    } 
}