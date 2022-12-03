using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_Victor
{
    internal class note:Examen
    {
        public int points
        {
            get; set;
        }
      

        public note(int points)
        {
            this.points=points;
           
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

