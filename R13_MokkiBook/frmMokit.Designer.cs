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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMokit));
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
            this.mokki_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alue_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvaus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varustelu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new R13_MokkiBook.DataSet1();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.lblViiva = new System.Windows.Forms.Label();
            this.mokkiTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.mokkiTableAdapter();
            this.alueTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.alueTableAdapter();
            this.btnTyhjenna = new System.Windows.Forms.Button();
            this.tbHae = new System.Windows.Forms.TextBox();
            this.btnHae = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.toolTip1.SetToolTip(this.lbMokkiId, "Mökki id, yksilöllinen mökin tunniste numero");
            // 
            // lbPostinumero
            // 
            this.lbPostinumero.AutoSize = true;
            this.lbPostinumero.Location = new System.Drawing.Point(27, 102);
            this.lbPostinumero.Name = "lbPostinumero";
            this.lbPostinumero.Size = new System.Drawing.Size(82, 16);
            this.lbPostinumero.TabIndex = 1;
            this.lbPostinumero.Text = "Postinumero";
            // 
            // lbNimi
            // 
            this.lbNimi.AutoSize = true;
            this.lbNimi.Location = new System.Drawing.Point(27, 139);
            this.lbNimi.Name = "lbNimi";
            this.lbNimi.Size = new System.Drawing.Size(70, 16);
            this.lbNimi.TabIndex = 2;
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
            this.toolTip1.SetToolTip(this.lbHinta, "Käytä hinnassa pilkkua");
            // 
            // lbLahiosoite
            // 
            this.lbLahiosoite.AutoSize = true;
            this.lbLahiosoite.Location = new System.Drawing.Point(27, 177);
            this.lbLahiosoite.Name = "lbLahiosoite";
            this.lbLahiosoite.Size = new System.Drawing.Size(70, 16);
            this.lbLahiosoite.TabIndex = 3;
            this.lbLahiosoite.Text = "Katuosoite";
            // 
            // lbKuvaus
            // 
            this.lbKuvaus.AutoSize = true;
            this.lbKuvaus.Location = new System.Drawing.Point(361, 67);
            this.lbKuvaus.Name = "lbKuvaus";
            this.lbKuvaus.Size = new System.Drawing.Size(51, 16);
            this.lbKuvaus.TabIndex = 4;
            this.lbKuvaus.Text = "Kuvaus";
            // 
            // lbHenkilomaara
            // 
            this.lbHenkilomaara.AutoSize = true;
            this.lbHenkilomaara.Location = new System.Drawing.Point(361, 137);
            this.lbHenkilomaara.Name = "lbHenkilomaara";
            this.lbHenkilomaara.Size = new System.Drawing.Size(92, 16);
            this.lbHenkilomaara.TabIndex = 5;
            this.lbHenkilomaara.Text = "Henkilömäärä";
            // 
            // lbAlueId
            // 
            this.lbAlueId.AutoSize = true;
            this.lbAlueId.Location = new System.Drawing.Point(27, 67);
            this.lbAlueId.Name = "lbAlueId";
            this.lbAlueId.Size = new System.Drawing.Size(53, 16);
            this.lbAlueId.TabIndex = 0;
            this.lbAlueId.Text = "Alue ID:";
            this.toolTip1.SetToolTip(this.lbAlueId, "Alue id, yksilöllinen alueen tunniste numero");
            // 
            // lbVarustelu
            // 
            this.lbVarustelu.AutoSize = true;
            this.lbVarustelu.Location = new System.Drawing.Point(361, 174);
            this.lbVarustelu.Name = "lbVarustelu";
            this.lbVarustelu.Size = new System.Drawing.Size(63, 16);
            this.lbVarustelu.TabIndex = 6;
            this.lbVarustelu.Text = "Varustelu";
            // 
            // tbMokkiId
            // 
            this.tbMokkiId.Location = new System.Drawing.Point(122, 31);
            this.tbMokkiId.Name = "tbMokkiId";
            this.tbMokkiId.Size = new System.Drawing.Size(168, 22);
            this.tbMokkiId.TabIndex = 10;
            this.tbMokkiId.TextChanged += new System.EventHandler(this.tbMokkiId_TextChanged);
            this.tbMokkiId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMokkiId_KeyPress);
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Location = new System.Drawing.Point(122, 174);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(168, 22);
            this.tbKatuosoite.TabIndex = 3;
            this.tbKatuosoite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKatuosoite_KeyPress);
            this.tbKatuosoite.Leave += new System.EventHandler(this.tbKatuosoite_Leave);
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(464, 171);
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(168, 22);
            this.tbVarustelu.TabIndex = 6;
            this.tbVarustelu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVarustelu_KeyPress);
            // 
            // tbHenkilomaara
            // 
            this.tbHenkilomaara.Location = new System.Drawing.Point(464, 137);
            this.tbHenkilomaara.Name = "tbHenkilomaara";
            this.tbHenkilomaara.Size = new System.Drawing.Size(168, 22);
            this.tbHenkilomaara.TabIndex = 5;
            this.tbHenkilomaara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHenkilomaara_KeyPress);
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(464, 64);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(168, 54);
            this.tbKuvaus.TabIndex = 4;
            this.tbKuvaus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKuvaus_KeyPress);
            // 
            // tbHinta
            // 
            this.tbHinta.Location = new System.Drawing.Point(464, 31);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(168, 22);
            this.tbHinta.TabIndex = 18;
            this.tbHinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHinta_KeyPress);
            this.tbHinta.Leave += new System.EventHandler(this.tbHinta_Leave);
            // 
            // tbMokinnimi
            // 
            this.tbMokinnimi.Location = new System.Drawing.Point(122, 133);
            this.tbMokinnimi.Name = "tbMokinnimi";
            this.tbMokinnimi.Size = new System.Drawing.Size(168, 22);
            this.tbMokinnimi.TabIndex = 2;
            this.tbMokinnimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMokinnimi_KeyPress);
            this.tbMokinnimi.Leave += new System.EventHandler(this.tbMokinnimi_Leave);
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.Location = new System.Drawing.Point(122, 102);
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(168, 22);
            this.tbPostinumero.TabIndex = 1;
            this.tbPostinumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostinumero_KeyPress);
            // 
            // tbAlueId
            // 
            this.tbAlueId.Location = new System.Drawing.Point(122, 64);
            this.tbAlueId.Name = "tbAlueId";
            this.tbAlueId.Size = new System.Drawing.Size(168, 22);
            this.tbAlueId.TabIndex = 0;
            this.tbAlueId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlueId_KeyPress);
            // 
            // dgvMokit
            // 
            this.dgvMokit.AutoGenerateColumns = false;
            this.dgvMokit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mokki_id,
            this.alue_id,
            this.postinro,
            this.mokkinimi,
            this.katuosoite,
            this.hinta,
            this.kuvaus,
            this.henkilomaara,
            this.varustelu});
            this.dgvMokit.DataSource = this.mokkiBindingSource;
            this.dgvMokit.Location = new System.Drawing.Point(31, 278);
            this.dgvMokit.Name = "dgvMokit";
            this.dgvMokit.RowHeadersWidth = 51;
            this.dgvMokit.RowTemplate.Height = 24;
            this.dgvMokit.Size = new System.Drawing.Size(1470, 399);
            this.dgvMokit.TabIndex = 11;
            this.dgvMokit.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMokit_RowHeaderMouseDoubleClick);
            this.dgvMokit.SelectionChanged += new System.EventHandler(this.dgvMokit_SelectionChanged);
            // 
            // mokki_id
            // 
            this.mokki_id.DataPropertyName = "mokki_id";
            this.mokki_id.HeaderText = "mokki_id";
            this.mokki_id.MinimumWidth = 6;
            this.mokki_id.Name = "mokki_id";
            this.mokki_id.Width = 125;
            // 
            // alue_id
            // 
            this.alue_id.DataPropertyName = "alue_id";
            this.alue_id.HeaderText = "alue_id";
            this.alue_id.MinimumWidth = 6;
            this.alue_id.Name = "alue_id";
            this.alue_id.Width = 125;
            // 
            // postinro
            // 
            this.postinro.DataPropertyName = "postinro";
            this.postinro.HeaderText = "postinro";
            this.postinro.MinimumWidth = 6;
            this.postinro.Name = "postinro";
            this.postinro.Width = 125;
            // 
            // mokkinimi
            // 
            this.mokkinimi.DataPropertyName = "mokkinimi";
            this.mokkinimi.HeaderText = "mokkinimi";
            this.mokkinimi.MinimumWidth = 6;
            this.mokkinimi.Name = "mokkinimi";
            this.mokkinimi.Width = 125;
            // 
            // katuosoite
            // 
            this.katuosoite.DataPropertyName = "katuosoite";
            this.katuosoite.HeaderText = "katuosoite";
            this.katuosoite.MinimumWidth = 6;
            this.katuosoite.Name = "katuosoite";
            this.katuosoite.Width = 125;
            // 
            // hinta
            // 
            this.hinta.DataPropertyName = "hinta";
            this.hinta.HeaderText = "hinta";
            this.hinta.MinimumWidth = 6;
            this.hinta.Name = "hinta";
            this.hinta.Width = 125;
            // 
            // kuvaus
            // 
            this.kuvaus.DataPropertyName = "kuvaus";
            this.kuvaus.HeaderText = "kuvaus";
            this.kuvaus.MinimumWidth = 6;
            this.kuvaus.Name = "kuvaus";
            this.kuvaus.Width = 125;
            // 
            // henkilomaara
            // 
            this.henkilomaara.DataPropertyName = "henkilomaara";
            this.henkilomaara.HeaderText = "henkilomaara";
            this.henkilomaara.MinimumWidth = 6;
            this.henkilomaara.Name = "henkilomaara";
            this.henkilomaara.Width = 125;
            // 
            // varustelu
            // 
            this.varustelu.DataPropertyName = "varustelu";
            this.varustelu.HeaderText = "varustelu";
            this.varustelu.MinimumWidth = 6;
            this.varustelu.Name = "varustelu";
            this.varustelu.Width = 125;
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
            this.btnLisaa.TabIndex = 7;
            this.btnLisaa.Text = "Lisää mökki";
            this.toolTip1.SetToolTip(this.btnLisaa, "Lisää uuden mökin tietokantaan. Täytä ensiksi yläpuolella oleva lomake.");
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(214, 214);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(161, 39);
            this.btnMuokkaa.TabIndex = 8;
            this.btnMuokkaa.Text = "Tallenna muutos";
            this.toolTip1.SetToolTip(this.btnMuokkaa, resources.GetString("btnMuokkaa.ToolTip"));
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(409, 214);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(161, 39);
            this.btnPoista.TabIndex = 9;
            this.btnPoista.Text = "Poista";
            this.toolTip1.SetToolTip(this.btnPoista, "Poista mökin tiedot tietokannasta");
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // lblViiva
            // 
            this.lblViiva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblViiva.AutoSize = true;
            this.lblViiva.Location = new System.Drawing.Point(364, 680);
            this.lblViiva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViiva.Name = "lblViiva";
            this.lblViiva.Size = new System.Drawing.Size(11, 16);
            this.lblViiva.TabIndex = 29;
            this.lblViiva.Text = "-";
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // alueTableAdapter
            // 
            this.alueTableAdapter.ClearBeforeFill = true;
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.Location = new System.Drawing.Point(589, 214);
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.Size = new System.Drawing.Size(161, 39);
            this.btnTyhjenna.TabIndex = 10;
            this.btnTyhjenna.Text = "Tyhjennä rivit";
            this.toolTip1.SetToolTip(this.btnTyhjenna, "Tyhjentää lomakkeen rivit");
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.Click += new System.EventHandler(this.btnTyhjenna_Click);
            // 
            // tbHae
            // 
            this.tbHae.Location = new System.Drawing.Point(1190, 228);
            this.tbHae.Name = "tbHae";
            this.tbHae.Size = new System.Drawing.Size(237, 22);
            this.tbHae.TabIndex = 12;
            // 
            // btnHae
            // 
            this.btnHae.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHae.Location = new System.Drawing.Point(1434, 225);
            this.btnHae.Margin = new System.Windows.Forms.Padding(4);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(67, 28);
            this.btnHae.TabIndex = 13;
            this.btnHae.Text = "Hae";
            this.toolTip1.SetToolTip(this.btnHae, "Hae mökkiä id numerolla. Kirjoita numero viereiseen tekstikenttään.");
            this.btnHae.UseVisualStyleBackColor = true;
            this.btnHae.Click += new System.EventHandler(this.btnHae_Click);
            // 
            // frmMokit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1615, 758);
            this.Controls.Add(this.tbHae);
            this.Controls.Add(this.btnHae);
            this.Controls.Add(this.btnTyhjenna);
            this.Controls.Add(this.lblViiva);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label lblViiva;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private DataSet1TableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private DataSet1TableAdapters.alueTableAdapter alueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokki_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn alue_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinro;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoite;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinta;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvaus;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaara;
        private System.Windows.Forms.DataGridViewTextBoxColumn varustelu;
        private System.Windows.Forms.Button btnTyhjenna;
        private System.Windows.Forms.TextBox tbHae;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}