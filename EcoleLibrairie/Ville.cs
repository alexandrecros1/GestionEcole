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
        private int idville;
        private string nomville;
        #endregion

        #region Propriétés
        public int Idville
        {
            get { return idville; }
            private set { idville = value; }
        }
        public string Nomville
        {
            get { return nomville; }
            private set { nomville = value; }
        }
        #endregion

        #region Constructeur
        public Ville(int idville, string nomville)
        {
            Idville = idville;
            Nomville = nomville;
        }
        #endregion
    }
}
