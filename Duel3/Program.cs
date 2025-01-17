// objets de la classe Guerriere

using System.ComponentModel.Design;
using Duel.Classes;


List<Guerriere> listGuerrieres = new List<Guerriere>();

Guerriere ciri = new Guerriere("Ciri", 10, 2);
Guerriere vi = new Guerriere("Vi", 12, 1);

MenuBagarre();

void MenuBagarre()
{
    do
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" \n");

        Console.WriteLine("\t \u2554\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2557");
        Console.WriteLine("\t \u2551 La bagarre !! \u2551 ");
        Console.WriteLine("\t \u255A\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u2550\u255D \n");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\t\u2554\u2550\u2557");
        Console.WriteLine("\t\u25511\u2551 - Ajouter une guerrière");
        Console.WriteLine("\t\u255A\u2550\u255D \n");
        Console.WriteLine("\t\u2554\u2550\u2557");
        Console.WriteLine("\t\u25512\u2551 - Liste des guerrières");
        Console.WriteLine("\t\u255A\u2550\u255D \n");
        Console.WriteLine("\t\u2554\u2550\u2557");
        Console.WriteLine("\t\u25513\u2551 - Lancer le duel (bagarre !!)");
        Console.WriteLine("\t\u255A\u2550\u255D \n");
        Console.WriteLine("\t\u2554\u2550\u2557");
        Console.WriteLine("\t\u25514\u2551 - Duel tour par tour ");
        Console.WriteLine("\t\u255A\u2550\u255D \n");
        Console.WriteLine("\t\u2554\u2550\u2557");
        Console.WriteLine("\t\u25510\u2551 - Quitter");
        Console.WriteLine("\t\u255A\u2550\u255D \n");
        Console.WriteLine(" \n");

        const string choixTitre = "\tVotre choix de champion.ne : ";
        foreach (char c in choixTitre)
        {
            Console.Write(c);
            System.Threading.Thread.Sleep(5);
        }

        int choix = int.Parse(Console.ReadLine());
        Console.ResetColor();

        switch (choix)
        {
            case 1:
                AjouterGuerriere();
                break;

            case 2:
                AfficherListeGuerrieres();
                break;

            case 3:
                LancerDuel();
                break;

            case 4:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n Bienvenue dans le duel tour par tour ");
                Console.ResetColor();
                break;

            case 0:
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine("\n Posez les gantelets et les épées, à la prochaine ! ");
                Console.ResetColor();

                Environment.Exit(0);

                break;
        }
    } while (true);


    void AjouterGuerriere()
    {
        int compteur = 0;

        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("- Ajouter une guerrière -\n");

            Console.WriteLine("\t1 - Guerrière \n");
            Console.WriteLine("\t2 - Naine \n");
            Console.WriteLine("\t3 - Elfe \n");
            Console.WriteLine("\t0 - Retour \n");

            Console.Write($"\tVotre choix de classe : ");
            int choixAjout = int.Parse(Console.ReadLine());
            Console.ResetColor();

            string classe = "";
            switch (choixAjout)
            {
                case 1:
                    classe = "Guerriere";

                    break;

                case 2:
                    classe = "Naine";

                    break;
                case 3:
                    classe = "Elfe";

                    break;
                case 0:
                    Console.Clear();
                    Environment.Exit(0);

                    break;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Entrez le nom de votre guerrière s'il-vous-plaît : ");
            string Nom = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Bienvenue à " + Nom);

            Console.WriteLine($"Combien de points de vie {Nom} a-t-elle ? (entre 1 et 70)");
            int PointsDeVie = int.Parse(Console.ReadLine());

            Console.WriteLine("Combien de dés d'attaque a-t-elle ? (entre 1 et 5)");
            int nbDesAttaque = int.Parse(Console.ReadLine());

            if (classe == "Naine")
            {
                Console.WriteLine("A-t-elle une armure lourde ? (true ou false)");
                string armureLourde = Console.ReadLine();
                Console.WriteLine($"Vous avez ajouté {Nom} ({PointsDeVie}, {nbDesAttaque}, {armureLourde})");
            }

            if (classe == "Guerrière" || classe == "Elfe")
            {
                Console.WriteLine($"Vous avez ajouté {Nom} ({PointsDeVie}, {nbDesAttaque})");
            }

            if (classe == "Guerrière")
            {
                Guerriere ajout = new Guerriere(Nom, PointsDeVie, nbDesAttaque);
                listGuerrieres.Add(ajout);
                compteur++;
            }
            else if (classe == "Naine")
            {
                Naine ajout = new Naine(Nom, PointsDeVie, nbDesAttaque, true);
                listGuerrieres.Add(ajout);
                compteur++;
            }
            else
            {
                Elfe ajout = new Elfe(Nom, PointsDeVie, nbDesAttaque);
                listGuerrieres.Add((ajout));
                compteur++;
            }
        }
    }
}

