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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // BOUTON AJOUT ETUDIANT
        private void button2_Click(object sender, EventArgs e)
        {
            AjouterEtudiant frm = new AjouterEtudiant();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        { 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Statistiques frm = new Statistiques();
            frm.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ListeEtudiant frm = new ListeEtudiant();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ListeClasse frm = new ListeClasse();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AjouterClasse frm = new AjouterClasse();
            frm.ShowDialog();
        }
    }
}
