using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_Victor
{
    internal class reponse
    {


        public string type
        {
            get; set;
        }

        public string bon_reponse
        {
            get; set;
        }

        public string aucune_reponse
        {
            get; set;
        }



        public reponse( string type, string aucune_reponse, string bon_reponse)
        {
            this.type= type;
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
