using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adı = "Ayşe";
            musteri1.Soyadı = "Korkmaz";
            musteri1.Tc = "9588248642";
            musteri1.KartNumarası = 1245454584 ;

            Musteri musteri2 = new Musteri();
            musteri2.Adı = "Ebru";
            musteri2.Soyadı = "Yılmaz";
            musteri2.Tc = "54878522542";
            musteri2.KartNumarası = 1164564232;

            Musteri musteri3 = new Musteri();
            musteri3.Adı = "Atakan";
            musteri3.Soyadı = "Özkan";
            musteri3.Tc = "8797841452";
            musteri3.KartNumarası = 455412154;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler) 
            {
                Console.WriteLine(musteri.Adı + " " +musteri.Soyadı + " " + musteri.Tc + " " + musteri.KartNumarası );

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager.Silme(musteri3);

        }
    }
}
