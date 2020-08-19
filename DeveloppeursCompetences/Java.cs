using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloppeursCompetences
{
    public class Java: ITranslator
    {
        private ITranslator bt;
        private String competence;

        public Java(ITranslator bt)
        {
            this.bt = bt;
            this.competence = "Java";
        }

        public String getName()
        {
            return bt.getName();
        }

        public String getCompetence()
        {
            return this.competence + ", " + bt.getCompetence();
        }
    }
}
