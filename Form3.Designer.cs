namespace Proiect_TAP
{
    partial class PanouControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanouControl));
            this.butvfStoc = new System.Windows.Forms.Button();
            this.butEmployee = new System.Windows.Forms.Button();
            this.labelGreet = new System.Windows.Forms.Label();
            this.pfpBox = new System.Windows.Forms.PictureBox();
            this.logout = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuDelogare = new System.Windows.Forms.MenuItem();
            this.menuInchidere = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuPoza = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuDespre = new System.Windows.Forms.MenuItem();
            this.openPFP = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pfpBox)).BeginInit();
            this.SuspendLayout();
            // 
            // butvfStoc
            // 
            this.butvfStoc.Location = new System.Drawing.Point(12, 30);
            this.butvfStoc.Name = "butvfStoc";
            this.butvfStoc.Size = new System.Drawing.Size(161, 137);
            this.butvfStoc.TabIndex = 0;
            this.butvfStoc.Text = "Gestionare catalog";
            this.butvfStoc.UseVisualStyleBackColor = true;
            this.butvfStoc.Click += new System.EventHandler(this.butvfStoc_Click);
            // 
            // butEmployee
            // 
            this.butEmployee.ForeColor = System.Drawing.Color.Red;
            this.butEmployee.Location = new System.Drawing.Point(12, 173);
            this.butEmployee.Name = "butEmployee";
            this.butEmployee.Size = new System.Drawing.Size(161, 126);
            this.butEmployee.TabIndex = 1;
            this.butEmployee.Text = "Gestionare utilizatori";
            this.butEmployee.UseVisualStyleBackColor = true;
            this.butEmployee.Visible = false;
            this.butEmployee.Click += new System.EventHandler(this.butEmployee_Click);
            // 
            // labelGreet
            // 
            this.labelGreet.AutoSize = true;
            this.labelGreet.Location = new System.Drawing.Point(376, 22);
            this.labelGreet.Name = "labelGreet";
            this.labelGreet.Size = new System.Drawing.Size(37, 13);
            this.labelGreet.TabIndex = 3;
            this.labelGreet.Text = "Salut, ";
            // 
            // pfpBox
            // 
            this.pfpBox.Image = ((System.Drawing.Image)(resources.GetObject("pfpBox.Image")));
            this.pfpBox.Location = new System.Drawing.Point(379, 38);
            this.pfpBox.Name = "pfpBox";
            this.pfpBox.Size = new System.Drawing.Size(260, 232);
            this.pfpBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pfpBox.TabIndex = 4;
            this.pfpBox.TabStop = false;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(564, 276);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 5;
            this.logout.Text = "Delogare";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem4,
            this.menuItem6});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuDelogare,
            this.menuInchidere});
            this.menuItem1.Text = "Fereastra";
            // 
            // menuDelogare
            // 
            this.menuDelogare.Index = 0;
            this.menuDelogare.Text = "Delogare";
            this.menuDelogare.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuInchidere
            // 
            this.menuInchidere.Index = 1;
            this.menuInchidere.Text = "Inchidere program";
            this.menuInchidere.Click += new System.EventHandler(this.menuInchidere_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuPoza,
            this.menuItem2});
            this.menuItem4.Text = "Optiuni cont";
            // 
            // menuPoza
            // 
            this.menuPoza.Index = 0;
            this.menuPoza.Text = "Schimbare poza profil";
            this.menuPoza.Click += new System.EventHandler(this.menuPoza_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Schimbare parola";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click_1);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 2;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuDespre});
            this.menuItem6.Text = "Ajutor";
            // 
            // menuDespre
            // 
            this.menuDespre.Index = 0;
            this.menuDespre.Text = "Despre";
            this.menuDespre.Click += new System.EventHandler(this.menuDespre_Click);
            // 
            // PanouControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 311);
            this.ControlBox = false;
            this.Controls.Add(this.logout);
            this.Controls.Add(this.pfpBox);
            this.Controls.Add(this.labelGreet);
            this.Controls.Add(this.butEmployee);
            this.Controls.Add(this.butvfStoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Menu = this.mainMenu1;
            this.Name = "PanouControl";
            this.Text = "Panou Control";
            ((System.ComponentModel.ISupportInitialize)(this.pfpBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butvfStoc;
        private System.Windows.Forms.Button butEmployee;
        private System.Windows.Forms.Label labelGreet;
        private System.Windows.Forms.PictureBox pfpBox;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuDelogare;
        private System.Windows.Forms.MenuItem menuInchidere;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuPoza;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuDespre;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.OpenFileDialog openPFP;
    }
}