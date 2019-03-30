using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnaire_d_adhérents
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Comptes' table. You can move, or remove it, as needed.
            this.comptesTableAdapter.Fill(this.databaseDataSet.Comptes);
            LNbrAdherents.Text = databaseDataSet.Comptes.Count.ToString();
            label1.Text = DateTime.Today.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard.Visible = false;
            Apropos.Visible = false;
            Aide.Visible = true;
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard.Visible = false;
            Aide.Visible = false;
            Apropos.Visible = true;
            
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Dashboard.Visible = true;
            Aide.Visible = false;
            Apropos.Visible = false;
        }

        private void LNbrAdherents_Click(object sender, EventArgs e)
        {

        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List l = new List();
            l.Show();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager m = new Manager();
            m.Show();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Del D = new Del();
            D.Show();
        }
    }
}
