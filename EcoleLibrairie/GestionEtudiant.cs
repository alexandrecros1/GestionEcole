﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EcoleLibrary
{
    public class GestionEtudiant : GestionBase
    {
        private static GestionEtudiant instance;
        #region Builders
        public GestionEtudiant() : base()
        {
        }
        #endregion

        public List<EtudiantDto> ListeEtudiant()
        {
            List<EtudiantDto> liste = new List<EtudiantDto>();
            try
            {
                Open();

                string query = "SELECT * FROM etudiant";
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        EtudiantDto etudiant = new EtudiantDto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                            reader.GetDateTime(3), reader.GetString(4), reader.GetString(5), reader.GetInt32(6), reader.GetInt32(7), reader.GetInt32(8));
                        if (etudiant != null)
                            liste.Add(etudiant);
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
        // Ajouter un étudiant : le C dans CRUD
        public bool AjouterEtudiant(EtudiantDto etudiant)
        {
            bool result = true;
            try
            {
                Open();
                string query = @"INSERT INTO Etudiant (nomEtudiant, prenomEtudiant, dateNaissanceEtudiant, adresseEtudiant, mailEtudiant, idClasse,
idVille, idStatut) VALUES (@nomEtudiant, @prenomEtudiant, @dateNaissanceEtudiant, @adresseEtudiant, @mailEtudiant, @idClasse, @idVille, @idStatut)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nomEtudiant", etudiant.Nom);
                cmd.Parameters.AddWithValue("@prenomEtudiant", etudiant.Prenom);
                cmd.Parameters.AddWithValue("@dateNaissanceEtudiant", etudiant.DateNaissance);
                cmd.Parameters.AddWithValue("@adresseEtudiant", etudiant.Adresse);
                cmd.Parameters.AddWithValue("@mailEtudiant", etudiant.Mail);
                cmd.Parameters.AddWithValue("@idClasse", etudiant.Idclasse);
                cmd.Parameters.AddWithValue("@idVille", etudiant.Idville);
                cmd.Parameters.AddWithValue("@idStatut", etudiant.Idstatut);
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

        // Supprimer un étudiant : le D dans CRUD
        public bool SupprimerEtudiant(EtudiantDto etudiant)
        {
            bool result = true;
            try
            {
                Open();
                string query = @"DELETE FROM Etudiant WHERE idEtudiant = @idEtudiant";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idEtudiant", etudiant.Id);
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

        // Modifier un étudiant : le U dans CRUD
        public bool ModifierEtudiant(EtudiantDto etudiant)
        {
            bool result = true;
            try
            {
                Open();
                string query = @"UPDATE Etudiant SET nomEtudiant = @nomEtudiant, prenomEtudiant = @prenomEtudiant,
dateNaissanceEtudiant = @dateNaissanceEtudiant, adresseEtudiant = @adresseEtudiant, mailEtudiant = @mailEtudiant, idClasse = @idClasse,
idVille = @idVille, idStatut = @idStatut WHERE idEtudiant = @idEtudiant";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idEtudiant", etudiant.Id);
                cmd.Parameters.AddWithValue("@nomEtudiant", etudiant.Nom);
                cmd.Parameters.AddWithValue("@prenomEtudiant", etudiant.Prenom);
                cmd.Parameters.AddWithValue("@dateNaissanceEtudiant", etudiant.DateNaissance);
                cmd.Parameters.AddWithValue("@adresseEtudiant", etudiant.Adresse);
                cmd.Parameters.AddWithValue("@mailEtudiant", etudiant.Mail);
                cmd.Parameters.AddWithValue("@idClasse", etudiant.Idclasse);
                cmd.Parameters.AddWithValue("@idVille", etudiant.Idville);
                cmd.Parameters.AddWithValue("@idStatut", etudiant.Idstatut);
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

        public static GestionEtudiant Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new GestionEtudiant();
                }
                return instance;
            }
        }
    }
}