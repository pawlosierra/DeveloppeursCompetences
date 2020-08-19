﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloppeursCompetences
{
    class CSharp: ITranslator
    {
        private ITranslator bt;
        private String competence;

        public CSharp(ITranslator bt)
        {
            this.bt = bt;
            this.competence = "C#";
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
