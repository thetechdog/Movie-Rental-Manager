using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proiect_TAP
{
    public partial class Creator : Form
    {   //INSERT THE LOCATION OF YOUR DB FILE HERE OR ELSE IT WON'T WORK PROPERLY
        public string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./SampleDB.accdb"; 

        public Creator()
        {
            InitializeComponent();

        }

        private void Creator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza_DateDataSet.TipCont' table. You can move, or remove it, as needed.
            this.tipContTableAdapter.Fill(this.baza_DateDataSet.TipCont);
            this.cmbPriv.SelectedIndex = 2;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPriv_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbPriv.SelectedIndex == 0 || cmbPriv.SelectedIndex == 1)
            {
                adminPass.Enabled = true;
            }
            else adminPass.Enabled = false;
        }

        private void bConfirm_Click(object sender, EventArgs e)
        {   
            if(User.Text=="" || Pass.Text=="") MessageBox.Show("Completati toate campurile!");
            else if (cmbPriv.Text == "Client")
            {   string query="SELECT * FROM Utilizatori WHERE Username='" + User.Text + "'";
                if (Cautare(connectionString, query) == false){
                    query = "INSERT INTO Utilizatori (Username, Parola, TipCont) VALUES ('" + User.Text + "', '" + Pass.Text + "', " + (cmbPriv.SelectedIndex + 1) + ")";
                    //MessageBox.Show(query);
                    ExecuteQuery(connectionString, query);
                    this.Close();
                }
                else MessageBox.Show("Exista deja un cont cu acest username!");
                
            }
            else
            {
                if (adminPass.Text == "") MessageBox.Show("Completati parola admin!");
                else
                {
                    string query = "SELECT * FROM Utilizatori WHERE Username='" + User.Text + "'";
                    //de vf si parola adminului
                    string parolaad = (string)RezComm(connectionString, "SELECT * FROM PassAdmin");
                    //MessageBox.Show(parolaad);
                    if (parolaad == null || !(parolaad is string)) MessageBox.Show("Nu s-a gasit parola adminului! Contactati administratorul de sistem!");
                    else {
                        if (adminPass.Text != parolaad) MessageBox.Show("Parola adminului este gresita!");
                        else
                        {



                            if (Cautare(connectionString, query) == false)
                            {
                                query = "INSERT INTO Utilizatori (Username, Parola, TipCont) VALUES ('" + User.Text + "', '" + Pass.Text + "', " + (cmbPriv.SelectedIndex + 1) + ")";
                                //MessageBox.Show(query);
                                ExecuteQuery(connectionString, query);
                                this.Close();
                            }
                            else MessageBox.Show("Exista deja un cont cu acest username!");
                        }
                }
                }

            }
        }

        public void ExecuteQuery(string connectionString, string query)
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
                MessageBox.Show("Contul a fost creat cu succes!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Interogare invalida: "+ex.Message);
            }
        }

        public static bool Cautare(string connectionString, string query)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            

                            return reader.HasRows;
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing query: " + ex.Message);
                return false;
            }
        }

        public object RezComm(string connectionString, string query)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                         return command.ExecuteScalar();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Interogare invalida: " + ex.Message);
                return ex;
            }
        }


    }
}
