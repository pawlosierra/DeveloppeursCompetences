using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloppeursCompetences
{
    class Web: ITranslator
    {
        private ITranslator bt;
        private String competence;

        public Web(ITranslator bt)
        {
            this.bt = bt;
            this.competence = "Web";
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
