using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Constructeur par defaut
        public Evaluation()
        {
            this.cote = new Cote();
            this.description = "";
        }


        // Constructeur complet
        public Evaluation(Cote cote, string description)
        {
            this.cote = cote;
            this.description = description;
        }
    }
}
