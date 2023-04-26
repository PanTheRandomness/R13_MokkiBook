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
            this.lblPostino = new System.Windows.Forms.Label();
            this.tbPostino = new System.Windows.Forms.TextBox();
            this.lblLahiosoite = new System.Windows.Forms.Label();
            this.tbLahiosoite = new System.Windows.Forms.TextBox();
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
            this.lblPostinro = new System.Windows.Forms.Label();
            this.lbPostitoimipaikka = new System.Windows.Forms.ListBox();
            this.tbPostinro = new System.Windows.Forms.TextBox();
            this.postiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postiTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.postiTableAdapter();
            this.dtpAlkupvm = new System.Windows.Forms.DateTimePicker();
            this.dtmLoppupvm = new System.Windows.Forms.DateTimePicker();
            this.lblAjankohta = new System.Windows.Forms.Label();
            this.pnlAsiakastiedot.SuspendLayout();
            this.pnlVaraustiedot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epUusiVaraus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postiBindingSource)).BeginInit();
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
            this.pnlAsiakastiedot.Controls.Add(this.tbLahiosoite);
            this.pnlAsiakastiedot.Controls.Add(this.lblLahiosoite);
            this.pnlAsiakastiedot.Controls.Add(this.tbPostino);
            this.pnlAsiakastiedot.Controls.Add(this.lblPostino);
            this.pnlAsiakastiedot.Controls.Add(this.lblSnimi);
            this.pnlAsiakastiedot.Controls.Add(this.tbSnimi);
            this.pnlAsiakastiedot.Controls.Add(this.tbEnimi);
            this.pnlAsiakastiedot.Controls.Add(this.lblEnimi);
            this.pnlAsiakastiedot.Controls.Add(this.lblAsiakastunnus);
            this.pnlAsiakastiedot.Controls.Add(this.dgvAsiakkaat);
            this.pnlAsiakastiedot.Controls.Add(this.tbAsiakastunnus);
            this.pnlAsiakastiedot.Location = new System.Drawing.Point(2, 2);
            this.pnlAsiakastiedot.Name = "pnlAsiakastiedot";
            this.pnlAsiakastiedot.Size = new System.Drawing.Size(995, 230);
            this.pnlAsiakastiedot.TabIndex = 0;
            // 
            // pnlVaraustiedot
            // 
            this.pnlVaraustiedot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVaraustiedot.Controls.Add(this.lblAjankohta);
            this.pnlVaraustiedot.Controls.Add(this.dtmLoppupvm);
            this.pnlVaraustiedot.Controls.Add(this.dtpAlkupvm);
            this.pnlVaraustiedot.Controls.Add(this.lblPostinro);
            this.pnlVaraustiedot.Controls.Add(this.lbPostitoimipaikka);
            this.pnlVaraustiedot.Controls.Add(this.tbPostinro);
            this.pnlVaraustiedot.Controls.Add(this.lbAlueid);
            this.pnlVaraustiedot.Controls.Add(this.lbAlue);
            this.pnlVaraustiedot.Controls.Add(this.tbAlueid);
            this.pnlVaraustiedot.Location = new System.Drawing.Point(2, 233);
            this.pnlVaraustiedot.Name = "pnlVaraustiedot";
            this.pnlVaraustiedot.Size = new System.Drawing.Size(995, 311);
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
            this.tbAsiakastunnus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAsiakastunnus.Location = new System.Drawing.Point(92, 205);
            this.tbAsiakastunnus.Name = "tbAsiakastunnus";
            this.tbAsiakastunnus.Size = new System.Drawing.Size(151, 20);
            this.tbAsiakastunnus.TabIndex = 6;
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
            this.dgvAsiakkaat.Location = new System.Drawing.Point(462, 0);
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.Size = new System.Drawing.Size(533, 225);
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
            this.lblAsiakastunnus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAsiakastunnus.AutoSize = true;
            this.lblAsiakastunnus.Location = new System.Drawing.Point(10, 208);
            this.lblAsiakastunnus.Name = "lblAsiakastunnus";
            this.lblAsiakastunnus.Size = new System.Drawing.Size(76, 13);
            this.lblAsiakastunnus.TabIndex = 6;
            this.lblAsiakastunnus.Text = "Asiakastunnus";
            // 
            // lblEnimi
            // 
            this.lblEnimi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnimi.AutoSize = true;
            this.lblEnimi.Location = new System.Drawing.Point(10, 13);
            this.lblEnimi.Name = "lblEnimi";
            this.lblEnimi.Size = new System.Drawing.Size(41, 13);
            this.lblEnimi.TabIndex = 0;
            this.lblEnimi.Text = "Etunimi";
            // 
            // tbEnimi
            // 
            this.tbEnimi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEnimi.Location = new System.Drawing.Point(57, 10);
            this.tbEnimi.Name = "tbEnimi";
            this.tbEnimi.Size = new System.Drawing.Size(125, 20);
            this.tbEnimi.TabIndex = 0;
            // 
            // tbSnimi
            // 
            this.tbSnimi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSnimi.Location = new System.Drawing.Point(249, 10);
            this.tbSnimi.Name = "tbSnimi";
            this.tbSnimi.Size = new System.Drawing.Size(185, 20);
            this.tbSnimi.TabIndex = 1;
            // 
            // lblSnimi
            // 
            this.lblSnimi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSnimi.AutoSize = true;
            this.lblSnimi.Location = new System.Drawing.Point(193, 13);
            this.lblSnimi.Name = "lblSnimi";
            this.lblSnimi.Size = new System.Drawing.Size(50, 13);
            this.lblSnimi.TabIndex = 1;
            this.lblSnimi.Text = "Sukunimi";
            // 
            // lblPostino
            // 
            this.lblPostino.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPostino.AutoSize = true;
            this.lblPostino.Location = new System.Drawing.Point(10, 49);
            this.lblPostino.Name = "lblPostino";
            this.lblPostino.Size = new System.Drawing.Size(65, 13);
            this.lblPostino.TabIndex = 2;
            this.lblPostino.Text = "Postinumero";
            // 
            // tbPostino
            // 
            this.tbPostino.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPostino.Location = new System.Drawing.Point(81, 46);
            this.tbPostino.Name = "tbPostino";
            this.tbPostino.Size = new System.Drawing.Size(101, 20);
            this.tbPostino.TabIndex = 2;
            // 
            // lblLahiosoite
            // 
            this.lblLahiosoite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLahiosoite.AutoSize = true;
            this.lblLahiosoite.Location = new System.Drawing.Point(188, 49);
            this.lblLahiosoite.Name = "lblLahiosoite";
            this.lblLahiosoite.Size = new System.Drawing.Size(55, 13);
            this.lblLahiosoite.TabIndex = 3;
            this.lblLahiosoite.Text = "Lähiosoite";
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLahiosoite.Location = new System.Drawing.Point(249, 46);
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(185, 20);
            this.tbLahiosoite.TabIndex = 3;
            // 
            // lblPuhno
            // 
            this.lblPuhno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPuhno.AutoSize = true;
            this.lblPuhno.Location = new System.Drawing.Point(10, 100);
            this.lblPuhno.Name = "lblPuhno";
            this.lblPuhno.Size = new System.Drawing.Size(77, 13);
            this.lblPuhno.TabIndex = 4;
            this.lblPuhno.Text = "Puhelinnumero";
            // 
            // mtbPuhno
            // 
            this.mtbPuhno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbPuhno.Location = new System.Drawing.Point(93, 97);
            this.mtbPuhno.Mask = "(999) 000-0000";
            this.mtbPuhno.Name = "mtbPuhno";
            this.mtbPuhno.Size = new System.Drawing.Size(150, 20);
            this.mtbPuhno.TabIndex = 4;
            // 
            // mtbSp
            // 
            this.mtbSp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbSp.Location = new System.Drawing.Point(93, 133);
            this.mtbSp.Mask = "________@________.__";
            this.mtbSp.Name = "mtbSp";
            this.mtbSp.Size = new System.Drawing.Size(150, 20);
            this.mtbSp.TabIndex = 5;
            this.mtbSp.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbSp_MaskInputRejected);
            // 
            // lblSp
            // 
            this.lblSp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSp.AutoSize = true;
            this.lblSp.Location = new System.Drawing.Point(10, 136);
            this.lblSp.Name = "lblSp";
            this.lblSp.Size = new System.Drawing.Size(60, 13);
            this.lblSp.TabIndex = 5;
            this.lblSp.Text = "Sähköposti";
            // 
            // btnLisaa
            // 
            this.btnLisaa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLisaa.Location = new System.Drawing.Point(343, 202);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(91, 23);
            this.btnLisaa.TabIndex = 8;
            this.btnLisaa.Text = "Lisää asiakas";
            this.btnLisaa.UseVisualStyleBackColor = true;
            // 
            // btnHae
            // 
            this.btnHae.Location = new System.Drawing.Point(293, 202);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(44, 23);
            this.btnHae.TabIndex = 7;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            // 
            // tbAlueid
            // 
            this.tbAlueid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAlueid.Location = new System.Drawing.Point(14, 52);
            this.tbAlueid.Name = "tbAlueid";
            this.tbAlueid.Size = new System.Drawing.Size(111, 20);
            this.tbAlueid.TabIndex = 0;
            // 
            // lbAlue
            // 
            this.lbAlue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAlue.DataSource = this.alueBindingSource;
            this.lbAlue.DisplayMember = "nimi";
            this.lbAlue.FormattingEnabled = true;
            this.lbAlue.Location = new System.Drawing.Point(131, 16);
            this.lbAlue.Name = "lbAlue";
            this.lbAlue.Size = new System.Drawing.Size(162, 56);
            this.lbAlue.TabIndex = 1;
            // 
            // lbAlueid
            // 
            this.lbAlueid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAlueid.AutoSize = true;
            this.lbAlueid.Location = new System.Drawing.Point(11, 36);
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
            // lblPostinro
            // 
            this.lblPostinro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPostinro.AutoSize = true;
            this.lblPostinro.Location = new System.Drawing.Point(10, 98);
            this.lblPostinro.Name = "lblPostinro";
            this.lblPostinro.Size = new System.Drawing.Size(65, 13);
            this.lblPostinro.TabIndex = 5;
            this.lblPostinro.Text = "Postinumero";
            // 
            // lbPostitoimipaikka
            // 
            this.lbPostitoimipaikka.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPostitoimipaikka.DataSource = this.postiBindingSource;
            this.lbPostitoimipaikka.DisplayMember = "toimipaikka";
            this.lbPostitoimipaikka.FormattingEnabled = true;
            this.lbPostitoimipaikka.Location = new System.Drawing.Point(131, 78);
            this.lbPostitoimipaikka.Name = "lbPostitoimipaikka";
            this.lbPostitoimipaikka.Size = new System.Drawing.Size(162, 56);
            this.lbPostitoimipaikka.TabIndex = 4;
            // 
            // tbPostinro
            // 
            this.tbPostinro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPostinro.Location = new System.Drawing.Point(14, 114);
            this.tbPostinro.Name = "tbPostinro";
            this.tbPostinro.Size = new System.Drawing.Size(111, 20);
            this.tbPostinro.TabIndex = 3;
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
            this.dtpAlkupvm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpAlkupvm.Location = new System.Drawing.Point(93, 154);
            this.dtpAlkupvm.Name = "dtpAlkupvm";
            this.dtpAlkupvm.Size = new System.Drawing.Size(200, 20);
            this.dtpAlkupvm.TabIndex = 6;
            this.dtpAlkupvm.ValueChanged += new System.EventHandler(this.dtpAlkupvm_ValueChanged);
            // 
            // dtmLoppupvm
            // 
            this.dtmLoppupvm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtmLoppupvm.Location = new System.Drawing.Point(93, 180);
            this.dtmLoppupvm.Name = "dtmLoppupvm";
            this.dtmLoppupvm.Size = new System.Drawing.Size(200, 20);
            this.dtmLoppupvm.TabIndex = 7;
            this.dtmLoppupvm.ValueChanged += new System.EventHandler(this.dtmLoppupvm_ValueChanged);
            // 
            // lblAjankohta
            // 
            this.lblAjankohta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAjankohta.AutoSize = true;
            this.lblAjankohta.Location = new System.Drawing.Point(11, 160);
            this.lblAjankohta.Name = "lblAjankohta";
            this.lblAjankohta.Size = new System.Drawing.Size(55, 13);
            this.lblAjankohta.TabIndex = 8;
            this.lblAjankohta.Text = "Ajankohta";
            // 
            // frmUusiVaraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 546);
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
        private System.Windows.Forms.Label lblPostino;
        private System.Windows.Forms.Label lblSnimi;
        private System.Windows.Forms.TextBox tbSnimi;
        private System.Windows.Forms.TextBox tbEnimi;
        private System.Windows.Forms.Label lblEnimi;
        private System.Windows.Forms.TextBox tbLahiosoite;
        private System.Windows.Forms.Label lblLahiosoite;
        private System.Windows.Forms.TextBox tbPostino;
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
        private System.Windows.Forms.Label lblPostinro;
        private System.Windows.Forms.ListBox lbPostitoimipaikka;
        private System.Windows.Forms.TextBox tbPostinro;
        private System.Windows.Forms.BindingSource postiBindingSource;
        private DataSet1TableAdapters.postiTableAdapter postiTableAdapter;
        private System.Windows.Forms.Label lblAjankohta;
        private System.Windows.Forms.DateTimePicker dtmLoppupvm;
        private System.Windows.Forms.DateTimePicker dtpAlkupvm;
    }
}