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
    public partial class AddFilm : Form
    {   VerificareSiInchiriere verificareSiInchiriere;
        Creator creator = new Creator();
        public AddFilm(VerificareSiInchiriere verificareSiInchiriere)
        {
            InitializeComponent();
            this.verificareSiInchiriere = verificareSiInchiriere;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verificareSiInchiriere.RefreshData();
            this.Close();
        }

        private void butConfirm_Click(object sender, EventArgs e)
        {   if (textTitlu.Text == "" || textStudio.Text == "" || cmbFormat.Text == "") MessageBox.Show("Completeaza toate campurile!");
            else {
                string query = "INSERT INTO StocFilme(Titlu,Studio,Format,Inchiriat) VALUES('" + textTitlu.Text + "','" + textStudio.Text + "','" + cmbFormat.Text + "','Nu');";
                PanouControl.ExecQuery(creator.connectionString, query);
                //MessageBox.Show(query);
                MessageBox.Show("Filmul a fost adaugat cu succes!");

            }
            
        }
    }
}
