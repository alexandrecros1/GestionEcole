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
    }
}
