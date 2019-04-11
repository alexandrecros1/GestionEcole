using EcoleLibrary;
using System;

namespace EcoleLibrary
{
    class Statut
    {
        #region Attributs
        private int idStatut;
        private string nomStatut;
        private int prixFormation;
        #endregion

        #region Méthodes

        public int Idstatut
        {
            get { return idStatut; }
            set { idStatut = value; }
        }
        public string Nomstatut
        {
            get { return nomStatut; }
            set { nomStatut = value; }
        }
        public int Prixformation
        {
            get { return prixFormation; }
            set { prixFormation = value; }
        }
        #endregion

        #region Constructeur
        public Statut(int idStatut, string nomStatut, int prixFormation)
        {
            Idstatut = idStatut;
            Nomstatut = nomStatut;
            Prixformation = prixFormation;
        }
        #endregion
    }
}
