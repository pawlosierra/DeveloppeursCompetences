using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloppeursCompetences
{
    class Program
    {
        static void Main(string[] args)
        {
            ITranslator competenceDeveloppeur11 = new BasicTranslator("Juan");
            ITranslator competenceDeveloppeur12 = new Java(competenceDeveloppeur11);
            ITranslator competenceDeveloppeur13 = new Web(competenceDeveloppeur12);

            Console.WriteLine("Nom: " + competenceDeveloppeur13.getName());
            Console.WriteLine("Competences: " + competenceDeveloppeur13.getCompetence());

            ITranslator competenceDeveloppeur2 = new Java(
                                                new Web(
                                                new CSharp(
                                                new Cplusplus(
                                                new Python(
                                                new BasicTranslator("Pawlo"))))));
            Console.WriteLine("Name: " + competenceDeveloppeur2.getName());
            Console.WriteLine("Competences: " + competenceDeveloppeur2.getCompetence());

            ITranslator competenceDeveloppeur3 = new CSharp(
                                                 new Python(
                                                 new BasicTranslator("Fernando")));

            Console.WriteLine("Name: " + competenceDeveloppeur3.getName());
            Console.WriteLine("Competences: " + competenceDeveloppeur3.getCompetence());

            ITranslator competenceDeveloppeur41 = new BasicTranslator("Laura");
            ITranslator competenceDeveloppeur42 = new Python(competenceDeveloppeur41);
            ITranslator competenceDeveloppeur43 = new Cplusplus(competenceDeveloppeur42);

            Console.WriteLine("Nom: " + competenceDeveloppeur43.getName());
            Console.WriteLine("Competences: " + competenceDeveloppeur43.getCompetence());

            Console.ReadKey();
        }
    }
}
