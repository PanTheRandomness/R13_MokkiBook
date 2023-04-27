namespace R13_MokkiBook
{
    partial class frmVaraukset
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
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkimokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vahvistuspvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattualkupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattuloppupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsVaraustaulunMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMuokkaa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVarauksenPalvelut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPoista = new System.Windows.Forms.ToolStripMenuItem();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new R13_MokkiBook.DataSet1();
            this.varausTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.varausTableAdapter();
            this.pnlToiminnot = new System.Windows.Forms.Panel();
            this.lblPaivat = new System.Windows.Forms.Label();
            this.dtpAlku = new System.Windows.Forms.DateTimePicker();
            this.cmsTyhjenna = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tyhjennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblViiva = new System.Windows.Forms.Label();
            this.dtpLoppu = new System.Windows.Forms.DateTimePicker();
            this.lblAlue = new System.Windows.Forms.Label();
            this.cbAlue = new System.Windows.Forms.ComboBox();
            this.lblMokki = new System.Windows.Forms.Label();
            this.cbMokki = new System.Windows.Forms.ComboBox();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Asiakas = new System.Windows.Forms.Label();
            this.cbAsiakas = new System.Windows.Forms.ComboBox();
            this.alueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHae = new System.Windows.Forms.Button();
            this.btnRaportti = new System.Windows.Forms.Button();
            this.btnUusi = new System.Windows.Forms.Button();
            this.epVaraukset = new System.Windows.Forms.ErrorProvider(this.components);
            this.mokkiTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.mokkiTableAdapter();
            this.alueTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.alueTableAdapter();
            this.pdRaportti = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            this.cmsVaraustaulunMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.cmsTyhjenna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epVaraukset)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVaraukset.AutoGenerateColumns = false;
            this.dgvVaraukset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varausidDataGridViewTextBoxColumn,
            this.asiakasidDataGridViewTextBoxColumn,
            this.mokkimokkiidDataGridViewTextBoxColumn,
            this.varattupvmDataGridViewTextBoxColumn,
            this.vahvistuspvmDataGridViewTextBoxColumn,
            this.varattualkupvmDataGridViewTextBoxColumn,
            this.varattuloppupvmDataGridViewTextBoxColumn});
            this.dgvVaraukset.ContextMenuStrip = this.cmsVaraustaulunMenu;
            this.dgvVaraukset.DataSource = this.varausBindingSource;
            this.dgvVaraukset.Location = new System.Drawing.Point(2, 3);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.Size = new System.Drawing.Size(1269, 578);
            this.dgvVaraukset.TabIndex = 0;
            this.dgvVaraukset.SelectionChanged += new System.EventHandler(this.dgvVaraukset_SelectionChanged);
            // 
            // varausidDataGridViewTextBoxColumn
            // 
            this.varausidDataGridViewTextBoxColumn.DataPropertyName = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.HeaderText = "Varaustunnus";
            this.varausidDataGridViewTextBoxColumn.Name = "varausidDataGridViewTextBoxColumn";
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "Asiakastunnus";
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            // 
            // mokkimokkiidDataGridViewTextBoxColumn
            // 
            this.mokkimokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_mokki_id";
            this.mokkimokkiidDataGridViewTextBoxColumn.HeaderText = "Mökki";
            this.mokkimokkiidDataGridViewTextBoxColumn.Name = "mokkimokkiidDataGridViewTextBoxColumn";
            // 
            // varattupvmDataGridViewTextBoxColumn
            // 
            this.varattupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_pvm";
            this.varattupvmDataGridViewTextBoxColumn.HeaderText = "Varaus tehty";
            this.varattupvmDataGridViewTextBoxColumn.Name = "varattupvmDataGridViewTextBoxColumn";
            // 
            // vahvistuspvmDataGridViewTextBoxColumn
            // 
            this.vahvistuspvmDataGridViewTextBoxColumn.DataPropertyName = "vahvistus_pvm";
            this.vahvistuspvmDataGridViewTextBoxColumn.HeaderText = "Varaus vahvistettu";
            this.vahvistuspvmDataGridViewTextBoxColumn.Name = "vahvistuspvmDataGridViewTextBoxColumn";
            // 
            // varattualkupvmDataGridViewTextBoxColumn
            // 
            this.varattualkupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_alkupvm";
            this.varattualkupvmDataGridViewTextBoxColumn.HeaderText = "Varauksen alkupävä";
            this.varattualkupvmDataGridViewTextBoxColumn.Name = "varattualkupvmDataGridViewTextBoxColumn";
            // 
            // varattuloppupvmDataGridViewTextBoxColumn
            // 
            this.varattuloppupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_loppupvm";
            this.varattuloppupvmDataGridViewTextBoxColumn.HeaderText = "Varauksen päättymispäivä";
            this.varattuloppupvmDataGridViewTextBoxColumn.Name = "varattuloppupvmDataGridViewTextBoxColumn";
            // 
            // cmsVaraustaulunMenu
            // 
            this.cmsVaraustaulunMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMuokkaa,
            this.tsmiVarauksenPalvelut,
            this.tsmiPoista});
            this.cmsVaraustaulunMenu.Name = "cmsVaraustaulunMenu";
            this.cmsVaraustaulunMenu.Size = new System.Drawing.Size(207, 70);
            this.cmsVaraustaulunMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cmsVaraustaulunMenu_Opening);
            // 
            // tsmiMuokkaa
            // 
            this.tsmiMuokkaa.Name = "tsmiMuokkaa";
            this.tsmiMuokkaa.Size = new System.Drawing.Size(206, 22);
            this.tsmiMuokkaa.Text = "Muokkaa varausta";
            this.tsmiMuokkaa.Click += new System.EventHandler(this.tsmiMuokkaa_Click);
            // 
            // tsmiVarauksenPalvelut
            // 
            this.tsmiVarauksenPalvelut.Name = "tsmiVarauksenPalvelut";
            this.tsmiVarauksenPalvelut.Size = new System.Drawing.Size(206, 22);
            this.tsmiVarauksenPalvelut.Text = "Näytä varauksen palvelut";
            this.tsmiVarauksenPalvelut.Click += new System.EventHandler(this.tsmiVarauksenPalvelut_Click);
            // 
            // tsmiPoista
            // 
            this.tsmiPoista.Name = "tsmiPoista";
            this.tsmiPoista.Size = new System.Drawing.Size(206, 22);
            this.tsmiPoista.Text = "Poista varaus";
            this.tsmiPoista.Click += new System.EventHandler(this.tsmiPoista_Click);
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // varausTableAdapter
            // 
            this.varausTableAdapter.ClearBeforeFill = true;
            // 
            // pnlToiminnot
            // 
            this.pnlToiminnot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlToiminnot.Location = new System.Drawing.Point(3, 638);
            this.pnlToiminnot.Name = "pnlToiminnot";
            this.pnlToiminnot.Size = new System.Drawing.Size(1267, 0);
            this.pnlToiminnot.TabIndex = 2;
            // 
            // lblPaivat
            // 
            this.lblPaivat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPaivat.AutoSize = true;
            this.lblPaivat.Location = new System.Drawing.Point(12, 594);
            this.lblPaivat.Name = "lblPaivat";
            this.lblPaivat.Size = new System.Drawing.Size(41, 13);
            this.lblPaivat.TabIndex = 1;
            this.lblPaivat.Text = "Päiviltä";
            // 
            // dtpAlku
            // 
            this.dtpAlku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpAlku.ContextMenuStrip = this.cmsTyhjenna;
            this.dtpAlku.Location = new System.Drawing.Point(59, 592);
            this.dtpAlku.Name = "dtpAlku";
            this.dtpAlku.Size = new System.Drawing.Size(200, 20);
            this.dtpAlku.TabIndex = 1;
            this.dtpAlku.ValueChanged += new System.EventHandler(this.dtpAlku_ValueChanged);
            // 
            // cmsTyhjenna
            // 
            this.cmsTyhjenna.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tyhjennaToolStripMenuItem});
            this.cmsTyhjenna.Name = "cmsTyhjenna";
            this.cmsTyhjenna.Size = new System.Drawing.Size(122, 26);
            // 
            // tyhjennaToolStripMenuItem
            // 
            this.tyhjennaToolStripMenuItem.Name = "tyhjennaToolStripMenuItem";
            this.tyhjennaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.tyhjennaToolStripMenuItem.Text = "Tyhjennä";
            this.tyhjennaToolStripMenuItem.Click += new System.EventHandler(this.tyhjennaToolStripMenuItem_Click);
            // 
            // lblViiva
            // 
            this.lblViiva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblViiva.AutoSize = true;
            this.lblViiva.Location = new System.Drawing.Point(265, 594);
            this.lblViiva.Name = "lblViiva";
            this.lblViiva.Size = new System.Drawing.Size(10, 13);
            this.lblViiva.TabIndex = 2;
            this.lblViiva.Text = "-";
            // 
            // dtpLoppu
            // 
            this.dtpLoppu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpLoppu.ContextMenuStrip = this.cmsTyhjenna;
            this.dtpLoppu.Location = new System.Drawing.Point(281, 592);
            this.dtpLoppu.Name = "dtpLoppu";
            this.dtpLoppu.Size = new System.Drawing.Size(200, 20);
            this.dtpLoppu.TabIndex = 2;
            this.dtpLoppu.ValueChanged += new System.EventHandler(this.dtpLoppu_ValueChanged);
            // 
            // lblAlue
            // 
            this.lblAlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAlue.AutoSize = true;
            this.lblAlue.Location = new System.Drawing.Point(487, 594);
            this.lblAlue.Name = "lblAlue";
            this.lblAlue.Size = new System.Drawing.Size(28, 13);
            this.lblAlue.TabIndex = 3;
            this.lblAlue.Text = "Alue";
            // 
            // cbAlue
            // 
            this.cbAlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAlue.ContextMenuStrip = this.cmsTyhjenna;
            this.cbAlue.Enabled = false;
            this.cbAlue.FormattingEnabled = true;
            this.cbAlue.Location = new System.Drawing.Point(521, 590);
            this.cbAlue.Name = "cbAlue";
            this.cbAlue.Size = new System.Drawing.Size(86, 21);
            this.cbAlue.TabIndex = 3;
            this.cbAlue.SelectedIndexChanged += new System.EventHandler(this.cbAlue_SelectedIndexChanged);
            // 
            // lblMokki
            // 
            this.lblMokki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMokki.AutoSize = true;
            this.lblMokki.Location = new System.Drawing.Point(613, 594);
            this.lblMokki.Name = "lblMokki";
            this.lblMokki.Size = new System.Drawing.Size(36, 13);
            this.lblMokki.TabIndex = 4;
            this.lblMokki.Text = "Mökki";
            // 
            // cbMokki
            // 
            this.cbMokki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMokki.ContextMenuStrip = this.cmsTyhjenna;
            this.cbMokki.DataSource = this.mokkiBindingSource;
            this.cbMokki.DisplayMember = "mokki_id";
            this.cbMokki.FormattingEnabled = true;
            this.cbMokki.Location = new System.Drawing.Point(655, 590);
            this.cbMokki.Name = "cbMokki";
            this.cbMokki.Size = new System.Drawing.Size(86, 21);
            this.cbMokki.TabIndex = 4;
            this.cbMokki.SelectedIndexChanged += new System.EventHandler(this.cbMokki_SelectedIndexChanged);
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // Asiakas
            // 
            this.Asiakas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Asiakas.AutoSize = true;
            this.Asiakas.Location = new System.Drawing.Point(747, 594);
            this.Asiakas.Name = "Asiakas";
            this.Asiakas.Size = new System.Drawing.Size(44, 13);
            this.Asiakas.TabIndex = 5;
            this.Asiakas.Text = "Asiakas";
            // 
            // cbAsiakas
            // 
            this.cbAsiakas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAsiakas.ContextMenuStrip = this.cmsTyhjenna;
            this.cbAsiakas.DataSource = this.alueBindingSource;
            this.cbAsiakas.DisplayMember = "nimi";
            this.cbAsiakas.FormattingEnabled = true;
            this.cbAsiakas.Location = new System.Drawing.Point(797, 591);
            this.cbAsiakas.Name = "cbAsiakas";
            this.cbAsiakas.Size = new System.Drawing.Size(86, 21);
            this.cbAsiakas.TabIndex = 5;
            this.cbAsiakas.SelectedIndexChanged += new System.EventHandler(this.cbAsiakas_SelectedIndexChanged);
            // 
            // alueBindingSource
            // 
            this.alueBindingSource.DataMember = "alue";
            this.alueBindingSource.DataSource = this.dataSet1;
            // 
            // btnHae
            // 
            this.btnHae.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHae.Location = new System.Drawing.Point(889, 590);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(50, 23);
            this.btnHae.TabIndex = 6;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            this.btnHae.Click += new System.EventHandler(this.btnHae_Click);
            // 
            // btnRaportti
            // 
            this.btnRaportti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRaportti.Location = new System.Drawing.Point(945, 591);
            this.btnRaportti.Name = "btnRaportti";
            this.btnRaportti.Size = new System.Drawing.Size(64, 23);
            this.btnRaportti.TabIndex = 7;
            this.btnRaportti.Text = "Raportti";
            this.btnRaportti.UseVisualStyleBackColor = true;
            this.btnRaportti.Click += new System.EventHandler(this.btnRaportti_Click);
            // 
            // btnUusi
            // 
            this.btnUusi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUusi.Location = new System.Drawing.Point(1187, 591);
            this.btnUusi.Name = "btnUusi";
            this.btnUusi.Size = new System.Drawing.Size(75, 23);
            this.btnUusi.TabIndex = 8;
            this.btnUusi.Text = "Uusi varaus";
            this.btnUusi.UseVisualStyleBackColor = true;
            this.btnUusi.Click += new System.EventHandler(this.btnUusi_Click);
            // 
            // epVaraukset
            // 
            this.epVaraukset.ContainerControl = this;
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // alueTableAdapter
            // 
            this.alueTableAdapter.ClearBeforeFill = true;
            // 
            // pdRaportti
            // 
            this.pdRaportti.PrintToFile = true;
            this.pdRaportti.ShowHelp = true;
            this.pdRaportti.UseEXDialog = true;
            // 
            // frmVaraukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 620);
            this.Controls.Add(this.btnUusi);
            this.Controls.Add(this.btnRaportti);
            this.Controls.Add(this.btnHae);
            this.Controls.Add(this.cbAsiakas);
            this.Controls.Add(this.Asiakas);
            this.Controls.Add(this.cbMokki);
            this.Controls.Add(this.lblMokki);
            this.Controls.Add(this.cbAlue);
            this.Controls.Add(this.lblAlue);
            this.Controls.Add(this.dtpLoppu);
            this.Controls.Add(this.lblViiva);
            this.Controls.Add(this.dtpAlku);
            this.Controls.Add(this.lblPaivat);
            this.Controls.Add(this.pnlToiminnot);
            this.Controls.Add(this.dgvVaraukset);
            this.MinimumSize = new System.Drawing.Size(1290, 659);
            this.Name = "frmVaraukset";
            this.Text = "Varaukset";
            this.Load += new System.EventHandler(this.frmVaraukset_Load);
            this.Leave += new System.EventHandler(this.frmVaraukset_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            this.cmsVaraustaulunMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.cmsTyhjenna.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epVaraukset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVaraukset;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private DataSet1TableAdapters.varausTableAdapter varausTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkimokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahvistuspvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattualkupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattuloppupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cmsVaraustaulunMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiMuokkaa;
        private System.Windows.Forms.ToolStripMenuItem tsmiVarauksenPalvelut;
        private System.Windows.Forms.ToolStripMenuItem tsmiPoista;
        private System.Windows.Forms.Panel pnlToiminnot;
        private System.Windows.Forms.Label lblPaivat;
        private System.Windows.Forms.DateTimePicker dtpAlku;
        private System.Windows.Forms.Label lblViiva;
        private System.Windows.Forms.DateTimePicker dtpLoppu;
        private System.Windows.Forms.Label lblAlue;
        private System.Windows.Forms.ComboBox cbAlue;
        private System.Windows.Forms.Label lblMokki;
        private System.Windows.Forms.ComboBox cbMokki;
        private System.Windows.Forms.Label Asiakas;
        private System.Windows.Forms.ComboBox cbAsiakas;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.Button btnRaportti;
        private System.Windows.Forms.Button btnUusi;
        private System.Windows.Forms.ErrorProvider epVaraukset;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private DataSet1TableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.BindingSource alueBindingSource;
        private DataSet1TableAdapters.alueTableAdapter alueTableAdapter;
        private System.Windows.Forms.ContextMenuStrip cmsTyhjenna;
        private System.Windows.Forms.ToolStripMenuItem tyhjennaToolStripMenuItem;
        private System.Windows.Forms.PrintDialog pdRaportti;
    }
}