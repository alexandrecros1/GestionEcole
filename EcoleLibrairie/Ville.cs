using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleLibrary
{
    class Ville
    {
        #region Attributs
        private int idVille;
        private string nomVille;
        #endregion

        #region Propriétés
        public int Idville
        {
            get { return idVille; }
            private set { idVille = value; }
        }
        public string Nomville
        {
            get { return nomVille; }
            private set { nomVille = value; }
        }
        #endregion

        #region Constructeur
        public Ville(int idVille, string nomVille)
        {
            Idville = idVille;
            Nomville = nomVille;
        }
        #endregion
    }
}
