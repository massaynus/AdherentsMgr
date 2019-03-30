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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Comptes' table. You can move, or remove it, as needed.
            this.comptesTableAdapter.Fill(this.databaseDataSet.Comptes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.comptesTableAdapter.Insert(FullName.Text, GSM.Text, EMAIL.Text, Adresse.Text, dateTimePicker1.Text);
            MessageBox.Show("Ajouté avec succes");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
