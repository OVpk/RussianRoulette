namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Tableau tableau = new Tableau();
            tableau.AfficherBarillet(tableau.MelangerBalle(tableau.InitialisationTableau()));
        }
    }
}