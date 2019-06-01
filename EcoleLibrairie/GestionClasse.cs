using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace EcoleLibrary
{
    public class GestionClasse : GestionBase
    {
        private static GestionClasse instance;
        #region Builders
       
        #endregion

        public List<Classe> ListeClasse()
        {
            List<Classe> liste = new List<Classe>();
            try
            {
                Open();

                string query = @"SELECT * FROM classe";
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        Classe classe = new Classe(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(3));
                        if (classe != null)
                            liste.Add(classe);
                    }
                    catch (SqlException)
                    {

                    }

                }
                reader.Close();
            }
            catch (SqlException)
            {
            }
            finally
            {
                Close();
            }
            return liste;
        }

        #region CRUD

        // Ajouter une Classe : le C dans CRUD
        public bool AjouterClasse(Classe classe)
        {
            bool result = false;
            try
            {
                Open();

                string query = "INSERT INTO Classe (nomClasse, nbPlace) VALUES (@nomClasse, @nbPlace)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nomClasse", classe.Nomclasse);
                cmd.Parameters.AddWithValue("@nbPlace", classe.Nbplace);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException)
            {
                result = false;
            }
            finally
            {
                Close();
            }
            return result;
        }

        // Supprimer une Classe : le D dans CRUD
        public bool SupprimerClasse(Classe classe)
        { 
            bool result = true;
            try
            {
                Open();
                string query = @"DELETE FROM Classe WHERE idClasse = @idClasse";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idClasse", classe.Idclasse);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                result = false;
            }
            finally
            {
                Close();
            }
            return result;
        }

        // Modifier une Classe : le U dans CRUD
        public bool ModifierClasse(Classe classe)
        {
            bool result = true;
            try
            {
                Open();
                string query = @"UPDATE Classe SET nomClasse = @nomClasse, nbPlace = @nbPlace WHERE idClasse = @idClasse";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idClasse", classe.Idclasse);
                cmd.Parameters.AddWithValue("@nomClasse", classe.Nomclasse);
                cmd.Parameters.AddWithValue("@nbPlace", classe.Nbplace);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                result = false;
            }
            finally
            {
                Close();
            }
            return result;
        }
        #endregion
        public GestionClasse() : base()
        {
        }
        public static GestionClasse Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GestionClasse();
                }
                return instance;
            }
        }
    }
}
