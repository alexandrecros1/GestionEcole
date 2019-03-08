using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleLibrary
{
    public class Classe
    {
        #region Attributs
        private int idclasse;
        private string nomclasse;
        private int nbPlace;
        private List<Classe> listeClasse = new List<Classe>();
        #endregion

        #region Propriétés
        public int Idclasse
        {
            get { return idclasse; }
            set { idclasse = value; }
        }
        public string Nomclasse
        {
            get { return nomclasse; }
            set { nomclasse = value; }
        }
        public int Nbplace
        {
            get { return nbPlace; }
            set { nbPlace = value; }
        }
        public List<Classe> ListeClasse
        {
            get { return listeClasse; }
        }
        #endregion

        #region Constructeur
        public Classe(int id, string nomclasse, int nbPlace)
        {
            Idclasse = id;
            Nomclasse = nomclasse;
            Nbplace = nbPlace;
        }
        #endregion

        #region Méthodes de recherche
        public Classe RechercherClasse(int id)
        {
            return listeClasse.Find(delegate (Classe classe)
            {
                return classe.Idclasse == id;
            });
        }
        #endregion
    }
}
