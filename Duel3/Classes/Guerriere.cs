using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duel.Classes
{
    internal class Guerriere
    {

        // attributs
        private string _nom;
        private int _pointsDeVie;
        private int _nbDesAttaque;

        // propriétés
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public int PointsDeVie
        {
            get { return _pointsDeVie; }
            set { _pointsDeVie = value; }
        }
        // nombre de dés qu'on va lancer ?
        public int NbDesAttaque
        {
            get { return _nbDesAttaque; }
            set { _nbDesAttaque = value; }
        }

        // constructeur
        public Guerriere(string Nom, int PointsDeVie, int NbDesAttaque)
        {
            _nom = Nom;
            _pointsDeVie = PointsDeVie;
            _nbDesAttaque = NbDesAttaque;
        }

        public string GetNom()
        {
            return _nom;
        }
        public int GetPointsDeVie()
        {
            return _pointsDeVie;
        }
        public void SetPointsDeVie(int PointsDeVie)
        {
            PointsDeVie = 0;
        }
        public int GetNbDesAttaque()
        {
            return _nbDesAttaque;
        }

        public void AfficherInfos()
        {
            Console.WriteLine($"Guerriere {Nom} ({PointsDeVie}, {NbDesAttaque}) ");
        }
        public virtual int Attaquer()
        {
            Random random = new Random();
            int degats = random.Next(1, 7);
            ++NbDesAttaque;

            Console.WriteLine($"{Nom} pourfend son adversaire et lui inflige {degats} !!");
            AfficherInfos();
            return degats;
        }
        public virtual void SubirDegats(int degatsPris)
        {

            PointsDeVie -= degatsPris;
            //if (Guerriere.listGuerrieres[0])

            Console.WriteLine($"{Nom} a pris {degatsPris} de dégât !");

        }
    }
}
