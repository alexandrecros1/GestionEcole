namespace WindowsForms
{
    partial class Statistiques
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewCountEtudiants = new WindowsForms.ViewCountEtudiants();
            this.viewCountStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewCountStudentsTableAdapter = new WindowsForms.ViewCountEtudiantsTableAdapters.ViewCountStudentsTableAdapter();
            this.nombreEtudiantsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.viewAverageEtudiants = new WindowsForms.ViewAverageEtudiants();
            this.viewAverageStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewAverageStudentsTableAdapter = new WindowsForms.ViewAverageEtudiantsTableAdapters.ViewAverageStudentsTableAdapter();
            this.moyenneEtudiantParClasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCountEtudiants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCountStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAverageEtudiants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAverageStudentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Statistiques globales";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreEtudiantsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewCountStudentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(142, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(143, 43);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // viewCountEtudiants
            // 
            this.viewCountEtudiants.DataSetName = "ViewCountEtudiants";
            this.viewCountEtudiants.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewCountStudentsBindingSource
            // 
            this.viewCountStudentsBindingSource.DataMember = "ViewCountStudents";
            this.viewCountStudentsBindingSource.DataSource = this.viewCountEtudiants;
            // 
            // viewCountStudentsTableAdapter
            // 
            this.viewCountStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // nombreEtudiantsDataGridViewTextBoxColumn
            // 
            this.nombreEtudiantsDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Etudiants";
            this.nombreEtudiantsDataGridViewTextBoxColumn.HeaderText = "Nombre_Etudiants";
            this.nombreEtudiantsDataGridViewTextBoxColumn.Name = "nombreEtudiantsDataGridViewTextBoxColumn";
            this.nombreEtudiantsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moyenneEtudiantParClasseDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.viewAverageStudentsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(110, 201);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(204, 44);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // viewAverageEtudiants
            // 
            this.viewAverageEtudiants.DataSetName = "ViewAverageEtudiants";
            this.viewAverageEtudiants.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewAverageStudentsBindingSource
            // 
            this.viewAverageStudentsBindingSource.DataMember = "ViewAverageStudents";
            this.viewAverageStudentsBindingSource.DataSource = this.viewAverageEtudiants;
            // 
            // viewAverageStudentsTableAdapter
            // 
            this.viewAverageStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // moyenneEtudiantParClasseDataGridViewTextBoxColumn
            // 
            this.moyenneEtudiantParClasseDataGridViewTextBoxColumn.DataPropertyName = "Moyenne_Etudiant_Par_Classe";
            this.moyenneEtudiantParClasseDataGridViewTextBoxColumn.HeaderText = "Moyenne_Etudiant_Par_Classe";
            this.moyenneEtudiantParClasseDataGridViewTextBoxColumn.Name = "moyenneEtudiantParClasseDataGridViewTextBoxColumn";
            this.moyenneEtudiantParClasseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(426, 405);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Statistiques";
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.Statistiques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCountEtudiants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCountStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAverageEtudiants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAverageStudentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ViewCountEtudiants viewCountEtudiants;
        private System.Windows.Forms.BindingSource viewCountStudentsBindingSource;
        private ViewCountEtudiantsTableAdapters.ViewCountStudentsTableAdapter viewCountStudentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEtudiantsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ViewAverageEtudiants viewAverageEtudiants;
        private System.Windows.Forms.BindingSource viewAverageStudentsBindingSource;
        private ViewAverageEtudiantsTableAdapters.ViewAverageStudentsTableAdapter viewAverageStudentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn moyenneEtudiantParClasseDataGridViewTextBoxColumn;
    }
}