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
    public partial class VerificareSiInchiriere : Form
    {   int nivelPrivilegii;
        string username;
        Creator creator = new Creator();
        public VerificareSiInchiriere(string username, int nivelPrivilegii)
        {
            InitializeComponent();
            this.nivelPrivilegii = nivelPrivilegii;
            this.username = username;
            toolTipTick.ToolTipTitle = "Salvare termeni Date Calendaristice";
            toolTipTick.SetToolTip(dateCheck, "Bifeaza pentru a adauga/schimba si Data Inchirierii/Returnarii pentru acest film. De folosit pentru intrarile inchiriate.");
            
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerificareSiInchiriere_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baza_DateDataSet11.Query1' table. You can move, or remove it, as needed.
            //this.query1TableAdapter.Fill(this.baza_DateDataSet11.Query1);
            RefreshData();
            /*if (nivelPrivilegii == 1 || nivelPrivilegii == 2)
            {
                // TODO: This line of code loads data into the 'baza_DateDataSet2.Query1' table. You can move, or remove it, as needed.
                this.query1TableAdapter1.Fill(this.baza_DateDataSet2.Query1);
            }
            else {textTitlu.DataBindings.Clear();
                textStudio.DataBindings.Clear();
                textFormat.DataBindings.Clear();
                dataGridView1.DataSource=this.query2BindingSource;
                this.query2TableAdapter.Fill(this.baza_DateDataSet2.Query2); 
                
                textTitlu.DataBindings.Add("Text", this.baza_DateDataSet2, "query2BindingSource.Titlu");
                textStudio.DataBindings.Add("Text", this.baza_DateDataSet2, "query2BindingSource.Studio");
                textFormat.DataBindings.Add("Text", this.baza_DateDataSet2, "query2BindingSource.Format");
            } */



            if (nivelPrivilegii==1 || nivelPrivilegii == 2)
            {
                radioInchiriere.Visible = true;
                radioStocManage.Show();
                labelInchiriat.Show();
                labelInchiriatDe.Show();
                labelDI.Show();
                labelDR.Show();
                menuItemStoc.Visible = true;
                textInchiriat.Show();
                textInchiriatDe.Show();
                dtmDI.Show();
                dtmDR.Show();
                labelID.Visible = true;
                labelFl.Show();
                delFilm.Show();


            }
            else
            {
                //dataGridView1.Columns.Remove("Persoana");
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;

                labelID.ForeColor= this.BackColor;
                labelFl.ForeColor = this.BackColor;
                //labelFl.ForeColor = Color.Transparent;
                //dataGridView1.Columns.RemoveAt(4);
            }

        }

        private void menuItem4_Click(object sender, EventArgs e) //add film
        {
            AddFilm addFilm = new AddFilm(this);
            addFilm.ShowDialog();
        }

        private void radioInchiriere_CheckedChanged(object sender, EventArgs e)
        {
            textTitlu.Enabled = false;
            textStudio.Enabled = false;
            textFormat.Enabled = false;
            //textInchiriat.Enabled = false;
            //textInchiriatDe.Enabled = false;
            dtmDI.Enabled = false;
            dtmDR.Enabled = false;
            butonRent_Edit.Text="Inchiriere";
            //delFilm.Visible = false;
            dateCheck.Visible=false;
            delFilm.Text = "Confirmare returnare";
        }

        private void radioStocManage_CheckedChanged(object sender, EventArgs e)
        {
            textTitlu.Enabled = true;
            textStudio.Enabled = true;
            textFormat.Enabled = true;
            //textInchiriat.Enabled = true;
            //textInchiriatDe.Enabled = true;
            dtmDI.Enabled = true;
            dtmDR.Enabled = true;
            butonRent_Edit.Text = "Editare";
            //delFilm.Visible = true;
            dateCheck.Visible = true;
            delFilm.Text = "Sterge film";
        }

        private void butonRent_Edit_Click(object sender, EventArgs e)
        {
            //if(butonRent_Edit.Text=="Editare") MessageBox.Show("test1!");
            //else if (butonRent_Edit.Text == "Inchiriere") MessageBox.Show("test2!");
            if (butonRent_Edit.Text == "Inchiriere") {
                if (textInchiriat.Text == "Nu")
                {
                    
                    
                    int ID = Convert.ToInt32(creator.RezComm(creator.connectionString, "SELECT ID FROM Utilizatori WHERE Username = '" + username + "';"));
                    //MessageBox.Show(ID.ToString());

                    string query = "UPDATE StocFilme SET InchiriatDe = '" + ID + "', DataInchiriere = '" + DateTime.Now.ToShortDateString() + "', Inchiriat = 'Da', DataReturnare = '" + DateTime.Now.AddDays(14).ToShortDateString() + "'  WHERE ID = " + labelID.Text + ";";
                    //MessageBox.Show(query);
                    PanouControl.ExecQuery(creator.connectionString, query);
                    //dataGridView1.Refresh();
                    //query1BindingSource1.ResetBindings(true);//actualizare
                    dataGridView1.DataSource = null;
                    RefreshData();
                    dataGridView1.DataSource = query1BindingSource1;
                    messageStrip.Text = "Film inchiriat!";



                }
                else messageStrip.Text = "Filmul este deja inchiriat!";
                
                
                
            }
            else if (butonRent_Edit.Text == "Editare")
            {
                if (textTitlu.Text == "" || textStudio.Text == "" || textFormat.Text == "") messageStrip.Text = "Completati toate campurile!";
                else {
                    if (dateCheck.Checked == true)
                    {
                        if (textInchiriat.Text == "Nu" || textInchiriat.Text == "Da")
                        {
                            string query = "UPDATE StocFilme SET Titlu = '" + textTitlu.Text + "', Studio = '" + textStudio.Text + "', Format = '" + textFormat.Text + "', DataInchiriere = '" + dtmDI.Value + "', DataReturnare = '" + dtmDR.Value + "' WHERE ID = " + labelID.Text + ";";
                            //MessageBox.Show(query);
                            PanouControl.ExecQuery(creator.connectionString, query);
                            messageStrip.Text = "Film editat!";
                            RefreshData();

                        }
                        else messageStrip.Text = "Proprietatea 'Inchiriat' trebuie sa fia 'Da' sau 'Nu'!";

                    }
                    else
                    {
                        if (textInchiriat.Text == "Nu" || textInchiriat.Text == "Da")
                        {
                            string query = "UPDATE StocFilme SET Titlu = '" + textTitlu.Text + "', Studio = '" + textStudio.Text + "', Format = '" + textFormat.Text + "' WHERE ID = " + labelID.Text + ";";
                            //MessageBox.Show(query);
                            PanouControl.ExecQuery(creator.connectionString, query);
                            messageStrip.Text = "Film editat!";
                            RefreshData();

                        }
                        else messageStrip.Text = "Proprietatea 'Inchiriat' trebuie sa fia 'Da' sau 'Nu'!";
                    }


                }

                
                

                
            }
        }



        public void RefreshData()
        {
            string query = "SELECT S.ID, S.Titlu, S.Studio, S.Format, S.Inchiriat, U.Username AS Persoana, S.DataInchiriere, S.DataReturnare FROM StocFilme AS S LEFT JOIN Utilizatori AS U ON S.InchiriatDe = U.ID;";

            using (OleDbConnection connection = new OleDbConnection(creator.connectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                query1BindingSource1.DataSource = dataTable;
            }
        }


        private void delFilm_Click_1(object sender, EventArgs e)
        {   if (delFilm.Text == "Sterge film") {
                DialogResult result = MessageBox.Show("Sigur stergi filmul?", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
                string query = "DELETE FROM StocFilme WHERE ID=" + labelID.Text + ";";
                PanouControl.ExecQuery(creator.connectionString, query);
                messageStrip.Text = "Film sters!";
                RefreshData();
            }
            else if (delFilm.Text == "Confirmare returnare") {
                textInchiriat.Enabled = true;
                if(textInchiriat.Text == "Nu") messageStrip.Text = "Filmul nu este inchiriat!";
                else {
                    string query = "UPDATE StocFilme SET Inchiriat = 'Nu', InchiriatDe = NULL, DataInchiriere = NULL, DataReturnare = NULL WHERE ID = " + labelID.Text + ";";
                    PanouControl.ExecQuery(creator.connectionString, query);
                    messageStrip.Text = "Film returnat!";
                    RefreshData();
                }
                textInchiriat.Enabled = false;


                
            }
            
        }
    }
}
