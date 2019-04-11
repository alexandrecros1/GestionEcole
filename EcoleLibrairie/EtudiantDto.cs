using System;
using System.Collections.Generic;

namespace EcoleLibrary
{
    public class EtudiantDto
    {
        #region Attributs
        private int idEtudiant;
        private string nomEtudiant;
        private string prenomEtudiant;
        private DateTime dateNaissanceEtudiant;
        private string adresseEtudiant;
        private string mailEtudiant;
        private int idClasse;
        private int idVille;
        private int idStatut;
        public List<EtudiantDto> ListeEtudiant = new List<EtudiantDto>();
        #endregion

        #region Propriétés
        public int Id {
            get { return idEtudiant; }
            private set { idEtudiant = value; }
        }
        public string Nom { 
            get { return nomEtudiant; }
            set { nomEtudiant = value; }
        }
        public string Prenom {
            get { return prenomEtudiant; }
            set { prenomEtudiant = value; }
        }

        public DateTime DateNaissance {
            get { return dateNaissanceEtudiant; }
            set { dateNaissanceEtudiant = value; }
        }

        public string Adresse
        {
            get { return adresseEtudiant; }
            set { adresseEtudiant = value; }
        }

        public string Mail
        {
            get { return mailEtudiant; }
            set { mailEtudiant = value; }
        }

        public int Idclasse
        {
            get { return idClasse; }
            set { idClasse = value; }
        }

        public int Idville
        {
            get { return idVille; }
            set { idVille = value; }
        }

        public int Idstatut
        {
            get { return idStatut; }
            set { idStatut = value; }
        }
        #endregion

        #region Constructeur
        public EtudiantDto(int idEtudiant, string nomEtudiant, string prenomEtudiant, DateTime dateNaissanceEtudiant, string adresseEtudiant,
            string mailEtudiant, int idClasse, int idVille, int idStatut)
        {
            Id = idEtudiant;
            Nom = nomEtudiant;
            Prenom = prenomEtudiant;
            DateNaissance = dateNaissanceEtudiant;
            Adresse = adresseEtudiant;
            Mail = mailEtudiant;
            Idclasse = idClasse;
            Idville = idVille;
            Idstatut = idStatut;
        }
        #endregion
    }
}
