using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ad_ugurlurakam = new Dictionary<string, int>();

            ad_ugurlurakam.Add("Ayşe",5);
            ad_ugurlurakam.Add("Ecrin",8);
            ad_ugurlurakam.Add("Kemal",4);

            foreach (var istenen in ad_ugurlurakam)
            {
                Console.WriteLine(istenen);
            }

        }
    }
}
