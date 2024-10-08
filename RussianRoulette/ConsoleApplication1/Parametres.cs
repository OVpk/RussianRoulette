using System;

namespace ConsoleApplication1
{
    public class Parametres
    {
        public void parametres()
        {
            int num_chambres = int.Parse(Console.ReadLine());
            if (num_chambres < 6)
            {
                Console.Write("minimun 6 chambres");
            } 
            else if (num_chambres > 15)
            {
                Console.Write("maximun 15 chambres");
            }
            int num_balles_chambres = int.Parse(Console.ReadLine());
            if (num_balles_chambres <= 1)
            {
                Console.Write("minimun 1 balle");
            }
            else if (num_balles_chambres > num_chambres - 1)
            {
                Console.Write("il ne peut pas avoir plus de balles que de chambres");
            }
        }
    }
}