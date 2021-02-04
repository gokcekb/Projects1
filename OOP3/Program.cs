using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            IloggerService databaseloggerService = new DatabaseLoggerService();
            IloggerService filebaseloggerService = new FilebaseLoggerService();



            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,databaseloggerService);
            // basvuruManager.BasvuruYap(ıhtiyacKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager,tasitKrediManager};
            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

         }   
       
    } 
      
}           
            

   

