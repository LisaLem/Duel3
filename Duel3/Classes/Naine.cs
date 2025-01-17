using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duel.Classes
{
    internal class Naine : Guerriere
    {
        // attribut spécifique
        private bool ArmureLourde;

        public Naine(string nom, int pointsDeVie, int nbDesAttaques, bool armureLourde)
        : base(nom, pointsDeVie, nbDesAttaques)
        {
            ArmureLourde = armureLourde;
        }

        // méthode spécifique
        public override void SubirDegats(int degats)
        {
            //base.SubirDegats(degats); 
        }

    }
}
