using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    //naming convention
    class SepetManager
    {
        public void Ekle(Product urun) //method oluşturduk.
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi,int fiyati,string aciklama)
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}
