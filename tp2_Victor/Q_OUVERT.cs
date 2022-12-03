using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_Victor
{
    internal class Q_OUVERT:question
    {

        public string quest
        {
            get; set;
        }





        public Q_OUVERT(string quest)
        {
            this.quest = quest;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
