using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();            //kendi veri tipini yazıyormuş gibi düşün
            kurs1.KursAdi = "C#";             
            kurs1.KursEgitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 68;


            Kurs kurs2 = new Kurs();            //kendi veri tipini yazıyormuş gibi düşün
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmeni = "Kerem Varış";
            kurs2.IzlenmeOranı = 64;


            Kurs kurs3 = new Kurs();            //kendi veri tipini yazıyormuş gibi düşün
            kurs3.KursAdi = "Python";
            kurs3.KursEgitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOranı = 80;



            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursEgitmeni);

            // string[] kurslar = new string [] {  }    bir öncekin de böyle yapmıştık şimdi veri tipimiz 
            // string değil Kurs


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.KursEgitmeni);
                Console.WriteLine(kurs.IzlenmeOranı);
                
            }

        }
    }
    class Kurs 
    {
        public string KursAdi { get; set; }       // prop ile, kendi veri tipini tanımladın.
        public string KursEgitmeni { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
