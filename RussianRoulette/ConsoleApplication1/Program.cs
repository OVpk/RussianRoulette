namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Joueur joueur = new Joueur();
            //joueur.Role();
            
            Tableau tableau = new Tableau();
            string[,] barrilletActuel = tableau.InitialisationTableau();
            tableau.MelangerBalle(barrilletActuel);
            tableau.AfficherBarillet(barrilletActuel);
            tableau.IndexActuelBalle(barrilletActuel);
        }
    }
}