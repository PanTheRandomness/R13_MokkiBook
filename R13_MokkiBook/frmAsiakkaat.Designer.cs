﻿namespace R13_MokkiBook
{
    partial class frmAsiakkaat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsiakkaat));
            this.lbAsiakasid = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbLahiosoite = new System.Windows.Forms.Label();
            this.lbSukunimi = new System.Windows.Forms.Label();
            this.lbEtunimi = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbPuhelinnumero = new System.Windows.Forms.Label();
            this.tbAsiakasid = new System.Windows.Forms.TextBox();
            this.tbPuhelinnro = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLahiosoite = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.tbPostiNro = new System.Windows.Forms.TextBox();
            this.dgvAsiakkaat = new System.Windows.Forms.DataGridView();
            this.asiakas_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new R13_MokkiBook.DataSet1();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.asiakasTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.asiakasTableAdapter();
            this.btnTyhjenna = new System.Windows.Forms.Button();
            this.tbHae = new System.Windows.Forms.TextBox();
            this.btnHae = new System.Windows.Forms.Button();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbPostitoimipaikka = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAsiakasid
            // 
            this.lbAsiakasid.AutoSize = true;
            this.lbAsiakasid.Location = new System.Drawing.Point(36, 49);
            this.lbAsiakasid.Name = "lbAsiakasid";
            this.lbAsiakasid.Size = new System.Drawing.Size(74, 16);
            this.lbAsiakasid.TabIndex = 0;
            this.lbAsiakasid.Text = "Asiakas_id";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(396, 114);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(41, 16);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email";
            // 
            // lbLahiosoite
            // 
            this.lbLahiosoite.AutoSize = true;
            this.lbLahiosoite.Location = new System.Drawing.Point(396, 87);
            this.lbLahiosoite.Name = "lbLahiosoite";
            this.lbLahiosoite.Size = new System.Drawing.Size(69, 16);
            this.lbLahiosoite.TabIndex = 4;
            this.lbLahiosoite.Text = "Lähiosoite";
            // 
            // lbSukunimi
            // 
            this.lbSukunimi.AutoSize = true;
            this.lbSukunimi.Location = new System.Drawing.Point(36, 143);
            this.lbSukunimi.Name = "lbSukunimi";
            this.lbSukunimi.Size = new System.Drawing.Size(61, 16);
            this.lbSukunimi.TabIndex = 3;
            this.lbSukunimi.Text = "Sukunimi";
            // 
            // lbEtunimi
            // 
            this.lbEtunimi.AutoSize = true;
            this.lbEtunimi.Location = new System.Drawing.Point(36, 111);
            this.lbEtunimi.Name = "lbEtunimi";
            this.lbEtunimi.Size = new System.Drawing.Size(50, 16);
            this.lbEtunimi.TabIndex = 2;
            this.lbEtunimi.Text = "Etunimi";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(36, 79);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(82, 16);
            this.lb.TabIndex = 1;
            this.lb.Text = "Postinumero";
            // 
            // lbPuhelinnumero
            // 
            this.lbPuhelinnumero.AutoSize = true;
            this.lbPuhelinnumero.Location = new System.Drawing.Point(396, 143);
            this.lbPuhelinnumero.Name = "lbPuhelinnumero";
            this.lbPuhelinnumero.Size = new System.Drawing.Size(96, 16);
            this.lbPuhelinnumero.TabIndex = 6;
            this.lbPuhelinnumero.Text = "Puhelinnumero";
            // 
            // tbAsiakasid
            // 
            this.tbAsiakasid.Location = new System.Drawing.Point(176, 49);
            this.tbAsiakasid.Name = "tbAsiakasid";
            this.tbAsiakasid.Size = new System.Drawing.Size(159, 22);
            this.tbAsiakasid.TabIndex = 0;
            this.tbAsiakasid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAsiakasid_KeyPress);
            // 
            // tbPuhelinnro
            // 
            this.tbPuhelinnro.Location = new System.Drawing.Point(516, 140);
            this.tbPuhelinnro.Name = "tbPuhelinnro";
            this.tbPuhelinnro.Size = new System.Drawing.Size(159, 22);
            this.tbPuhelinnro.TabIndex = 6;
            this.tbPuhelinnro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPuhelinnro_KeyPress);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(516, 112);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(159, 22);
            this.tbEmail.TabIndex = 5;
            this.tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEmail_KeyPress);
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Location = new System.Drawing.Point(516, 80);
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(159, 22);
            this.tbLahiosoite.TabIndex = 4;
            this.tbLahiosoite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLahiosoite_KeyPress);
            this.tbLahiosoite.Leave += new System.EventHandler(this.tbLahiosoite_Leave);
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(176, 143);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(159, 22);
            this.tbSukunimi.TabIndex = 3;
            this.tbSukunimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSukunimi_KeyPress);
            this.tbSukunimi.Leave += new System.EventHandler(this.tbEtunimi_Leave);
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(176, 111);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(159, 22);
            this.tbEtunimi.TabIndex = 2;
            this.tbEtunimi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEtunimi_KeyPress);
            this.tbEtunimi.Leave += new System.EventHandler(this.tbEtunimi_Leave);
            // 
            // tbPostiNro
            // 
            this.tbPostiNro.Location = new System.Drawing.Point(176, 79);
            this.tbPostiNro.Name = "tbPostiNro";
            this.tbPostiNro.Size = new System.Drawing.Size(159, 22);
            this.tbPostiNro.TabIndex = 1;
            this.tbPostiNro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostiNro_KeyPress);
            // 
            // dgvAsiakkaat
            // 
            this.dgvAsiakkaat.AutoGenerateColumns = false;
            this.dgvAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakkaat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiakas_id,
            this.postinro,
            this.etunimi,
            this.sukunimi,
            this.lahiosoite,
            this.email,
            this.puhelinnro});
            this.dgvAsiakkaat.DataSource = this.asiakasBindingSource;
            this.dgvAsiakkaat.Location = new System.Drawing.Point(29, 269);
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.RowHeadersWidth = 51;
            this.dgvAsiakkaat.RowTemplate.Height = 24;
            this.dgvAsiakkaat.Size = new System.Drawing.Size(729, 176);
            this.dgvAsiakkaat.TabIndex = 14;
            this.dgvAsiakkaat.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAsiakkaat_RowHeaderMouseDoubleClick);
            // 
            // asiakas_id
            // 
            this.asiakas_id.DataPropertyName = "asiakas_id";
            this.asiakas_id.HeaderText = "asiakas_id";
            this.asiakas_id.MinimumWidth = 6;
            this.asiakas_id.Name = "asiakas_id";
            this.asiakas_id.Width = 125;
            // 
            // postinro
            // 
            this.postinro.DataPropertyName = "postinro";
            this.postinro.HeaderText = "postinro";
            this.postinro.MinimumWidth = 6;
            this.postinro.Name = "postinro";
            this.postinro.Width = 125;
            // 
            // etunimi
            // 
            this.etunimi.DataPropertyName = "etunimi";
            this.etunimi.HeaderText = "etunimi";
            this.etunimi.MinimumWidth = 6;
            this.etunimi.Name = "etunimi";
            this.etunimi.Width = 125;
            // 
            // sukunimi
            // 
            this.sukunimi.DataPropertyName = "sukunimi";
            this.sukunimi.HeaderText = "sukunimi";
            this.sukunimi.MinimumWidth = 6;
            this.sukunimi.Name = "sukunimi";
            this.sukunimi.Width = 125;
            // 
            // lahiosoite
            // 
            this.lahiosoite.DataPropertyName = "lahiosoite";
            this.lahiosoite.HeaderText = "lahiosoite";
            this.lahiosoite.MinimumWidth = 6;
            this.lahiosoite.Name = "lahiosoite";
            this.lahiosoite.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // puhelinnro
            // 
            this.puhelinnro.DataPropertyName = "puhelinnro";
            this.puhelinnro.HeaderText = "puhelinnro";
            this.puhelinnro.MinimumWidth = 6;
            this.puhelinnro.Name = "puhelinnro";
            this.puhelinnro.Width = 125;
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
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(29, 200);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(176, 45);
            this.btnLisaa.TabIndex = 15;
            this.btnLisaa.Text = "Lisää asiakas";
            this.MyToolTip.SetToolTip(this.btnLisaa, "Lisää uuden asiakkaan tiedot tietokantaan. Täytä ensiksi yläpuolella oleva lomake" +
        ".");
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(211, 200);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(163, 45);
            this.btnMuokkaa.TabIndex = 16;
            this.btnMuokkaa.Text = "Tallenna muutos";
            this.MyToolTip.SetToolTip(this.btnMuokkaa, "Tuplaklikkaa asiakasriviä, jota haluisit muokata. Tiedot siirtyvät yllä olevaan l" +
        "omakkeeseen ja voit tehdä tarvittavat muutokset. Lopuksi tallenna muutokset, jot" +
        "ta ne siirtyvät tietokantaan.");
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(380, 200);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(173, 45);
            this.btnPoista.TabIndex = 17;
            this.btnPoista.Text = "Poista";
            this.MyToolTip.SetToolTip(this.btnPoista, "Poista asiakkaan tiedot tietokannasta");
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.Location = new System.Drawing.Point(559, 200);
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.Size = new System.Drawing.Size(160, 45);
            this.btnTyhjenna.TabIndex = 23;
            this.btnTyhjenna.Text = "Tyhjennä";
            this.MyToolTip.SetToolTip(this.btnTyhjenna, "Tyhjenää lomakkeen rivit");
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.Click += new System.EventHandler(this.btnTyhjenna_Click);
            // 
            // tbHae
            // 
            this.tbHae.Location = new System.Drawing.Point(29, 451);
            this.tbHae.Name = "tbHae";
            this.tbHae.Size = new System.Drawing.Size(124, 22);
            this.tbHae.TabIndex = 24;
            // 
            // btnHae
            // 
            this.btnHae.Location = new System.Drawing.Point(159, 450);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(96, 23);
            this.btnHae.TabIndex = 25;
            this.btnHae.Text = "Hae";
            this.MyToolTip.SetToolTip(this.btnHae, "Hae asiakas id-numerolla. Kirjoita numero viereiseen tekstikenttään.");
            this.btnHae.UseVisualStyleBackColor = true;
            this.btnHae.Click += new System.EventHandler(this.btnHae_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Postitoimipaikka";
            // 
            // tbPostitoimipaikka
            // 
            this.tbPostitoimipaikka.Location = new System.Drawing.Point(516, 52);
            this.tbPostitoimipaikka.Name = "tbPostitoimipaikka";
            this.tbPostitoimipaikka.Size = new System.Drawing.Size(159, 22);
            this.tbPostitoimipaikka.TabIndex = 27;
            // 
            // frmAsiakkaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 475);
            this.Controls.Add(this.tbPostitoimipaikka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHae);
            this.Controls.Add(this.tbHae);
            this.Controls.Add(this.btnTyhjenna);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnMuokkaa);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.dgvAsiakkaat);
            this.Controls.Add(this.tbPostiNro);
            this.Controls.Add(this.tbEtunimi);
            this.Controls.Add(this.tbSukunimi);
            this.Controls.Add(this.tbLahiosoite);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPuhelinnro);
            this.Controls.Add(this.tbAsiakasid);
            this.Controls.Add(this.lbPuhelinnumero);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lbEtunimi);
            this.Controls.Add(this.lbSukunimi);
            this.Controls.Add(this.lbLahiosoite);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbAsiakasid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAsiakkaat";
            this.Text = "frmAsiakkaat";
            this.Load += new System.EventHandler(this.frmAsiakkaat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAsiakasid;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbLahiosoite;
        private System.Windows.Forms.Label lbSukunimi;
        private System.Windows.Forms.Label lbEtunimi;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbPuhelinnumero;
        private System.Windows.Forms.TextBox tbAsiakasid;
        private System.Windows.Forms.TextBox tbPuhelinnro;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLahiosoite;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.TextBox tbPostiNro;
        private System.Windows.Forms.DataGridView dgvAsiakkaat;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private DataSet1TableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakas_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinro;
        private System.Windows.Forms.DataGridViewTextBoxColumn etunimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sukunimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn lahiosoite;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnro;
        private System.Windows.Forms.Button btnTyhjenna;
        private System.Windows.Forms.TextBox tbHae;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.ToolTip MyToolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPostitoimipaikka;
    }
}