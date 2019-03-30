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
    public partial class Form1 : Form
    {
        bool auth = false;
        public bool Auth
        {
            get { return auth; }
            set { value = auth; }
        }
        static int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BAccpeter_Click(object sender, EventArgs e)
        {
            if ((ID.Text == "Root" && mdp.Text == "1337") || (ID.Text == "Administrateur" && mdp.Text == "Sins"))
            {

                auth = true;
                Close();
                /*Form2 f = new Form2();
                f.Show();
                //Application.Exit();
                //this.Hide();
                //this.Close();*/
            }
            else
            {
                i++;
                if(i<3) MessageBox.Show("Wrong Login");
                else
                {
                    MessageBox.Show("trois entrées erronées");
                    Environment.Exit(0);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Today.ToLongDateString();
        }
    }
}
