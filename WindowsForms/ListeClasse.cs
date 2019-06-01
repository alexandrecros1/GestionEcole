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
    public partial class ListeClasse : Form
    {
        public ListeClasse()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListeClasse_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'classeDataSet.classe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.classeTableAdapter.Fill(this.classeDataSet.classe);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionClasse ajoutCla = GestionClasse.Instance;

            Classe classe = new Classe(0, nomClasse.Text, Convert.ToInt32(nbPlace.Text));
            ajoutCla.AjouterClasse(classe);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = e.RowIndex;
            DataGridViewRow ligne = dataGridView1.Rows[selectedrowindex];

            idClasse.Text = ligne.Cells[0].Value.ToString();
            nomClasse.Text = ligne.Cells[1].Value.ToString();
            nbPlace.Text = ligne.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionClasse modifClasse = GestionClasse.Instance;

            Classe cla = new Classe(Convert.ToInt32(idClasse.Text), nomClasse.Text, Convert.ToInt32(nbPlace.Text));
            modifClasse.ModifierClasse(cla);
        }

        private void BoutonAjout_Click(object sender, EventArgs e)
        {
            GestionClasse suppClasse = GestionClasse.Instance;

            Classe cla = new Classe(Convert.ToInt32(idClasse.Text), nomClasse.Text, Convert.ToInt32(nbPlace.Text));
            suppClasse.SupprimerClasse(cla);
        }
    }
}
