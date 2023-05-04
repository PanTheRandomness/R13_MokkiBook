namespace R13_MokkiBook
{
    partial class frmMokit
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
            this.lbMokkiId = new System.Windows.Forms.Label();
            this.lbPostinumero = new System.Windows.Forms.Label();
            this.lbNimi = new System.Windows.Forms.Label();
            this.lbHinta = new System.Windows.Forms.Label();
            this.lbLahiosoite = new System.Windows.Forms.Label();
            this.lbKuvaus = new System.Windows.Forms.Label();
            this.lbHenkilomaara = new System.Windows.Forms.Label();
            this.lbAlueId = new System.Windows.Forms.Label();
            this.lbVarustelu = new System.Windows.Forms.Label();
            this.tbMokkiId = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.tbHenkilomaara = new System.Windows.Forms.TextBox();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.tbMokinnimi = new System.Windows.Forms.TextBox();
            this.tbPostinumero = new System.Windows.Forms.TextBox();
            this.tbAlueId = new System.Windows.Forms.TextBox();
            this.dgvMokit = new System.Windows.Forms.DataGridView();
            this.mokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varusteluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new R13_MokkiBook.DataSet1();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.dtpLoppu = new System.Windows.Forms.DateTimePicker();
            this.lblViiva = new System.Windows.Forms.Label();
            this.dtpAlku = new System.Windows.Forms.DateTimePicker();
            this.lblPaivat = new System.Windows.Forms.Label();
            this.btnHae = new System.Windows.Forms.Button();
            this.mokkiTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.mokkiTableAdapter();
            this.alueTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.alueTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMokkiId
            // 
            this.lbMokkiId.AutoSize = true;
            this.lbMokkiId.Location = new System.Drawing.Point(27, 37);
            this.lbMokkiId.Name = "lbMokkiId";
            this.lbMokkiId.Size = new System.Drawing.Size(62, 16);
            this.lbMokkiId.TabIndex = 0;
            this.lbMokkiId.Text = "Mökki ID:";
            // 
            // lbPostinumero
            // 
            this.lbPostinumero.AutoSize = true;
            this.lbPostinumero.Location = new System.Drawing.Point(27, 102);
            this.lbPostinumero.Name = "lbPostinumero";
            this.lbPostinumero.Size = new System.Drawing.Size(82, 16);
            this.lbPostinumero.TabIndex = 2;
            this.lbPostinumero.Text = "Postinumero";
            // 
            // lbNimi
            // 
            this.lbNimi.AutoSize = true;
            this.lbNimi.Location = new System.Drawing.Point(27, 139);
            this.lbNimi.Name = "lbNimi";
            this.lbNimi.Size = new System.Drawing.Size(70, 16);
            this.lbNimi.TabIndex = 3;
            this.lbNimi.Text = "Mökin nimi";
            // 
            // lbHinta
            // 
            this.lbHinta.AutoSize = true;
            this.lbHinta.Location = new System.Drawing.Point(361, 37);
            this.lbHinta.Name = "lbHinta";
            this.lbHinta.Size = new System.Drawing.Size(38, 16);
            this.lbHinta.TabIndex = 4;
            this.lbHinta.Text = "Hinta";
            // 
            // lbLahiosoite
            // 
            this.lbLahiosoite.AutoSize = true;
            this.lbLahiosoite.Location = new System.Drawing.Point(27, 177);
            this.lbLahiosoite.Name = "lbLahiosoite";
            this.lbLahiosoite.Size = new System.Drawing.Size(70, 16);
            this.lbLahiosoite.TabIndex = 5;
            this.lbLahiosoite.Text = "Katuosoite";
            // 
            // lbKuvaus
            // 
            this.lbKuvaus.AutoSize = true;
            this.lbKuvaus.Location = new System.Drawing.Point(361, 67);
            this.lbKuvaus.Name = "lbKuvaus";
            this.lbKuvaus.Size = new System.Drawing.Size(51, 16);
            this.lbKuvaus.TabIndex = 6;
            this.lbKuvaus.Text = "Kuvaus";
            // 
            // lbHenkilomaara
            // 
            this.lbHenkilomaara.AutoSize = true;
            this.lbHenkilomaara.Location = new System.Drawing.Point(361, 137);
            this.lbHenkilomaara.Name = "lbHenkilomaara";
            this.lbHenkilomaara.Size = new System.Drawing.Size(92, 16);
            this.lbHenkilomaara.TabIndex = 7;
            this.lbHenkilomaara.Text = "Henkilömäärä";
            // 
            // lbAlueId
            // 
            this.lbAlueId.AutoSize = true;
            this.lbAlueId.Location = new System.Drawing.Point(27, 67);
            this.lbAlueId.Name = "lbAlueId";
            this.lbAlueId.Size = new System.Drawing.Size(53, 16);
            this.lbAlueId.TabIndex = 8;
            this.lbAlueId.Text = "Alue ID:";
            // 
            // lbVarustelu
            // 
            this.lbVarustelu.AutoSize = true;
            this.lbVarustelu.Location = new System.Drawing.Point(361, 174);
            this.lbVarustelu.Name = "lbVarustelu";
            this.lbVarustelu.Size = new System.Drawing.Size(63, 16);
            this.lbVarustelu.TabIndex = 9;
            this.lbVarustelu.Text = "Varustelu";
            // 
            // tbMokkiId
            // 
            this.tbMokkiId.Location = new System.Drawing.Point(122, 31);
            this.tbMokkiId.Name = "tbMokkiId";
            this.tbMokkiId.Size = new System.Drawing.Size(168, 22);
            this.tbMokkiId.TabIndex = 10;
            this.tbMokkiId.TextChanged += new System.EventHandler(this.tbMokkiId_TextChanged);
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Location = new System.Drawing.Point(122, 174);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(168, 22);
            this.tbKatuosoite.TabIndex = 11;
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(464, 171);
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(168, 22);
            this.tbVarustelu.TabIndex = 15;
            // 
            // tbHenkilomaara
            // 
            this.tbHenkilomaara.Location = new System.Drawing.Point(464, 137);
            this.tbHenkilomaara.Name = "tbHenkilomaara";
            this.tbHenkilomaara.Size = new System.Drawing.Size(168, 22);
            this.tbHenkilomaara.TabIndex = 16;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(464, 64);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(168, 54);
            this.tbKuvaus.TabIndex = 17;
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(464, 31);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(168, 22);
            this.tbHinta.TabIndex = 18;
            // 
            // tbMokinnimi
            // 
            this.tbMokinnimi.Location = new System.Drawing.Point(122, 133);
            this.tbMokinnimi.Name = "tbMokinnimi";
            this.tbMokinnimi.Size = new System.Drawing.Size(168, 22);
            this.tbMokinnimi.TabIndex = 19;
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.Location = new System.Drawing.Point(122, 102);
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(168, 22);
            this.tbPostinumero.TabIndex = 20;
            // 
            // tbAlueId
            // 
            this.tbAlueId.Location = new System.Drawing.Point(122, 64);
            this.tbAlueId.Name = "tbAlueId";
            this.tbAlueId.Size = new System.Drawing.Size(168, 22);
            this.tbAlueId.TabIndex = 21;
            // 
            // dgvMokit
            // 
            this.dgvMokit.AutoGenerateColumns = false;
            this.dgvMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mokkiidDataGridViewTextBoxColumn,
            this.alueidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.mokkinimiDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.hintaDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.henkilomaaraDataGridViewTextBoxColumn,
            this.varusteluDataGridViewTextBoxColumn});
            this.dgvMokit.DataSource = this.mokkiBindingSource;
            this.dgvMokit.Location = new System.Drawing.Point(31, 259);
            this.dgvMokit.Name = "dgvMokit";
            this.dgvMokit.RowHeadersWidth = 51;
            this.dgvMokit.RowTemplate.Height = 24;
            this.dgvMokit.Size = new System.Drawing.Size(719, 170);
            this.dgvMokit.TabIndex = 22;
            // 
            // mokkiidDataGridViewTextBoxColumn
            // 
            this.mokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_id";
            this.mokkiidDataGridViewTextBoxColumn.HeaderText = "mokki_id";
            this.mokkiidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mokkiidDataGridViewTextBoxColumn.Name = "mokkiidDataGridViewTextBoxColumn";
            this.mokkiidDataGridViewTextBoxColumn.Width = 125;
            // 
            // alueidDataGridViewTextBoxColumn
            // 
            this.alueidDataGridViewTextBoxColumn.DataPropertyName = "alue_id";
            this.alueidDataGridViewTextBoxColumn.HeaderText = "alue_id";
            this.alueidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alueidDataGridViewTextBoxColumn.Name = "alueidDataGridViewTextBoxColumn";
            this.alueidDataGridViewTextBoxColumn.Width = 125;
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            this.postinroDataGridViewTextBoxColumn.Width = 125;
            // 
            // mokkinimiDataGridViewTextBoxColumn
            // 
            this.mokkinimiDataGridViewTextBoxColumn.DataPropertyName = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.HeaderText = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mokkinimiDataGridViewTextBoxColumn.Name = "mokkinimiDataGridViewTextBoxColumn";
            this.mokkinimiDataGridViewTextBoxColumn.Width = 125;
            // 
            // katuosoiteDataGridViewTextBoxColumn
            // 
            this.katuosoiteDataGridViewTextBoxColumn.DataPropertyName = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.HeaderText = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.katuosoiteDataGridViewTextBoxColumn.Name = "katuosoiteDataGridViewTextBoxColumn";
            this.katuosoiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // hintaDataGridViewTextBoxColumn
            // 
            this.hintaDataGridViewTextBoxColumn.DataPropertyName = "hinta";
            this.hintaDataGridViewTextBoxColumn.HeaderText = "hinta";
            this.hintaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hintaDataGridViewTextBoxColumn.Name = "hintaDataGridViewTextBoxColumn";
            this.hintaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            this.kuvausDataGridViewTextBoxColumn.Width = 125;
            // 
            // henkilomaaraDataGridViewTextBoxColumn
            // 
            this.henkilomaaraDataGridViewTextBoxColumn.DataPropertyName = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.HeaderText = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.henkilomaaraDataGridViewTextBoxColumn.Name = "henkilomaaraDataGridViewTextBoxColumn";
            this.henkilomaaraDataGridViewTextBoxColumn.Width = 125;
            // 
            // varusteluDataGridViewTextBoxColumn
            // 
            this.varusteluDataGridViewTextBoxColumn.DataPropertyName = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.HeaderText = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.varusteluDataGridViewTextBoxColumn.Name = "varusteluDataGridViewTextBoxColumn";
            this.varusteluDataGridViewTextBoxColumn.Width = 125;
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(31, 214);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(161, 39);
            this.btnLisaa.TabIndex = 23;
            this.btnLisaa.Text = "Lisää mökki";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(216, 214);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(161, 39);
            this.btnMuokkaa.TabIndex = 24;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(392, 214);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(161, 39);
            this.btnPoista.TabIndex = 25;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // dtpLoppu
            // 
            this.dtpLoppu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpLoppu.Location = new System.Drawing.Point(386, 445);
            this.dtpLoppu.Margin = new System.Windows.Forms.Padding(4);
            this.dtpLoppu.Name = "dtpLoppu";
            this.dtpLoppu.Size = new System.Drawing.Size(265, 22);
            this.dtpLoppu.TabIndex = 28;
            // 
            // lblViiva
            // 
            this.lblViiva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblViiva.AutoSize = true;
            this.lblViiva.Location = new System.Drawing.Point(364, 447);
            this.lblViiva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViiva.Name = "lblViiva";
            this.lblViiva.Size = new System.Drawing.Size(11, 16);
            this.lblViiva.TabIndex = 29;
            this.lblViiva.Text = "-";
            // 
            // dtpAlku
            // 
            this.dtpAlku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpAlku.Location = new System.Drawing.Point(90, 445);
            this.dtpAlku.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAlku.Name = "dtpAlku";
            this.dtpAlku.Size = new System.Drawing.Size(265, 22);
            this.dtpAlku.TabIndex = 26;
            // 
            // lblPaivat
            // 
            this.lblPaivat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPaivat.AutoSize = true;
            this.lblPaivat.Location = new System.Drawing.Point(27, 447);
            this.lblPaivat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaivat.Name = "lblPaivat";
            this.lblPaivat.Size = new System.Drawing.Size(51, 16);
            this.lblPaivat.TabIndex = 27;
            this.lblPaivat.Text = "Päiviltä";
            // 
            // btnHae
            // 
            this.btnHae.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHae.Location = new System.Drawing.Point(683, 441);
            this.btnHae.Margin = new System.Windows.Forms.Padding(4);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(67, 28);
            this.btnHae.TabIndex = 30;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // alueTableAdapter
            // 
            this.alueTableAdapter.ClearBeforeFill = true;
            // 
            // frmMokit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.btnHae);
            this.Controls.Add(this.dtpLoppu);
            this.Controls.Add(this.lblViiva);
            this.Controls.Add(this.dtpAlku);
            this.Controls.Add(this.lblPaivat);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnMuokkaa);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.dgvMokit);
            this.Controls.Add(this.tbAlueId);
            this.Controls.Add(this.tbPostinumero);
            this.Controls.Add(this.tbMokinnimi);
            this.Controls.Add(this.tbHinta);
            this.Controls.Add(this.tbKuvaus);
            this.Controls.Add(this.tbHenkilomaara);
            this.Controls.Add(this.tbVarustelu);
            this.Controls.Add(this.tbKatuosoite);
            this.Controls.Add(this.tbMokkiId);
            this.Controls.Add(this.lbVarustelu);
            this.Controls.Add(this.lbAlueId);
            this.Controls.Add(this.lbHenkilomaara);
            this.Controls.Add(this.lbKuvaus);
            this.Controls.Add(this.lbLahiosoite);
            this.Controls.Add(this.lbHinta);
            this.Controls.Add(this.lbNimi);
            this.Controls.Add(this.lbPostinumero);
            this.Controls.Add(this.lbMokkiId);
            this.Name = "frmMokit";
            this.Text = "Mokit";
            this.Load += new System.EventHandler(this.frmMokit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMokkiId;
        private System.Windows.Forms.Label lbPostinumero;
        private System.Windows.Forms.Label lbNimi;
        private System.Windows.Forms.Label lbHinta;
        private System.Windows.Forms.Label lbLahiosoite;
        private System.Windows.Forms.Label lbKuvaus;
        private System.Windows.Forms.Label lbHenkilomaara;
        private System.Windows.Forms.Label lbAlueId;
        private System.Windows.Forms.Label lbVarustelu;
        private System.Windows.Forms.TextBox tbMokkiId;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbVarustelu;
        private System.Windows.Forms.TextBox tbHenkilomaara;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbMokinnimi;
        private System.Windows.Forms.TextBox tbPostinumero;
        private System.Windows.Forms.TextBox tbAlueId;
        private System.Windows.Forms.DataGridView dgvMokit;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.DateTimePicker dtpLoppu;
        private System.Windows.Forms.Label lblViiva;
        private System.Windows.Forms.DateTimePicker dtpAlku;
        private System.Windows.Forms.Label lblPaivat;
        private System.Windows.Forms.Button btnHae;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private DataSet1TableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varusteluDataGridViewTextBoxColumn;
        private DataSet1TableAdapters.alueTableAdapter alueTableAdapter;
    }
}