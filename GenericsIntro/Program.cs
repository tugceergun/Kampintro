using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); //generic bir class olduğu için MyList isimler = new Mylist(); diyemezsin. //string türünde liste.
            isimler.Add("Tuğçe");
        }
    }
}
