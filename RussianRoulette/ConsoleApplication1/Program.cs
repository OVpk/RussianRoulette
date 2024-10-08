namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Joueur joueur = new Joueur();
            joueur.Role();
            
            Tableau tableau = new Tableau();
            tableau.AfficherBarillet(tableau.MelangerBalle(tableau.InitialisationTableau()));
        }
    }
}