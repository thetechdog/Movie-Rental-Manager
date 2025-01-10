using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_TAP
{
    public partial class UserDestroyer : Form

    {
        string username;
        Creator creator = new Creator();
        public UserDestroyer(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void UserDestroyer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza_DateDataSet.Utilizatori' table. You can move, or remove it, as needed.
            this.utilizatoriTableAdapter.Fill(this.baza_DateDataSet.Utilizatori);

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eradicate_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == username) MessageBox.Show("Nu iti poti sterge propriul cont!");
            else { 
                DialogResult dialogResult = MessageBox.Show("Sigur stergi contul?", "Avertisment stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    PanouControl.ExecQuery(creator.connectionString, "DELETE FROM Utilizatori WHERE Username='" + comboBox1.Text + "'"); MessageBox.Show("Cont sters cu succes!"); this.Close();

                }

                
                 }
        }
    }
}
