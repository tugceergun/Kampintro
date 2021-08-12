using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            double fiyati = 15;
            string aciklama = "amasya elması";

            string[] meyveler = new string[] { };

            Product urun1 = new Product();  //class'ın örneği
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] {urun1,urun2 };

            //type-safe -- tip güvenli
            foreach (var urun in urunler) //var yerine Product yazsan da olur. Aynı şeye geliyor.
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("---------Metodlar----------");

            //instance - örnek 
            //encapsulation(kapsülleme)

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); //methodu çağırdık. Method, tekrar tekrar aynı şeyi kullanabilme imkanı verir.
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("armut", 15, "yesil armut");
        }
    }
}
