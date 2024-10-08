using System;

namespace ConsoleApplication1
{
    public class Score
    {
        public void Victory()
        {
            int score_P1 = 0;
            int score_P2 = 0;
            if (score_P1 > score_P2)
            {
                Console.WriteLine("Victoire du joueur 1");
            }
            else if (score_P1 < score_P2)
            {
                Console.WriteLine("Victoire du joueur 2");
            }
        }
    }
}