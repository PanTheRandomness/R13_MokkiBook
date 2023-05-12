using System.Data;

namespace R13_MokkiBook
{
    partial class frmUusiVaraus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUusiVaraus));
            this.pnlAsiakastiedot = new System.Windows.Forms.Panel();
            this.lblValitseasiakas = new System.Windows.Forms.Label();
            this.btnTyhjValinta = new System.Windows.Forms.Button();
            this.tbPostitoimipaikkaAsiakas = new System.Windows.Forms.TextBox();
            this.lblPostitoimipaikka = new System.Windows.Forms.Label();
            this.tbSahkoposti = new System.Windows.Forms.TextBox();
            this.tbPuhno = new System.Windows.Forms.TextBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.lblSp = new System.Windows.Forms.Label();
            this.lblPuhno = new System.Windows.Forms.Label();
            this.tbLahiosoiteAsiakas = new System.Windows.Forms.TextBox();
            this.lblLahiosoiteAsiakas = new System.Windows.Forms.Label();
            this.tbPostinoAsiakas = new System.Windows.Forms.TextBox();
            this.lblPostinoAsiakas = new System.Windows.Forms.Label();
            this.lblSnimi = new System.Windows.Forms.Label();
            this.tbSnimi = new System.Windows.Forms.TextBox();
            this.tbEnimi = new System.Windows.Forms.TextBox();
            this.lblEnimi = new System.Windows.Forms.Label();
            this.lblAsiakastunnus = new System.Windows.Forms.Label();
            this.dgvAsiakkaat = new System.Windows.Forms.DataGridView();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new R13_MokkiBook.DataSet1();
            this.tbAsiakastunnus = new System.Windows.Forms.TextBox();
            this.pnlVaraustiedot = new System.Windows.Forms.Panel();
            this.pnlMokki = new System.Windows.Forms.Panel();
            this.lblValitsemokki = new System.Windows.Forms.Label();
            this.tbnTyhjennaMokkihaku = new System.Windows.Forms.Button();
            this.btnNollaaAika = new System.Windows.Forms.Button();
            this.btnHaemokki = new System.Windows.Forms.Button();
            this.lblMaksimihinta = new System.Windows.Forms.Label();
            this.lblMinhinta = new System.Windows.Forms.Label();
            this.tbMaxhinta = new System.Windows.Forms.TextBox();
            this.tbMinhinta = new System.Windows.Forms.TextBox();
            this.lblHenkilomaara = new System.Windows.Forms.Label();
            this.nudHlomaara = new System.Windows.Forms.NumericUpDown();
            this.tbMokkitunnus = new System.Windows.Forms.TextBox();
            this.lblMokkitun = new System.Windows.Forms.Label();
            this.lblAjankohta = new System.Windows.Forms.Label();
            this.dtmLoppupvm = new System.Windows.Forms.DateTimePicker();
            this.dtpAlkupvm = new System.Windows.Forms.DateTimePicker();
            this.lbAlueid = new System.Windows.Forms.Label();
            this.lbAlue = new System.Windows.Forms.ListBox();
            this.alueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbAlueid = new System.Windows.Forms.TextBox();
            this.cbLukitseMokki = new System.Windows.Forms.CheckBox();
            this.btnLuoVaraus = new System.Windows.Forms.Button();
            this.lblLoppuhinta = new System.Windows.Forms.Label();
            this.tbLoppuhinta = new System.Windows.Forms.TextBox();
            this.pnlPalvelut = new System.Windows.Forms.Panel();
            this.lblValitsePalvelut = new System.Windows.Forms.Label();
            this.btnPoistaPalvelu = new System.Windows.Forms.Button();
            this.dgvAlueenPalvelut = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alueidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblPalvelujenMaara = new System.Windows.Forms.Label();
            this.nudPalveluLkm = new System.Windows.Forms.NumericUpDown();
            this.btnLisaaPalveluVaraukseen = new System.Windows.Forms.Button();
            this.lbVarauksenPalvelut = new System.Windows.Forms.ListBox();
            this.dgvMokitUusiVaraus = new System.Windows.Forms.DataGridView();
            this.mokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varusteluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.epUusiVaraus = new System.Windows.Forms.ErrorProvider(this.components);
            this.asiakasTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.asiakasTableAdapter();
            this.alueTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.alueTableAdapter();
            this.postiTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.postiTableAdapter();
            this.mokkiTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.mokkiTableAdapter();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varausTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.varausTableAdapter();
            this.ttUusiVaraus = new System.Windows.Forms.ToolTip(this.components);
            this.palveluTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.palveluTableAdapter();
            this.pnlAsiakastiedot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.pnlVaraustiedot.SuspendLayout();
            this.pnlMokki.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHlomaara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            this.pnlPalvelut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlueenPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPalveluLkm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokitUusiVaraus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUusiVaraus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAsiakastiedot
            // 
            this.pnlAsiakastiedot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAsiakastiedot.Controls.Add(this.lblValitseasiakas);
            this.pnlAsiakastiedot.Controls.Add(this.btnTyhjValinta);
            this.pnlAsiakastiedot.Controls.Add(this.tbPostitoimipaikkaAsiakas);
            this.pnlAsiakastiedot.Controls.Add(this.lblPostitoimipaikka);
            this.pnlAsiakastiedot.Controls.Add(this.tbSahkoposti);
            this.pnlAsiakastiedot.Controls.Add(this.tbPuhno);
            this.pnlAsiakastiedot.Controls.Add(this.btnLisaa);
            this.pnlAsiakastiedot.Controls.Add(this.lblSp);
            this.pnlAsiakastiedot.Controls.Add(this.lblPuhno);
            this.pnlAsiakastiedot.Controls.Add(this.tbLahiosoiteAsiakas);
            this.pnlAsiakastiedot.Controls.Add(this.lblLahiosoiteAsiakas);
            this.pnlAsiakastiedot.Controls.Add(this.tbPostinoAsiakas);
            this.pnlAsiakastiedot.Controls.Add(this.lblPostinoAsiakas);
            this.pnlAsiakastiedot.Controls.Add(this.lblSnimi);
            this.pnlAsiakastiedot.Controls.Add(this.tbSnimi);
            this.pnlAsiakastiedot.Controls.Add(this.tbEnimi);
            this.pnlAsiakastiedot.Controls.Add(this.lblEnimi);
            this.pnlAsiakastiedot.Controls.Add(this.lblAsiakastunnus);
            this.pnlAsiakastiedot.Controls.Add(this.dgvAsiakkaat);
            this.pnlAsiakastiedot.Controls.Add(this.tbAsiakastunnus);
            this.pnlAsiakastiedot.Location = new System.Drawing.Point(2, 2);
            this.pnlAsiakastiedot.Name = "pnlAsiakastiedot";
            this.pnlAsiakastiedot.Size = new System.Drawing.Size(1068, 268);
            this.pnlAsiakastiedot.TabIndex = 0;
            // 
            // lblValitseasiakas
            // 
            this.lblValitseasiakas.AutoSize = true;
            this.lblValitseasiakas.Location = new System.Drawing.Point(11, 16);
            this.lblValitseasiakas.Name = "lblValitseasiakas";
            this.lblValitseasiakas.Size = new System.Drawing.Size(92, 13);
            this.lblValitseasiakas.TabIndex = 0;
            this.lblValitseasiakas.Text = "1. Valitse asiakas:";
            // 
            // btnTyhjValinta
            // 
            this.btnTyhjValinta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTyhjValinta.Location = new System.Drawing.Point(332, 140);
            this.btnTyhjValinta.Name = "btnTyhjValinta";
            this.btnTyhjValinta.Size = new System.Drawing.Size(102, 23);
            this.btnTyhjValinta.TabIndex = 7;
            this.btnTyhjValinta.Text = "Tyhjennä valinta";
            this.ttUusiVaraus.SetToolTip(this.btnTyhjValinta, "Peru asiakkaan valinta; Tyhjentää tekstikentät");
            this.btnTyhjValinta.UseVisualStyleBackColor = true;
            this.btnTyhjValinta.Click += new System.EventHandler(this.btnTyhjValinta_Click);
            // 
            // tbPostitoimipaikkaAsiakas
            // 
            this.tbPostitoimipaikkaAsiakas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPostitoimipaikkaAsiakas.Location = new System.Drawing.Point(99, 134);
            this.tbPostitoimipaikkaAsiakas.Name = "tbPostitoimipaikkaAsiakas";
            this.tbPostitoimipaikkaAsiakas.Size = new System.Drawing.Size(144, 20);
            this.tbPostitoimipaikkaAsiakas.TabIndex = 4;
            this.tbPostitoimipaikkaAsiakas.Tag = "";
            this.ttUusiVaraus.SetToolTip(this.tbPostitoimipaikkaAsiakas, "Syötä asiakkaan postitoimipaikka");
            this.tbPostitoimipaikkaAsiakas.Leave += new System.EventHandler(this.tbEnimi_Leave);
            // 
            // lblPostitoimipaikka
            // 
            this.lblPostitoimipaikka.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPostitoimipaikka.AutoSize = true;
            this.lblPostitoimipaikka.Location = new System.Drawing.Point(10, 137);
            this.lblPostitoimipaikka.Name = "lblPostitoimipaikka";
            this.lblPostitoimipaikka.Size = new System.Drawing.Size(83, 13);
            this.lblPostitoimipaikka.TabIndex = 4;
            this.lblPostitoimipaikka.Text = "Postitoimipaikka";
            // 
            // tbSahkoposti
            // 
            this.tbSahkoposti.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbSahkoposti.Location = new System.Drawing.Point(93, 186);
            this.tbSahkoposti.Name = "tbSahkoposti";
            this.tbSahkoposti.Size = new System.Drawing.Size(150, 20);
            this.tbSahkoposti.TabIndex = 6;
            this.tbSahkoposti.Tag = "";
            this.ttUusiVaraus.SetToolTip(this.tbSahkoposti, "Syötä asiakkaan sähköpostiosoite");
            this.tbSahkoposti.TextChanged += new System.EventHandler(this.tbSahkoposti_TextChanged);
            // 
            // tbPuhno
            // 
            this.tbPuhno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPuhno.Location = new System.Drawing.Point(93, 160);
            this.tbPuhno.Name = "tbPuhno";
            this.tbPuhno.Size = new System.Drawing.Size(150, 20);
            this.tbPuhno.TabIndex = 5;
            this.tbPuhno.Tag = "";
            this.ttUusiVaraus.SetToolTip(this.tbPuhno, "Syötä asiakkaan puhelinnumero");
            this.tbPuhno.TextChanged += new System.EventHandler(this.tbPuhno_TextChanged);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLisaa.Location = new System.Drawing.Point(332, 231);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(102, 23);
            this.btnLisaa.TabIndex = 8;
            this.btnLisaa.Text = "Lisää asiakas";
            this.ttUusiVaraus.SetToolTip(this.btnLisaa, "Lisää asiakkaan tietokantaan");
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // lblSp
            // 
            this.lblSp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSp.AutoSize = true;
            this.lblSp.Location = new System.Drawing.Point(10, 189);
            this.lblSp.Name = "lblSp";
            this.lblSp.Size = new System.Drawing.Size(60, 13);
            this.lblSp.TabIndex = 6;
            this.lblSp.Text = "Sähköposti";
            // 
            // lblPuhno
            // 
            this.lblPuhno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPuhno.AutoSize = true;
            this.lblPuhno.Location = new System.Drawing.Point(10, 163);
            this.lblPuhno.Name = "lblPuhno";
            this.lblPuhno.Size = new System.Drawing.Size(77, 13);
            this.lblPuhno.TabIndex = 5;
            this.lblPuhno.Text = "Puhelinnumero";
            // 
            // tbLahiosoiteAsiakas
            // 
            this.tbLahiosoiteAsiakas.Location = new System.Drawing.Point(249, 68);
            this.tbLahiosoiteAsiakas.Name = "tbLahiosoiteAsiakas";
            this.tbLahiosoiteAsiakas.Size = new System.Drawing.Size(185, 20);
            this.tbLahiosoiteAsiakas.TabIndex = 3;
            this.tbLahiosoiteAsiakas.Tag = "";
            this.ttUusiVaraus.SetToolTip(this.tbLahiosoiteAsiakas, "Syötä asiakkaan lähiosoite");
            this.tbLahiosoiteAsiakas.TextChanged += new System.EventHandler(this.tbLahiosoiteAsiakas_TextChanged);
            // 
            // lblLahiosoiteAsiakas
            // 
            this.lblLahiosoiteAsiakas.AutoSize = true;
            this.lblLahiosoiteAsiakas.Location = new System.Drawing.Point(188, 71);
            this.lblLahiosoiteAsiakas.Name = "lblLahiosoiteAsiakas";
            this.lblLahiosoiteAsiakas.Size = new System.Drawing.Size(55, 13);
            this.lblLahiosoiteAsiakas.TabIndex = 3;
            this.lblLahiosoiteAsiakas.Text = "Lähiosoite";
            // 
            // tbPostinoAsiakas
            // 
            this.tbPostinoAsiakas.Location = new System.Drawing.Point(81, 68);
            this.tbPostinoAsiakas.Name = "tbPostinoAsiakas";
            this.tbPostinoAsiakas.Size = new System.Drawing.Size(101, 20);
            this.tbPostinoAsiakas.TabIndex = 2;
            this.tbPostinoAsiakas.Tag = "";
            this.ttUusiVaraus.SetToolTip(this.tbPostinoAsiakas, "Syötä asiakkaan postinumero");
            this.tbPostinoAsiakas.TextChanged += new System.EventHandler(this.tbPostinoAsiakas_TextChanged);
            this.tbPostinoAsiakas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostinoAsiakas_KeyPress);
            // 
            // lblPostinoAsiakas
            // 
            this.lblPostinoAsiakas.AutoSize = true;
            this.lblPostinoAsiakas.Location = new System.Drawing.Point(10, 71);
            this.lblPostinoAsiakas.Name = "lblPostinoAsiakas";
            this.lblPostinoAsiakas.Size = new System.Drawing.Size(65, 13);
            this.lblPostinoAsiakas.TabIndex = 2;
            this.lblPostinoAsiakas.Text = "Postinumero";
            // 
            // lblSnimi
            // 
            this.lblSnimi.AutoSize = true;
            this.lblSnimi.Location = new System.Drawing.Point(193, 45);
            this.lblSnimi.Name = "lblSnimi";
            this.lblSnimi.Size = new System.Drawing.Size(50, 13);
            this.lblSnimi.TabIndex = 1;
            this.lblSnimi.Text = "Sukunimi";
            // 
            // tbSnimi
            // 
            this.tbSnimi.Location = new System.Drawing.Point(249, 42);
            this.tbSnimi.Name = "tbSnimi";
            this.tbSnimi.Size = new System.Drawing.Size(185, 20);
            this.tbSnimi.TabIndex = 1;
            this.tbSnimi.Tag = "";
            this.ttUusiVaraus.SetToolTip(this.tbSnimi, "Syötä asiakkaan sukunimi");
            this.tbSnimi.TextChanged += new System.EventHandler(this.tbSnimi_TextChanged);
            this.tbSnimi.Leave += new System.EventHandler(this.tbEnimi_Leave);
            // 
            // tbEnimi
            // 
            this.tbEnimi.Location = new System.Drawing.Point(57, 42);
            this.tbEnimi.Name = "tbEnimi";
            this.tbEnimi.Size = new System.Drawing.Size(125, 20);
            this.tbEnimi.TabIndex = 0;
            this.tbEnimi.Tag = "";
            this.ttUusiVaraus.SetToolTip(this.tbEnimi, "Syötä asiakkaan etunimi");
            this.tbEnimi.TextChanged += new System.EventHandler(this.tbEnimi_TextChanged);
            this.tbEnimi.Leave += new System.EventHandler(this.tbEnimi_Leave);
            // 
            // lblEnimi
            // 
            this.lblEnimi.AutoSize = true;
            this.lblEnimi.Location = new System.Drawing.Point(10, 45);
            this.lblEnimi.Name = "lblEnimi";
            this.lblEnimi.Size = new System.Drawing.Size(41, 13);
            this.lblEnimi.TabIndex = 0;
            this.lblEnimi.Text = "Etunimi";
            // 
            // lblAsiakastunnus
            // 
            this.lblAsiakastunnus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAsiakastunnus.AutoSize = true;
            this.lblAsiakastunnus.Location = new System.Drawing.Point(11, 237);
            this.lblAsiakastunnus.Name = "lblAsiakastunnus";
            this.lblAsiakastunnus.Size = new System.Drawing.Size(76, 13);
            this.lblAsiakastunnus.TabIndex = 9;
            this.lblAsiakastunnus.Text = "Asiakastunnus";
            // 
            // dgvAsiakkaat
            // 
            this.dgvAsiakkaat.AllowUserToDeleteRows = false;
            this.dgvAsiakkaat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsiakkaat.AutoGenerateColumns = false;
            this.dgvAsiakkaat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakkaat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiakasidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn,
            this.etunimiDataGridViewTextBoxColumn,
            this.sukunimiDataGridViewTextBoxColumn,
            this.lahiosoiteDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.puhelinnroDataGridViewTextBoxColumn});
            this.dgvAsiakkaat.DataSource = this.asiakasBindingSource;
            this.dgvAsiakkaat.Location = new System.Drawing.Point(455, 0);
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.Size = new System.Drawing.Size(607, 264);
            this.dgvAsiakkaat.TabIndex = 10;
            this.dgvAsiakkaat.TabStop = false;
            this.dgvAsiakkaat.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAsiakkaat_RowHeaderMouseClick);
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "Asiakastunnus";
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "Postinumero";
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            // 
            // etunimiDataGridViewTextBoxColumn
            // 
            this.etunimiDataGridViewTextBoxColumn.DataPropertyName = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.HeaderText = "Etunimi";
            this.etunimiDataGridViewTextBoxColumn.Name = "etunimiDataGridViewTextBoxColumn";
            // 
            // sukunimiDataGridViewTextBoxColumn
            // 
            this.sukunimiDataGridViewTextBoxColumn.DataPropertyName = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.HeaderText = "Sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.Name = "sukunimiDataGridViewTextBoxColumn";
            // 
            // lahiosoiteDataGridViewTextBoxColumn
            // 
            this.lahiosoiteDataGridViewTextBoxColumn.DataPropertyName = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.HeaderText = "Lähiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.Name = "lahiosoiteDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Sähköpostiosoite";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // puhelinnroDataGridViewTextBoxColumn
            // 
            this.puhelinnroDataGridViewTextBoxColumn.DataPropertyName = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.HeaderText = "Puhelinnumero";
            this.puhelinnroDataGridViewTextBoxColumn.Name = "puhelinnroDataGridViewTextBoxColumn";
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbAsiakastunnus
            // 
            this.tbAsiakastunnus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAsiakastunnus.Location = new System.Drawing.Point(93, 234);
            this.tbAsiakastunnus.Name = "tbAsiakastunnus";
            this.tbAsiakastunnus.Size = new System.Drawing.Size(151, 20);
            this.tbAsiakastunnus.TabIndex = 9;
            this.ttUusiVaraus.SetToolTip(this.tbAsiakastunnus, "Syötä asiakkaan asiakastunnus");
            this.tbAsiakastunnus.TextChanged += new System.EventHandler(this.tbAsiakastunnus_TextChanged);
            this.tbAsiakastunnus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostinoAsiakas_KeyPress);
            // 
            // pnlVaraustiedot
            // 
            this.pnlVaraustiedot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVaraustiedot.Controls.Add(this.pnlMokki);
            this.pnlVaraustiedot.Controls.Add(this.cbLukitseMokki);
            this.pnlVaraustiedot.Controls.Add(this.btnLuoVaraus);
            this.pnlVaraustiedot.Controls.Add(this.lblLoppuhinta);
            this.pnlVaraustiedot.Controls.Add(this.tbLoppuhinta);
            this.pnlVaraustiedot.Controls.Add(this.pnlPalvelut);
            this.pnlVaraustiedot.Controls.Add(this.dgvMokitUusiVaraus);
            this.pnlVaraustiedot.Location = new System.Drawing.Point(2, 275);
            this.pnlVaraustiedot.Name = "pnlVaraustiedot";
            this.pnlVaraustiedot.Size = new System.Drawing.Size(1068, 437);
            this.pnlVaraustiedot.TabIndex = 9;
            // 
            // pnlMokki
            // 
            this.pnlMokki.Controls.Add(this.lblValitsemokki);
            this.pnlMokki.Controls.Add(this.tbnTyhjennaMokkihaku);
            this.pnlMokki.Controls.Add(this.btnNollaaAika);
            this.pnlMokki.Controls.Add(this.btnHaemokki);
            this.pnlMokki.Controls.Add(this.lblMaksimihinta);
            this.pnlMokki.Controls.Add(this.lblMinhinta);
            this.pnlMokki.Controls.Add(this.tbMaxhinta);
            this.pnlMokki.Controls.Add(this.tbMinhinta);
            this.pnlMokki.Controls.Add(this.lblHenkilomaara);
            this.pnlMokki.Controls.Add(this.nudHlomaara);
            this.pnlMokki.Controls.Add(this.tbMokkitunnus);
            this.pnlMokki.Controls.Add(this.lblMokkitun);
            this.pnlMokki.Controls.Add(this.lblAjankohta);
            this.pnlMokki.Controls.Add(this.dtmLoppupvm);
            this.pnlMokki.Controls.Add(this.dtpAlkupvm);
            this.pnlMokki.Controls.Add(this.lbAlueid);
            this.pnlMokki.Controls.Add(this.lbAlue);
            this.pnlMokki.Controls.Add(this.tbAlueid);
            this.pnlMokki.Location = new System.Drawing.Point(4, 3);
            this.pnlMokki.Name = "pnlMokki";
            this.pnlMokki.Size = new System.Drawing.Size(508, 258);
            this.pnlMokki.TabIndex = 10;
            // 
            // lblValitsemokki
            // 
            this.lblValitsemokki.AutoSize = true;
            this.lblValitsemokki.Location = new System.Drawing.Point(7, 26);
            this.lblValitsemokki.Name = "lblValitsemokki";
            this.lblValitsemokki.Size = new System.Drawing.Size(84, 13);
            this.lblValitsemokki.TabIndex = 9;
            this.lblValitsemokki.Text = "2. Valitse mökki:";
            // 
            // tbnTyhjennaMokkihaku
            // 
            this.tbnTyhjennaMokkihaku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbnTyhjennaMokkihaku.Location = new System.Drawing.Point(318, 226);
            this.tbnTyhjennaMokkihaku.Name = "tbnTyhjennaMokkihaku";
            this.tbnTyhjennaMokkihaku.Size = new System.Drawing.Size(100, 23);
            this.tbnTyhjennaMokkihaku.TabIndex = 18;
            this.tbnTyhjennaMokkihaku.Text = "Tyhjennä mökki";
            this.ttUusiVaraus.SetToolTip(this.tbnTyhjennaMokkihaku, "Tyhjentää mökkiin liittyvät hakukriteerit sekä valitun mökin");
            this.tbnTyhjennaMokkihaku.UseVisualStyleBackColor = true;
            this.tbnTyhjennaMokkihaku.Click += new System.EventHandler(this.tbnTyhjennaMokkihaku_Click);
            // 
            // btnNollaaAika
            // 
            this.btnNollaaAika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNollaaAika.Location = new System.Drawing.Point(14, 81);
            this.btnNollaaAika.Name = "btnNollaaAika";
            this.btnNollaaAika.Size = new System.Drawing.Size(61, 23);
            this.btnNollaaAika.TabIndex = 11;
            this.btnNollaaAika.Text = "Nollaa";
            this.ttUusiVaraus.SetToolTip(this.btnNollaaAika, "Palauttaa oletuspäivämäärän");
            this.btnNollaaAika.UseVisualStyleBackColor = true;
            this.btnNollaaAika.Click += new System.EventHandler(this.btnNollaaAika_Click);
            // 
            // btnHaemokki
            // 
            this.btnHaemokki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHaemokki.Location = new System.Drawing.Point(424, 226);
            this.btnHaemokki.Name = "btnHaemokki";
            this.btnHaemokki.Size = new System.Drawing.Size(75, 23);
            this.btnHaemokki.TabIndex = 19;
            this.btnHaemokki.Text = "Hae mökkiä";
            this.ttUusiVaraus.SetToolTip(this.btnHaemokki, "Hae mökkiä annetuilla kriteereillä");
            this.btnHaemokki.UseVisualStyleBackColor = true;
            this.btnHaemokki.Click += new System.EventHandler(this.btnHaemokki_Click);
            // 
            // lblMaksimihinta
            // 
            this.lblMaksimihinta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMaksimihinta.AutoSize = true;
            this.lblMaksimihinta.Location = new System.Drawing.Point(301, 176);
            this.lblMaksimihinta.Name = "lblMaksimihinta";
            this.lblMaksimihinta.Size = new System.Drawing.Size(83, 13);
            this.lblMaksimihinta.TabIndex = 16;
            this.lblMaksimihinta.Text = "Maksimihinta (€)";
            // 
            // lblMinhinta
            // 
            this.lblMinhinta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMinhinta.AutoSize = true;
            this.lblMinhinta.Location = new System.Drawing.Point(301, 150);
            this.lblMinhinta.Name = "lblMinhinta";
            this.lblMinhinta.Size = new System.Drawing.Size(74, 13);
            this.lblMinhinta.TabIndex = 15;
            this.lblMinhinta.Text = "Minimihinta (€)";
            // 
            // tbMaxhinta
            // 
            this.tbMaxhinta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMaxhinta.Location = new System.Drawing.Point(399, 173);
            this.tbMaxhinta.Name = "tbMaxhinta";
            this.tbMaxhinta.Size = new System.Drawing.Size(100, 20);
            this.tbMaxhinta.TabIndex = 16;
            this.tbMaxhinta.Text = "0";
            this.ttUusiVaraus.SetToolTip(this.tbMaxhinta, "Syötä maksimihinta mökille");
            this.tbMaxhinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinhinta_KeyPress);
            this.tbMaxhinta.Leave += new System.EventHandler(this.tbMaxhinta_Leave);
            // 
            // tbMinhinta
            // 
            this.tbMinhinta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMinhinta.Location = new System.Drawing.Point(399, 147);
            this.tbMinhinta.Name = "tbMinhinta";
            this.tbMinhinta.Size = new System.Drawing.Size(100, 20);
            this.tbMinhinta.TabIndex = 15;
            this.tbMinhinta.Text = "0";
            this.ttUusiVaraus.SetToolTip(this.tbMinhinta, "Syötä minimihinta mökille");
            this.tbMinhinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinhinta_KeyPress);
            this.tbMinhinta.Leave += new System.EventHandler(this.tbMinhinta_Leave);
            // 
            // lblHenkilomaara
            // 
            this.lblHenkilomaara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHenkilomaara.AutoSize = true;
            this.lblHenkilomaara.Location = new System.Drawing.Point(315, 65);
            this.lblHenkilomaara.Name = "lblHenkilomaara";
            this.lblHenkilomaara.Size = new System.Drawing.Size(72, 13);
            this.lblHenkilomaara.TabIndex = 12;
            this.lblHenkilomaara.Text = "Henkilömäärä";
            // 
            // nudHlomaara
            // 
            this.nudHlomaara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudHlomaara.Location = new System.Drawing.Point(399, 62);
            this.nudHlomaara.Name = "nudHlomaara";
            this.nudHlomaara.Size = new System.Drawing.Size(99, 20);
            this.nudHlomaara.TabIndex = 12;
            this.ttUusiVaraus.SetToolTip(this.nudHlomaara, "Valitse majoitettavien henkilöiden määrä");
            this.nudHlomaara.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHlomaara.ValueChanged += new System.EventHandler(this.nudHlomaara_ValueChanged);
            this.nudHlomaara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostinoAsiakas_KeyPress);
            // 
            // tbMokkitunnus
            // 
            this.tbMokkitunnus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMokkitunnus.Location = new System.Drawing.Point(85, 233);
            this.tbMokkitunnus.Name = "tbMokkitunnus";
            this.tbMokkitunnus.Size = new System.Drawing.Size(182, 20);
            this.tbMokkitunnus.TabIndex = 17;
            this.ttUusiVaraus.SetToolTip(this.tbMokkitunnus, "Syötä halutun mökin mökkitunnus. HUOM: Jätä tyhjäksi, jos haluat hakea muilla kri" +
        "teereillä!");
            this.tbMokkitunnus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostinoAsiakas_KeyPress);
            // 
            // lblMokkitun
            // 
            this.lblMokkitun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMokkitun.AutoSize = true;
            this.lblMokkitun.Location = new System.Drawing.Point(11, 236);
            this.lblMokkitun.Name = "lblMokkitun";
            this.lblMokkitun.Size = new System.Drawing.Size(68, 13);
            this.lblMokkitun.TabIndex = 17;
            this.lblMokkitun.Text = "Mökkitunnus";
            // 
            // lblAjankohta
            // 
            this.lblAjankohta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAjankohta.AutoSize = true;
            this.lblAjankohta.Location = new System.Drawing.Point(13, 64);
            this.lblAjankohta.Name = "lblAjankohta";
            this.lblAjankohta.Size = new System.Drawing.Size(55, 13);
            this.lblAjankohta.TabIndex = 9;
            this.lblAjankohta.Text = "Ajankohta";
            // 
            // dtmLoppupvm
            // 
            this.dtmLoppupvm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtmLoppupvm.Location = new System.Drawing.Point(95, 84);
            this.dtmLoppupvm.Name = "dtmLoppupvm";
            this.dtmLoppupvm.Size = new System.Drawing.Size(200, 20);
            this.dtmLoppupvm.TabIndex = 10;
            this.ttUusiVaraus.SetToolTip(this.dtmLoppupvm, "Valitse varauksen päättymispäivämäärä");
            this.dtmLoppupvm.ValueChanged += new System.EventHandler(this.dtmLoppupvm_ValueChanged);
            // 
            // dtpAlkupvm
            // 
            this.dtpAlkupvm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpAlkupvm.Location = new System.Drawing.Point(95, 58);
            this.dtpAlkupvm.Name = "dtpAlkupvm";
            this.dtpAlkupvm.Size = new System.Drawing.Size(200, 20);
            this.dtpAlkupvm.TabIndex = 9;
            this.ttUusiVaraus.SetToolTip(this.dtpAlkupvm, "Valitse varauksen alkupäivämäärä");
            this.dtpAlkupvm.ValueChanged += new System.EventHandler(this.dtpAlkupvm_ValueChanged);
            // 
            // lbAlueid
            // 
            this.lbAlueid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbAlueid.AutoSize = true;
            this.lbAlueid.Location = new System.Drawing.Point(13, 154);
            this.lbAlueid.Name = "lbAlueid";
            this.lbAlueid.Size = new System.Drawing.Size(60, 13);
            this.lbAlueid.TabIndex = 13;
            this.lbAlueid.Text = "Aluetunnus";
            // 
            // lbAlue
            // 
            this.lbAlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbAlue.DataSource = this.alueBindingSource;
            this.lbAlue.DisplayMember = "nimi";
            this.lbAlue.FormattingEnabled = true;
            this.lbAlue.Location = new System.Drawing.Point(133, 137);
            this.lbAlue.Name = "lbAlue";
            this.lbAlue.Size = new System.Drawing.Size(162, 56);
            this.lbAlue.TabIndex = 14;
            this.ttUusiVaraus.SetToolTip(this.lbAlue, "Valitse haluttu alue");
            this.lbAlue.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbAlue_MouseDoubleClick);
            // 
            // alueBindingSource
            // 
            this.alueBindingSource.DataMember = "alue";
            this.alueBindingSource.DataSource = this.dataSet1;
            // 
            // tbAlueid
            // 
            this.tbAlueid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbAlueid.Location = new System.Drawing.Point(16, 170);
            this.tbAlueid.Name = "tbAlueid";
            this.tbAlueid.Size = new System.Drawing.Size(111, 20);
            this.tbAlueid.TabIndex = 13;
            this.ttUusiVaraus.SetToolTip(this.tbAlueid, "Syötä halutun alueen tunnus");
            this.tbAlueid.TextChanged += new System.EventHandler(this.tbAlueid_TextChanged);
            this.tbAlueid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostinoAsiakas_KeyPress);
            // 
            // cbLukitseMokki
            // 
            this.cbLukitseMokki.AutoSize = true;
            this.cbLukitseMokki.Location = new System.Drawing.Point(167, 269);
            this.cbLukitseMokki.Name = "cbLukitseMokki";
            this.cbLukitseMokki.Size = new System.Drawing.Size(103, 17);
            this.cbLukitseMokki.TabIndex = 21;
            this.cbLukitseMokki.Text = "3. Lukitse mökki";
            this.ttUusiVaraus.SetToolTip(this.cbLukitseMokki, "Lukitse mökin valinta muokataksesi varauksen palveluja");
            this.cbLukitseMokki.UseVisualStyleBackColor = true;
            this.cbLukitseMokki.CheckedChanged += new System.EventHandler(this.cbLukitseMokki_CheckedChanged);
            // 
            // btnLuoVaraus
            // 
            this.btnLuoVaraus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuoVaraus.Location = new System.Drawing.Point(928, 265);
            this.btnLuoVaraus.Name = "btnLuoVaraus";
            this.btnLuoVaraus.Size = new System.Drawing.Size(133, 23);
            this.btnLuoVaraus.TabIndex = 28;
            this.btnLuoVaraus.Text = "Luo varaus";
            this.ttUusiVaraus.SetToolTip(this.btnLuoVaraus, "Luo varauksen");
            this.btnLuoVaraus.UseVisualStyleBackColor = true;
            this.btnLuoVaraus.Click += new System.EventHandler(this.btnLuoVaraus_Click);
            // 
            // lblLoppuhinta
            // 
            this.lblLoppuhinta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoppuhinta.AutoSize = true;
            this.lblLoppuhinta.Location = new System.Drawing.Point(741, 270);
            this.lblLoppuhinta.Name = "lblLoppuhinta";
            this.lblLoppuhinta.Size = new System.Drawing.Size(75, 13);
            this.lblLoppuhinta.TabIndex = 27;
            this.lblLoppuhinta.Text = "Loppuhinta (€)";
            // 
            // tbLoppuhinta
            // 
            this.tbLoppuhinta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLoppuhinta.Location = new System.Drawing.Point(822, 267);
            this.tbLoppuhinta.Name = "tbLoppuhinta";
            this.tbLoppuhinta.Size = new System.Drawing.Size(100, 20);
            this.tbLoppuhinta.TabIndex = 27;
            this.tbLoppuhinta.Text = "0";
            this.ttUusiVaraus.SetToolTip(this.tbLoppuhinta, "Näyttää arvioidun loppuhinnan");
            this.tbLoppuhinta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLoppuhinta_KeyPress);
            // 
            // pnlPalvelut
            // 
            this.pnlPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPalvelut.Controls.Add(this.lblValitsePalvelut);
            this.pnlPalvelut.Controls.Add(this.btnPoistaPalvelu);
            this.pnlPalvelut.Controls.Add(this.dgvAlueenPalvelut);
            this.pnlPalvelut.Controls.Add(this.lblPalvelujenMaara);
            this.pnlPalvelut.Controls.Add(this.nudPalveluLkm);
            this.pnlPalvelut.Controls.Add(this.btnLisaaPalveluVaraukseen);
            this.pnlPalvelut.Controls.Add(this.lbVarauksenPalvelut);
            this.pnlPalvelut.Enabled = false;
            this.pnlPalvelut.Location = new System.Drawing.Point(517, 3);
            this.pnlPalvelut.Name = "pnlPalvelut";
            this.pnlPalvelut.Size = new System.Drawing.Size(547, 258);
            this.pnlPalvelut.TabIndex = 24;
            // 
            // lblValitsePalvelut
            // 
            this.lblValitsePalvelut.AutoSize = true;
            this.lblValitsePalvelut.Location = new System.Drawing.Point(3, 10);
            this.lblValitsePalvelut.Name = "lblValitsePalvelut";
            this.lblValitsePalvelut.Size = new System.Drawing.Size(93, 13);
            this.lblValitsePalvelut.TabIndex = 22;
            this.lblValitsePalvelut.Text = "4. Valitse palvelut:";
            // 
            // btnPoistaPalvelu
            // 
            this.btnPoistaPalvelu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPoistaPalvelu.Enabled = false;
            this.btnPoistaPalvelu.Location = new System.Drawing.Point(456, 232);
            this.btnPoistaPalvelu.Name = "btnPoistaPalvelu";
            this.btnPoistaPalvelu.Size = new System.Drawing.Size(92, 23);
            this.btnPoistaPalvelu.TabIndex = 26;
            this.btnPoistaPalvelu.Text = "Poista palvelu";
            this.ttUusiVaraus.SetToolTip(this.btnPoistaPalvelu, "Poistaa valitun palvelun varauksen palveluista.");
            this.btnPoistaPalvelu.UseVisualStyleBackColor = true;
            this.btnPoistaPalvelu.Click += new System.EventHandler(this.btnPoistaPalvelu_Click);
            // 
            // dgvAlueenPalvelut
            // 
            this.dgvAlueenPalvelut.AllowUserToAddRows = false;
            this.dgvAlueenPalvelut.AllowUserToDeleteRows = false;
            this.dgvAlueenPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlueenPalvelut.AutoGenerateColumns = false;
            this.dgvAlueenPalvelut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlueenPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlueenPalvelut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.alueidDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.kuvausDataGridViewTextBoxColumn2,
            this.hintaDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.dgvAlueenPalvelut.DataSource = this.palveluBindingSource1;
            this.dgvAlueenPalvelut.Enabled = false;
            this.dgvAlueenPalvelut.Location = new System.Drawing.Point(1, 26);
            this.dgvAlueenPalvelut.Name = "dgvAlueenPalvelut";
            this.dgvAlueenPalvelut.ReadOnly = true;
            this.dgvAlueenPalvelut.Size = new System.Drawing.Size(546, 105);
            this.dgvAlueenPalvelut.TabIndex = 22;
            this.dgvAlueenPalvelut.TabStop = false;
            this.ttUusiVaraus.SetToolTip(this.dgvAlueenPalvelut, "Lukitse mökki käyttääksesi tätä: Valitse lisättävä palvelu");
            this.dgvAlueenPalvelut.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAlueenPalvelut_RowHeaderMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "palvelu_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Palvelutunnus";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // alueidDataGridViewTextBoxColumn2
            // 
            this.alueidDataGridViewTextBoxColumn2.DataPropertyName = "alue_id";
            this.alueidDataGridViewTextBoxColumn2.HeaderText = "Aluetunnus";
            this.alueidDataGridViewTextBoxColumn2.Name = "alueidDataGridViewTextBoxColumn2";
            this.alueidDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nimi";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nimi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tyyppi";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tyyppi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // kuvausDataGridViewTextBoxColumn2
            // 
            this.kuvausDataGridViewTextBoxColumn2.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn2.HeaderText = "Kuvaus";
            this.kuvausDataGridViewTextBoxColumn2.Name = "kuvausDataGridViewTextBoxColumn2";
            this.kuvausDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // hintaDataGridViewTextBoxColumn2
            // 
            this.hintaDataGridViewTextBoxColumn2.DataPropertyName = "hinta";
            this.hintaDataGridViewTextBoxColumn2.HeaderText = "Hinta";
            this.hintaDataGridViewTextBoxColumn2.Name = "hintaDataGridViewTextBoxColumn2";
            this.hintaDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "alv";
            this.dataGridViewTextBoxColumn4.HeaderText = "Alv";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // palveluBindingSource1
            // 
            this.palveluBindingSource1.DataMember = "palvelu";
            this.palveluBindingSource1.DataSource = this.dataSet1;
            // 
            // lblPalvelujenMaara
            // 
            this.lblPalvelujenMaara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPalvelujenMaara.AutoSize = true;
            this.lblPalvelujenMaara.Location = new System.Drawing.Point(297, 142);
            this.lblPalvelujenMaara.Name = "lblPalvelujenMaara";
            this.lblPalvelujenMaara.Size = new System.Drawing.Size(37, 13);
            this.lblPalvelujenMaara.TabIndex = 23;
            this.lblPalvelujenMaara.Text = "Määrä";
            // 
            // nudPalveluLkm
            // 
            this.nudPalveluLkm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPalveluLkm.Enabled = false;
            this.nudPalveluLkm.Location = new System.Drawing.Point(340, 137);
            this.nudPalveluLkm.Name = "nudPalveluLkm";
            this.nudPalveluLkm.Size = new System.Drawing.Size(51, 20);
            this.nudPalveluLkm.TabIndex = 23;
            this.ttUusiVaraus.SetToolTip(this.nudPalveluLkm, "Valitse lisättävän palvelun lukumäärä");
            this.nudPalveluLkm.ValueChanged += new System.EventHandler(this.nudPalveluLkm_ValueChanged);
            // 
            // btnLisaaPalveluVaraukseen
            // 
            this.btnLisaaPalveluVaraukseen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLisaaPalveluVaraukseen.Enabled = false;
            this.btnLisaaPalveluVaraukseen.Location = new System.Drawing.Point(397, 137);
            this.btnLisaaPalveluVaraukseen.Name = "btnLisaaPalveluVaraukseen";
            this.btnLisaaPalveluVaraukseen.Size = new System.Drawing.Size(149, 23);
            this.btnLisaaPalveluVaraukseen.TabIndex = 24;
            this.btnLisaaPalveluVaraukseen.Text = "Lisää palvelu varaukseen";
            this.ttUusiVaraus.SetToolTip(this.btnLisaaPalveluVaraukseen, "Lisää valitun palvelun varaukseen");
            this.btnLisaaPalveluVaraukseen.UseVisualStyleBackColor = true;
            this.btnLisaaPalveluVaraukseen.Click += new System.EventHandler(this.btnLisaaPalveluVaraukseen_Click);
            // 
            // lbVarauksenPalvelut
            // 
            this.lbVarauksenPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVarauksenPalvelut.Enabled = false;
            this.lbVarauksenPalvelut.FormattingEnabled = true;
            this.lbVarauksenPalvelut.Location = new System.Drawing.Point(0, 161);
            this.lbVarauksenPalvelut.Name = "lbVarauksenPalvelut";
            this.lbVarauksenPalvelut.Size = new System.Drawing.Size(546, 69);
            this.lbVarauksenPalvelut.TabIndex = 25;
            this.ttUusiVaraus.SetToolTip(this.lbVarauksenPalvelut, "Valitse varauksesta poistettava palvelu.");
            this.lbVarauksenPalvelut.SelectedIndexChanged += new System.EventHandler(this.lbVarauksenPalvelut_SelectedIndexChanged);
            // 
            // dgvMokitUusiVaraus
            // 
            this.dgvMokitUusiVaraus.AllowUserToAddRows = false;
            this.dgvMokitUusiVaraus.AllowUserToDeleteRows = false;
            this.dgvMokitUusiVaraus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMokitUusiVaraus.AutoGenerateColumns = false;
            this.dgvMokitUusiVaraus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMokitUusiVaraus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMokitUusiVaraus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mokkiidDataGridViewTextBoxColumn,
            this.alueidDataGridViewTextBoxColumn,
            this.postinroDataGridViewTextBoxColumn1,
            this.mokkinimiDataGridViewTextBoxColumn,
            this.katuosoiteDataGridViewTextBoxColumn,
            this.hintaDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.henkilomaaraDataGridViewTextBoxColumn,
            this.varusteluDataGridViewTextBoxColumn});
            this.dgvMokitUusiVaraus.DataSource = this.mokkiBindingSource;
            this.dgvMokitUusiVaraus.Location = new System.Drawing.Point(0, 293);
            this.dgvMokitUusiVaraus.Name = "dgvMokitUusiVaraus";
            this.dgvMokitUusiVaraus.ReadOnly = true;
            this.dgvMokitUusiVaraus.Size = new System.Drawing.Size(1064, 143);
            this.dgvMokitUusiVaraus.TabIndex = 20;
            this.dgvMokitUusiVaraus.TabStop = false;
            this.dgvMokitUusiVaraus.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMokitUusiVaraus_RowHeaderMouseClick);
            // 
            // mokkiidDataGridViewTextBoxColumn
            // 
            this.mokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_id";
            this.mokkiidDataGridViewTextBoxColumn.HeaderText = "Mökkitunnus";
            this.mokkiidDataGridViewTextBoxColumn.Name = "mokkiidDataGridViewTextBoxColumn";
            this.mokkiidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alueidDataGridViewTextBoxColumn
            // 
            this.alueidDataGridViewTextBoxColumn.DataPropertyName = "alue_id";
            this.alueidDataGridViewTextBoxColumn.HeaderText = "Aluetunnus";
            this.alueidDataGridViewTextBoxColumn.Name = "alueidDataGridViewTextBoxColumn";
            this.alueidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postinroDataGridViewTextBoxColumn1
            // 
            this.postinroDataGridViewTextBoxColumn1.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn1.HeaderText = "Postinumero";
            this.postinroDataGridViewTextBoxColumn1.Name = "postinroDataGridViewTextBoxColumn1";
            this.postinroDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // mokkinimiDataGridViewTextBoxColumn
            // 
            this.mokkinimiDataGridViewTextBoxColumn.DataPropertyName = "mokkinimi";
            this.mokkinimiDataGridViewTextBoxColumn.HeaderText = "Mökin nimi";
            this.mokkinimiDataGridViewTextBoxColumn.Name = "mokkinimiDataGridViewTextBoxColumn";
            this.mokkinimiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // katuosoiteDataGridViewTextBoxColumn
            // 
            this.katuosoiteDataGridViewTextBoxColumn.DataPropertyName = "katuosoite";
            this.katuosoiteDataGridViewTextBoxColumn.HeaderText = "Lähiosoite";
            this.katuosoiteDataGridViewTextBoxColumn.Name = "katuosoiteDataGridViewTextBoxColumn";
            this.katuosoiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hintaDataGridViewTextBoxColumn
            // 
            this.hintaDataGridViewTextBoxColumn.DataPropertyName = "hinta";
            this.hintaDataGridViewTextBoxColumn.HeaderText = "Hinta";
            this.hintaDataGridViewTextBoxColumn.Name = "hintaDataGridViewTextBoxColumn";
            this.hintaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "Kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            this.kuvausDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // henkilomaaraDataGridViewTextBoxColumn
            // 
            this.henkilomaaraDataGridViewTextBoxColumn.DataPropertyName = "henkilomaara";
            this.henkilomaaraDataGridViewTextBoxColumn.HeaderText = "Henkilömäärä";
            this.henkilomaaraDataGridViewTextBoxColumn.Name = "henkilomaaraDataGridViewTextBoxColumn";
            this.henkilomaaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // varusteluDataGridViewTextBoxColumn
            // 
            this.varusteluDataGridViewTextBoxColumn.DataPropertyName = "varustelu";
            this.varusteluDataGridViewTextBoxColumn.HeaderText = "Varustelu";
            this.varusteluDataGridViewTextBoxColumn.Name = "varusteluDataGridViewTextBoxColumn";
            this.varusteluDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.dataSet1;
            // 
            // postiBindingSource
            // 
            this.postiBindingSource.DataMember = "posti";
            this.postiBindingSource.DataSource = this.dataSet1;
            // 
            // epUusiVaraus
            // 
            this.epUusiVaraus.ContainerControl = this;
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // alueTableAdapter
            // 
            this.alueTableAdapter.ClearBeforeFill = true;
            // 
            // postiTableAdapter
            // 
            this.postiTableAdapter.ClearBeforeFill = true;
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.dataSet1;
            // 
            // varausTableAdapter
            // 
            this.varausTableAdapter.ClearBeforeFill = true;
            // 
            // palveluTableAdapter
            // 
            this.palveluTableAdapter.ClearBeforeFill = true;
            // 
            // frmUusiVaraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 714);
            this.Controls.Add(this.pnlVaraustiedot);
            this.Controls.Add(this.pnlAsiakastiedot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1088, 727);
            this.Name = "frmUusiVaraus";
            this.Text = "Uusi varaus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUusiVaraus_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUusiVaraus_FormClosed);
            this.Load += new System.EventHandler(this.frmUusiVaraus_Load);
            this.pnlAsiakastiedot.ResumeLayout(false);
            this.pnlAsiakastiedot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.pnlVaraustiedot.ResumeLayout(false);
            this.pnlVaraustiedot.PerformLayout();
            this.pnlMokki.ResumeLayout(false);
            this.pnlMokki.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHlomaara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            this.pnlPalvelut.ResumeLayout(false);
            this.pnlPalvelut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlueenPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPalveluLkm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokitUusiVaraus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUusiVaraus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAsiakastiedot;
        private System.Windows.Forms.Panel pnlVaraustiedot;
        private System.Windows.Forms.ErrorProvider epUusiVaraus;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private DataSet1TableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.Label lblAsiakastunnus;
        private System.Windows.Forms.DataGridView dgvAsiakkaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sukunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lahiosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnroDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbAsiakastunnus;
        private System.Windows.Forms.Label lblPostinoAsiakas;
        private System.Windows.Forms.Label lblSnimi;
        private System.Windows.Forms.TextBox tbSnimi;
        private System.Windows.Forms.TextBox tbEnimi;
        private System.Windows.Forms.Label lblEnimi;
        private System.Windows.Forms.TextBox tbLahiosoiteAsiakas;
        private System.Windows.Forms.Label lblLahiosoiteAsiakas;
        private System.Windows.Forms.TextBox tbPostinoAsiakas;
        private System.Windows.Forms.Label lblSp;
        private System.Windows.Forms.Label lblPuhno;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Label lbAlueid;
        private System.Windows.Forms.ListBox lbAlue;
        private System.Windows.Forms.TextBox tbAlueid;
        private System.Windows.Forms.BindingSource alueBindingSource;
        private DataSet1TableAdapters.alueTableAdapter alueTableAdapter;
        private System.Windows.Forms.BindingSource postiBindingSource;
        private DataSet1TableAdapters.postiTableAdapter postiTableAdapter;
        private System.Windows.Forms.Label lblAjankohta;
        private System.Windows.Forms.DateTimePicker dtmLoppupvm;
        private System.Windows.Forms.DateTimePicker dtpAlkupvm;
        private System.Windows.Forms.TextBox tbMokkitunnus;
        private System.Windows.Forms.Label lblMokkitun;
        private System.Windows.Forms.DataGridView dgvMokitUusiVaraus;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private DataSet1TableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.TextBox tbMinhinta;
        private System.Windows.Forms.Label lblHenkilomaara;
        private System.Windows.Forms.NumericUpDown nudHlomaara;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkinimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katuosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn henkilomaaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varusteluDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblLoppuhinta;
        private System.Windows.Forms.TextBox tbLoppuhinta;
        private System.Windows.Forms.Label lblMaksimihinta;
        private System.Windows.Forms.Label lblMinhinta;
        private System.Windows.Forms.TextBox tbMaxhinta;
        private System.Windows.Forms.Button btnLuoVaraus;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private DataSet1TableAdapters.varausTableAdapter varausTableAdapter;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private System.Windows.Forms.Panel pnlPalvelut;
        private System.Windows.Forms.DataGridView dgvAlueenPalvelut;
        private System.Windows.Forms.Label lblPalvelujenMaara;
        private System.Windows.Forms.NumericUpDown nudPalveluLkm;
        private System.Windows.Forms.Button btnLisaaPalveluVaraukseen;
        private System.Windows.Forms.CheckBox cbLukitseMokki;
        private System.Windows.Forms.DataGridViewTextBoxColumn palveluidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alueidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyyppiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alvDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPoistaPalvelu;
        private System.Windows.Forms.TextBox tbSahkoposti;
        private System.Windows.Forms.TextBox tbPuhno;
        private System.Windows.Forms.ToolTip ttUusiVaraus;
        private System.Windows.Forms.Label lblPostitoimipaikka;
        private System.Windows.Forms.TextBox tbPostitoimipaikkaAsiakas;
        private System.Windows.Forms.Panel pnlMokki;
        private System.Windows.Forms.Button btnTyhjValinta;
        private System.Windows.Forms.Button btnHaemokki;
        private System.Windows.Forms.BindingSource palveluBindingSource1;
        private DataSet1TableAdapters.palveluTableAdapter palveluTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alueidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnNollaaAika;
        private System.Windows.Forms.Button tbnTyhjennaMokkihaku;
        private System.Windows.Forms.Label lblValitseasiakas;
        private System.Windows.Forms.Label lblValitsemokki;
        private System.Windows.Forms.Label lblValitsePalvelut;
        private System.Windows.Forms.ListBox lbVarauksenPalvelut;
    }

}
