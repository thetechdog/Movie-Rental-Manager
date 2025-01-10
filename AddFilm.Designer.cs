namespace Proiect_TAP
{
    partial class AddFilm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTitlu = new System.Windows.Forms.TextBox();
            this.textStudio = new System.Windows.Forms.TextBox();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.butConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titlu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Studio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Format";
            // 
            // textTitlu
            // 
            this.textTitlu.Location = new System.Drawing.Point(19, 43);
            this.textTitlu.Name = "textTitlu";
            this.textTitlu.Size = new System.Drawing.Size(156, 20);
            this.textTitlu.TabIndex = 3;
            // 
            // textStudio
            // 
            this.textStudio.Location = new System.Drawing.Point(19, 96);
            this.textStudio.Name = "textStudio";
            this.textStudio.Size = new System.Drawing.Size(156, 20);
            this.textStudio.TabIndex = 4;
            // 
            // cmbFormat
            // 
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Items.AddRange(new object[] {
            "DVD",
            "Blu-ray",
            "3D Blu-ray",
            "4K UHD Blu-ray",
            "HD-DVD",
            "VCD",
            "SVCD",
            "CVD",
            "UMD Video",
            "HD-VMD",
            "VHS",
            "Betamax",
            "VHD",
            "LaserDisc",
            "Digital"});
            this.cmbFormat.Location = new System.Drawing.Point(19, 145);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(156, 21);
            this.cmbFormat.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Renuntare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butConfirm
            // 
            this.butConfirm.Location = new System.Drawing.Point(103, 189);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(75, 23);
            this.butConfirm.TabIndex = 7;
            this.butConfirm.Text = "Ok";
            this.butConfirm.UseVisualStyleBackColor = true;
            this.butConfirm.Click += new System.EventHandler(this.butConfirm_Click);
            // 
            // AddFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 232);
            this.ControlBox = false;
            this.Controls.Add(this.butConfirm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.textStudio);
            this.Controls.Add(this.textTitlu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddFilm";
            this.Text = "Adaugare Film";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTitlu;
        private System.Windows.Forms.TextBox textStudio;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butConfirm;
    }
}