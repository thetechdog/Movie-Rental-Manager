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
    public partial class Logare : Form
    
    {Creator creator = new Creator();
        public Logare()
        {
            InitializeComponent();
        }

        
        private void bCreate_Click(object sender, EventArgs e)
        {
            
            creator.ShowDialog();
        }

        private void bLogare_Click(object sender, EventArgs e)
        {
            if(textUser.Text=="" || textPass.Text=="") MessageBox.Show("Completati toate campurile!");
            else
            {
                string query = "SELECT Username, Parola,TipCont FROM Utilizatori WHERE Username='" + textUser.Text + "' AND Parola='" + textPass.Text + "'";
                int nivelPrivilegii = Convert.ToInt32(creator.RezComm(creator.connectionString, "SELECT TipCont FROM Utilizatori WHERE Username='" + textUser.Text + "'"));
                if (Creator.Cautare(creator.connectionString, query) == true) {MessageBox.Show("Logare cu succes!"); 
                    //static deci merge fara instanta
                    PanouControl p=new PanouControl(textUser.Text,nivelPrivilegii,this); textUser.Text = ""; textPass.Text = ""; this.Hide(); p.Show();
                        }
                else MessageBox.Show("Username sau parola gresite!","Atentie!",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }
    }
}