void AfficherListeGuerrieres()
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("- Liste des guerrières -\n");

    ciri.AfficherInfos();
    vi.AfficherInfos();

    foreach (var listee in listGuerrieres)
    {
        Console.WriteLine($"{listee.GetType().Name} {listee.Nom} ({listee.PointsDeVie}, {listee.NbDesAttaque})");
    }

    Console.ResetColor();
}

void LancerDuel()
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\t ╔═════════╗\n\t ║ Le duel ║ \n\t ╚═════════╝ \n\n");

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\tQue le combat... commence !");
    Console.ReadKey();
    Console.WriteLine("\n");

    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\tCombattantes :");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("\t 1) ");
    vi.AfficherInfos();
    Console.Write("\t 2) ");
    ciri.AfficherInfos();
    Console.ReadKey();
    Console.WriteLine("\n");

    const string choixFighter = "\tChoose your fighter (tapez son numéro) : ";
    foreach (char c in choixFighter)
    {
        Console.Write(c);
        System.Threading.Thread.Sleep(5);
    }
    int choixDuFighter = int.Parse(Console.ReadLine());

    if (choixDuFighter == 1)
    {
        Console.WriteLine("\n");
        Console.WriteLine("\tVous avez choisi Vi !");
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\t ╔═════════╗\n\t ║ Le duel ║ \n\t ╚═════════╝ \n\n");
        
        Console.WriteLine("\t VI VS CIRI");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"{vi.Nom} attaque {ciri.Nom} !");
        int degatSubit = vi.Attaquer();
        ciri.SubirDegats(degatSubit);

        Console.WriteLine($"{vi} pourfend et fait {degatSubit} de dégâts !");
        Console.WriteLine($"{ciri} a {ciri.PointsDeVie} de points de vie.");

        if (ciri.PointsDeVie <= 0)
        {
            Console.WriteLine($"{vi.Nom} a gagné !");
        }
        if (vi.PointsDeVie <= 0)
        {
            Console.WriteLine($"{ciri.Nom} a gagné !");
        }

        Console.WriteLine("");
        Console.WriteLine("\nTapez sur une touche pour continuer le combat");
        Console.ReadKey();
        Console.ResetColor();
        
    }
    else if (choixDuFighter == 2)
    {
        Console.WriteLine("\n");
        Console.WriteLine("\tVous avez choisi Ciri !");
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\t ╔═════════╗\n\t ║ Le duel ║ \n\t ╚═════════╝ \n\n");
        
        Console.WriteLine("\t CIRI VS VI");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        do
        {
            int degats = vi.Attaquer();
            ciri.SubirDegats(degats);

            if (ciri.PointsDeVie <= 0)
            {
                Console.WriteLine($"{vi.Nom} a gagné le duel !");
            }

            degats = ciri.Attaquer();
            vi.SubirDegats(degats);

            if (vi.PointsDeVie <= 0)
            {
                Console.WriteLine($"{ciri.Nom} a gagné le duel !");
            }
            break;
        } while (vi.PointsDeVie > 0 && ciri.PointsDeVie > 0);

        Console.WriteLine("");
        Console.WriteLine("Tapez sur une touche pour continuer le combat !");
        Console.ReadKey();
    }

    else
    {
        Console.WriteLine("");
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\tChoisissez un numéro affiché s'il-vous-plaît");
        Console.ResetColor();
    }
}
Console.ResetColor();

