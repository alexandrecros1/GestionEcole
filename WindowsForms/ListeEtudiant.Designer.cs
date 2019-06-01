namespace WindowsForms
{
    partial class ListeEtudiant
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idEtudiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStatutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etudiantDataSet = new WindowsForms.etudiantDataSet();
            this.etudiantTableAdapter = new WindowsForms.etudiantDataSetTableAdapters.etudiantTableAdapter();
            this.nomEtudiant = new System.Windows.Forms.TextBox();
            this.prenomEtudiant = new System.Windows.Forms.TextBox();
            this.dateNaissanceEtudiant = new System.Windows.Forms.TextBox();
            this.adresseEtudiant = new System.Windows.Forms.TextBox();
            this.mailEtudiant = new System.Windows.Forms.TextBox();
            this.classeEtudiant = new System.Windows.Forms.ComboBox();
            this.classeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ajoutEtudiantClasse = new WindowsForms.ajoutEtudiantClasse();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.supprimerEtudiant = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statutEtudiant = new System.Windows.Forms.ComboBox();
            this.statutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ajoutEtudiantStatut = new WindowsForms.ajoutEtudiantStatut();
            this.villeEtudiant = new System.Windows.Forms.ComboBox();
            this.villeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ajoutEtudiantVille = new WindowsForms.ajoutEtudiantVille();
            this.classeDataSet = new WindowsForms.classeDataSet();
            this.classeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classeTableAdapter = new WindowsForms.classeDataSetTableAdapters.classeTableAdapter();
            this.villeTableAdapter = new WindowsForms.ajoutEtudiantVilleTableAdapters.villeTableAdapter();
            this.classeTableAdapter1 = new WindowsForms.ajoutEtudiantClasseTableAdapters.classeTableAdapter();
            this.statutTableAdapter = new WindowsForms.ajoutEtudiantStatutTableAdapters.statutTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idEtudiant = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutEtudiantClasse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutEtudiantStatut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutEtudiantVille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Liste des étudiants";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEtudiantDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.idClasseDataGridViewTextBoxColumn,
            this.idVilleDataGridViewTextBoxColumn,
            this.idStatutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.etudiantBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.Location = new System.Drawing.Point(14, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1281, 322);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idEtudiantDataGridViewTextBoxColumn
            // 
            this.idEtudiantDataGridViewTextBoxColumn.DataPropertyName = "idEtudiant";
            this.idEtudiantDataGridViewTextBoxColumn.HeaderText = "idEtudiant";
            this.idEtudiantDataGridViewTextBoxColumn.Name = "idEtudiantDataGridViewTextBoxColumn";
            this.idEtudiantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nomEtudiant";
            this.dataGridViewTextBoxColumn1.HeaderText = "nomEtudiant";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "prenomEtudiant";
            this.dataGridViewTextBoxColumn2.HeaderText = "prenomEtudiant";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dateNaissanceEtudiant";
            this.dataGridViewTextBoxColumn3.HeaderText = "dateNaissanceEtudiant";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "adresseEtudiant";
            this.dataGridViewTextBoxColumn4.HeaderText = "adresseEtudiant";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "mailEtudiant";
            this.dataGridViewTextBoxColumn5.HeaderText = "mailEtudiant";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // idClasseDataGridViewTextBoxColumn
            // 
            this.idClasseDataGridViewTextBoxColumn.DataPropertyName = "idClasse";
            this.idClasseDataGridViewTextBoxColumn.HeaderText = "idClasse";
            this.idClasseDataGridViewTextBoxColumn.Name = "idClasseDataGridViewTextBoxColumn";
            this.idClasseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idVilleDataGridViewTextBoxColumn
            // 
            this.idVilleDataGridViewTextBoxColumn.DataPropertyName = "idVille";
            this.idVilleDataGridViewTextBoxColumn.HeaderText = "idVille";
            this.idVilleDataGridViewTextBoxColumn.Name = "idVilleDataGridViewTextBoxColumn";
            this.idVilleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idStatutDataGridViewTextBoxColumn
            // 
            this.idStatutDataGridViewTextBoxColumn.DataPropertyName = "idStatut";
            this.idStatutDataGridViewTextBoxColumn.HeaderText = "idStatut";
            this.idStatutDataGridViewTextBoxColumn.Name = "idStatutDataGridViewTextBoxColumn";
            this.idStatutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etudiantBindingSource
            // 
            this.etudiantBindingSource.DataMember = "etudiant";
            this.etudiantBindingSource.DataSource = this.etudiantDataSet;
            // 
            // etudiantDataSet
            // 
            this.etudiantDataSet.DataSetName = "etudiantDataSet";
            this.etudiantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etudiantTableAdapter
            // 
            this.etudiantTableAdapter.ClearBeforeFill = true;
            // 
            // nomEtudiant
            // 
            this.nomEtudiant.Location = new System.Drawing.Point(499, 405);
            this.nomEtudiant.Name = "nomEtudiant";
            this.nomEtudiant.Size = new System.Drawing.Size(100, 22);
            this.nomEtudiant.TabIndex = 30;
            // 
            // prenomEtudiant
            // 
            this.prenomEtudiant.Location = new System.Drawing.Point(499, 439);
            this.prenomEtudiant.Name = "prenomEtudiant";
            this.prenomEtudiant.Size = new System.Drawing.Size(100, 22);
            this.prenomEtudiant.TabIndex = 29;
            // 
            // dateNaissanceEtudiant
            // 
            this.dateNaissanceEtudiant.Location = new System.Drawing.Point(499, 473);
            this.dateNaissanceEtudiant.Name = "dateNaissanceEtudiant";
            this.dateNaissanceEtudiant.Size = new System.Drawing.Size(100, 22);
            this.dateNaissanceEtudiant.TabIndex = 28;
            // 
            // adresseEtudiant
            // 
            this.adresseEtudiant.Location = new System.Drawing.Point(499, 510);
            this.adresseEtudiant.Name = "adresseEtudiant";
            this.adresseEtudiant.Size = new System.Drawing.Size(100, 22);
            this.adresseEtudiant.TabIndex = 27;
            // 
            // mailEtudiant
            // 
            this.mailEtudiant.Location = new System.Drawing.Point(499, 545);
            this.mailEtudiant.Name = "mailEtudiant";
            this.mailEtudiant.Size = new System.Drawing.Size(100, 22);
            this.mailEtudiant.TabIndex = 26;
            // 
            // classeEtudiant
            // 
            this.classeEtudiant.DataSource = this.classeBindingSource1;
            this.classeEtudiant.DisplayMember = "nomClasse";
            this.classeEtudiant.FormattingEnabled = true;
            this.classeEtudiant.Location = new System.Drawing.Point(499, 582);
            this.classeEtudiant.Name = "classeEtudiant";
            this.classeEtudiant.Size = new System.Drawing.Size(100, 24);
            this.classeEtudiant.TabIndex = 25;
            this.classeEtudiant.ValueMember = "idClasse";
            // 
            // classeBindingSource1
            // 
            this.classeBindingSource1.DataMember = "classe";
            this.classeBindingSource1.DataSource = this.ajoutEtudiantClasse;
            // 
            // ajoutEtudiantClasse
            // 
            this.ajoutEtudiantClasse.DataSetName = "ajoutEtudiantClasse";
            this.ajoutEtudiantClasse.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 586);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Classe :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 548);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Mail :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Adresse :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Date de naissance :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nom :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(691, 447);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 38);
            this.button1.TabIndex = 32;
            this.button1.Text = "Ajouter l\'étudiant";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // supprimerEtudiant
            // 
            this.supprimerEtudiant.BackColor = System.Drawing.Color.LightCoral;
            this.supprimerEtudiant.ForeColor = System.Drawing.Color.White;
            this.supprimerEtudiant.Location = new System.Drawing.Point(691, 607);
            this.supprimerEtudiant.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.supprimerEtudiant.Name = "supprimerEtudiant";
            this.supprimerEtudiant.Size = new System.Drawing.Size(148, 38);
            this.supprimerEtudiant.TabIndex = 31;
            this.supprimerEtudiant.Text = "Supprimer l\'étudiant";
            this.supprimerEtudiant.UseVisualStyleBackColor = false;
            this.supprimerEtudiant.Click += new System.EventHandler(this.BoutonAjout_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(691, 528);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 38);
            this.button2.TabIndex = 33;
            this.button2.Text = "Modifier l\'étudiant";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // statutEtudiant
            // 
            this.statutEtudiant.DataSource = this.statutBindingSource;
            this.statutEtudiant.DisplayMember = "nomStatut";
            this.statutEtudiant.FormattingEnabled = true;
            this.statutEtudiant.Location = new System.Drawing.Point(499, 659);
            this.statutEtudiant.Name = "statutEtudiant";
            this.statutEtudiant.Size = new System.Drawing.Size(100, 24);
            this.statutEtudiant.TabIndex = 34;
            this.statutEtudiant.ValueMember = "idStatut";
            // 
            // statutBindingSource
            // 
            this.statutBindingSource.DataMember = "statut";
            this.statutBindingSource.DataSource = this.ajoutEtudiantStatut;
            // 
            // ajoutEtudiantStatut
            // 
            this.ajoutEtudiantStatut.DataSetName = "ajoutEtudiantStatut";
            this.ajoutEtudiantStatut.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // villeEtudiant
            // 
            this.villeEtudiant.DataSource = this.villeBindingSource;
            this.villeEtudiant.DisplayMember = "nomVille";
            this.villeEtudiant.FormattingEnabled = true;
            this.villeEtudiant.Location = new System.Drawing.Point(499, 621);
            this.villeEtudiant.Name = "villeEtudiant";
            this.villeEtudiant.Size = new System.Drawing.Size(100, 24);
            this.villeEtudiant.TabIndex = 35;
            this.villeEtudiant.ValueMember = "idVille";
            // 
            // villeBindingSource
            // 
            this.villeBindingSource.DataMember = "ville";
            this.villeBindingSource.DataSource = this.ajoutEtudiantVille;
            // 
            // ajoutEtudiantVille
            // 
            this.ajoutEtudiantVille.DataSetName = "ajoutEtudiantVille";
            this.ajoutEtudiantVille.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classeDataSet
            // 
            this.classeDataSet.DataSetName = "classeDataSet";
            this.classeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classeDataSetBindingSource
            // 
            this.classeDataSetBindingSource.DataSource = this.classeDataSet;
            this.classeDataSetBindingSource.Position = 0;
            // 
            // classeBindingSource
            // 
            this.classeBindingSource.DataMember = "classe";
            this.classeBindingSource.DataSource = this.classeDataSetBindingSource;
            // 
            // classeTableAdapter
            // 
            this.classeTableAdapter.ClearBeforeFill = true;
            // 
            // villeTableAdapter
            // 
            this.villeTableAdapter.ClearBeforeFill = true;
            // 
            // classeTableAdapter1
            // 
            this.classeTableAdapter1.ClearBeforeFill = true;
            // 
            // statutTableAdapter
            // 
            this.statutTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 625);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Ville :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(438, 663);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Statut :";
            // 
            // idEtudiant
            // 
            this.idEtudiant.Location = new System.Drawing.Point(235, 420);
            this.idEtudiant.Name = "idEtudiant";
            this.idEtudiant.Size = new System.Drawing.Size(100, 22);
            this.idEtudiant.TabIndex = 38;
            this.idEtudiant.Visible = false;
            // 
            // ListeEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1310, 707);
            this.Controls.Add(this.idEtudiant);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.villeEtudiant);
            this.Controls.Add(this.statutEtudiant);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.supprimerEtudiant);
            this.Controls.Add(this.nomEtudiant);
            this.Controls.Add(this.prenomEtudiant);
            this.Controls.Add(this.dateNaissanceEtudiant);
            this.Controls.Add(this.adresseEtudiant);
            this.Controls.Add(this.mailEtudiant);
            this.Controls.Add(this.classeEtudiant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "ListeEtudiant";
            this.Text = "ListeEtudiant";
            this.Load += new System.EventHandler(this.ListeEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutEtudiantClasse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutEtudiantStatut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajoutEtudiantVille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private etudiantDataSet etudiantDataSet;
        private System.Windows.Forms.BindingSource etudiantBindingSource;
        private etudiantDataSetTableAdapters.etudiantTableAdapter etudiantTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEtudiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStatutDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox nomEtudiant;
        private System.Windows.Forms.TextBox prenomEtudiant;
        private System.Windows.Forms.TextBox dateNaissanceEtudiant;
        private System.Windows.Forms.TextBox adresseEtudiant;
        private System.Windows.Forms.TextBox mailEtudiant;
        private System.Windows.Forms.ComboBox classeEtudiant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button supprimerEtudiant;
        private System.Windows.Forms.BindingSource classeDataSetBindingSource;
        private classeDataSet classeDataSet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox statutEtudiant;
        private System.Windows.Forms.ComboBox villeEtudiant;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private classeDataSetTableAdapters.classeTableAdapter classeTableAdapter;
        private ajoutEtudiantVille ajoutEtudiantVille;
        private System.Windows.Forms.BindingSource villeBindingSource;
        private ajoutEtudiantVilleTableAdapters.villeTableAdapter villeTableAdapter;
        private ajoutEtudiantClasse ajoutEtudiantClasse;
        private System.Windows.Forms.BindingSource classeBindingSource1;
        private ajoutEtudiantClasseTableAdapters.classeTableAdapter classeTableAdapter1;
        private ajoutEtudiantStatut ajoutEtudiantStatut;
        private System.Windows.Forms.BindingSource statutBindingSource;
        private ajoutEtudiantStatutTableAdapters.statutTableAdapter statutTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idEtudiant;
    }
}