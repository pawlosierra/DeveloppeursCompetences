using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloppeursCompetences
{
    public class BasicTranslator: ITranslator
    {
        private String nom;

        public BasicTranslator(String nom)
        {
            this.nom = nom;
        }

        public String getName()
        {
            return nom;
        }

        public String getCompetence()
        {
            return "";
        }
    }
}
