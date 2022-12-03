using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_Victor
{
    internal class question:Examen
    {


        public string type
        {
            get; set;
        }

        public int numero
        {
            get; set;
        }

       



        public question(string type, int numero)
        {
            this.type = type;

        }



        public override string ToString()
        {
            return base.ToString();
        }
    }
}

