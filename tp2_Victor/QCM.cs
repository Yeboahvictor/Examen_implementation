using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2_Victor
{
    internal class QCM:question
    {


        public string quest
        {
            get; set;
        }

        



        public QCM(string quest)
        {
            this.quest = quest;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

