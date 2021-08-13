using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123;
            musteri1.Ad = "Tuğçe";
            musteri1.Soyad = "Ergün";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 456;
            musteri2.Ad = "Engin";
            musteri2.Soyad = "Demiroğ";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.MusteriEkle(musteri1);
            musterimanager.MusteriEkle(musteri2); 

            musterimanager.Listele(musteriler);
            
            musterimanager.Silme(musteri1);

            
        }
    }
}
