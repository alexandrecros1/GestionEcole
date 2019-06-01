using System.Data;
using System.Data.SqlClient;

namespace EcoleLibrary
{
    public class GestionBase
    {
        #region Attributes
        // Chaine de connection à la BD
        private string connectionString;
        // Connection à la BD
        public SqlConnection connection;
        #endregion

        #region Builders
        public GestionBase()
        {
            this.connectionString = Connexion.Connect;
            connection = new SqlConnection(connectionString);
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

        public SqlConnection GetMySqlConnection() { return this.connection; }
        #endregion
    }
}
