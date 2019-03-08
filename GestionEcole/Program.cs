using System;
using System.Text;
using EcoleLibrary;

namespace GestionEcole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Etudiant e1 = new Etudiant(1, "DUPONT", "Jean", new DateTime(1997, 5, 12));
            Etudiant e2 = new Etudiant(2, "HENRY", "Marine", new DateTime(1981, 7, 8));
            Etudiant e3 = new Etudiant(3, "MALTAN", "Elisabeth", new DateTime(1961, 3, 14));
            Etudiant e4 = new Etudiant(4, "COLOMBIER", "Paul", new DateTime(1998, 11, 17));
            Etudiant e5 = new Etudiant(5, "CROS", "Alexandre", new DateTime(1997, 12, 26));
            Etudiant e6 = new Etudiant(6, "BERNARD", "Philippe", new DateTime(1972, 5, 24));
            Etudiant e7 = new Etudiant(7, "HURET", "Christine", new DateTime(1997, 8, 29));
            Etudiant e8 = new Etudiant(8, "LAUZE", "François", new DateTime(1999, 4, 3));
            Etudiant e9 = new Etudiant(9, "BOMPARD", "Jean-Luc", new DateTime(1970, 1, 13));
            Etudiant e10 = new Etudiant(10, "CARREFOUR", "Lisa", new DateTime(1997, 3, 19));


            Classe B1 = new Classe(1, 30);
            B1.AjouterClasseEtudiant(new ClasseEtudiant(e1, ClasseEtudiant.TypeClasse.Etudiant));
            B1.AjouterClasseEtudiant(new ClasseEtudiant(e2, ClasseEtudiant.TypeClasse.Etudiante));
            B1.AjouterClasseEtudiant(new ClasseEtudiant(e3, ClasseEtudiant.TypeClasse.Etudiante));
            B1.AjouterClasseEtudiant(new ClasseEtudiant(e4, ClasseEtudiant.TypeClasse.Etudiant));
            B1.AjouterClasseEtudiant(new ClasseEtudiant(e5, ClasseEtudiant.TypeClasse.Etudiant));
            B1.AjouterClasseEtudiant(new ClasseEtudiant(e6, ClasseEtudiant.TypeClasse.PersonneReconversion));
            B1.AjouterClasseEtudiant(new ClasseEtudiant(e7, ClasseEtudiant.TypeClasse.Etudiante));
            B1.AjouterClasseEtudiant(new ClasseEtudiant(e8, ClasseEtudiant.TypeClasse.PersonneReconversion));
            B1.AjouterClasseEtudiant(new ClasseEtudiant(e9, ClasseEtudiant.TypeClasse.PersonneReconversion));
            B1.AjouterClasseEtudiant(new ClasseEtudiant(e10, ClasseEtudiant.TypeClasse.Etudiante));


            Ecole ecole = new Ecole();
            ecole.AjouterClasse(B1);

            ecole.AfficherClasses();

            ecole.AfficherEtudiantsClasses();
        }
    }
}
