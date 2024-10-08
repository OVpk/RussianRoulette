using System;

namespace ConsoleApplication1
{
    public class Tour
    {
        public Joueur joueur;
        public Tableau tableau;
        public string ouiOuNon;
        public int positionballe;
        public int pointj1 = 0;
        public int pointj2 = 0;
        private string[,] barriellet;
        public void DebutTour()
        {
            Console.WriteLine("entrée n'importe quelle touche");
            ouiOuNon = Console.ReadLine();
            barriellet = tableau.InitialisationTableau();
            barriellet = tableau.MelangerBalle(barriellet);
            tableau.AfficherBarillet(barriellet);
            //tableau.AfficherBarillet(barrie);
            positionballe = tableau.IndexActuelBalle(barriellet);
        }
        public void Tire()
        {
            do
            {
                Console.WriteLine("Canon vide, continuer ? (Y/N)");
                ouiOuNon = Console.ReadLine();
                int nbTire = 1;
                
                if (ouiOuNon == "Y")
                {
                    positionballe = positionballe - 1;
                    nbTire += 1;
                    
                    
                    if (joueur.j1Prio == true)
                    {
                        pointj1 = pointj1 + 1;
                        
                    }
                    else
                    {
                        pointj2 = pointj2 + 1;
                    }
                }
                else if (ouiOuNon == "N")
                {
                    tableau.AfficherBarillet(tableau.BarrilletApresTour(barriellet, nbTire));
                    Console.WriteLine("J1 pts : " + pointj1 +" " +"J2 pts : " + pointj2);
                    return;
                }
            } while (positionballe >=0);
            
            Console.WriteLine("MORT");
        }
    }
    
    
}