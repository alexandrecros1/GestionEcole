using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace EcoleLibrary
{
    public class GestionEtudiant : GestionBase
    {
        #region Builders
        public GestionEtudiant() : base()
        {
        }
        #endregion

        public List<Etudiant> ListeEtudiant()
        {
            List<Etudiant> liste = new List<Etudiant>();
            try
            {
                Open();

                string query = "SELECT * FROM etudiant";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        Etudiant etudiant = new Etudiant(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                            reader.GetDateTime(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                        if (etudiant != null)
                            liste.Add(etudiant);
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
        public bool AjouterEtudiant(Etudiant etudiant)
        {
            bool result = true;
            try
            {
                Open();
                string query = @"INSERT INTO Classe VALUES (@id, @nom, @prenom, @dateNaissance, @adresse, @mail, @classe)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", etudiant.Id);
                cmd.Parameters.AddWithValue("@nom", etudiant.Nom);
                cmd.Parameters.AddWithValue("@prenom", etudiant.Prenom);
                cmd.Parameters.AddWithValue("@dateNaissance", etudiant.DateNaissance);
                cmd.Parameters.AddWithValue("@adresse", etudiant.Adresse);
                cmd.Parameters.AddWithValue("@mail", etudiant.Mail);
                cmd.Parameters.AddWithValue("@classe", etudiant.Classe);
                MySqlParameter idclasse = cmd.Parameters.Add("@idclasse", SqlDbType.Int);
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

        // Supprimer un étudiant : le D dans CRUD
        public bool SupprimerEtudiant(Etudiant etudiant)
        {
            int result = 0;
            try
            {
                Open();
                string query = @"DELETE FROM Etudiant WHERE Id = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", etudiant.Id);
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

        // Modifier un étudiant : le U dans CRUD
        public bool ModifierEtudiant(Etudiant etudiant)
        {
            int result = 0;
            try
            {
                Open();
                string query = @"UPDATE etudiant SET Id = @id, Nom = @nom, Prenom = @prenom, DateNaissance = @dateNaissance,
                                Adresse = @adresse, Mail = @mail, Classe = @classe WHERE Id = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", etudiant.Id);
                cmd.Parameters.AddWithValue("@nom", etudiant.Nom);
                cmd.Parameters.AddWithValue("@prenom", etudiant.Prenom);
                cmd.Parameters.AddWithValue("@dateNaissance", etudiant.DateNaissance);
                cmd.Parameters.AddWithValue("@adresse", etudiant.Adresse);
                cmd.Parameters.AddWithValue("@mail", etudiant.Mail);
                cmd.Parameters.AddWithValue("@classe", etudiant.Classe);
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