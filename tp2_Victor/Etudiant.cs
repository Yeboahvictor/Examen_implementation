using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_Victor
{
    internal class Etudiant:Examen
    {
       public string nom  {
             get;set;
        }
        public string filiere
        {
            get;set;
        }

        public string CNE
        {
            get;set;
        }

        public Etudiant (string nom, string filiere, string cNE)
        {
            this.nom = nom;
            this.filiere = filiere;
            this.CNE = cNE;
        }

        public override string ToString()
        {
            return base.ToString(); 
        }
    }
}
