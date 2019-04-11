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
            this.etudiantDataSet = new WindowsForms.etudiantDataSet();
            this.etudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etudiantTableAdapter = new WindowsForms.etudiantDataSetTableAdapters.etudiantTableAdapter();
            this.idEtudiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStatutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Liste des étudiants";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(590, 458);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // etudiantDataSet
            // 
            this.etudiantDataSet.DataSetName = "etudiantDataSet";
            this.etudiantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etudiantBindingSource
            // 
            this.etudiantBindingSource.DataMember = "etudiant";
            this.etudiantBindingSource.DataSource = this.etudiantDataSet;
            // 
            // etudiantTableAdapter
            // 
            this.etudiantTableAdapter.ClearBeforeFill = true;
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
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "prenomEtudiant";
            this.dataGridViewTextBoxColumn2.HeaderText = "prenomEtudiant";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dateNaissanceEtudiant";
            this.dataGridViewTextBoxColumn3.HeaderText = "dateNaissanceEtudiant";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "adresseEtudiant";
            this.dataGridViewTextBoxColumn4.HeaderText = "adresseEtudiant";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "mailEtudiant";
            this.dataGridViewTextBoxColumn5.HeaderText = "mailEtudiant";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // idClasseDataGridViewTextBoxColumn
            // 
            this.idClasseDataGridViewTextBoxColumn.DataPropertyName = "idClasse";
            this.idClasseDataGridViewTextBoxColumn.HeaderText = "idClasse";
            this.idClasseDataGridViewTextBoxColumn.Name = "idClasseDataGridViewTextBoxColumn";
            // 
            // idVilleDataGridViewTextBoxColumn
            // 
            this.idVilleDataGridViewTextBoxColumn.DataPropertyName = "idVille";
            this.idVilleDataGridViewTextBoxColumn.HeaderText = "idVille";
            this.idVilleDataGridViewTextBoxColumn.Name = "idVilleDataGridViewTextBoxColumn";
            // 
            // idStatutDataGridViewTextBoxColumn
            // 
            this.idStatutDataGridViewTextBoxColumn.DataPropertyName = "idStatut";
            this.idStatutDataGridViewTextBoxColumn.HeaderText = "idStatut";
            this.idStatutDataGridViewTextBoxColumn.Name = "idStatutDataGridViewTextBoxColumn";
            // 
            // ListeEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(609, 538);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "ListeEtudiant";
            this.Text = "ListeEtudiant";
            this.Load += new System.EventHandler(this.ListeEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).EndInit();
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
    }
}