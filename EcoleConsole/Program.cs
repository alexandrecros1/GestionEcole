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

            // CREATION DES ETUDIANTS
            Etudiant e1 = new Etudiant(1, "DUPONT", "Jean", new DateTime(1997, 5, 12), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B1");
            Etudiant e2 = new Etudiant(2, "HENRY", "Marine", new DateTime(1981, 7, 8), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B1");
            Etudiant e3 = new Etudiant(3, "MALTAN", "Elisabeth", new DateTime(1961, 3, 14), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B1");
            Etudiant e4 = new Etudiant(4, "COLOMBIER", "Paul", new DateTime(1998, 11, 17), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B1");
            Etudiant e5 = new Etudiant(5, "CROS", "Alexandre", new DateTime(1997, 12, 26), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B1");
            Etudiant e6 = new Etudiant(6, "BERNARD", "Philippe", new DateTime(1972, 5, 24), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B1");
            Etudiant e7 = new Etudiant(7, "HURET", "Christine", new DateTime(1997, 8, 29), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B1");
            Etudiant e8 = new Etudiant(8, "LAUZE", "François", new DateTime(1999, 4, 3), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B1");
            Etudiant e9 = new Etudiant(9, "BOMPARD", "Alfred", new DateTime(1970, 1, 13), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B1");
            Etudiant e10 = new Etudiant(10, "CARREFOUR", "Lisa", new DateTime(1997, 3, 19), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B1");
            Etudiant e11 = new Etudiant(11, "MEDIN", "Corentin", new DateTime(1999, 1, 29), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B1");

            Etudiant e12 = new Etudiant(12, "CURTIS", "Jessie", new DateTime(1975, 3, 7), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B2");
            Etudiant e13 = new Etudiant(13, "DUCAN", "Noelle", new DateTime(1973, 5, 9), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B2");
            Etudiant e14 = new Etudiant(14, "CARROLL", "Angel", new DateTime(1982, 4, 1), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B2");
            Etudiant e15 = new Etudiant(15, "MURRAY", "Catherine", new DateTime(1975, 7, 3), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B2");
            Etudiant e16 = new Etudiant(16, "CRUZ", "Ronald", new DateTime(1976, 6, 5), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B2");
            Etudiant e17 = new Etudiant(17, "BOYD", "Oscar", new DateTime(1973, 6, 10), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B2");
            Etudiant e18 = new Etudiant(18, "BOWMAN", "Armando", new DateTime(1977, 4, 11), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B2");
            Etudiant e19 = new Etudiant(19, "HOFFMAN", "Roff", new DateTime(1981, 5, 11), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B2");

            Etudiant e20 = new Etudiant(20, "ROBINSON", "Sandra", new DateTime(1979, 3, 10), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B3");
            Etudiant e21 = new Etudiant(21, "ELLIS", "Pauline", new DateTime(1978, 1, 4), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B3");
            Etudiant e22 = new Etudiant(22, "SMITH", "Mabel", new DateTime(1978, 2, 12), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B3");
            Etudiant e23 = new Etudiant(23, "MASON", "Austin", new DateTime(1985, 4, 6), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B3");
            Etudiant e24 = new Etudiant(24, "BECK", "Francis", new DateTime(1977, 3, 1), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B3");
            Etudiant e25 = new Etudiant(25, "EVANS", "Collin", new DateTime(1976, 6, 8), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B3");
            Etudiant e26 = new Etudiant(26, "MONTGOMERY", "Ray", new DateTime(1985, 3, 12), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B3");
            Etudiant e27 = new Etudiant(27, "LABONTE", "Laurène", new DateTime(1992, 5, 25), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B3");
            Etudiant e28 = new Etudiant(28, "BERTRAND", "Ophelia", new DateTime(1994, 7, 20), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B3");
            Etudiant e29 = new Etudiant(29, "VARGAS", "Nina", new DateTime(1979, 1, 3), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B3");
            Etudiant e30 = new Etudiant(30, "CAISSE", "Florence", new DateTime(1989, 4, 30), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B3");
            Etudiant e31 = new Etudiant(31, "POULIOTTE", "Eleanor", new DateTime(1991, 10, 24), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B3");
            Etudiant e32 = new Etudiant(32, "FOUCAULT", "Claude", new DateTime(1978, 2, 18), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B3");
            Etudiant e33 = new Etudiant(33, "PATENAUDE", "Noël", new DateTime(1992, 10, 3), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B3");
            Etudiant e34 = new Etudiant(34, "GRANT", "Charlie", new DateTime(1979, 1, 3), "Rue des Apothicaires", "prenom.nom@epsi.fr", "B3");

            Etudiant e35 = new Etudiant(35, "AUDRIC", "Benoit", new DateTime(1990, 8, 23), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I4");
            Etudiant e36 = new Etudiant(36, "PETRIE", "David", new DateTime(1990, 9, 21), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I4");
            Etudiant e37 = new Etudiant(37, "HUPPE", "Kari", new DateTime(1988, 8, 28), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I4");
            Etudiant e38 = new Etudiant(38, "AUBE", "Royale", new DateTime(1988, 10, 3), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I4");
            Etudiant e39 = new Etudiant(39, "LABROSSE", "Gilbert", new DateTime(1997, 06, 27), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I4");
            Etudiant e40 = new Etudiant(40, "LECLERC", "Eddy", new DateTime(1995, 4, 22), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I4");
            Etudiant e41 = new Etudiant(41, "BRIARD", "Paul", new DateTime(1996, 11, 28), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I4");
            Etudiant e42 = new Etudiant(42, "GRIMARD", "Thierry", new DateTime(1993, 9, 29), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I4");
            Etudiant e43 = new Etudiant(43, "BROUSSEAU", "Mirabelle", new DateTime(1996, 07, 13), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I4");
            Etudiant e44 = new Etudiant(44, "ROYER", "Nicolas", new DateTime(1994, 5, 14), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I4");
            Etudiant e45 = new Etudiant(45, "DUBEAU", "Eleanor", new DateTime(1994, 6, 30), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I4");

            Etudiant e46 = new Etudiant(46, "LEREAU", "Mathilde", new DateTime(1992, 9, 7), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I5");
            Etudiant e47 = new Etudiant(47, "DESCHAMPS", "Hugo", new DateTime(1994, 12, 3), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I5");
            Etudiant e48 = new Etudiant(48, "MOUET", "Mathieu", new DateTime(1993, 12, 23), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I5");
            Etudiant e49 = new Etudiant(49, "DURAND", "Delphine", new DateTime(1993, 10, 10), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I5");
            Etudiant e50 = new Etudiant(50, "GRAS", "Lucie", new DateTime(1992, 8, 4), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I5");
            Etudiant e51 = new Etudiant(51, "CLAVETTE", "Marie", new DateTime(1992, 9, 4), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I5");
            Etudiant e52 = new Etudiant(52, "BOURGEAU", "Adrien", new DateTime(1995, 2, 1), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I5");
            Etudiant e53 = new Etudiant(53, "LAFOND", "Antoine", new DateTime(1994, 4, 28), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I5");
            Etudiant e54 = new Etudiant(54, "COUTURIER", "Eric", new DateTime(1989, 9, 2), "Rue des Apothicaires", "prenom.nom@epsi.fr", "I5");

            Classe B1 = new Classe(1, "B1", 20);
            Classe B2 = new Classe(1, "B1", 20);
            Classe B3 = new Classe(1, "B1", 20);
            Classe I4 = new Classe(1, "B1", 20);
            Classe I5 = new Classe(1, "B1", 20);
        }
    }
}
