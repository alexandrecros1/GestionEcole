using EcoleLibrary;
using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class AjouterEtudiant : Form
    {
        public AjouterEtudiant()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AjouterEtudiant_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'ajoutEtudiantStatut.statut'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.statutTableAdapter.Fill(this.ajoutEtudiantStatut.statut);
            // TODO: cette ligne de code charge les données dans la table 'ajoutEtudiantVille.ville'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.villeTableAdapter.Fill(this.ajoutEtudiantVille.ville);
            // TODO: cette ligne de code charge les données dans la table 'ajoutEtudiantClasse.classe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.classeTableAdapter.Fill(this.ajoutEtudiantClasse.classe);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // RETOUR A L'ACCUEIL
        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionEtudiant ajout = GestionEtudiant.Instance;
            EtudiantDto etu = new EtudiantDto(0, nomEtudiant.Text, prenomEtudiant.Text, Convert.ToDateTime(datenaissanceEtudiant.Text),
                adresseEtudiant.Text, mailEtudiant.Text, Convert.ToInt32(classeEtudiant), Convert.ToInt32(villeEtudiant), Convert.ToInt32(statutEtudiant));
            ajout.AjouterEtudiant(etu);
        }

        private void classeEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void villeEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
