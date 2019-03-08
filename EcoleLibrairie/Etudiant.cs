using System;

namespace EcoleLibrary
{
    public class Etudiant
    {
        #region Attributs
        private int id;
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private string adresse;
        private string mail;
        private string classe;
        #endregion

        #region Propriétés
        public int Id {
            get { return id; }
            private set { id = value; }
        }
        public string Nom { 
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom {
            get { return prenom; }
            set { prenom = value; }
        }

        public DateTime DateNaissance {
            get { return dateNaissance; }
            set { dateNaissance = value; }
        }

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public string Classe
        {
            get { return classe; }
            set { classe = value; }
        }
        #endregion

        #region Constructeur
        public Etudiant(int id, string nom, string prenom, DateTime dateNaissance, string adresse, string mail, string classe)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Adresse = adresse;
            Mail = mail;
            Classe = classe;
        }
        #endregion
    }
}
