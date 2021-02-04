using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adı + " " + musteri.Soyadı + "=Müşteri Eklendi");

        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adı + " " + musteri.Soyadı + "=Müşteri Silindi");
        }
    }
}
