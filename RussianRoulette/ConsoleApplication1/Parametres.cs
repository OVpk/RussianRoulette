using System;

namespace ConsoleApplication1
{
    public class Parametres
    {
        public void parametres()
        {
            int num_round = int.Parse(Console.ReadLine());
            if (num_round < 6)
            {
                Console.Write("minimun 6 chambres");
            } 
            else if (num_round > 15)
            {
                Console.Write("maximun 15 chambres");
            }
            int num_bullet = int.Parse(Console.ReadLine());
            if (num_bullet <= 1)
            {
                Console.Write("minimun 1 balle");
            }
            else if (num_bullet > num_round - 1)
            {
                Console.Write("il ne peut pas avoir plus de balles que de chambres");
            }
        }
    }
}