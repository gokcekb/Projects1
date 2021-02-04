using System;

namespace RefAndOut
{
    class Program
    {
            static void Metot3(ref int a)
            {
                a += 10;
            }

            static void Main()
            {
                int a = 5;

                Metot3(ref a);

                Console.WriteLine("a = {0}", a);
                Console.ReadLine();
            }
        }
    }

