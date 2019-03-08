using EcoleLibrary;
using System;

namespace EcoleLibrary
{
    class Statut
    {
        #region Attributs
        private Etudiant etudiant;
        static double Prix_Etudiant = 5000;
        static double Prix_PersonneReconversion = 3000;
        public enum TypeStatut { Etudiant, PersonneReconversion };
        #endregion

        #region Méthodes
        public static double getPrixClasse(Statut.TypeStatut typestatut)
        {
            double prix = Prix_PersonneReconversion;

            switch (typestatut)
            {
                case Statut.TypeStatut.Etudiant:
                    prix = Prix_Etudiant;
                    break;
            }

            return prix;
        }

        public TypeStatut typeclasseetudiant { get; set; }

        public Etudiant Etudiant
        {
            get { return etudiant; }
            set { etudiant = value; }
        }

        public void Identite()
        {
            Console.WriteLine("ID : " + Etudiant.Id + "\nIdentité : " + Etudiant.Nom + " " + Etudiant.Prenom + "\nDate Naiss : " + Etudiant.DateNaissance.ToShortDateString() + "\n***********************");
        }
        #endregion

        #region Constructeur
        public Statut(Etudiant etudiant, TypeStatut typestatut)
        {
            Etudiant = etudiant;
            typeclasseetudiant = typestatut;
        }
        #endregion
    }
}
