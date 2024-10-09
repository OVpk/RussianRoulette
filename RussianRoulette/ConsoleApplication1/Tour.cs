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

        public bool IsDead = false;
        public void DebutTour()
        {
            Console.WriteLine("Appuyez sur entré :");
            ouiOuNon = Console.ReadLine();
            barriellet = tableau.InitialisationTableau();
            barriellet = tableau.MelangerBalle(barriellet);
            //tableau.AfficherBarillet(barriellet);
            positionballe = tableau.IndexActuelBalle(barriellet);
        }
        public void Tire()
        {
            int nbTire = 0;
            
            do
            {
                Console.WriteLine("Canon vide, continuer ? (Y/N)");
                ouiOuNon = Console.ReadLine();
                
                
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
                    Console.WriteLine("J1 pts : " + pointj1 +" | " +"J2 pts : " + pointj2);
                    joueur.j1Prio = !joueur.j1Prio;
                    Console.WriteLine();
                    Console.WriteLine("Changement de joueur !");
                    return;
                }
            } while (positionballe >=0);
            
            Console.WriteLine("MORT");
            if (joueur.j1Prio == true)
            {
                pointj1 = pointj1 - nbTire;
                pointj2 = pointj2 + nbTire;

            }
            else
            {
                pointj2 = pointj2 - nbTire;
                pointj1 = pointj1 + nbTire;
            }
            Console.WriteLine("J1 pts : " + pointj1 +" | " +"J2 pts : " + pointj2);
            IsDead = true;
        }
    }
    
    
}