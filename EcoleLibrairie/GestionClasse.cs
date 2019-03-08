using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace EcoleLibrary
{
    public class GestionClasse : GestionBase
    {
        #region Builders
        public GestionClasse() : base()
        {
        }
        #endregion

        public List<Classe> ListeClasse()
        {
            List<Classe> liste = new List<Classe>();
            try
            {
                Open();

                string query = "SELECT * FROM classe";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        Classe classe = new Classe(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(3));
                        if (classe != null)
                            liste.Add(classe);
                    }
                    catch (MySqlException)
                    {

                    }

                }
                reader.Close();
            }
            catch (MySqlException)
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
            bool result = true;
            try
            {
                Open();
                string query = @"INSERT INTO Classe VALUES (@idclasse, @nomclasse, @nbplace)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idclasse", classe.Idclasse);
                cmd.Parameters.AddWithValue("@nomclasse", classe.Nomclasse);
                cmd.Parameters.AddWithValue("@nbplace", classe.Nbplace);
                MySqlParameter idclasse = cmd.Parameters.Add("@idclasse", MySqlDbType.Int32);
                idclasse.Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException)
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
            int result = 0;
            try
            {
                Open();
                string query = @"DELETE FROM Classe WHERE Idclasse = @idclasse";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idclasse", classe.Idclasse);
                result = cmd.ExecuteNonQuery();
            }
            catch (MySqlException)
            {
            }
            finally
            {
                Close();
            }
            return false;
        }

        // Modifier une Classe : le U dans CRUD
        public bool ModifierClasse(Classe classe)
        {
            int result = 0;
            try
            {
                Open();
                string query = @"UPDATE classe SET Idclasse = @idclasse, Nomclasse = @nomclasse, Nbplace = @nbplace WHERE Idclasse = @idclasse";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idclasse", classe.Idclasse);
                cmd.Parameters.AddWithValue("@nomclasse", classe.Nomclasse);
                cmd.Parameters.AddWithValue("@nbplace", classe.Nbplace);
                result = cmd.ExecuteNonQuery();
            }
            catch (MySqlException)
            {
            }
            finally
            {
                Close();
            }
            return false;

        }
        #endregion
    }
}
