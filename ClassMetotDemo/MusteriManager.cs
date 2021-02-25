using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

       public void add(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi : "+musteri.Isim);
        }

        public void remove(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi : " + musteri.Isim);
        }

        public void information(Musteri musteri)
        {
            Console.WriteLine("Musteri bilgileri : " );
            Console.WriteLine("İsim : "+musteri.Isim);
            Console.WriteLine("Soyİsim : " + musteri.SoyIsim);
            Console.WriteLine("Yas : " + musteri.Yas);
            Console.WriteLine("ID : " + musteri.ID);

        }



    }
}
