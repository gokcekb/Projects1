using System;

namespace KahveAkademisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Product kahve1 = new Product();
            kahve1.KahveninKategorisi = "Filtre";
            kahve1.KahveninAdı = "COLOMBIA SUPREMO";
            kahve1.KahveninFiyatı = 45;


            Product kahve2 = new Product();
            kahve2.KahveninKategorisi = "Filtre";
            kahve2.KahveninAdı = "KENYA - AA PLUS";
            kahve2.KahveninFiyatı = 60;


            Product kahve3 = new Product();
            kahve3.KahveninKategorisi = "Filtre";
            kahve3.KahveninAdı = "BRAZİL FAZENDE İRMAS PERREİRA";
            kahve3.KahveninFiyatı = 55;


            Product[] kahveler = new Product[] { kahve1, kahve2, kahve3 };
            Console.WriteLine("for başladı");
            for (int i = 0; i < kahveler.Length; i++)
            {
                Console.WriteLine(kahveler[i].KahveninKategorisi +" " +kahveler[i].KahveninAdı + " " + kahveler[i].KahveninFiyatı);

            }

            Console.WriteLine("forech başladı");
            foreach (Product kahve in kahveler)
            {
                Console.WriteLine(kahve.KahveninKategorisi +" " + kahve.KahveninAdı +" " + kahve.KahveninFiyatı);
            }

            Console.WriteLine("while başladı");
            int m = 0;
            while (m < kahveler.Length) 

            {
                Console.WriteLine(kahveler[m].KahveninKategorisi + " " + kahveler[m].KahveninAdı + " " + kahveler[m].KahveninFiyatı);
                m++;
            }

        }
    }


class Product
    {
        public string KahveninKategorisi { get; set; }
        public string KahveninAdı { get; set; }
        public int KahveninFiyatı { get; set; }

     }


        
    
}
    



