using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_Victor
{
    internal class penalite:note
    {


        public string retrait
        {
            get; set;
        }

     



        public penalite(string retrait)
        {
            this.retrait = retrait;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
