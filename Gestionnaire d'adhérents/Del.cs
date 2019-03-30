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
    public partial class Del : Form
    {
        public Del()
        {
            InitializeComponent();
        }

        private void Del_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Comptes' table. You can move, or remove it, as needed.
            this.comptesTableAdapter.Fill(this.databaseDataSet.Comptes);

        }

        private void Del_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.comptesTableAdapter.Update(this.databaseDataSet.Comptes);
        }
    }
}
