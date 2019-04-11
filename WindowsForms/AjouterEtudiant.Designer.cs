namespace WindowsForms
{
    partial class AjouterEtudiant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nomEtudiant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prenomEtudiant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datenaissanceEtudiant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.adresseEtudiant = new System.Windows.Forms.TextBox();
            this.mailEtudiant = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statutEtudiant = new System.Windows.Forms.ComboBox();
            this.villeEtudiant = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.classeEtudiant = new System.Windows.Forms.ComboBox();
            this.ajoutEtudiantClasse = new WindowsForms.ajoutEtudiantClasse();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classeTableAdapter = new WindowsForms.ajoutEtudiantClasseTableAdapters.classeTableAdapter();
            this.ajoutEtudiantVille = new WindowsForms.ajoutEtudiantVille();
            this.villeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villeTableAdapter = new WindowsForms.ajoutEtudiantVilleTableAdapters.villeTableAdapter();
            this.ajoutEtudiantStatut = new WindowsForms.ajoutEtudiantStatut();
            this.statutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statutTableAdapter = new WindowsForms.ajoutEtudiantStatutTableAdapters.statutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutEtudiantClasse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutEtudiantVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutEtudiantStatut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un étudiant";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomEtudiant
            // 
            this.nomEtudiant.Location = new System.Drawing.Point(234, 64);
            this.nomEtudiant.Name = "nomEtudiant";
            this.nomEtudiant.Size = new System.Drawing.Size(100, 22);
            this.nomEtudiant.TabIndex = 1;
            this.nomEtudiant.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prénom :";
            // 
            // prenomEtudiant
            // 
            this.prenomEtudiant.Location = new System.Drawing.Point(234, 106);
            this.prenomEtudiant.Name = "prenomEtudiant";
            this.prenomEtudiant.Size = new System.Drawing.Size(100, 22);
            this.prenomEtudiant.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date de naissance :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // datenaissanceEtudiant
            // 
            this.datenaissanceEtudiant.Location = new System.Drawing.Point(234, 150);
            this.datenaissanceEtudiant.Name = "datenaissanceEtudiant";
            this.datenaissanceEtudiant.Size = new System.Drawing.Size(100, 22);
            this.datenaissanceEtudiant.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Classe :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Adresse :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mail :";
            // 
            // adresseEtudiant
            // 
            this.adresseEtudiant.Location = new System.Drawing.Point(234, 193);
            this.adresseEtudiant.Name = "adresseEtudiant";
            this.adresseEtudiant.Size = new System.Drawing.Size(100, 22);
            this.adresseEtudiant.TabIndex = 11;
            // 
            // mailEtudiant
            // 
            this.mailEtudiant.Location = new System.Drawing.Point(234, 235);
            this.mailEtudiant.Name = "mailEtudiant";
            this.mailEtudiant.Size = new System.Drawing.Size(100, 22);
            this.mailEtudiant.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statutEtudiant
            // 
            this.statutEtudiant.DataSource = this.statutBindingSource;
            this.statutEtudiant.DisplayMember = "nomStatut";
            this.statutEtudiant.FormattingEnabled = true;
            this.statutEtudiant.Location = new System.Drawing.Point(234, 360);
            this.statutEtudiant.Name = "statutEtudiant";
            this.statutEtudiant.Size = new System.Drawing.Size(100, 24);
            this.statutEtudiant.TabIndex = 14;
            this.statutEtudiant.ValueMember = "idclasse";
            // 
            // villeEtudiant
            // 
            this.villeEtudiant.DataSource = this.villeBindingSource;
            this.villeEtudiant.DisplayMember = "nomVille";
            this.villeEtudiant.FormattingEnabled = true;
            this.villeEtudiant.Location = new System.Drawing.Point(234, 316);
            this.villeEtudiant.Name = "villeEtudiant";
            this.villeEtudiant.Size = new System.Drawing.Size(100, 24);
            this.villeEtudiant.TabIndex = 15;
            this.villeEtudiant.ValueMember = "idclasse";
            this.villeEtudiant.SelectedIndexChanged += new System.EventHandler(this.villeEtudiant_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Statut :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ville :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // classeEtudiant
            // 
            this.classeEtudiant.DataSource = this.classeBindingSource;
            this.classeEtudiant.DisplayMember = "nomClasse";
            this.classeEtudiant.FormattingEnabled = true;
            this.classeEtudiant.Location = new System.Drawing.Point(234, 276);
            this.classeEtudiant.Name = "classeEtudiant";
            this.classeEtudiant.Size = new System.Drawing.Size(100, 24);
            this.classeEtudiant.TabIndex = 8;
            this.classeEtudiant.ValueMember = "nomClasse";
            this.classeEtudiant.SelectedIndexChanged += new System.EventHandler(this.classeEtudiant_SelectedIndexChanged);
            // 
            // ajoutEtudiantClasse
            // 
            this.ajoutEtudiantClasse.DataSetName = "ajoutEtudiantClasse";
            this.ajoutEtudiantClasse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classeBindingSource
            // 
            this.classeBindingSource.DataMember = "classe";
            this.classeBindingSource.DataSource = this.ajoutEtudiantClasse;
            // 
            // classeTableAdapter
            // 
            this.classeTableAdapter.ClearBeforeFill = true;
            // 
            // ajoutEtudiantVille
            // 
            this.ajoutEtudiantVille.DataSetName = "ajoutEtudiantVille";
            this.ajoutEtudiantVille.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // villeBindingSource
            // 
            this.villeBindingSource.DataMember = "ville";
            this.villeBindingSource.DataSource = this.ajoutEtudiantVille;
            // 
            // villeTableAdapter
            // 
            this.villeTableAdapter.ClearBeforeFill = true;
            // 
            // ajoutEtudiantStatut
            // 
            this.ajoutEtudiantStatut.DataSetName = "ajoutEtudiantStatut";
            this.ajoutEtudiantStatut.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statutBindingSource
            // 
            this.statutBindingSource.DataMember = "statut";
            this.statutBindingSource.DataSource = this.ajoutEtudiantStatut;
            // 
            // statutTableAdapter
            // 
            this.statutTableAdapter.ClearBeforeFill = true;
            // 
            // AjouterEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(578, 495);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.villeEtudiant);
            this.Controls.Add(this.statutEtudiant);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mailEtudiant);
            this.Controls.Add(this.adresseEtudiant);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.classeEtudiant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datenaissanceEtudiant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prenomEtudiant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomEtudiant);
            this.Controls.Add(this.label1);
            this.Name = "AjouterEtudiant";
            this.Text = "AjouterEtudiant";
            this.Load += new System.EventHandler(this.AjouterEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ajoutEtudiantClasse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutEtudiantVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutEtudiantStatut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomEtudiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prenomEtudiant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox datenaissanceEtudiant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adresseEtudiant;
        private System.Windows.Forms.TextBox mailEtudiant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox statutEtudiant;
        private System.Windows.Forms.ComboBox villeEtudiant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox classeEtudiant;
        private ajoutEtudiantClasse ajoutEtudiantClasse;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private ajoutEtudiantClasseTableAdapters.classeTableAdapter classeTableAdapter;
        private ajoutEtudiantVille ajoutEtudiantVille;
        private System.Windows.Forms.BindingSource villeBindingSource;
        private ajoutEtudiantVilleTableAdapters.villeTableAdapter villeTableAdapter;
        private ajoutEtudiantStatut ajoutEtudiantStatut;
        private System.Windows.Forms.BindingSource statutBindingSource;
        private ajoutEtudiantStatutTableAdapters.statutTableAdapter statutTableAdapter;
    }
}