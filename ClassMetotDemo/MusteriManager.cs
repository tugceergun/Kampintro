using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle (Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi:" + musteri.Ad);
        }

        public void Listele(Musteri[] listele)
        {
            Console.WriteLine("----Müşteriler listelendi----");
            foreach (var musteri in listele)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.Id);
            }
        }

        public void Silme(Musteri silme)
        {
            Console.WriteLine("Musteri silindi:" + silme.Ad);
        }

    }
}
