namespace WindowsForms
{
    partial class ListeClasse
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
            this.idClasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classeDataSet = new WindowsForms.classeDataSet();
            this.classeTableAdapter = new WindowsForms.classeDataSetTableAdapters.classeTableAdapter();
            this.nbPlace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BoutonAjout = new System.Windows.Forms.Button();
            this.nomClasse = new System.Windows.Forms.TextBox();
            this.idClasse = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Liste des classes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClasseDataGridViewTextBoxColumn,
            this.nomClasseDataGridViewTextBoxColumn,
            this.nbPlaceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.classeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(480, 227);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idClasseDataGridViewTextBoxColumn
            // 
            this.idClasseDataGridViewTextBoxColumn.DataPropertyName = "idClasse";
            this.idClasseDataGridViewTextBoxColumn.HeaderText = "idClasse";
            this.idClasseDataGridViewTextBoxColumn.Name = "idClasseDataGridViewTextBoxColumn";
            this.idClasseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomClasseDataGridViewTextBoxColumn
            // 
            this.nomClasseDataGridViewTextBoxColumn.DataPropertyName = "nomClasse";
            this.nomClasseDataGridViewTextBoxColumn.HeaderText = "nomClasse";
            this.nomClasseDataGridViewTextBoxColumn.Name = "nomClasseDataGridViewTextBoxColumn";
            this.nomClasseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nbPlaceDataGridViewTextBoxColumn
            // 
            this.nbPlaceDataGridViewTextBoxColumn.DataPropertyName = "nbPlace";
            this.nbPlaceDataGridViewTextBoxColumn.HeaderText = "nbPlace";
            this.nbPlaceDataGridViewTextBoxColumn.Name = "nbPlaceDataGridViewTextBoxColumn";
            this.nbPlaceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classeBindingSource
            // 
            this.classeBindingSource.DataMember = "classe";
            this.classeBindingSource.DataSource = this.classeDataSet;
            // 
            // classeDataSet
            // 
            this.classeDataSet.DataSetName = "classeDataSet";
            this.classeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classeTableAdapter
            // 
            this.classeTableAdapter.ClearBeforeFill = true;
            // 
            // nbPlace
            // 
            this.nbPlace.Location = new System.Drawing.Point(243, 388);
            this.nbPlace.Name = "nbPlace";
            this.nbPlace.Size = new System.Drawing.Size(100, 22);
            this.nbPlace.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Effectif max. :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nom :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(220, 448);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 38);
            this.button2.TabIndex = 36;
            this.button2.Text = "Modifier la classe";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(55, 448);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 38);
            this.button1.TabIndex = 35;
            this.button1.Text = "Ajouter la classe";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BoutonAjout
            // 
            this.BoutonAjout.BackColor = System.Drawing.Color.LightCoral;
            this.BoutonAjout.ForeColor = System.Drawing.Color.White;
            this.BoutonAjout.Location = new System.Drawing.Point(387, 448);
            this.BoutonAjout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BoutonAjout.Name = "BoutonAjout";
            this.BoutonAjout.Size = new System.Drawing.Size(148, 38);
            this.BoutonAjout.TabIndex = 34;
            this.BoutonAjout.Text = "Supprimer la classe";
            this.BoutonAjout.UseVisualStyleBackColor = false;
            this.BoutonAjout.Click += new System.EventHandler(this.BoutonAjout_Click);
            // 
            // nomClasse
            // 
            this.nomClasse.Location = new System.Drawing.Point(243, 348);
            this.nomClasse.Name = "nomClasse";
            this.nomClasse.Size = new System.Drawing.Size(100, 22);
            this.nomClasse.TabIndex = 15;
            // 
            // idClasse
            // 
            this.idClasse.Location = new System.Drawing.Point(25, 351);
            this.idClasse.Name = "idClasse";
            this.idClasse.Size = new System.Drawing.Size(100, 22);
            this.idClasse.TabIndex = 37;
            this.idClasse.Visible = false;
            // 
            // ListeClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(589, 604);
            this.Controls.Add(this.idClasse);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoutonAjout);
            this.Controls.Add(this.nbPlace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomClasse);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "ListeClasse";
            this.Text = "ListeClasse";
            this.Load += new System.EventHandler(this.ListeClasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private classeDataSet classeDataSet;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private classeDataSetTableAdapters.classeTableAdapter classeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbPlaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox nbPlace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BoutonAjout;
        private System.Windows.Forms.TextBox nomClasse;
        private System.Windows.Forms.TextBox idClasse;
    }
}