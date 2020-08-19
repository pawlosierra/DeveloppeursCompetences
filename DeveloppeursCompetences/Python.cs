using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloppeursCompetences
{
    class Python : ITranslator
    {
        private ITranslator bt;
        private String competence;

        public Python(ITranslator bt)
        {
            this.bt = bt;
            this.competence = "Python";
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
