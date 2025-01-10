namespace Proiect_TAP
{
    partial class Creator
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
            this.bConfirm = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPriv = new System.Windows.Forms.ComboBox();
            this.tipContBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza_DateDataSet = new Proiect_TAP.Baza_DateDataSet();
            this.tipContTableAdapter = new Proiect_TAP.Baza_DateDataSetTableAdapters.TipContTableAdapter();
            this.adminPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tipContBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_DateDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bConfirm
            // 
            this.bConfirm.Location = new System.Drawing.Point(77, 243);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(75, 23);
            this.bConfirm.TabIndex = 0;
            this.bConfirm.Text = "Confirmare";
            this.bConfirm.UseVisualStyleBackColor = true;
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(77, 272);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 1;
            this.bExit.Text = "Renuntare";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(13, 44);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(194, 20);
            this.User.TabIndex = 2;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(13, 92);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '*';
            this.Pass.Size = new System.Drawing.Size(194, 20);
            this.Pass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Privilegii";
            // 
            // cmbPriv
            // 
            this.cmbPriv.DataSource = this.tipContBindingSource;
            this.cmbPriv.DisplayMember = "Tip";
            this.cmbPriv.FormattingEnabled = true;
            this.cmbPriv.Location = new System.Drawing.Point(12, 194);
            this.cmbPriv.Name = "cmbPriv";
            this.cmbPriv.Size = new System.Drawing.Size(195, 21);
            this.cmbPriv.TabIndex = 7;
            this.cmbPriv.ValueMember = "ID";
            this.cmbPriv.DropDownClosed += new System.EventHandler(this.cmbPriv_DropDownClosed);
            // 
            // tipContBindingSource
            // 
            this.tipContBindingSource.DataMember = "TipCont";
            this.tipContBindingSource.DataSource = this.baza_DateDataSet;
            // 
            // baza_DateDataSet
            // 
            this.baza_DateDataSet.DataSetName = "Baza_DateDataSet";
            this.baza_DateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipContTableAdapter
            // 
            this.tipContTableAdapter.ClearBeforeFill = true;
            // 
            // adminPass
            // 
            this.adminPass.Enabled = false;
            this.adminPass.Location = new System.Drawing.Point(12, 142);
            this.adminPass.Name = "adminPass";
            this.adminPass.PasswordChar = '*';
            this.adminPass.Size = new System.Drawing.Size(191, 20);
            this.adminPass.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cheie admin";
            // 
            // Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 303);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adminPass);
            this.Controls.Add(this.cmbPriv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.User);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Creator";
            this.Text = "Creare cont";
            this.Load += new System.EventHandler(this.Creator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipContBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_DateDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bConfirm;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPriv;
        private Baza_DateDataSet baza_DateDataSet;
        private System.Windows.Forms.BindingSource tipContBindingSource;
        private Baza_DateDataSetTableAdapters.TipContTableAdapter tipContTableAdapter;
        private System.Windows.Forms.TextBox adminPass;
        private System.Windows.Forms.Label label4;
    }
}