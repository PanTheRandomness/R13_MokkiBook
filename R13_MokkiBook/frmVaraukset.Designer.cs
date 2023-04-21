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
            this.btnHae = new System.Windows.Forms.Button();
            this.btnTulostaVarausRaportti = new System.Windows.Forms.Button();
            this.btnUusiVaraus = new System.Windows.Forms.Button();
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkimokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vahvistuspvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattualkupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattuloppupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varauksetData = new R13_MokkiBook.VarauksetData();
            this.tamTauluAdapteriManageri = new R13_MokkiBook.VarauksetDataTableAdapters.TableAdapterManager();
            this.taVaraus = new R13_MokkiBook.VarauksetDataTableAdapters.varausTableAdapter();
            this.cmsVarauksenMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiVarauksenPalvelut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPoista = new System.Windows.Forms.ToolStripMenuItem();
            this.epVaraukset = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpAlku = new System.Windows.Forms.DateTimePicker();
            this.lblAlkuPvm = new System.Windows.Forms.Label();
            this.lblLoppu = new System.Windows.Forms.Label();
            this.dtpLoppu = new System.Windows.Forms.DateTimePicker();
            this.cbAlue = new System.Windows.Forms.ComboBox();
            this.cbMokki = new System.Windows.Forms.ComboBox();
            this.cbAsiakas = new System.Windows.Forms.ComboBox();
            this.pnlAlapaneeli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetData)).BeginInit();
            this.cmsVarauksenMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epVaraukset)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAlapaneeli
            // 
            this.pnlAlapaneeli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.pnlAlapaneeli.Location = new System.Drawing.Point(0, 613);
            this.pnlAlapaneeli.Name = "pnlAlapaneeli";
            this.pnlAlapaneeli.Size = new System.Drawing.Size(1274, 49);
            this.pnlAlapaneeli.TabIndex = 1;
            // 
            // btnHae
            // 
            this.btnHae.Location = new System.Drawing.Point(928, 14);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(51, 23);
            this.btnHae.TabIndex = 6;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            // 
            // btnTulostaVarausRaportti
            // 
            this.btnTulostaVarausRaportti.Location = new System.Drawing.Point(985, 14);
            this.btnTulostaVarausRaportti.Name = "btnTulostaVarausRaportti";
            this.btnTulostaVarausRaportti.Size = new System.Drawing.Size(103, 23);
            this.btnTulostaVarausRaportti.TabIndex = 7;
            this.btnTulostaVarausRaportti.Text = "Tulosta raportti";
            this.btnTulostaVarausRaportti.UseVisualStyleBackColor = true;
            // 
            // btnUusiVaraus
            // 
            this.btnUusiVaraus.Location = new System.Drawing.Point(1183, 14);
            this.btnUusiVaraus.Name = "btnUusiVaraus";
            this.btnUusiVaraus.Size = new System.Drawing.Size(79, 23);
            this.btnUusiVaraus.TabIndex = 8;
            this.btnUusiVaraus.Text = "Luo uusi";
            this.btnUusiVaraus.UseVisualStyleBackColor = true;
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
            this.dgvVaraukset.DataSource = this.varausBindingSource;
            this.dgvVaraukset.Location = new System.Drawing.Point(0, 1);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.Size = new System.Drawing.Size(1273, 613);
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
            this.mokkimokkiidDataGridViewTextBoxColumn.HeaderText = "Mökkitunnus";
            this.mokkimokkiidDataGridViewTextBoxColumn.Name = "mokkimokkiidDataGridViewTextBoxColumn";
            // 
            // varattupvmDataGridViewTextBoxColumn
            // 
            this.varattupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_pvm";
            this.varattupvmDataGridViewTextBoxColumn.HeaderText = "Varauspäivä";
            this.varattupvmDataGridViewTextBoxColumn.Name = "varattupvmDataGridViewTextBoxColumn";
            this.varattupvmDataGridViewTextBoxColumn.ToolTipText = "pvm";
            // 
            // vahvistuspvmDataGridViewTextBoxColumn
            // 
            this.vahvistuspvmDataGridViewTextBoxColumn.DataPropertyName = "vahvistus_pvm";
            this.vahvistuspvmDataGridViewTextBoxColumn.HeaderText = "Vahvistuspäivä";
            this.vahvistuspvmDataGridViewTextBoxColumn.Name = "vahvistuspvmDataGridViewTextBoxColumn";
            this.vahvistuspvmDataGridViewTextBoxColumn.ToolTipText = "pvm";
            // 
            // varattualkupvmDataGridViewTextBoxColumn
            // 
            this.varattualkupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_alkupvm";
            this.varattualkupvmDataGridViewTextBoxColumn.HeaderText = "Varauksen alkupäivämäärä";
            this.varattualkupvmDataGridViewTextBoxColumn.Name = "varattualkupvmDataGridViewTextBoxColumn";
            // 
            // varattuloppupvmDataGridViewTextBoxColumn
            // 
            this.varattuloppupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_loppupvm";
            this.varattuloppupvmDataGridViewTextBoxColumn.HeaderText = "Varauksen päättymispäivä";
            this.varattuloppupvmDataGridViewTextBoxColumn.Name = "varattuloppupvmDataGridViewTextBoxColumn";
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
            // dtpAlku
            // 
            this.dtpAlku.Location = new System.Drawing.Point(69, 17);
            this.dtpAlku.Name = "dtpAlku";
            this.dtpAlku.Size = new System.Drawing.Size(200, 20);
            this.dtpAlku.TabIndex = 1;
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
            // 
            // cbAlue
            // 
            this.cbAlue.FormattingEnabled = true;
            this.cbAlue.Location = new System.Drawing.Point(547, 16);
            this.cbAlue.Name = "cbAlue";
            this.cbAlue.Size = new System.Drawing.Size(121, 21);
            this.cbAlue.TabIndex = 3;
            this.cbAlue.Text = "Aluetunnus";
            // 
            // cbMokki
            // 
            this.cbMokki.FormattingEnabled = true;
            this.cbMokki.Location = new System.Drawing.Point(674, 16);
            this.cbMokki.Name = "cbMokki";
            this.cbMokki.Size = new System.Drawing.Size(121, 21);
            this.cbMokki.TabIndex = 4;
            this.cbMokki.Text = "Mökkitunnus";
            // 
            // cbAsiakas
            // 
            this.cbAsiakas.FormattingEnabled = true;
            this.cbAsiakas.Location = new System.Drawing.Point(801, 16);
            this.cbAsiakas.Name = "cbAsiakas";
            this.cbAsiakas.Size = new System.Drawing.Size(121, 21);
            this.cbAsiakas.TabIndex = 5;
            this.cbAsiakas.Text = "Asiakastunnus";
            this.cbAsiakas.SelectedIndexChanged += new System.EventHandler(this.cbAsiakas_SelectedIndexChanged);
            // 
            // frmVaraukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 662);
            this.Controls.Add(this.dgvVaraukset);
            this.Controls.Add(this.pnlAlapaneeli);
            this.Name = "frmVaraukset";
            this.Text = "Varaukset";
            this.Load += new System.EventHandler(this.frmVaraukset_Load);
            this.Leave += new System.EventHandler(this.frmVaraukset_Leave);
            this.pnlAlapaneeli.ResumeLayout(false);
            this.pnlAlapaneeli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetData)).EndInit();
            this.cmsVarauksenMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epVaraukset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAlapaneeli;
        private System.Windows.Forms.DataGridView dgvVaraukset;
        private VarauksetData varauksetData;
        private VarauksetDataTableAdapters.TableAdapterManager tamTauluAdapteriManageri;
        private VarauksetDataTableAdapters.varausTableAdapter taVaraus;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkimokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahvistuspvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattualkupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattuloppupvmDataGridViewTextBoxColumn;
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
    }
}