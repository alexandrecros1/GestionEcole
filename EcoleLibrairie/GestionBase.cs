using MySql.Data.MySqlClient;
using System.Data;

namespace EcoleLibrary
{
    public class GestionBase
    {
        #region Attributes
        // Chaine de connection à la BD
        private string connectionString;
        // Connection à la BD
        public MySqlConnection connection;
        #endregion

        #region Builders
        public GestionBase()
        {
            this.connectionString = Connexion.ADO_CONNEXION_STRING;
            connection = new MySqlConnection(connectionString);
        }
        #endregion

        #region Connection
        public void Open()
        {
            if (connection != null && connection.State == ConnectionState.Closed)
                connection.Open();
        }
        public bool IsOpenned()
        {
            if (connection != null && connection.State == ConnectionState.Open)
                return true;

            return false;
        }
        public void Close()
        {
            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetMySqlConnection() { return this.connection; }
        #endregion
    }
}
