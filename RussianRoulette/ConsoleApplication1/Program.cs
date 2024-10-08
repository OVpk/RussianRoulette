using System.Security.Cryptography.X509Certificates;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Joueur joueur = new Joueur();
            joueur.Role();

            Tableau tableau = new Tableau();

            Tour tour = new Tour();
            tour.tableau = tableau;
            tour.joueur = joueur;
            tour.DebutTour();
            tour.Tire();



        }
        
    }
}