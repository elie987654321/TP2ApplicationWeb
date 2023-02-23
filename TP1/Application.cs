namespace TP1
{
    public class Application
    {
        static void Main(string[] args)
        {
            // Json
            String chemin = Environment.CurrentDirectory;
            String racineProjet = Directory.GetParent(chemin).Parent.Parent.FullName;
            String fichierJson = racineProjet + "/" + "catalogueDeJeux.json";
            String fichierJson2 = racineProjet + "/" + "fichierDeJeux.json";

            Catalogue catalogue = new Catalogue();

            
        }
    }
}