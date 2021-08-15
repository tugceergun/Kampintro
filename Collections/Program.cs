using System;
using System.Collections.Generic;  //List kullanmak için eklenir.

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerim", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; //5 elemanlı hale getirmeye çalıştık diyelim. ama her new'de yeni bir adres tanımlanır.
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]); //bu eleman artık boş kalır çünkü yeni bir adres.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerim", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker"); //5.eleman ekledik.
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            
        }
    }
}
