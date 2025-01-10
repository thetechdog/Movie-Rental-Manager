namespace Proiect_TAP
{
    partial class VerificareSiInchiriere
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
            this.radioInchiriere = new System.Windows.Forms.RadioButton();
            this.radioStocManage = new System.Windows.Forms.RadioButton();
            this.butonRent_Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInchiriat = new System.Windows.Forms.Label();
            this.labelInchiriatDe = new System.Windows.Forms.Label();
            this.labelDI = new System.Windows.Forms.Label();
            this.labelDR = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItemBack = new System.Windows.Forms.MenuItem();
            this.menuItemStoc = new System.Windows.Forms.MenuItem();
            this.menuItemAddFilm = new System.Windows.Forms.MenuItem();
            this.textTitlu = new System.Windows.Forms.TextBox();
            this.query1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.baza_DateDataSet11 = new Proiect_TAP.Baza_DateDataSet1();
            this.textStudio = new System.Windows.Forms.TextBox();
            this.textFormat = new System.Windows.Forms.TextBox();
            this.textInchiriatDe = new System.Windows.Forms.TextBox();
            this.dtmDI = new System.Windows.Forms.DateTimePicker();
            this.dtmDR = new System.Windows.Forms.DateTimePicker();
            this.textInchiriat = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inchiriatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persoanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInchiriereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataReturnareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocFilmeTableAdapter = new Proiect_TAP.Baza_DateDataSetTableAdapters.StocFilmeTableAdapter();
            this.baza_DateDataSet = new Proiect_TAP.Baza_DateDataSet();
            this.stocFilmeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.query1TableAdapter = new Proiect_TAP.Baza_DateDataSet1TableAdapters.Query1TableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.messageStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelID = new System.Windows.Forms.Label();
            this.labelFl = new System.Windows.Forms.Label();
            this.delFilm = new System.Windows.Forms.Button();
            this.dateCheck = new System.Windows.Forms.CheckBox();
            this.toolTipTick = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.query1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_DateDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_DateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocFilmeBindingSource1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioInchiriere
            // 
            this.radioInchiriere.AutoSize = true;
            this.radioInchiriere.Checked = true;
            this.radioInchiriere.Location = new System.Drawing.Point(456, 53);
            this.radioInchiriere.Name = "radioInchiriere";
            this.radioInchiriere.Size = new System.Drawing.Size(92, 17);
            this.radioInchiriere.TabIndex = 0;
            this.radioInchiriere.TabStop = true;
            this.radioInchiriere.Text = "Mod Inchiriere";
            this.radioInchiriere.UseVisualStyleBackColor = true;
            this.radioInchiriere.Visible = false;
            this.radioInchiriere.CheckedChanged += new System.EventHandler(this.radioInchiriere_CheckedChanged);
            // 
            // radioStocManage
            // 
            this.radioStocManage.AutoSize = true;
            this.radioStocManage.Location = new System.Drawing.Point(571, 53);
            this.radioStocManage.Name = "radioStocManage";
            this.radioStocManage.Size = new System.Drawing.Size(82, 17);
            this.radioStocManage.TabIndex = 1;
            this.radioStocManage.Text = "Mod Editare";
            this.radioStocManage.UseVisualStyleBackColor = true;
            this.radioStocManage.Visible = false;
            this.radioStocManage.CheckedChanged += new System.EventHandler(this.radioStocManage_CheckedChanged);
            // 
            // butonRent_Edit
            // 
            this.butonRent_Edit.Location = new System.Drawing.Point(456, 92);
            this.butonRent_Edit.Name = "butonRent_Edit";
            this.butonRent_Edit.Size = new System.Drawing.Size(75, 23);
            this.butonRent_Edit.TabIndex = 3;
            this.butonRent_Edit.Text = "Inchiriere";
            this.butonRent_Edit.UseVisualStyleBackColor = true;
            this.butonRent_Edit.Click += new System.EventHandler(this.butonRent_Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titlu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Studio/Distribuitor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Format";
            // 
            // labelInchiriat
            // 
            this.labelInchiriat.AutoSize = true;
            this.labelInchiriat.Location = new System.Drawing.Point(462, 251);
            this.labelInchiriat.Name = "labelInchiriat";
            this.labelInchiriat.Size = new System.Drawing.Size(44, 13);
            this.labelInchiriat.TabIndex = 7;
            this.labelInchiriat.Text = "Inchiriat";
            // 
            // labelInchiriatDe
            // 
            this.labelInchiriatDe.AutoSize = true;
            this.labelInchiriatDe.Location = new System.Drawing.Point(462, 275);
            this.labelInchiriatDe.Name = "labelInchiriatDe";
            this.labelInchiriatDe.Size = new System.Drawing.Size(59, 13);
            this.labelInchiriatDe.TabIndex = 8;
            this.labelInchiriatDe.Text = "Inchiriat de";
            this.labelInchiriatDe.Visible = false;
            // 
            // labelDI
            // 
            this.labelDI.AutoSize = true;
            this.labelDI.Location = new System.Drawing.Point(462, 298);
            this.labelDI.Name = "labelDI";
            this.labelDI.Size = new System.Drawing.Size(76, 13);
            this.labelDI.TabIndex = 9;
            this.labelDI.Text = "Data Inchiriere";
            this.labelDI.Visible = false;
            // 
            // labelDR
            // 
            this.labelDR.AutoSize = true;
            this.labelDR.Location = new System.Drawing.Point(462, 324);
            this.labelDR.Name = "labelDR";
            this.labelDR.Size = new System.Drawing.Size(80, 13);
            this.labelDR.TabIndex = 10;
            this.labelDR.Text = "Data Returnare";
            this.labelDR.Visible = false;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItemStoc});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemBack});
            this.menuItem1.Text = "Fereastra";
            // 
            // menuItemBack
            // 
            this.menuItemBack.Index = 0;
            this.menuItemBack.Text = "Inapoi";
            this.menuItemBack.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItemStoc
            // 
            this.menuItemStoc.Index = 1;
            this.menuItemStoc.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemAddFilm});
            this.menuItemStoc.Text = "Gestionare Stoc";
            this.menuItemStoc.Visible = false;
            // 
            // menuItemAddFilm
            // 
            this.menuItemAddFilm.Index = 0;
            this.menuItemAddFilm.Text = "Adaugare film";
            this.menuItemAddFilm.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // textTitlu
            // 
            this.textTitlu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.query1BindingSource1, "Titlu", true));
            this.textTitlu.Enabled = false;
            this.textTitlu.Location = new System.Drawing.Point(548, 133);
            this.textTitlu.Name = "textTitlu";
            this.textTitlu.Size = new System.Drawing.Size(218, 20);
            this.textTitlu.TabIndex = 11;
            // 
            // query1BindingSource1
            // 
            this.query1BindingSource1.DataMember = "Query1";
            this.query1BindingSource1.DataSource = this.baza_DateDataSet11;
            // 
            // baza_DateDataSet11
            // 
            this.baza_DateDataSet11.DataSetName = "Baza_DateDataSet1";
            this.baza_DateDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textStudio
            // 
            this.textStudio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.query1BindingSource1, "Studio", true));
            this.textStudio.Enabled = false;
            this.textStudio.Location = new System.Drawing.Point(549, 159);
            this.textStudio.Name = "textStudio";
            this.textStudio.Size = new System.Drawing.Size(218, 20);
            this.textStudio.TabIndex = 12;
            // 
            // textFormat
            // 
            this.textFormat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.query1BindingSource1, "Format", true));
            this.textFormat.Enabled = false;
            this.textFormat.Location = new System.Drawing.Point(548, 186);
            this.textFormat.Name = "textFormat";
            this.textFormat.Size = new System.Drawing.Size(218, 20);
            this.textFormat.TabIndex = 13;
            // 
            // textInchiriatDe
            // 
            this.textInchiriatDe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.query1BindingSource1, "Persoana", true));
            this.textInchiriatDe.Enabled = false;
            this.textInchiriatDe.Location = new System.Drawing.Point(548, 271);
            this.textInchiriatDe.Name = "textInchiriatDe";
            this.textInchiriatDe.Size = new System.Drawing.Size(218, 20);
            this.textInchiriatDe.TabIndex = 15;
            this.textInchiriatDe.Visible = false;
            // 
            // dtmDI
            // 
            this.dtmDI.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.query1BindingSource1, "DataInchiriere", true));
            this.dtmDI.Enabled = false;
            this.dtmDI.Location = new System.Drawing.Point(548, 298);
            this.dtmDI.Name = "dtmDI";
            this.dtmDI.Size = new System.Drawing.Size(201, 20);
            this.dtmDI.TabIndex = 16;
            this.dtmDI.Visible = false;
            // 
            // dtmDR
            // 
            this.dtmDR.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.query1BindingSource1, "DataReturnare", true));
            this.dtmDR.Enabled = false;
            this.dtmDR.Location = new System.Drawing.Point(549, 324);
            this.dtmDR.Name = "dtmDR";
            this.dtmDR.Size = new System.Drawing.Size(200, 20);
            this.dtmDR.TabIndex = 17;
            this.dtmDR.Visible = false;
            // 
            // textInchiriat
            // 
            this.textInchiriat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.query1BindingSource1, "Inchiriat", true));
            this.textInchiriat.Enabled = false;
            this.textInchiriat.Location = new System.Drawing.Point(548, 248);
            this.textInchiriat.Name = "textInchiriat";
            this.textInchiriat.Size = new System.Drawing.Size(217, 20);
            this.textInchiriat.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titluDataGridViewTextBoxColumn,
            this.studioDataGridViewTextBoxColumn,
            this.formatDataGridViewTextBoxColumn,
            this.inchiriatDataGridViewTextBoxColumn,
            this.persoanaDataGridViewTextBoxColumn,
            this.dataInchiriereDataGridViewTextBoxColumn,
            this.dataReturnareDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.query1BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(438, 390);
            this.dataGridView1.TabIndex = 22;
            // 
            // titluDataGridViewTextBoxColumn
            // 
            this.titluDataGridViewTextBoxColumn.DataPropertyName = "Titlu";
            this.titluDataGridViewTextBoxColumn.HeaderText = "Titlu";
            this.titluDataGridViewTextBoxColumn.Name = "titluDataGridViewTextBoxColumn";
            this.titluDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studioDataGridViewTextBoxColumn
            // 
            this.studioDataGridViewTextBoxColumn.DataPropertyName = "Studio";
            this.studioDataGridViewTextBoxColumn.HeaderText = "Studio";
            this.studioDataGridViewTextBoxColumn.Name = "studioDataGridViewTextBoxColumn";
            this.studioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formatDataGridViewTextBoxColumn
            // 
            this.formatDataGridViewTextBoxColumn.DataPropertyName = "Format";
            this.formatDataGridViewTextBoxColumn.HeaderText = "Format";
            this.formatDataGridViewTextBoxColumn.Name = "formatDataGridViewTextBoxColumn";
            this.formatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inchiriatDataGridViewTextBoxColumn
            // 
            this.inchiriatDataGridViewTextBoxColumn.DataPropertyName = "Inchiriat";
            this.inchiriatDataGridViewTextBoxColumn.HeaderText = "Inchiriat";
            this.inchiriatDataGridViewTextBoxColumn.Name = "inchiriatDataGridViewTextBoxColumn";
            this.inchiriatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // persoanaDataGridViewTextBoxColumn
            // 
            this.persoanaDataGridViewTextBoxColumn.DataPropertyName = "Persoana";
            this.persoanaDataGridViewTextBoxColumn.HeaderText = "Persoana";
            this.persoanaDataGridViewTextBoxColumn.Name = "persoanaDataGridViewTextBoxColumn";
            this.persoanaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataInchiriereDataGridViewTextBoxColumn
            // 
            this.dataInchiriereDataGridViewTextBoxColumn.DataPropertyName = "DataInchiriere";
            this.dataInchiriereDataGridViewTextBoxColumn.HeaderText = "DataInchiriere";
            this.dataInchiriereDataGridViewTextBoxColumn.Name = "dataInchiriereDataGridViewTextBoxColumn";
            this.dataInchiriereDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataReturnareDataGridViewTextBoxColumn
            // 
            this.dataReturnareDataGridViewTextBoxColumn.DataPropertyName = "DataReturnare";
            this.dataReturnareDataGridViewTextBoxColumn.HeaderText = "DataReturnare";
            this.dataReturnareDataGridViewTextBoxColumn.Name = "dataReturnareDataGridViewTextBoxColumn";
            this.dataReturnareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stocFilmeTableAdapter
            // 
            this.stocFilmeTableAdapter.ClearBeforeFill = true;
            // 
            // baza_DateDataSet
            // 
            this.baza_DateDataSet.DataSetName = "Baza_DateDataSet";
            this.baza_DateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stocFilmeBindingSource1
            // 
            this.stocFilmeBindingSource1.DataMember = "StocFilme";
            this.stocFilmeBindingSource1.DataSource = this.baza_DateDataSet;
            // 
            // query1TableAdapter
            // 
            this.query1TableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // messageStrip
            // 
            this.messageStrip.Name = "messageStrip";
            this.messageStrip.Size = new System.Drawing.Size(150, 17);
            this.messageStrip.Text = "Informatiile vor aparea aici.";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.query1BindingSource1, "ID", true));
            this.labelID.Location = new System.Drawing.Point(721, 408);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 24;
            this.labelID.Text = "ID";
            // 
            // labelFl
            // 
            this.labelFl.AutoSize = true;
            this.labelFl.Location = new System.Drawing.Point(682, 408);
            this.labelFl.Name = "labelFl";
            this.labelFl.Size = new System.Drawing.Size(42, 13);
            this.labelFl.TabIndex = 25;
            this.labelFl.Text = "ID Film:";
            // 
            // delFilm
            // 
            this.delFilm.Location = new System.Drawing.Point(538, 92);
            this.delFilm.Name = "delFilm";
            this.delFilm.Size = new System.Drawing.Size(115, 23);
            this.delFilm.TabIndex = 26;
            this.delFilm.Text = "Confirmare returnare";
            this.delFilm.UseVisualStyleBackColor = true;
            this.delFilm.Visible = false;
            this.delFilm.Click += new System.EventHandler(this.delFilm_Click_1);
            // 
            // dateCheck
            // 
            this.dateCheck.AutoSize = true;
            this.dateCheck.Location = new System.Drawing.Point(549, 351);
            this.dateCheck.Name = "dateCheck";
            this.dateCheck.Size = new System.Drawing.Size(74, 17);
            this.dateCheck.TabIndex = 27;
            this.dateCheck.Text = "Cu termen";
            this.dateCheck.UseVisualStyleBackColor = true;
            this.dateCheck.Visible = false;
            // 
            // toolTipTick
            // 
            this.toolTipTick.AutoPopDelay = 5000;
            this.toolTipTick.InitialDelay = 250;
            this.toolTipTick.IsBalloon = true;
            this.toolTipTick.ReshowDelay = 100;
            this.toolTipTick.ShowAlways = true;
            this.toolTipTick.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // VerificareSiInchiriere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.ControlBox = false;
            this.Controls.Add(this.dateCheck);
            this.Controls.Add(this.delFilm);
            this.Controls.Add(this.labelFl);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textInchiriat);
            this.Controls.Add(this.dtmDR);
            this.Controls.Add(this.dtmDI);
            this.Controls.Add(this.textInchiriatDe);
            this.Controls.Add(this.textFormat);
            this.Controls.Add(this.textStudio);
            this.Controls.Add(this.textTitlu);
            this.Controls.Add(this.labelDR);
            this.Controls.Add(this.labelDI);
            this.Controls.Add(this.labelInchiriatDe);
            this.Controls.Add(this.labelInchiriat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butonRent_Edit);
            this.Controls.Add(this.radioStocManage);
            this.Controls.Add(this.radioInchiriere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Menu = this.mainMenu1;
            this.Name = "VerificareSiInchiriere";
            this.Text = "Manager Filme";
            this.Load += new System.EventHandler(this.VerificareSiInchiriere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.query1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_DateDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_DateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocFilmeBindingSource1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioInchiriere;
        private System.Windows.Forms.RadioButton radioStocManage;
        private System.Windows.Forms.Button butonRent_Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInchiriat;
        private System.Windows.Forms.Label labelInchiriatDe;
        private System.Windows.Forms.Label labelDI;
        private System.Windows.Forms.Label labelDR;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItemBack;
        private System.Windows.Forms.MenuItem menuItemStoc;
        private System.Windows.Forms.MenuItem menuItemAddFilm;
        private System.Windows.Forms.TextBox textTitlu;
        private System.Windows.Forms.TextBox textStudio;
        private System.Windows.Forms.TextBox textFormat;
        private System.Windows.Forms.TextBox textInchiriatDe;
        private System.Windows.Forms.DateTimePicker dtmDI;
        private System.Windows.Forms.DateTimePicker dtmDR;
        private System.Windows.Forms.TextBox textInchiriat;
        private Baza_DateDataSetTableAdapters.StocFilmeTableAdapter stocFilmeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Baza_DateDataSet baza_DateDataSet;
        private System.Windows.Forms.BindingSource stocFilmeBindingSource1;
        private System.Windows.Forms.BindingSource query1BindingSource1;
        private Baza_DateDataSet1 baza_DateDataSet11;
        private Baza_DateDataSet1TableAdapters.Query1TableAdapter query1TableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel messageStrip;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inchiriatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persoanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInchiriereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataReturnareDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelFl;
        private System.Windows.Forms.Button delFilm;
        private System.Windows.Forms.CheckBox dateCheck;
        private System.Windows.Forms.ToolTip toolTipTick;
    }
}