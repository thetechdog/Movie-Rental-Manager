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
    public partial class schimbPass : Form
    {
        string username;
        Creator creator=new Creator();
        public schimbPass(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string oldpass = (string)creator.RezComm(creator.connectionString, "SELECT Parola FROM Utilizatori WHERE Username='" + username + "'");
            if (txtNewPass.Text!=txtConfirmPass.Text) MessageBox.Show("Parolele nu coincid!");
            else if (txtNewPass.Text == "" || txtConfirmPass.Text == "" || txtOldPass.Text == "") MessageBox.Show("Completati toate campurile!");
            else if (txtOldPass.Text != oldpass) MessageBox.Show("Parola curenta este gresita!");
            else
            { PanouControl.ExecQuery(creator.connectionString, "UPDATE Utilizatori SET Parola='" + txtNewPass.Text + "' WHERE Username='" + username + "'"); MessageBox.Show("Parola a fost schimbata cu succes!"); this.Close(); }
        }
    }
}
