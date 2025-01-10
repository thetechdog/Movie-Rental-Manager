namespace Proiect_TAP
{
    partial class Logare
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
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.lUser = new System.Windows.Forms.Label();
            this.lParola = new System.Windows.Forms.Label();
            this.bLogare = new System.Windows.Forms.Button();
            this.bCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(35, 49);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(100, 20);
            this.textUser.TabIndex = 1;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(35, 97);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(100, 20);
            this.textPass.TabIndex = 2;
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(32, 33);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(55, 13);
            this.lUser.TabIndex = 3;
            this.lUser.Text = "Username";
            // 
            // lParola
            // 
            this.lParola.AutoSize = true;
            this.lParola.Location = new System.Drawing.Point(32, 81);
            this.lParola.Name = "lParola";
            this.lParola.Size = new System.Drawing.Size(37, 13);
            this.lParola.TabIndex = 4;
            this.lParola.Text = "Parola";
            // 
            // bLogare
            // 
            this.bLogare.Location = new System.Drawing.Point(35, 139);
            this.bLogare.Name = "bLogare";
            this.bLogare.Size = new System.Drawing.Size(100, 23);
            this.bLogare.TabIndex = 5;
            this.bLogare.Text = "Logare";
            this.bLogare.UseVisualStyleBackColor = true;
            this.bLogare.Click += new System.EventHandler(this.bLogare_Click);
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(35, 168);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(100, 23);
            this.bCreate.TabIndex = 6;
            this.bCreate.Text = "Creare cont";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // Logare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 203);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.bLogare);
            this.Controls.Add(this.lParola);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Logare";
            this.Text = "Logare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Label lParola;
        private System.Windows.Forms.Button bLogare;
        private System.Windows.Forms.Button bCreate;
    }
}

