namespace WindowsForms
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titre = new System.Windows.Forms.Label();
            this.StatistiquesBouton = new System.Windows.Forms.Button();
            this.ListeEtudiantsBouton = new System.Windows.Forms.Button();
            this.ListeClassesBouton = new System.Windows.Forms.Button();
            this.LogoManagSchool = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoManagSchool)).BeginInit();
            this.SuspendLayout();
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Calisto MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.Location = new System.Drawing.Point(153, 30);
            this.Titre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(359, 32);
            this.Titre.TabIndex = 0;
            this.Titre.Text = "Bienvenue sur Manag\'School";
            this.Titre.Click += new System.EventHandler(this.label1_Click);
            // 
            // StatistiquesBouton
            // 
            this.StatistiquesBouton.BackColor = System.Drawing.Color.LightGray;
            this.StatistiquesBouton.Location = new System.Drawing.Point(215, 429);
            this.StatistiquesBouton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.StatistiquesBouton.Name = "StatistiquesBouton";
            this.StatistiquesBouton.Size = new System.Drawing.Size(149, 52);
            this.StatistiquesBouton.TabIndex = 3;
            this.StatistiquesBouton.Text = "STATISTIQUES";
            this.StatistiquesBouton.UseVisualStyleBackColor = false;
            this.StatistiquesBouton.Click += new System.EventHandler(this.button3_Click);
            // 
            // ListeEtudiantsBouton
            // 
            this.ListeEtudiantsBouton.BackColor = System.Drawing.Color.LightGray;
            this.ListeEtudiantsBouton.Location = new System.Drawing.Point(79, 330);
            this.ListeEtudiantsBouton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ListeEtudiantsBouton.Name = "ListeEtudiantsBouton";
            this.ListeEtudiantsBouton.Size = new System.Drawing.Size(149, 52);
            this.ListeEtudiantsBouton.TabIndex = 12;
            this.ListeEtudiantsBouton.Text = "ÉTUDIANTS";
            this.ListeEtudiantsBouton.UseVisualStyleBackColor = false;
            this.ListeEtudiantsBouton.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // ListeClassesBouton
            // 
            this.ListeClassesBouton.BackColor = System.Drawing.Color.LightGray;
            this.ListeClassesBouton.Location = new System.Drawing.Point(349, 330);
            this.ListeClassesBouton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ListeClassesBouton.Name = "ListeClassesBouton";
            this.ListeClassesBouton.Size = new System.Drawing.Size(149, 52);
            this.ListeClassesBouton.TabIndex = 13;
            this.ListeClassesBouton.Text = "CLASSES";
            this.ListeClassesBouton.UseVisualStyleBackColor = false;
            this.ListeClassesBouton.Click += new System.EventHandler(this.button8_Click);
            // 
            // LogoManagSchool
            // 
            this.LogoManagSchool.Image = global::WindowsForms.Properties.Resources.logo_managschool;
            this.LogoManagSchool.Location = new System.Drawing.Point(155, 84);
            this.LogoManagSchool.Name = "LogoManagSchool";
            this.LogoManagSchool.Size = new System.Drawing.Size(272, 221);
            this.LogoManagSchool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoManagSchool.TabIndex = 14;
            this.LogoManagSchool.TabStop = false;
            this.LogoManagSchool.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(576, 531);
            this.Controls.Add(this.LogoManagSchool);
            this.Controls.Add(this.ListeClassesBouton);
            this.Controls.Add(this.ListeEtudiantsBouton);
            this.Controls.Add(this.StatistiquesBouton);
            this.Controls.Add(this.Titre);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoManagSchool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Button StatistiquesBouton;
        private System.Windows.Forms.Button ListeEtudiantsBouton;
        private System.Windows.Forms.Button ListeClassesBouton;
        private System.Windows.Forms.PictureBox LogoManagSchool;
    }
}

