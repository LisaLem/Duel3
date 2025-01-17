using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duel.Classes
{
    internal class Elfe : Guerriere
    {
        public Elfe(string nom, int pointsDeVie, int nbDesAttaques)
        : base(nom, pointsDeVie, nbDesAttaques)
        {
        }
        // méthode spécifique
        public override int Attaquer()
        {
            return base.Attaquer();
        }

    }
}
