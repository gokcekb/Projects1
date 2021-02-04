using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "222222222";

            

            TüzelMüşteri musteri2 = new TüzelMüşteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12345";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "545452";

            //Gerçek müşteri-Tüzel müşteri
            //SOLİD

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TüzelMüşteri();
            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            
            

            //Gerçek Müşteri-Tüzel Müşteri
            //SOLİD

        }
    }
}
