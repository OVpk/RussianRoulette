using System;
using Microsoft.SqlServer.Server;

namespace ConsoleApplication1
{
    public class Tableau
    {

        public string[,] InitialisationTableau()
        {

            string[,] tableau2D = new string[4, 7];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0 && j == 3 || i == 1 && j == 1 || i == 1 && j == 5 || i == 2 && j == 1 ||
                        i == 2 && j == 5 || i == 3 && j == 3)
                    {
                        tableau2D[i, j] = "O";
                    }
                    else
                    {
                        tableau2D[i, j] = "■";
                    }
                    
                }
            }

            return tableau2D;
        }

        public void AfficherBarillet(string[,] tableau)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(tableau[i, j]);
                    if (j == 6)
                    {
                        Console.WriteLine();
                    }

                }
            }
        }
        public string[,] MelangerBalle(string[,] tableau)
            {
                (int x, int y)[] chambres = new (int x, int y)[] {(0,3),(1,5),(2,5),(3,3),(2,1),(1,1)};
 
                Random random = new Random();
                int randomIndex = random.Next(0, 6);
                Console.Write(randomIndex);
                Console.WriteLine();

                (int x, int y) chambreChoisi = chambres[randomIndex];

                tableau[chambreChoisi.x, chambreChoisi.y] = "X";
                return tableau;
            }

        

       
        
    }
}