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
            // TODO: cette ligne de code charge les données dans la table 'etudiantDataSet.etudiant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.etudiantTableAdapter.Fill(this.etudiantDataSet.etudiant);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
