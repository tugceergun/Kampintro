using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //generic class demek, çalışacağın özel bir tip olacağını belirtmek demek.
    class MyList<T>  //T, type'tan geliyor. Hangi tipi verirsen onu çalıştırır. int verirsen int;string verirsen string.
    {
        T[] items;
        //arka planda tutulan bir array oluşturduk (eklediğimiz elemanları hafızada tutabilmek için). Bunu yöneteceğiz.
        //metotun dışında,class'ın içinde yazdık.Çünkü başka metotlardan da erişebiliriz.
        // bu diziyi new'lemek(oluşturmak) zorundayız.0 elemanlı bile olsa.(bir referans alması için)(ekleme yapabilmek için)

        //constructor
        public MyList() //class'ı new'lersek bu(constructor) otomatik çalışıyor.
        {
            items = new T[0];  //yukarıdaki array'i new'ledik. //0 elemanlı array oluşturduk.
        }
        public void Add(T item) //T tipinde eleman
        {
            //ekleme yapınca referansın uçmaması için(elemanların uçmaması için); geçici dizinin referansını,en baştaki dizinin referansına eşitleriz.
            T[] tempArray = items;     //referans tutucu geçici array.

            //ekleme yapabilmek için dizinin eleman sayısını bir artırmak zorundayız.(çünkü 0 elemanlı dizi oluşturduk yukarda.)
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];  //geçici olarak verdiğimiz değerleri geri alıyoruz.
            }

            items[items.Length - 1] = item;  //son elemanı ekledik.
        }
    }
}
