using EcoleLibrary;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class ListeEtudiant : Form
    {
        public ListeEtudiant()
        {
            InitializeComponent();
        }

        private void ListeEtudiant_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void AffichageEtudiant()
        {
            GestionEtudiant gestion = new GestionEtudiant();
            List<Etudiant> Liste = gestion.ListeEtudiant();
            foreach (var etudiant in Liste)
            {
                ListViewItem ligne = new ListViewItem(new string[] { etudiant.Nom, etudiant.Prenom, etudiant.DateNaissance.ToString("ddMMyyyy"), etudiant.Adresse, etudiant.Mail });
                listView1.Items.Add(ligne);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AffichageEtudiant();
        }
    }
}