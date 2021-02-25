using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.Isim = "Furkan";
            m1.SoyIsim = "Metin";
            m1.Yas = 20;
            m1.ID = 0;

            Musteri m2 = new Musteri();
            m2.Isim = "Yusuf";
            m2.SoyIsim = "Metin";
            m2.Yas = 7;
            m2.ID = 1;

            Musteri m3 = new Musteri();
            m3.Isim = "Ömer";
            m3.SoyIsim = "Metin";
            m3.Yas = 17;
            m3.ID = 2;



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.add(m1);
            musteriManager.remove(m1);
            musteriManager.information(m1);
            Console.WriteLine("-------------------");

            musteriManager.add(m2);
            musteriManager.remove(m2);
            musteriManager.information(m2);
            Console.WriteLine("-------------------");

            musteriManager.add(m3);
            musteriManager.remove(m3);
            musteriManager.information(m3);
           


        }
    }
}
