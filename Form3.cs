using Azure.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_TAP
{
    public partial class PanouControl : Form
    {
        private Logare logare;
        private string username = "";
        private int nivelPrivilegii;
        Creator creator = new Creator();

        public PanouControl(string username, int nivelPrivilegii, Logare logare)
        {
            InitializeComponent();
            this.logare = logare;
            this.username = username;
            this.nivelPrivilegii = nivelPrivilegii;
            labelGreet.Text = "Bun venit, " + username + "!";
            if (nivelPrivilegii == 2)
                butEmployee.Visible = true;
            try {
                string pathpfp = (string)creator.RezComm(creator.connectionString, "SELECT LocImagine FROM Utilizatori WHERE Username='" + username + "'");
                pfpBox.Image = Image.FromFile(pathpfp); } catch (Exception e) { MessageBox.Show("Imaginea de profil este invalida: \n" + e.Message, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }


        }

        private void logout_Click(object sender, EventArgs e)
        {   logare.Show();
            this.Close();
        }

        private void butvfStoc_Click(object sender, EventArgs e)
        {   VerificareSiInchiriere vf=new VerificareSiInchiriere(this.username,nivelPrivilegii); vf.ShowDialog();

        }

        private void butRent_Click(object sender, EventArgs e)
        {

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            logare.Show();
            this.Close();
        }

        private void menuInchidere_Click(object sender, EventArgs e)
        {
            logare.Close();
            this.Close();
        }


        public static void ExecQuery(string connectionString, string query)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Interogare invalida: " + ex.Message);
            }
        }

        private void menuDespre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manager inchiriere filme - Ionel Andrei 2025", "Despre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void butEmployee_Click(object sender, EventArgs e)
        {
            UserDestroyer destroyer = new UserDestroyer(username);
            destroyer.ShowDialog();
        }

        private void menuItem2_Click_1(object sender, EventArgs e)
        {
            schimbPass sb = new schimbPass(username);
            sb.ShowDialog();
        }

        private void menuPoza_Click(object sender, EventArgs e)
        {
            try
            {   if (openPFP.ShowDialog() == DialogResult.OK) { 
                    string path=openPFP.FileName;
                    pfpBox.Image = Image.FromFile(path);
                    ExecQuery(creator.connectionString, "UPDATE Utilizatori SET LocImagine='" + path + "' WHERE Username='" + username + "'");
                
                
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Locatie invalida: \n" + ex.Message, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
