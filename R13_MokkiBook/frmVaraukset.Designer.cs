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
            this.pnlAlapaneeli = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMökki = new System.Windows.Forms.Label();
            this.lblAlue = new System.Windows.Forms.Label();
            this.cbAsiakas = new System.Windows.Forms.ComboBox();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varauksetData = new R13_MokkiBook.VarauksetData();
            this.cbMokki = new System.Windows.Forms.ComboBox();
            this.cbAlue = new System.Windows.Forms.ComboBox();
            this.alueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblLoppu = new System.Windows.Forms.Label();
            this.dtpLoppu = new System.Windows.Forms.DateTimePicker();
            this.lblAlkuPvm = new System.Windows.Forms.Label();
            this.dtpAlku = new System.Windows.Forms.DateTimePicker();
            this.btnHae = new System.Windows.Forms.Button();
            this.btnTulostaVarausRaportti = new System.Windows.Forms.Button();
            this.btnUusiVaraus = new System.Windows.Forms.Button();
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.dgvtbcVarausid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcMokinAlue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcAsiakasid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcMokkiid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcVarauspvm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcVahvistuspvm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcVarausAlku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcVarausLoppu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamTauluAdapteriManageri = new R13_MokkiBook.VarauksetDataTableAdapters.TableAdapterManager();
            this.taVaraus = new R13_MokkiBook.VarauksetDataTableAdapters.varausTableAdapter();
            this.cmsVarauksenMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiVarauksenPalvelut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPoista = new System.Windows.Forms.ToolStripMenuItem();
            this.epVaraukset = new System.Windows.Forms.ErrorProvider(this.components);
            this.varauksetData1 = new R13_MokkiBook.VarauksetData();
            this.varauksetData1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlAlapaneeli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            this.cmsVarauksenMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epVaraukset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetData1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAlapaneeli
            // 
            this.pnlAlapaneeli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAlapaneeli.Controls.Add(this.label1);
            this.pnlAlapaneeli.Controls.Add(this.lblMökki);
            this.pnlAlapaneeli.Controls.Add(this.lblAlue);
            this.pnlAlapaneeli.Controls.Add(this.cbAsiakas);
            this.pnlAlapaneeli.Controls.Add(this.cbMokki);
            this.pnlAlapaneeli.Controls.Add(this.cbAlue);
            this.pnlAlapaneeli.Controls.Add(this.lblLoppu);
            this.pnlAlapaneeli.Controls.Add(this.dtpLoppu);
            this.pnlAlapaneeli.Controls.Add(this.lblAlkuPvm);
            this.pnlAlapaneeli.Controls.Add(this.dtpAlku);
            this.pnlAlapaneeli.Controls.Add(this.btnHae);
            this.pnlAlapaneeli.Controls.Add(this.btnTulostaVarausRaportti);
            this.pnlAlapaneeli.Controls.Add(this.btnUusiVaraus);
            this.pnlAlapaneeli.Location = new System.Drawing.Point(0, 612);
            this.pnlAlapaneeli.Name = "pnlAlapaneeli";
            this.pnlAlapaneeli.Size = new System.Drawing.Size(1363, 49);
            this.pnlAlapaneeli.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(877, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Asiakastunnus";
            // 
            // lblMökki
            // 
            this.lblMökki.AutoSize = true;
            this.lblMökki.Location = new System.Drawing.Point(708, 20);
            this.lblMökki.Name = "lblMökki";
            this.lblMökki.Size = new System.Drawing.Size(36, 13);
            this.lblMökki.TabIndex = 4;
            this.lblMökki.Text = "Mökki";
            // 
            // lblAlue
            // 
            this.lblAlue.AutoSize = true;
            this.lblAlue.Location = new System.Drawing.Point(547, 20);
            this.lblAlue.Name = "lblAlue";
            this.lblAlue.Size = new System.Drawing.Size(28, 13);
            this.lblAlue.TabIndex = 3;
            this.lblAlue.Text = "Alue";
            // 
            // cbAsiakas
            // 
            this.cbAsiakas.DataSource = this.varausBindingSource;
            this.cbAsiakas.DisplayMember = "asiakas_id";
            this.cbAsiakas.FormattingEnabled = true;
            this.cbAsiakas.Location = new System.Drawing.Point(959, 16);
            this.cbAsiakas.Name = "cbAsiakas";
            this.cbAsiakas.Size = new System.Drawing.Size(121, 21);
            this.cbAsiakas.TabIndex = 5;
            this.cbAsiakas.SelectedIndexChanged += new System.EventHandler(this.cbAsiakas_SelectedIndexChanged);
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.varauksetData;
            // 
            // varauksetData
            // 
            this.varauksetData.DataSetName = "VarauksetData";
            this.varauksetData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbMokki
            // 
            this.cbMokki.DataSource = this.varausBindingSource;
            this.cbMokki.DisplayMember = "mokki_mokki_id";
            this.cbMokki.FormattingEnabled = true;
            this.cbMokki.Location = new System.Drawing.Point(750, 16);
            this.cbMokki.Name = "cbMokki";
            this.cbMokki.Size = new System.Drawing.Size(121, 21);
            this.cbMokki.TabIndex = 4;
            this.cbMokki.SelectedIndexChanged += new System.EventHandler(this.cbMokki_SelectedIndexChanged);
            // 
            // cbAlue
            // 
            this.cbAlue.DataSource = this.alueBindingSource;
            this.cbAlue.FormattingEnabled = true;
            this.cbAlue.Location = new System.Drawing.Point(581, 16);
            this.cbAlue.Name = "cbAlue";
            this.cbAlue.Size = new System.Drawing.Size(121, 21);
            this.cbAlue.TabIndex = 3;
            this.cbAlue.SelectedIndexChanged += new System.EventHandler(this.cbAlue_SelectedIndexChanged);
            // 
            // lblLoppu
            // 
            this.lblLoppu.AutoSize = true;
            this.lblLoppu.Location = new System.Drawing.Point(275, 19);
            this.lblLoppu.Name = "lblLoppu";
            this.lblLoppu.Size = new System.Drawing.Size(60, 13);
            this.lblLoppu.TabIndex = 2;
            this.lblLoppu.Text = "Loppu pvm";
            // 
            // dtpLoppu
            // 
            this.dtpLoppu.Location = new System.Drawing.Point(341, 17);
            this.dtpLoppu.Name = "dtpLoppu";
            this.dtpLoppu.Size = new System.Drawing.Size(200, 20);
            this.dtpLoppu.TabIndex = 2;
            this.dtpLoppu.ValueChanged += new System.EventHandler(this.dtpLoppu_ValueChanged);
            // 
            // lblAlkuPvm
            // 
            this.lblAlkuPvm.AutoSize = true;
            this.lblAlkuPvm.Location = new System.Drawing.Point(12, 19);
            this.lblAlkuPvm.Name = "lblAlkuPvm";
            this.lblAlkuPvm.Size = new System.Drawing.Size(51, 13);
            this.lblAlkuPvm.TabIndex = 1;
            this.lblAlkuPvm.Text = "Alku pvm";
            // 
            // dtpAlku
            // 
            this.dtpAlku.Location = new System.Drawing.Point(69, 17);
            this.dtpAlku.Name = "dtpAlku";
            this.dtpAlku.Size = new System.Drawing.Size(200, 20);
            this.dtpAlku.TabIndex = 1;
            this.dtpAlku.ValueChanged += new System.EventHandler(this.dtpAlku_ValueChanged);
            // 
            // btnHae
            // 
            this.btnHae.Location = new System.Drawing.Point(1086, 14);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(51, 23);
            this.btnHae.TabIndex = 6;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            this.btnHae.Click += new System.EventHandler(this.btnHae_Click);
            // 
            // btnTulostaVarausRaportti
            // 
            this.btnTulostaVarausRaportti.Location = new System.Drawing.Point(1143, 14);
            this.btnTulostaVarausRaportti.Name = "btnTulostaVarausRaportti";
            this.btnTulostaVarausRaportti.Size = new System.Drawing.Size(103, 23);
            this.btnTulostaVarausRaportti.TabIndex = 7;
            this.btnTulostaVarausRaportti.Text = "Tulosta raportti";
            this.btnTulostaVarausRaportti.UseVisualStyleBackColor = true;
            this.btnTulostaVarausRaportti.Click += new System.EventHandler(this.btnTulostaVarausRaportti_Click);
            // 
            // btnUusiVaraus
            // 
            this.btnUusiVaraus.Location = new System.Drawing.Point(1272, 15);
            this.btnUusiVaraus.Name = "btnUusiVaraus";
            this.btnUusiVaraus.Size = new System.Drawing.Size(79, 23);
            this.btnUusiVaraus.TabIndex = 8;
            this.btnUusiVaraus.Text = "Luo uusi";
            this.btnUusiVaraus.UseVisualStyleBackColor = true;
            this.btnUusiVaraus.Click += new System.EventHandler(this.btnUusiVaraus_Click);
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
            this.dgvtbcVarausid,
            this.dgvtbcMokinAlue,
            this.dgvtbcAsiakasid,
            this.dgvtbcMokkiid,
            this.dgvtbcVarauspvm,
            this.dgvtbcVahvistuspvm,
            this.dgvtbcVarausAlku,
            this.dgvtbcVarausLoppu});
            this.dgvVaraukset.DataSource = this.varausBindingSource;
            this.dgvVaraukset.Location = new System.Drawing.Point(0, 1);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.Size = new System.Drawing.Size(1362, 612);
            this.dgvVaraukset.TabIndex = 0;
            this.dgvVaraukset.SelectionChanged += new System.EventHandler(this.dgvVaraukset_SelectionChanged);
            // 
            // dgvtbcVarausid
            // 
            this.dgvtbcVarausid.DataPropertyName = "varaus_id";
            this.dgvtbcVarausid.HeaderText = "Varaustunnus";
            this.dgvtbcVarausid.Name = "dgvtbcVarausid";
            // 
            // dgvtbcMokinAlue
            // 
            this.dgvtbcMokinAlue.HeaderText = "Alue";
            this.dgvtbcMokinAlue.Name = "dgvtbcMokinAlue";
            // 
            // dgvtbcAsiakasid
            // 
            this.dgvtbcAsiakasid.DataPropertyName = "asiakas_id";
            this.dgvtbcAsiakasid.HeaderText = "Asiakastunnus";
            this.dgvtbcAsiakasid.Name = "dgvtbcAsiakasid";
            // 
            // dgvtbcMokkiid
            // 
            this.dgvtbcMokkiid.DataPropertyName = "mokki_mokki_id";
            this.dgvtbcMokkiid.HeaderText = "Mökkitunnus";
            this.dgvtbcMokkiid.Name = "dgvtbcMokkiid";
            // 
            // dgvtbcVarauspvm
            // 
            this.dgvtbcVarauspvm.DataPropertyName = "varattu_pvm";
            this.dgvtbcVarauspvm.HeaderText = "Varauspäivä";
            this.dgvtbcVarauspvm.Name = "dgvtbcVarauspvm";
            this.dgvtbcVarauspvm.ToolTipText = "pvm";
            // 
            // dgvtbcVahvistuspvm
            // 
            this.dgvtbcVahvistuspvm.DataPropertyName = "vahvistus_pvm";
            this.dgvtbcVahvistuspvm.HeaderText = "Vahvistuspäivä";
            this.dgvtbcVahvistuspvm.Name = "dgvtbcVahvistuspvm";
            this.dgvtbcVahvistuspvm.ToolTipText = "pvm";
            // 
            // dgvtbcVarausAlku
            // 
            this.dgvtbcVarausAlku.DataPropertyName = "varattu_alkupvm";
            this.dgvtbcVarausAlku.HeaderText = "Varauksen alkupäivämäärä";
            this.dgvtbcVarausAlku.Name = "dgvtbcVarausAlku";
            // 
            // dgvtbcVarausLoppu
            // 
            this.dgvtbcVarausLoppu.DataPropertyName = "varattu_loppupvm";
            this.dgvtbcVarausLoppu.HeaderText = "Varauksen päättymispäivä";
            this.dgvtbcVarausLoppu.Name = "dgvtbcVarausLoppu";
            // 
            // tamTauluAdapteriManageri
            // 
            this.tamTauluAdapteriManageri.BackupDataSetBeforeUpdate = true;
            this.tamTauluAdapteriManageri.UpdateOrder = R13_MokkiBook.VarauksetDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tamTauluAdapteriManageri.varauksen_palvelutTableAdapter = null;
            this.tamTauluAdapteriManageri.varausTableAdapter = this.taVaraus;
            // 
            // taVaraus
            // 
            this.taVaraus.ClearBeforeFill = true;
            // 
            // cmsVarauksenMenuStrip
            // 
            this.cmsVarauksenMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVarauksenPalvelut,
            this.tsmiPoista});
            this.cmsVarauksenMenuStrip.Name = "cmsVarauksenMenuStrip";
            this.cmsVarauksenMenuStrip.Size = new System.Drawing.Size(207, 48);
            // 
            // tsmiVarauksenPalvelut
            // 
            this.tsmiVarauksenPalvelut.Name = "tsmiVarauksenPalvelut";
            this.tsmiVarauksenPalvelut.Size = new System.Drawing.Size(206, 22);
            this.tsmiVarauksenPalvelut.Text = "Näytä varauksen palvelut";
            this.tsmiVarauksenPalvelut.ToolTipText = "Avaa toiseen ikkunaan listan varauksen sisältämistä palveluista";
            this.tsmiVarauksenPalvelut.Click += new System.EventHandler(this.VarauksenPalvelutToolStripMenuItem_Click);
            // 
            // tsmiPoista
            // 
            this.tsmiPoista.Name = "tsmiPoista";
            this.tsmiPoista.Size = new System.Drawing.Size(206, 22);
            this.tsmiPoista.Text = "Poista";
            this.tsmiPoista.ToolTipText = "Poistaa varauksen";
            this.tsmiPoista.Click += new System.EventHandler(this.tsmiPoista_Click);
            // 
            // epVaraukset
            // 
            this.epVaraukset.ContainerControl = this;
            // 
            // varauksetData1
            // 
            this.varauksetData1.DataSetName = "VarauksetData";
            this.varauksetData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // varauksetData1BindingSource
            // 
            this.varauksetData1BindingSource.DataSource = this.varauksetData1;
            this.varauksetData1BindingSource.Position = 0;
            // 
            // frmVaraukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 661);
            this.Controls.Add(this.dgvVaraukset);
            this.Controls.Add(this.pnlAlapaneeli);
            this.Name = "frmVaraukset";
            this.Text = "Varaukset";
            this.Load += new System.EventHandler(this.frmVaraukset_Load);
            this.Leave += new System.EventHandler(this.frmVaraukset_Leave);
            this.pnlAlapaneeli.ResumeLayout(false);
            this.pnlAlapaneeli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            this.cmsVarauksenMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epVaraukset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetData1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAlapaneeli;
        private System.Windows.Forms.DataGridView dgvVaraukset;
        private VarauksetData varauksetData;
        private VarauksetDataTableAdapters.TableAdapterManager tamTauluAdapteriManageri;
        private VarauksetDataTableAdapters.varausTableAdapter taVaraus;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.Button btnTulostaVarausRaportti;
        private System.Windows.Forms.Button btnUusiVaraus;
        private System.Windows.Forms.ContextMenuStrip cmsVarauksenMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiVarauksenPalvelut;
        private System.Windows.Forms.ToolStripMenuItem tsmiPoista;
        private System.Windows.Forms.ErrorProvider epVaraukset;
        private System.Windows.Forms.ComboBox cbAsiakas;
        private System.Windows.Forms.ComboBox cbMokki;
        private System.Windows.Forms.ComboBox cbAlue;
        private System.Windows.Forms.Label lblLoppu;
        private System.Windows.Forms.DateTimePicker dtpLoppu;
        private System.Windows.Forms.Label lblAlkuPvm;
        private System.Windows.Forms.DateTimePicker dtpAlku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMökki;
        private System.Windows.Forms.Label lblAlue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcVarausid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcMokinAlue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcAsiakasid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcMokkiid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcVarauspvm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcVahvistuspvm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcVarausAlku;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcVarausLoppu;
        private VarauksetData varauksetData1;
        private System.Windows.Forms.BindingSource varauksetData1BindingSource;
        private System.Windows.Forms.BindingSource alueBindingSource;
    }
}