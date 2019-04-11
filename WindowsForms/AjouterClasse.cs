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
    public partial class AjouterClasse : Form
    {
        public AjouterClasse()
        {
            InitializeComponent();
        }

        private void AjouterClasse_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionClasse newclasse = GestionClasse.Instance;
            Classe c = new Classe(0, nomclasse.Text, Convert.ToInt32(nbPlace.Text));
            newclasse.AjouterClasse(c);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
