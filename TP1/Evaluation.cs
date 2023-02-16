using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Evaluation
    {
        // Enumeration
        public enum Cote
        {

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
