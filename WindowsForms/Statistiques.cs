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
    public partial class Statistiques : Form
    {
        public Statistiques()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Statistiques_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'viewAverageEtudiants.ViewAverageStudents'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.viewAverageStudentsTableAdapter.Fill(this.viewAverageEtudiants.ViewAverageStudents);

            // TODO: cette ligne de code charge les données dans la table 'viewCountEtudiants.ViewCountStudents'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.viewCountStudentsTableAdapter.Fill(this.viewCountEtudiants.ViewCountStudents);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
