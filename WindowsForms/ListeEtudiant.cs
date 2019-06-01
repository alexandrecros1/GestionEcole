using EcoleLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class ListeEtudiant : Form
    {
        public ListeEtudiant()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ListeEtudiant_Load(object sender, EventArgs e)
        {
            this.statutTableAdapter.Fill(this.ajoutEtudiantStatut.statut);
            this.classeTableAdapter1.Fill(this.ajoutEtudiantClasse.classe);
            this.villeTableAdapter.Fill(this.ajoutEtudiantVille.ville);
            this.classeTableAdapter.Fill(this.classeDataSet.classe);
            this.etudiantTableAdapter.Fill(this.etudiantDataSet.etudiant);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = e.RowIndex;
            DataGridViewRow ligne = dataGridView1.Rows[selectedrowindex];

            idEtudiant.Text = ligne.Cells[0].Value.ToString();
            nomEtudiant.Text = ligne.Cells[1].Value.ToString();
            prenomEtudiant.Text = ligne.Cells[2].Value.ToString();
            dateNaissanceEtudiant.Text = ligne.Cells[3].Value.ToString();
            adresseEtudiant.Text = ligne.Cells[4].Value.ToString();
            mailEtudiant.Text = ligne.Cells[5].Value.ToString();
            classeEtudiant.SelectedValue = ligne.Cells[6].Value.ToString();
            villeEtudiant.SelectedValue = ligne.Cells[7].Value.ToString();
            statutEtudiant.SelectedValue = ligne.Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionEtudiant ajoutEtu = GestionEtudiant.Instance;

            EtudiantDto etu = new EtudiantDto(0, nomEtudiant.Text, prenomEtudiant.Text, Convert.ToDateTime(dateNaissanceEtudiant.Text), 
            adresseEtudiant.Text, mailEtudiant.Text, Convert.ToInt32(classeEtudiant.SelectedValue), Convert.ToInt32(villeEtudiant.SelectedValue),
            Convert.ToInt32(statutEtudiant.SelectedValue));
            ajoutEtu.AjouterEtudiant(etu);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionEtudiant modifEtu = GestionEtudiant.Instance;

            EtudiantDto etu = new EtudiantDto(Convert.ToInt32(idEtudiant.Text), nomEtudiant.Text, prenomEtudiant.Text, Convert.ToDateTime(dateNaissanceEtudiant.Text),
            adresseEtudiant.Text, mailEtudiant.Text, Convert.ToInt32(classeEtudiant.SelectedValue), Convert.ToInt32(villeEtudiant.SelectedValue),
            Convert.ToInt32(statutEtudiant.SelectedValue));
            modifEtu.ModifierEtudiant(etu);
        }

        private void BoutonAjout_Click(object sender, EventArgs e)
        {
            GestionEtudiant suppEtu = GestionEtudiant.Instance;

            EtudiantDto etu = new EtudiantDto(Convert.ToInt32(idEtudiant.Text), nomEtudiant.Text, prenomEtudiant.Text, Convert.ToDateTime(dateNaissanceEtudiant.Text),
            adresseEtudiant.Text, mailEtudiant.Text, Convert.ToInt32(classeEtudiant.SelectedValue), Convert.ToInt32(villeEtudiant.SelectedValue),
            Convert.ToInt32(statutEtudiant.SelectedValue));
            suppEtu.SupprimerEtudiant(etu);
        }
    }
}
