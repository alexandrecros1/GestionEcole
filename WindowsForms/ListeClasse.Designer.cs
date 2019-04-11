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
            this.classeDataSet = new WindowsForms.classeDataSet();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classeTableAdapter = new WindowsForms.classeDataSetTableAdapters.classeTableAdapter();
            this.idClasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomClasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Liste des classes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClasseDataGridViewTextBoxColumn,
            this.nomClasseDataGridViewTextBoxColumn,
            this.nbPlaceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.classeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(69, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 374);
            this.dataGridView1.TabIndex = 13;
            // 
            // classeDataSet
            // 
            this.classeDataSet.DataSetName = "classeDataSet";
            this.classeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classeBindingSource
            // 
            this.classeBindingSource.DataMember = "classe";
            this.classeBindingSource.DataSource = this.classeDataSet;
            // 
            // classeTableAdapter
            // 
            this.classeTableAdapter.ClearBeforeFill = true;
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
            // 
            // nbPlaceDataGridViewTextBoxColumn
            // 
            this.nbPlaceDataGridViewTextBoxColumn.DataPropertyName = "nbPlace";
            this.nbPlaceDataGridViewTextBoxColumn.HeaderText = "nbPlace";
            this.nbPlaceDataGridViewTextBoxColumn.Name = "nbPlaceDataGridViewTextBoxColumn";
            // 
            // ListeClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(573, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "ListeClasse";
            this.Text = "ListeClasse";
            this.Load += new System.EventHandler(this.ListeClasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
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
    }
}