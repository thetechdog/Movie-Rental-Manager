namespace Proiect_TAP
{
    partial class UserDestroyer
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.baza_DateDataSet = new Proiect_TAP.Baza_DateDataSet();
            this.utilizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatoriTableAdapter = new Proiect_TAP.Baza_DateDataSetTableAdapters.UtilizatoriTableAdapter();
            this.cancel = new System.Windows.Forms.Button();
            this.eradicate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.baza_DateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.utilizatoriBindingSource;
            this.comboBox1.DisplayMember = "Username";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Utilizator";
            // 
            // baza_DateDataSet
            // 
            this.baza_DateDataSet.DataSetName = "Baza_DateDataSet";
            this.baza_DateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizatoriBindingSource
            // 
            this.utilizatoriBindingSource.DataMember = "Utilizatori";
            this.utilizatoriBindingSource.DataSource = this.baza_DateDataSet;
            // 
            // utilizatoriTableAdapter
            // 
            this.utilizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(143, 57);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Anulare";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // eradicate
            // 
            this.eradicate.ForeColor = System.Drawing.Color.Red;
            this.eradicate.Location = new System.Drawing.Point(62, 57);
            this.eradicate.Name = "eradicate";
            this.eradicate.Size = new System.Drawing.Size(75, 23);
            this.eradicate.TabIndex = 3;
            this.eradicate.Text = "Eradicare";
            this.eradicate.UseVisualStyleBackColor = true;
            this.eradicate.Click += new System.EventHandler(this.eradicate_Click);
            // 
            // UserDestroyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 92);
            this.ControlBox = false;
            this.Controls.Add(this.eradicate);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserDestroyer";
            this.Text = "Manager utilizatori";
            this.Load += new System.EventHandler(this.UserDestroyer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baza_DateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private Baza_DateDataSet baza_DateDataSet;
        private System.Windows.Forms.BindingSource utilizatoriBindingSource;
        private Baza_DateDataSetTableAdapters.UtilizatoriTableAdapter utilizatoriTableAdapter;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button eradicate;
    }
}