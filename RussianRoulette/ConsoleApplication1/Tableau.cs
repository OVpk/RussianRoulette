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
        
        (int x, int y)[] chambres = new (int x, int y)[] {(0,3),(1,5),(2,5),(3,3),(2,1),(1,1)};
        public string[,] MelangerBalle(string[,] tableau)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, 6);

                (int x, int y) chambreChoisi = chambres[randomIndex];

                tableau[chambreChoisi.x, chambreChoisi.y] = "X";
                return tableau;
            }
        
        public int IndexActuelBalle(string[,] tableau)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (tableau[chambres[i].x, chambres[i].y] == "X")
                    {
                        
                        return i;
                    }
                }
                return -1;
            }

        public bool IsDead(string[,] tableau, int nbTirs)
        {
            if (IndexActuelBalle(tableau) - nbTirs < 0)
            {
                
                return true;
            }
            
            return false;
        }

        

        public string[,] BarrilletApresTour(string[,] tableau, int nbTirs)
        {
            if (!IsDead(tableau, nbTirs))
            {
                (int x, int y) ancienEmplacementBalle = chambres[IndexActuelBalle(tableau)];
                (int x, int y) nouveauEmplacementBalle = chambres[IndexActuelBalle(tableau) - nbTirs];
                tableau[nouveauEmplacementBalle.x, nouveauEmplacementBalle.y] = "X";
                tableau[ancienEmplacementBalle.x, ancienEmplacementBalle.y] = "O";
            }
            

            return tableau;
        }

        

       
        
    }
}