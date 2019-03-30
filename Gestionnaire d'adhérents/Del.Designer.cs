namespace Gestionnaire_d_adhérents
{
    partial class Del
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet = new Gestionnaire_d_adhérents.DatabaseDataSet();
            this.comptesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comptesTableAdapter = new Gestionnaire_d_adhérents.DatabaseDataSetTableAdapters.ComptesTableAdapter();
            this.nomCompletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDexpirationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comptesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomCompletDataGridViewTextBoxColumn,
            this.gSMDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.dateDexpirationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comptesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comptesBindingSource
            // 
            this.comptesBindingSource.DataMember = "Comptes";
            this.comptesBindingSource.DataSource = this.databaseDataSet;
            // 
            // comptesTableAdapter
            // 
            this.comptesTableAdapter.ClearBeforeFill = true;
            // 
            // nomCompletDataGridViewTextBoxColumn
            // 
            this.nomCompletDataGridViewTextBoxColumn.DataPropertyName = "Nom complet";
            this.nomCompletDataGridViewTextBoxColumn.HeaderText = "Nom complet";
            this.nomCompletDataGridViewTextBoxColumn.Name = "nomCompletDataGridViewTextBoxColumn";
            // 
            // gSMDataGridViewTextBoxColumn
            // 
            this.gSMDataGridViewTextBoxColumn.DataPropertyName = "GSM";
            this.gSMDataGridViewTextBoxColumn.HeaderText = "GSM";
            this.gSMDataGridViewTextBoxColumn.Name = "gSMDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // dateDexpirationDataGridViewTextBoxColumn
            // 
            this.dateDexpirationDataGridViewTextBoxColumn.DataPropertyName = "Date d\'expiration";
            this.dateDexpirationDataGridViewTextBoxColumn.HeaderText = "Date d\'expiration";
            this.dateDexpirationDataGridViewTextBoxColumn.Name = "dateDexpirationDataGridViewTextBoxColumn";
            // 
            // Del
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Del";
            this.ShowIcon = false;
            this.Text = "Del";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Del_FormClosing);
            this.Load += new System.EventHandler(this.Del_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comptesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource comptesBindingSource;
        private DatabaseDataSetTableAdapters.ComptesTableAdapter comptesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCompletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDexpirationDataGridViewTextBoxColumn;
    }
}