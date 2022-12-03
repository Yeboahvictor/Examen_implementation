using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_Victor
{
    internal class Examen
    {

        public string title
        {
            get; set;
        }
        public int Duree
        {
            get; set;
        }

        public string Date
        {
            get; set;
        }

        public Examen(string title, int Duree, string Date)
        {
            this.title = title;
            this.Duree = Duree;
            this.Date = Date;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
