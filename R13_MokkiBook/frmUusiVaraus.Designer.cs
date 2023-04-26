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
            this.pnlAsiakastiedot = new System.Windows.Forms.Panel();
            this.pnlVaraustiedot = new System.Windows.Forms.Panel();
            this.epUusiVaraus = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataSet1 = new R13_MokkiBook.DataSet1();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asiakasTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.asiakasTableAdapter();
            this.tbAsiakastunnus = new System.Windows.Forms.TextBox();
            this.dgvAsiakkaat = new System.Windows.Forms.DataGridView();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAsiakastunnus = new System.Windows.Forms.Label();
            this.lblEnimi = new System.Windows.Forms.Label();
            this.tbEnimi = new System.Windows.Forms.TextBox();
            this.tbSnimi = new System.Windows.Forms.TextBox();
            this.lblSnimi = new System.Windows.Forms.Label();
            this.lblPostinoAsiakas = new System.Windows.Forms.Label();
            this.tbPostinoAsiakas = new System.Windows.Forms.TextBox();
            this.lblLahiosoiteAsiakas = new System.Windows.Forms.Label();
            this.tbLahiosoiteAsiakas = new System.Windows.Forms.TextBox();
            this.lblPuhno = new System.Windows.Forms.Label();
            this.mtbPuhno = new System.Windows.Forms.MaskedTextBox();
            this.mtbSp = new System.Windows.Forms.MaskedTextBox();
            this.lblSp = new System.Windows.Forms.Label();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnHae = new System.Windows.Forms.Button();
            this.tbAlueid = new System.Windows.Forms.TextBox();
            this.lbAlue = new System.Windows.Forms.ListBox();
            this.lbAlueid = new System.Windows.Forms.Label();
            this.alueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alueTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.alueTableAdapter();
            this.lblPostinroMokki = new System.Windows.Forms.Label();
            this.lbPostitoimipaikka = new System.Windows.Forms.ListBox();
            this.tbPostinroMokki = new System.Windows.Forms.TextBox();
            this.postiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postiTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.postiTableAdapter();
            this.dtpAlkupvm = new System.Windows.Forms.DateTimePicker();
            this.dtmLoppupvm = new System.Windows.Forms.DateTimePicker();
            this.lblAjankohta = new System.Windows.Forms.Label();
            this.lblMokkitun = new System.Windows.Forms.Label();
            this.tbMokkitunnus = new System.Windows.Forms.TextBox();
            this.lblLahiosoiteMokki = new System.Windows.Forms.Label();
            this.tbLahiosoiteMokki = new System.Windows.Forms.TextBox();
            this.dgvMokitUusiVaraus = new System.Windows.Forms.DataGridView();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkiTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.mokkiTableAdapter();
            this.mokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkinimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katuosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.henkilomaaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varusteluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudHlomaara = new System.Windows.Forms.NumericUpDown();
            this.lblHenkilomaara = new System.Windows.Forms.Label();
            this.tbMinhinta = new System.Windows.Forms.TextBox();
            this.tbMaxhinta = new System.Windows.Forms.TextBox();
            this.lblMinhinta = new System.Windows.Forms.Label();
            this.lblMaksimihinta = new System.Windows.Forms.Label();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.tbLoppuhinta = new System.Windows.Forms.TextBox();
            this.lblLoppuhinta = new System.Windows.Forms.Label();
            this.lblVarustelu = new System.Windows.Forms.Label();
            this.lblKuvaus = new System.Windows.Forms.Label();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.btnLuoVaraus = new System.Windows.Forms.Button();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varausTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.varausTableAdapter();
            this.alueenPAlvelutDataSet = new R13_MokkiBook.AlueenPAlvelutDataSet();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palveluTableAdapter = new R13_MokkiBook.AlueenPAlvelutDataSetTableAdapters.palveluTableAdapter();
            this.lblVarauksenPalvelut = new System.Windows.Forms.Label();
            this.lblAlueenPalvelut = new System.Windows.Forms.Label();
            this.btnLisaaPalveluVaraukseen = new System.Windows.Forms.Button();
            this.nudPalveluLkm = new System.Windows.Forms.NumericUpDown();
            this.lblPalvelujenMaara = new System.Windows.Forms.Label();
            this.dgvAlueenPalvelut = new System.Windows.Forms.DataGridView();
            this.alvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyyppiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alueidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPalvelut = new System.Windows.Forms.Panel();
            this.lbVarauksenPalvelut = new System.Windows.Forms.ListBox();
            this.pnlAsiakastiedot.SuspendLayout();
            this.pnlVaraustiedot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUusiVaraus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokitUusiVaraus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHlomaara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueenPAlvelutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPalveluLkm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlueenPalvelut)).BeginInit();
            this.pnlPalvelut.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAsiakastiedot
            // 
            this.pnlAsiakastiedot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAsiakastiedot.Controls.Add(this.btnHae);
            this.pnlAsiakastiedot.Controls.Add(this.btnLisaa);
            this.pnlAsiakastiedot.Controls.Add(this.mtbSp);
            this.pnlAsiakastiedot.Controls.Add(this.lblSp);
            this.pnlAsiakastiedot.Controls.Add(this.mtbPuhno);
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
            this.pnlAsiakastiedot.Size = new System.Drawing.Size(1062, 241);
            this.pnlAsiakastiedot.TabIndex = 0;
            // 
            // pnlVaraustiedot
            // 
            this.pnlVaraustiedot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVaraustiedot.Controls.Add(this.btnLuoVaraus);
            this.pnlVaraustiedot.Controls.Add(this.lblKuvaus);
            this.pnlVaraustiedot.Controls.Add(this.tbKuvaus);
            this.pnlVaraustiedot.Controls.Add(this.lblVarustelu);
            this.pnlVaraustiedot.Controls.Add(this.lblLoppuhinta);
            this.pnlVaraustiedot.Controls.Add(this.tbLoppuhinta);
            this.pnlVaraustiedot.Controls.Add(this.tbVarustelu);
            this.pnlVaraustiedot.Controls.Add(this.lblMaksimihinta);
            this.pnlVaraustiedot.Controls.Add(this.lblMinhinta);
            this.pnlVaraustiedot.Controls.Add(this.tbMaxhinta);
            this.pnlVaraustiedot.Controls.Add(this.tbMinhinta);
            this.pnlVaraustiedot.Controls.Add(this.lblHenkilomaara);
            this.pnlVaraustiedot.Controls.Add(this.nudHlomaara);
            this.pnlVaraustiedot.Controls.Add(this.pnlPalvelut);
            this.pnlVaraustiedot.Controls.Add(this.dgvMokitUusiVaraus);
            this.pnlVaraustiedot.Controls.Add(this.tbLahiosoiteMokki);
            this.pnlVaraustiedot.Controls.Add(this.lblLahiosoiteMokki);
            this.pnlVaraustiedot.Controls.Add(this.tbMokkitunnus);
            this.pnlVaraustiedot.Controls.Add(this.lblMokkitun);
            this.pnlVaraustiedot.Controls.Add(this.lblAjankohta);
            this.pnlVaraustiedot.Controls.Add(this.dtmLoppupvm);
            this.pnlVaraustiedot.Controls.Add(this.dtpAlkupvm);
            this.pnlVaraustiedot.Controls.Add(this.lblPostinroMokki);
            this.pnlVaraustiedot.Controls.Add(this.lbPostitoimipaikka);
            this.pnlVaraustiedot.Controls.Add(this.tbPostinroMokki);
            this.pnlVaraustiedot.Controls.Add(this.lbAlueid);
            this.pnlVaraustiedot.Controls.Add(this.lbAlue);
            this.pnlVaraustiedot.Controls.Add(this.tbAlueid);
            this.pnlVaraustiedot.Location = new System.Drawing.Point(2, 249);
            this.pnlVaraustiedot.Name = "pnlVaraustiedot";
            this.pnlVaraustiedot.Size = new System.Drawing.Size(1062, 436);
            this.pnlVaraustiedot.TabIndex = 10;
            // 
            // epUusiVaraus
            // 
            this.epUusiVaraus.ContainerControl = this;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.dataSet1;
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // tbAsiakastunnus
            // 
            this.tbAsiakastunnus.Location = new System.Drawing.Point(93, 208);
            this.tbAsiakastunnus.Name = "tbAsiakastunnus";
            this.tbAsiakastunnus.Size = new System.Drawing.Size(151, 20);
            this.tbAsiakastunnus.TabIndex = 6;
            // 
            // dgvAsiakkaat
            // 
            this.dgvAsiakkaat.AllowUserToDeleteRows = false;
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
            this.dgvAsiakkaat.Location = new System.Drawing.Point(462, 0);
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.Size = new System.Drawing.Size(600, 238);
            this.dgvAsiakkaat.TabIndex = 9;
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
            // lblAsiakastunnus
            // 
            this.lblAsiakastunnus.AutoSize = true;
            this.lblAsiakastunnus.Location = new System.Drawing.Point(11, 211);
            this.lblAsiakastunnus.Name = "lblAsiakastunnus";
            this.lblAsiakastunnus.Size = new System.Drawing.Size(76, 13);
            this.lblAsiakastunnus.TabIndex = 6;
            this.lblAsiakastunnus.Text = "Asiakastunnus";
            // 
            // lblEnimi
            // 
            this.lblEnimi.AutoSize = true;
            this.lblEnimi.Location = new System.Drawing.Point(10, 13);
            this.lblEnimi.Name = "lblEnimi";
            this.lblEnimi.Size = new System.Drawing.Size(41, 13);
            this.lblEnimi.TabIndex = 0;
            this.lblEnimi.Text = "Etunimi";
            // 
            // tbEnimi
            // 
            this.tbEnimi.Location = new System.Drawing.Point(57, 10);
            this.tbEnimi.Name = "tbEnimi";
            this.tbEnimi.Size = new System.Drawing.Size(125, 20);
            this.tbEnimi.TabIndex = 0;
            // 
            // tbSnimi
            // 
            this.tbSnimi.Location = new System.Drawing.Point(249, 10);
            this.tbSnimi.Name = "tbSnimi";
            this.tbSnimi.Size = new System.Drawing.Size(185, 20);
            this.tbSnimi.TabIndex = 1;
            // 
            // lblSnimi
            // 
            this.lblSnimi.AutoSize = true;
            this.lblSnimi.Location = new System.Drawing.Point(193, 13);
            this.lblSnimi.Name = "lblSnimi";
            this.lblSnimi.Size = new System.Drawing.Size(50, 13);
            this.lblSnimi.TabIndex = 1;
            this.lblSnimi.Text = "Sukunimi";
            // 
            // lblPostinoAsiakas
            // 
            this.lblPostinoAsiakas.AutoSize = true;
            this.lblPostinoAsiakas.Location = new System.Drawing.Point(10, 49);
            this.lblPostinoAsiakas.Name = "lblPostinoAsiakas";
            this.lblPostinoAsiakas.Size = new System.Drawing.Size(65, 13);
            this.lblPostinoAsiakas.TabIndex = 2;
            this.lblPostinoAsiakas.Text = "Postinumero";
            // 
            // tbPostinoAsiakas
            // 
            this.tbPostinoAsiakas.Location = new System.Drawing.Point(81, 46);
            this.tbPostinoAsiakas.Name = "tbPostinoAsiakas";
            this.tbPostinoAsiakas.Size = new System.Drawing.Size(101, 20);
            this.tbPostinoAsiakas.TabIndex = 2;
            // 
            // lblLahiosoiteAsiakas
            // 
            this.lblLahiosoiteAsiakas.AutoSize = true;
            this.lblLahiosoiteAsiakas.Location = new System.Drawing.Point(188, 49);
            this.lblLahiosoiteAsiakas.Name = "lblLahiosoiteAsiakas";
            this.lblLahiosoiteAsiakas.Size = new System.Drawing.Size(55, 13);
            this.lblLahiosoiteAsiakas.TabIndex = 3;
            this.lblLahiosoiteAsiakas.Text = "Lähiosoite";
            // 
            // tbLahiosoiteAsiakas
            // 
            this.tbLahiosoiteAsiakas.Location = new System.Drawing.Point(249, 46);
            this.tbLahiosoiteAsiakas.Name = "tbLahiosoiteAsiakas";
            this.tbLahiosoiteAsiakas.Size = new System.Drawing.Size(185, 20);
            this.tbLahiosoiteAsiakas.TabIndex = 3;
            // 
            // lblPuhno
            // 
            this.lblPuhno.AutoSize = true;
            this.lblPuhno.Location = new System.Drawing.Point(10, 100);
            this.lblPuhno.Name = "lblPuhno";
            this.lblPuhno.Size = new System.Drawing.Size(77, 13);
            this.lblPuhno.TabIndex = 4;
            this.lblPuhno.Text = "Puhelinnumero";
            // 
            // mtbPuhno
            // 
            this.mtbPuhno.Location = new System.Drawing.Point(93, 97);
            this.mtbPuhno.Mask = "(999) 000-0000";
            this.mtbPuhno.Name = "mtbPuhno";
            this.mtbPuhno.Size = new System.Drawing.Size(150, 20);
            this.mtbPuhno.TabIndex = 4;
            // 
            // mtbSp
            // 
            this.mtbSp.Location = new System.Drawing.Point(93, 133);
            this.mtbSp.Mask = "________@________.__";
            this.mtbSp.Name = "mtbSp";
            this.mtbSp.Size = new System.Drawing.Size(150, 20);
            this.mtbSp.TabIndex = 5;
            this.mtbSp.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbSp_MaskInputRejected);
            // 
            // lblSp
            // 
            this.lblSp.AutoSize = true;
            this.lblSp.Location = new System.Drawing.Point(10, 136);
            this.lblSp.Name = "lblSp";
            this.lblSp.Size = new System.Drawing.Size(60, 13);
            this.lblSp.TabIndex = 5;
            this.lblSp.Text = "Sähköposti";
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(344, 205);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(91, 23);
            this.btnLisaa.TabIndex = 8;
            this.btnLisaa.Text = "Lisää asiakas";
            this.btnLisaa.UseVisualStyleBackColor = true;
            // 
            // btnHae
            // 
            this.btnHae.Location = new System.Drawing.Point(294, 205);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(44, 23);
            this.btnHae.TabIndex = 7;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            // 
            // tbAlueid
            // 
            this.tbAlueid.Location = new System.Drawing.Point(17, 101);
            this.tbAlueid.Name = "tbAlueid";
            this.tbAlueid.Size = new System.Drawing.Size(111, 20);
            this.tbAlueid.TabIndex = 0;
            // 
            // lbAlue
            // 
            this.lbAlue.DataSource = this.alueBindingSource;
            this.lbAlue.DisplayMember = "nimi";
            this.lbAlue.FormattingEnabled = true;
            this.lbAlue.Location = new System.Drawing.Point(134, 68);
            this.lbAlue.Name = "lbAlue";
            this.lbAlue.Size = new System.Drawing.Size(162, 56);
            this.lbAlue.TabIndex = 1;
            // 
            // lbAlueid
            // 
            this.lbAlueid.AutoSize = true;
            this.lbAlueid.Location = new System.Drawing.Point(14, 85);
            this.lbAlueid.Name = "lbAlueid";
            this.lbAlueid.Size = new System.Drawing.Size(60, 13);
            this.lbAlueid.TabIndex = 2;
            this.lbAlueid.Text = "Aluetunnus";
            // 
            // alueBindingSource
            // 
            this.alueBindingSource.DataMember = "alue";
            this.alueBindingSource.DataSource = this.dataSet1;
            // 
            // alueTableAdapter
            // 
            this.alueTableAdapter.ClearBeforeFill = true;
            // 
            // lblPostinroMokki
            // 
            this.lblPostinroMokki.AutoSize = true;
            this.lblPostinroMokki.Location = new System.Drawing.Point(10, 161);
            this.lblPostinroMokki.Name = "lblPostinroMokki";
            this.lblPostinroMokki.Size = new System.Drawing.Size(65, 13);
            this.lblPostinroMokki.TabIndex = 5;
            this.lblPostinroMokki.Text = "Postinumero";
            // 
            // lbPostitoimipaikka
            // 
            this.lbPostitoimipaikka.DataSource = this.postiBindingSource;
            this.lbPostitoimipaikka.DisplayMember = "toimipaikka";
            this.lbPostitoimipaikka.FormattingEnabled = true;
            this.lbPostitoimipaikka.Location = new System.Drawing.Point(131, 141);
            this.lbPostitoimipaikka.Name = "lbPostitoimipaikka";
            this.lbPostitoimipaikka.Size = new System.Drawing.Size(162, 56);
            this.lbPostitoimipaikka.TabIndex = 4;
            // 
            // tbPostinroMokki
            // 
            this.tbPostinroMokki.Location = new System.Drawing.Point(14, 177);
            this.tbPostinroMokki.Name = "tbPostinroMokki";
            this.tbPostinroMokki.Size = new System.Drawing.Size(111, 20);
            this.tbPostinroMokki.TabIndex = 3;
            // 
            // postiBindingSource
            // 
            this.postiBindingSource.DataMember = "posti";
            this.postiBindingSource.DataSource = this.dataSet1;
            // 
            // postiTableAdapter
            // 
            this.postiTableAdapter.ClearBeforeFill = true;
            // 
            // dtpAlkupvm
            // 
            this.dtpAlkupvm.Location = new System.Drawing.Point(93, 14);
            this.dtpAlkupvm.Name = "dtpAlkupvm";
            this.dtpAlkupvm.Size = new System.Drawing.Size(200, 20);
            this.dtpAlkupvm.TabIndex = 6;
            this.dtpAlkupvm.ValueChanged += new System.EventHandler(this.dtpAlkupvm_ValueChanged);
            // 
            // dtmLoppupvm
            // 
            this.dtmLoppupvm.Location = new System.Drawing.Point(93, 40);
            this.dtmLoppupvm.Name = "dtmLoppupvm";
            this.dtmLoppupvm.Size = new System.Drawing.Size(200, 20);
            this.dtmLoppupvm.TabIndex = 7;
            this.dtmLoppupvm.ValueChanged += new System.EventHandler(this.dtmLoppupvm_ValueChanged);
            // 
            // lblAjankohta
            // 
            this.lblAjankohta.AutoSize = true;
            this.lblAjankohta.Location = new System.Drawing.Point(11, 20);
            this.lblAjankohta.Name = "lblAjankohta";
            this.lblAjankohta.Size = new System.Drawing.Size(55, 13);
            this.lblAjankohta.TabIndex = 8;
            this.lblAjankohta.Text = "Ajankohta";
            // 
            // lblMokkitun
            // 
            this.lblMokkitun.AutoSize = true;
            this.lblMokkitun.Location = new System.Drawing.Point(14, 251);
            this.lblMokkitun.Name = "lblMokkitun";
            this.lblMokkitun.Size = new System.Drawing.Size(68, 13);
            this.lblMokkitun.TabIndex = 9;
            this.lblMokkitun.Text = "Mökkitunnus";
            // 
            // tbMokkitunnus
            // 
            this.tbMokkitunnus.Location = new System.Drawing.Point(93, 248);
            this.tbMokkitunnus.Name = "tbMokkitunnus";
            this.tbMokkitunnus.Size = new System.Drawing.Size(200, 20);
            this.tbMokkitunnus.TabIndex = 10;
            // 
            // lblLahiosoiteMokki
            // 
            this.lblLahiosoiteMokki.AutoSize = true;
            this.lblLahiosoiteMokki.Location = new System.Drawing.Point(14, 219);
            this.lblLahiosoiteMokki.Name = "lblLahiosoiteMokki";
            this.lblLahiosoiteMokki.Size = new System.Drawing.Size(37, 13);
            this.lblLahiosoiteMokki.TabIndex = 11;
            this.lblLahiosoiteMokki.Text = "Osoite";
            // 
            // tbLahiosoiteMokki
            // 
            this.tbLahiosoiteMokki.Location = new System.Drawing.Point(57, 212);
            this.tbLahiosoiteMokki.Name = "tbLahiosoiteMokki";
            this.tbLahiosoiteMokki.Size = new System.Drawing.Size(236, 20);
            this.tbLahiosoiteMokki.TabIndex = 12;
            // 
            // dgvMokitUusiVaraus
            // 
            this.dgvMokitUusiVaraus.AllowUserToAddRows = false;
            this.dgvMokitUusiVaraus.AllowUserToDeleteRows = false;
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
            this.dgvMokitUusiVaraus.Location = new System.Drawing.Point(0, 274);
            this.dgvMokitUusiVaraus.Name = "dgvMokitUusiVaraus";
            this.dgvMokitUusiVaraus.ReadOnly = true;
            this.dgvMokitUusiVaraus.Size = new System.Drawing.Size(1062, 162);
            this.dgvMokitUusiVaraus.TabIndex = 13;
            this.dgvMokitUusiVaraus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMokitUusiVaraus_CellContentClick);
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.dataSet1;
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
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
            // nudHlomaara
            // 
            this.nudHlomaara.Location = new System.Drawing.Point(379, 14);
            this.nudHlomaara.Name = "nudHlomaara";
            this.nudHlomaara.Size = new System.Drawing.Size(120, 20);
            this.nudHlomaara.TabIndex = 15;
            this.nudHlomaara.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblHenkilomaara
            // 
            this.lblHenkilomaara.AutoSize = true;
            this.lblHenkilomaara.Location = new System.Drawing.Point(299, 17);
            this.lblHenkilomaara.Name = "lblHenkilomaara";
            this.lblHenkilomaara.Size = new System.Drawing.Size(72, 13);
            this.lblHenkilomaara.TabIndex = 16;
            this.lblHenkilomaara.Text = "Henkilömäärä";
            // 
            // tbMinhinta
            // 
            this.tbMinhinta.Location = new System.Drawing.Point(399, 222);
            this.tbMinhinta.Name = "tbMinhinta";
            this.tbMinhinta.Size = new System.Drawing.Size(100, 20);
            this.tbMinhinta.TabIndex = 17;
            // 
            // tbMaxhinta
            // 
            this.tbMaxhinta.Location = new System.Drawing.Point(399, 248);
            this.tbMaxhinta.Name = "tbMaxhinta";
            this.tbMaxhinta.Size = new System.Drawing.Size(100, 20);
            this.tbMaxhinta.TabIndex = 18;
            // 
            // lblMinhinta
            // 
            this.lblMinhinta.AutoSize = true;
            this.lblMinhinta.Location = new System.Drawing.Point(301, 229);
            this.lblMinhinta.Name = "lblMinhinta";
            this.lblMinhinta.Size = new System.Drawing.Size(74, 13);
            this.lblMinhinta.TabIndex = 19;
            this.lblMinhinta.Text = "Minimihinta (€)";
            // 
            // lblMaksimihinta
            // 
            this.lblMaksimihinta.AutoSize = true;
            this.lblMaksimihinta.Location = new System.Drawing.Point(301, 255);
            this.lblMaksimihinta.Name = "lblMaksimihinta";
            this.lblMaksimihinta.Size = new System.Drawing.Size(83, 13);
            this.lblMaksimihinta.TabIndex = 20;
            this.lblMaksimihinta.Text = "Maksimihinta (€)";
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Location = new System.Drawing.Point(302, 65);
            this.tbVarustelu.Multiline = true;
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(197, 59);
            this.tbVarustelu.TabIndex = 21;
            // 
            // tbLoppuhinta
            // 
            this.tbLoppuhinta.Location = new System.Drawing.Point(813, 247);
            this.tbLoppuhinta.Name = "tbLoppuhinta";
            this.tbLoppuhinta.Size = new System.Drawing.Size(100, 20);
            this.tbLoppuhinta.TabIndex = 22;
            // 
            // lblLoppuhinta
            // 
            this.lblLoppuhinta.AutoSize = true;
            this.lblLoppuhinta.Location = new System.Drawing.Point(732, 250);
            this.lblLoppuhinta.Name = "lblLoppuhinta";
            this.lblLoppuhinta.Size = new System.Drawing.Size(75, 13);
            this.lblLoppuhinta.TabIndex = 23;
            this.lblLoppuhinta.Text = "Loppuhinta (€)";
            // 
            // lblVarustelu
            // 
            this.lblVarustelu.AutoSize = true;
            this.lblVarustelu.Location = new System.Drawing.Point(299, 49);
            this.lblVarustelu.Name = "lblVarustelu";
            this.lblVarustelu.Size = new System.Drawing.Size(51, 13);
            this.lblVarustelu.TabIndex = 24;
            this.lblVarustelu.Text = "Varustelu";
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Location = new System.Drawing.Point(299, 125);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(43, 13);
            this.lblKuvaus.TabIndex = 26;
            this.lblKuvaus.Text = "Kuvaus";
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(302, 141);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(197, 59);
            this.tbKuvaus.TabIndex = 25;
            // 
            // btnLuoVaraus
            // 
            this.btnLuoVaraus.Location = new System.Drawing.Point(919, 245);
            this.btnLuoVaraus.Name = "btnLuoVaraus";
            this.btnLuoVaraus.Size = new System.Drawing.Size(133, 23);
            this.btnLuoVaraus.TabIndex = 27;
            this.btnLuoVaraus.Text = "Luo varaus";
            this.btnLuoVaraus.UseVisualStyleBackColor = true;
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
            // alueenPAlvelutDataSet
            // 
            this.alueenPAlvelutDataSet.DataSetName = "AlueenPAlvelutDataSet";
            this.alueenPAlvelutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataMember = "palvelu";
            this.palveluBindingSource.DataSource = this.alueenPAlvelutDataSet;
            // 
            // palveluTableAdapter
            // 
            this.palveluTableAdapter.ClearBeforeFill = true;
            // 
            // lblVarauksenPalvelut
            // 
            this.lblVarauksenPalvelut.AutoSize = true;
            this.lblVarauksenPalvelut.Location = new System.Drawing.Point(3, 147);
            this.lblVarauksenPalvelut.Name = "lblVarauksenPalvelut";
            this.lblVarauksenPalvelut.Size = new System.Drawing.Size(98, 13);
            this.lblVarauksenPalvelut.TabIndex = 1;
            this.lblVarauksenPalvelut.Text = "Varauksen palvelut";
            // 
            // lblAlueenPalvelut
            // 
            this.lblAlueenPalvelut.AutoSize = true;
            this.lblAlueenPalvelut.Location = new System.Drawing.Point(3, 3);
            this.lblAlueenPalvelut.Name = "lblAlueenPalvelut";
            this.lblAlueenPalvelut.Size = new System.Drawing.Size(80, 13);
            this.lblAlueenPalvelut.TabIndex = 3;
            this.lblAlueenPalvelut.Text = "Alueen palvelut";
            // 
            // btnLisaaPalveluVaraukseen
            // 
            this.btnLisaaPalveluVaraukseen.Location = new System.Drawing.Point(393, 131);
            this.btnLisaaPalveluVaraukseen.Name = "btnLisaaPalveluVaraukseen";
            this.btnLisaaPalveluVaraukseen.Size = new System.Drawing.Size(149, 23);
            this.btnLisaaPalveluVaraukseen.TabIndex = 4;
            this.btnLisaaPalveluVaraukseen.Text = "Lisää palvelu varaukseen";
            this.btnLisaaPalveluVaraukseen.UseVisualStyleBackColor = true;
            // 
            // nudPalveluLkm
            // 
            this.nudPalveluLkm.Location = new System.Drawing.Point(336, 131);
            this.nudPalveluLkm.Name = "nudPalveluLkm";
            this.nudPalveluLkm.Size = new System.Drawing.Size(51, 20);
            this.nudPalveluLkm.TabIndex = 5;
            // 
            // lblPalvelujenMaara
            // 
            this.lblPalvelujenMaara.AutoSize = true;
            this.lblPalvelujenMaara.Location = new System.Drawing.Point(293, 136);
            this.lblPalvelujenMaara.Name = "lblPalvelujenMaara";
            this.lblPalvelujenMaara.Size = new System.Drawing.Size(37, 13);
            this.lblPalvelujenMaara.TabIndex = 6;
            this.lblPalvelujenMaara.Text = "Määrä";
            // 
            // dgvAlueenPalvelut
            // 
            this.dgvAlueenPalvelut.AllowUserToAddRows = false;
            this.dgvAlueenPalvelut.AllowUserToDeleteRows = false;
            this.dgvAlueenPalvelut.AutoGenerateColumns = false;
            this.dgvAlueenPalvelut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlueenPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlueenPalvelut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palveluidDataGridViewTextBoxColumn,
            this.alueidDataGridViewTextBoxColumn1,
            this.nimiDataGridViewTextBoxColumn,
            this.tyyppiDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn1,
            this.hintaDataGridViewTextBoxColumn1,
            this.alvDataGridViewTextBoxColumn});
            this.dgvAlueenPalvelut.DataSource = this.palveluBindingSource;
            this.dgvAlueenPalvelut.Location = new System.Drawing.Point(0, 20);
            this.dgvAlueenPalvelut.Name = "dgvAlueenPalvelut";
            this.dgvAlueenPalvelut.ReadOnly = true;
            this.dgvAlueenPalvelut.Size = new System.Drawing.Size(546, 105);
            this.dgvAlueenPalvelut.TabIndex = 7;
            // 
            // alvDataGridViewTextBoxColumn
            // 
            this.alvDataGridViewTextBoxColumn.DataPropertyName = "alv";
            this.alvDataGridViewTextBoxColumn.HeaderText = "ALV";
            this.alvDataGridViewTextBoxColumn.Name = "alvDataGridViewTextBoxColumn";
            this.alvDataGridViewTextBoxColumn.ReadOnly = true;
            this.alvDataGridViewTextBoxColumn.ToolTipText = "Palvelun arvolisävero";
            // 
            // hintaDataGridViewTextBoxColumn1
            // 
            this.hintaDataGridViewTextBoxColumn1.DataPropertyName = "hinta";
            this.hintaDataGridViewTextBoxColumn1.HeaderText = "Hinta";
            this.hintaDataGridViewTextBoxColumn1.Name = "hintaDataGridViewTextBoxColumn1";
            this.hintaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.hintaDataGridViewTextBoxColumn1.ToolTipText = "Palvelun hinta";
            // 
            // kuvausDataGridViewTextBoxColumn1
            // 
            this.kuvausDataGridViewTextBoxColumn1.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn1.HeaderText = "Kuvaus";
            this.kuvausDataGridViewTextBoxColumn1.Name = "kuvausDataGridViewTextBoxColumn1";
            this.kuvausDataGridViewTextBoxColumn1.ReadOnly = true;
            this.kuvausDataGridViewTextBoxColumn1.ToolTipText = "Palvelun kuvaus";
            // 
            // tyyppiDataGridViewTextBoxColumn
            // 
            this.tyyppiDataGridViewTextBoxColumn.DataPropertyName = "tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.HeaderText = "Tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.Name = "tyyppiDataGridViewTextBoxColumn";
            this.tyyppiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tyyppiDataGridViewTextBoxColumn.ToolTipText = "Palvelun tyyppi";
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "Nimi";
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            this.nimiDataGridViewTextBoxColumn.ReadOnly = true;
            this.nimiDataGridViewTextBoxColumn.ToolTipText = "Palvelun nimi";
            // 
            // alueidDataGridViewTextBoxColumn1
            // 
            this.alueidDataGridViewTextBoxColumn1.DataPropertyName = "alue_id";
            this.alueidDataGridViewTextBoxColumn1.HeaderText = "Alue";
            this.alueidDataGridViewTextBoxColumn1.Name = "alueidDataGridViewTextBoxColumn1";
            this.alueidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.alueidDataGridViewTextBoxColumn1.ToolTipText = "Aluetunnus";
            // 
            // palveluidDataGridViewTextBoxColumn
            // 
            this.palveluidDataGridViewTextBoxColumn.DataPropertyName = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.HeaderText = "Palvelutunnus";
            this.palveluidDataGridViewTextBoxColumn.Name = "palveluidDataGridViewTextBoxColumn";
            this.palveluidDataGridViewTextBoxColumn.ReadOnly = true;
            this.palveluidDataGridViewTextBoxColumn.ToolTipText = "Palvelun ID";
            // 
            // pnlPalvelut
            // 
            this.pnlPalvelut.Controls.Add(this.dgvAlueenPalvelut);
            this.pnlPalvelut.Controls.Add(this.lblPalvelujenMaara);
            this.pnlPalvelut.Controls.Add(this.nudPalveluLkm);
            this.pnlPalvelut.Controls.Add(this.btnLisaaPalveluVaraukseen);
            this.pnlPalvelut.Controls.Add(this.lblAlueenPalvelut);
            this.pnlPalvelut.Controls.Add(this.lblVarauksenPalvelut);
            this.pnlPalvelut.Controls.Add(this.lbVarauksenPalvelut);
            this.pnlPalvelut.Location = new System.Drawing.Point(516, -3);
            this.pnlPalvelut.Name = "pnlPalvelut";
            this.pnlPalvelut.Size = new System.Drawing.Size(545, 245);
            this.pnlPalvelut.TabIndex = 14;
            // 
            // lbVarauksenPalvelut
            // 
            this.lbVarauksenPalvelut.FormattingEnabled = true;
            this.lbVarauksenPalvelut.Location = new System.Drawing.Point(0, 161);
            this.lbVarauksenPalvelut.Name = "lbVarauksenPalvelut";
            this.lbVarauksenPalvelut.Size = new System.Drawing.Size(546, 82);
            this.lbVarauksenPalvelut.TabIndex = 0;
            // 
            // frmUusiVaraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 687);
            this.Controls.Add(this.pnlVaraustiedot);
            this.Controls.Add(this.pnlAsiakastiedot);
            this.Name = "frmUusiVaraus";
            this.Text = "Uusi varaus";
            this.Load += new System.EventHandler(this.frmUusiVaraus_Load);
            this.pnlAsiakastiedot.ResumeLayout(false);
            this.pnlAsiakastiedot.PerformLayout();
            this.pnlVaraustiedot.ResumeLayout(false);
            this.pnlVaraustiedot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUusiVaraus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMokitUusiVaraus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHlomaara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueenPAlvelutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPalveluLkm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlueenPalvelut)).EndInit();
            this.pnlPalvelut.ResumeLayout(false);
            this.pnlPalvelut.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox mtbSp;
        private System.Windows.Forms.Label lblSp;
        private System.Windows.Forms.MaskedTextBox mtbPuhno;
        private System.Windows.Forms.Label lblPuhno;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Label lbAlueid;
        private System.Windows.Forms.ListBox lbAlue;
        private System.Windows.Forms.TextBox tbAlueid;
        private System.Windows.Forms.BindingSource alueBindingSource;
        private DataSet1TableAdapters.alueTableAdapter alueTableAdapter;
        private System.Windows.Forms.Label lblPostinroMokki;
        private System.Windows.Forms.ListBox lbPostitoimipaikka;
        private System.Windows.Forms.TextBox tbPostinroMokki;
        private System.Windows.Forms.BindingSource postiBindingSource;
        private DataSet1TableAdapters.postiTableAdapter postiTableAdapter;
        private System.Windows.Forms.Label lblAjankohta;
        private System.Windows.Forms.DateTimePicker dtmLoppupvm;
        private System.Windows.Forms.DateTimePicker dtpAlkupvm;
        private System.Windows.Forms.Label lblLahiosoiteMokki;
        private System.Windows.Forms.TextBox tbMokkitunnus;
        private System.Windows.Forms.Label lblMokkitun;
        private System.Windows.Forms.DataGridView dgvMokitUusiVaraus;
        private System.Windows.Forms.TextBox tbLahiosoiteMokki;
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
        private System.Windows.Forms.Label lblKuvaus;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.Label lblVarustelu;
        private System.Windows.Forms.Label lblLoppuhinta;
        private System.Windows.Forms.TextBox tbLoppuhinta;
        private System.Windows.Forms.TextBox tbVarustelu;
        private System.Windows.Forms.Label lblMaksimihinta;
        private System.Windows.Forms.Label lblMinhinta;
        private System.Windows.Forms.TextBox tbMaxhinta;
        private System.Windows.Forms.Button btnLuoVaraus;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private DataSet1TableAdapters.varausTableAdapter varausTableAdapter;
        private AlueenPAlvelutDataSet alueenPAlvelutDataSet;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private AlueenPAlvelutDataSetTableAdapters.palveluTableAdapter palveluTableAdapter;
        private System.Windows.Forms.Panel pnlPalvelut;
        private System.Windows.Forms.DataGridView dgvAlueenPalvelut;
        private System.Windows.Forms.DataGridViewTextBoxColumn palveluidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alueidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyyppiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alvDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPalvelujenMaara;
        private System.Windows.Forms.NumericUpDown nudPalveluLkm;
        private System.Windows.Forms.Button btnLisaaPalveluVaraukseen;
        private System.Windows.Forms.Label lblAlueenPalvelut;
        private System.Windows.Forms.Label lblVarauksenPalvelut;
        private System.Windows.Forms.ListBox lbVarauksenPalvelut;
    }
}