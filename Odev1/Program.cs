using System;

namespace Odev1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Product kiyafetler = new Product();
            kiyafetler.Bluz = "Kırmızı";
            kiyafetler.Pantolon = "İspanyol paça";
            kiyafetler.Sapka = "Kovboy şapkası";

            Product kiyafetler2 = new Product();
            kiyafetler2.Bluz = "Su yeşili";
            kiyafetler2.Pantolon = "Bol paça";
            kiyafetler2.Sapka = "Rap şapkası";

            Product kiyafetler3 = new Product();
            kiyafetler3.Bluz = "Sarı";
            kiyafetler3.Pantolon = "Dar paça";
            kiyafetler3.Sapka = "Kış şapkası";

            Product[] giysiler = new Product[] { kiyafetler,kiyafetler2,kiyafetler3 };

            Console.WriteLine("---Foreach---");

            foreach (var Giysiler in giysiler)
            {
                Console.WriteLine("Bluz: "+Giysiler.Bluz + " " + "Pantolon:" + Giysiler.Pantolon + " " + "Şapka: "+Giysiler.Sapka);
            }

            Console.WriteLine("---For---");

            for (int i = 0; i < giysiler.Length; i++)
            {
                Console.WriteLine("Bluz: " +giysiler[i].Bluz + " Pantolon: "+ giysiler[i].Pantolon+ " Şapka: "+ giysiler[i].Sapka);
            }

            Console.WriteLine("---While---");
            int x = 0;
            while(x<giysiler.Length)
            {
                Console.WriteLine("Bluz: " + giysiler[x].Bluz + " Pantolon: " + giysiler[x].Pantolon + " Şapka: " + giysiler[x].Sapka);
                x++;
            }
                
        }
    }

    class Product
    {
        public string Bluz { get; set; }
        public string Pantolon { get; set; }
        public string Sapka { get; set; }

    }
}
