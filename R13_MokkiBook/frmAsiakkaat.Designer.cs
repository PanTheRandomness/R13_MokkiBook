namespace R13_MokkiBook
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
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postinroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sukunimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lahiosoiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puhelinnroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new R13_MokkiBook.DataSet1();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.dtpLoppu = new System.Windows.Forms.DateTimePicker();
            this.lblViiva = new System.Windows.Forms.Label();
            this.dtpAlku = new System.Windows.Forms.DateTimePicker();
            this.lblPaivat = new System.Windows.Forms.Label();
            this.btnHae = new System.Windows.Forms.Button();
            this.asiakasTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.asiakasTableAdapter();
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
            this.lbEmail.Location = new System.Drawing.Point(396, 82);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(41, 16);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email";
            // 
            // lbLahiosoite
            // 
            this.lbLahiosoite.AutoSize = true;
            this.lbLahiosoite.Location = new System.Drawing.Point(396, 52);
            this.lbLahiosoite.Name = "lbLahiosoite";
            this.lbLahiosoite.Size = new System.Drawing.Size(69, 16);
            this.lbLahiosoite.TabIndex = 2;
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
            this.lbEtunimi.TabIndex = 4;
            this.lbEtunimi.Text = "Etunimi";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(36, 79);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(82, 16);
            this.lb.TabIndex = 5;
            this.lb.Text = "Postinumero";
            // 
            // lbPuhelinnumero
            // 
            this.lbPuhelinnumero.AutoSize = true;
            this.lbPuhelinnumero.Location = new System.Drawing.Point(396, 117);
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
            this.tbAsiakasid.TabIndex = 7;
            // 
            // tbPuhelinnro
            // 
            this.tbPuhelinnro.Location = new System.Drawing.Point(516, 114);
            this.tbPuhelinnro.Name = "tbPuhelinnro";
            this.tbPuhelinnro.Size = new System.Drawing.Size(159, 22);
            this.tbPuhelinnro.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(516, 82);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(159, 22);
            this.tbEmail.TabIndex = 9;
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Location = new System.Drawing.Point(516, 52);
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(159, 22);
            this.tbLahiosoite.TabIndex = 10;
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Location = new System.Drawing.Point(176, 143);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(159, 22);
            this.tbSukunimi.TabIndex = 11;
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Location = new System.Drawing.Point(176, 111);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(159, 22);
            this.tbEtunimi.TabIndex = 12;
            // 
            // tbPostiNro
            // 
            this.tbPostiNro.Location = new System.Drawing.Point(176, 79);
            this.tbPostiNro.Name = "tbPostiNro";
            this.tbPostiNro.Size = new System.Drawing.Size(159, 22);
            this.tbPostiNro.TabIndex = 13;
            // 
            // dgvAsiakkaat
            // 
            this.dgvAsiakkaat.AutoGenerateColumns = false;
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
            this.dgvAsiakkaat.Location = new System.Drawing.Point(29, 269);
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.RowHeadersWidth = 51;
            this.dgvAsiakkaat.RowTemplate.Height = 24;
            this.dgvAsiakkaat.Size = new System.Drawing.Size(729, 176);
            this.dgvAsiakkaat.TabIndex = 14;
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            this.asiakasidDataGridViewTextBoxColumn.Width = 125;
            // 
            // postinroDataGridViewTextBoxColumn
            // 
            this.postinroDataGridViewTextBoxColumn.DataPropertyName = "postinro";
            this.postinroDataGridViewTextBoxColumn.HeaderText = "postinro";
            this.postinroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postinroDataGridViewTextBoxColumn.Name = "postinroDataGridViewTextBoxColumn";
            this.postinroDataGridViewTextBoxColumn.Width = 125;
            // 
            // etunimiDataGridViewTextBoxColumn
            // 
            this.etunimiDataGridViewTextBoxColumn.DataPropertyName = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.HeaderText = "etunimi";
            this.etunimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.etunimiDataGridViewTextBoxColumn.Name = "etunimiDataGridViewTextBoxColumn";
            this.etunimiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sukunimiDataGridViewTextBoxColumn
            // 
            this.sukunimiDataGridViewTextBoxColumn.DataPropertyName = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.HeaderText = "sukunimi";
            this.sukunimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sukunimiDataGridViewTextBoxColumn.Name = "sukunimiDataGridViewTextBoxColumn";
            this.sukunimiDataGridViewTextBoxColumn.Width = 125;
            // 
            // lahiosoiteDataGridViewTextBoxColumn
            // 
            this.lahiosoiteDataGridViewTextBoxColumn.DataPropertyName = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.HeaderText = "lahiosoite";
            this.lahiosoiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lahiosoiteDataGridViewTextBoxColumn.Name = "lahiosoiteDataGridViewTextBoxColumn";
            this.lahiosoiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // puhelinnroDataGridViewTextBoxColumn
            // 
            this.puhelinnroDataGridViewTextBoxColumn.DataPropertyName = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.HeaderText = "puhelinnro";
            this.puhelinnroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.puhelinnroDataGridViewTextBoxColumn.Name = "puhelinnroDataGridViewTextBoxColumn";
            this.puhelinnroDataGridViewTextBoxColumn.Width = 125;
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
            this.btnLisaa.UseVisualStyleBackColor = true;
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(211, 200);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(163, 45);
            this.btnMuokkaa.TabIndex = 16;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(380, 200);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(173, 45);
            this.btnPoista.TabIndex = 17;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            // 
            // dtpLoppu
            // 
            this.dtpLoppu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpLoppu.Location = new System.Drawing.Point(389, 456);
            this.dtpLoppu.Margin = new System.Windows.Forms.Padding(4);
            this.dtpLoppu.Name = "dtpLoppu";
            this.dtpLoppu.Size = new System.Drawing.Size(265, 22);
            this.dtpLoppu.TabIndex = 20;
            // 
            // lblViiva
            // 
            this.lblViiva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblViiva.AutoSize = true;
            this.lblViiva.Location = new System.Drawing.Point(367, 458);
            this.lblViiva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViiva.Name = "lblViiva";
            this.lblViiva.Size = new System.Drawing.Size(11, 16);
            this.lblViiva.TabIndex = 21;
            this.lblViiva.Text = "-";
            // 
            // dtpAlku
            // 
            this.dtpAlku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpAlku.Location = new System.Drawing.Point(93, 456);
            this.dtpAlku.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAlku.Name = "dtpAlku";
            this.dtpAlku.Size = new System.Drawing.Size(265, 22);
            this.dtpAlku.TabIndex = 18;
            // 
            // lblPaivat
            // 
            this.lblPaivat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPaivat.AutoSize = true;
            this.lblPaivat.Location = new System.Drawing.Point(30, 458);
            this.lblPaivat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaivat.Name = "lblPaivat";
            this.lblPaivat.Size = new System.Drawing.Size(51, 16);
            this.lblPaivat.TabIndex = 19;
            this.lblPaivat.Text = "Päiviltä";
            // 
            // btnHae
            // 
            this.btnHae.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHae.Location = new System.Drawing.Point(691, 452);
            this.btnHae.Margin = new System.Windows.Forms.Padding(4);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(67, 28);
            this.btnHae.TabIndex = 22;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // frmAsiakkaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.btnHae);
            this.Controls.Add(this.dtpLoppu);
            this.Controls.Add(this.lblViiva);
            this.Controls.Add(this.dtpAlku);
            this.Controls.Add(this.lblPaivat);
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
        private System.Windows.Forms.DateTimePicker dtpLoppu;
        private System.Windows.Forms.Label lblViiva;
        private System.Windows.Forms.DateTimePicker dtpAlku;
        private System.Windows.Forms.Label lblPaivat;
        private System.Windows.Forms.Button btnHae;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private DataSet1TableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postinroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sukunimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lahiosoiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puhelinnroDataGridViewTextBoxColumn;
    }
}