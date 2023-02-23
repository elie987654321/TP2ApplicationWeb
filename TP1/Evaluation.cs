namespace TP1
{
    public class Evaluation
    {
        // Enumeration
        public enum Cote
        {
            EXCELLENT = 5,
            TRES_BON = 4,
            BON = 3,
            MOYEN = 2,
            MAUVAIS = 1
        }

        // Attributs
        private Cote cote;
        private string description;

        public Cote Cote1 { get => cote; set => cote = value; }
        public string Description { get => description; set => description = value; }

        // Constructeur par defaut
        public Evaluation()
        {
            this.Cote1 = new Cote();
            this.Description = "";
        }


        // Constructeur complet
        public Evaluation(Cote cote, string description)
        {
            this.Cote1 = cote;
            this.Description = description;
        }



        // ToString
        public override string ToString()
        {
            return this.Cote1 + ", " + this.Description;
        }
    }
}
