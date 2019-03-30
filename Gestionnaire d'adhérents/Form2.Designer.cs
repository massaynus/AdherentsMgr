namespace Gestionnaire_d_adhérents
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Quitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Apropos = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Aide = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Dashboard = new System.Windows.Forms.Panel();
            this.LTotalC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LNbrAdherents = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.databaseDataSet = new Gestionnaire_d_adhérents.DatabaseDataSet();
            this.comptesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comptesTableAdapter = new Gestionnaire_d_adhérents.DatabaseDataSetTableAdapters.ComptesTableAdapter();
            this.comptesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.Apropos.SuspendLayout();
            this.Aide.SuspendLayout();
            this.Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comptesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comptesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Quitter
            // 
            this.Quitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Quitter.Location = new System.Drawing.Point(608, 315);
            this.Quitter.Name = "Quitter";
            this.Quitter.Size = new System.Drawing.Size(75, 23);
            this.Quitter.TabIndex = 0;
            this.Quitter.Text = "Quitter";
            this.Quitter.UseVisualStyleBackColor = true;
            this.Quitter.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date Time";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.managerToolStripMenuItem,
            this.listToolStripMenuItem,
            this.aProposToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.managerToolStripMenuItem.Text = "Manager";
            this.managerToolStripMenuItem.Click += new System.EventHandler(this.managerToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // Apropos
            // 
            this.Apropos.Controls.Add(this.label2);
            this.Apropos.Location = new System.Drawing.Point(12, 27);
            this.Apropos.Name = "Apropos";
            this.Apropos.Size = new System.Drawing.Size(671, 282);
            this.Apropos.TabIndex = 3;
            this.Apropos.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 120);
            this.label2.TabIndex = 0;
            this.label2.Text = "Application réaliser et dévélopper par ELMASSAOUDI YASSINE\r\n\r\nE-mail: massaoudi.y" +
    "ass@gmail.com\r\nGSM: +212674723786\r\n\r\nCopyright @ 2018-2019";
            // 
            // Aide
            // 
            this.Aide.Controls.Add(this.label3);
            this.Aide.Location = new System.Drawing.Point(12, 27);
            this.Aide.Name = "Aide";
            this.Aide.Size = new System.Drawing.Size(671, 282);
            this.Aide.TabIndex = 4;
            this.Aide.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(448, 170);
            this.label3.TabIndex = 0;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Dashboard
            // 
            this.Dashboard.Controls.Add(this.LTotalC);
            this.Dashboard.Controls.Add(this.label5);
            this.Dashboard.Controls.Add(this.LNbrAdherents);
            this.Dashboard.Controls.Add(this.label4);
            this.Dashboard.Controls.Add(this.monthCalendar1);
            this.Dashboard.Location = new System.Drawing.Point(9, 27);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(671, 282);
            this.Dashboard.TabIndex = 1;
            // 
            // LTotalC
            // 
            this.LTotalC.AutoSize = true;
            this.LTotalC.Location = new System.Drawing.Point(563, 204);
            this.LTotalC.Name = "LTotalC";
            this.LTotalC.Size = new System.Drawing.Size(13, 13);
            this.LTotalC.TabIndex = 6;
            this.LTotalC.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total sur caisse:";
            // 
            // LNbrAdherents
            // 
            this.LNbrAdherents.AutoSize = true;
            this.LNbrAdherents.Location = new System.Drawing.Point(563, 180);
            this.LNbrAdherents.Name = "LNbrAdherents";
            this.LNbrAdherents.Size = new System.Drawing.Size(13, 13);
            this.LNbrAdherents.TabIndex = 2;
            this.LNbrAdherents.Text = "0";
            this.LNbrAdherents.Click += new System.EventHandler(this.LNbrAdherents_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre adhérents:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(435, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
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
            // comptesBindingSource1
            // 
            this.comptesBindingSource1.DataMember = "Comptes";
            this.comptesBindingSource1.DataSource = this.databaseDataSet;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Quitter;
            this.ClientSize = new System.Drawing.Size(695, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.Apropos);
            this.Controls.Add(this.Quitter);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Aide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Main interface";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Apropos.ResumeLayout(false);
            this.Apropos.PerformLayout();
            this.Aide.ResumeLayout(false);
            this.Aide.PerformLayout();
            this.Dashboard.ResumeLayout(false);
            this.Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comptesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comptesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Quitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.Panel Apropos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Aide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Dashboard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label LNbrAdherents;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource comptesBindingSource;
        private DatabaseDataSetTableAdapters.ComptesTableAdapter comptesTableAdapter;
        private System.Windows.Forms.BindingSource comptesBindingSource1;
        private System.Windows.Forms.Label LTotalC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}