
namespace R13_MokkiBook
{
    partial class frmUusiPalvelu
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
            this.txtNimi = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.palvelu_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alue_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyyppi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvaus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new R13_MokkiBook.DataSet1();
            this.palveluBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbNimi = new System.Windows.Forms.Label();
            this.lbTyyppi = new System.Windows.Forms.Label();
            this.txtTyyppi = new System.Windows.Forms.TextBox();
            this.lbHinta = new System.Windows.Forms.Label();
            this.txtHinta = new System.Windows.Forms.TextBox();
            this.lbKuvaus = new System.Windows.Forms.Label();
            this.txtKuvaus = new System.Windows.Forms.TextBox();
            this.lbAlv = new System.Windows.Forms.Label();
            this.txtAlv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAlueID = new System.Windows.Forms.Label();
            this.txtAlueID = new System.Windows.Forms.TextBox();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.palveluTableAdapter1 = new R13_MokkiBook.DataSet1TableAdapters.palveluTableAdapter();
            this.dataSet11 = new R13_MokkiBook.DataSet1();
            this.AlueenPAlvelutDataSet = new R13_MokkiBook.DataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPalveluID = new System.Windows.Forms.TextBox();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTyhjenna = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsLbHae = new System.Windows.Forms.ToolStripLabel();
            this.tsTxtHae = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlueenPAlvelutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNimi
            // 
            this.txtNimi.Location = new System.Drawing.Point(235, 71);
            this.txtNimi.Multiline = true;
            this.txtNimi.Name = "txtNimi";
            this.txtNimi.Size = new System.Drawing.Size(100, 36);
            this.txtNimi.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(583, 114);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(84, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Lisää palvelu";
            this.ToolTip.SetToolTip(this.saveButton, "Lisää uusi palvelu tietokantaan");
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palvelu_id,
            this.alue_id,
            this.nimi,
            this.tyyppi,
            this.kuvaus,
            this.hinta,
            this.alv});
            this.dataGridView1.DataSource = this.palveluBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(3, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(862, 368);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // palvelu_id
            // 
            this.palvelu_id.DataPropertyName = "palvelu_id";
            this.palvelu_id.HeaderText = "palvelu_id";
            this.palvelu_id.Name = "palvelu_id";
            this.palvelu_id.ReadOnly = true;
            // 
            // alue_id
            // 
            this.alue_id.DataPropertyName = "alue_id";
            this.alue_id.HeaderText = "alue_id";
            this.alue_id.Name = "alue_id";
            this.alue_id.ReadOnly = true;
            // 
            // nimi
            // 
            this.nimi.DataPropertyName = "nimi";
            this.nimi.HeaderText = "nimi";
            this.nimi.Name = "nimi";
            this.nimi.ReadOnly = true;
            // 
            // tyyppi
            // 
            this.tyyppi.DataPropertyName = "tyyppi";
            this.tyyppi.HeaderText = "tyyppi";
            this.tyyppi.Name = "tyyppi";
            this.tyyppi.ReadOnly = true;
            // 
            // kuvaus
            // 
            this.kuvaus.DataPropertyName = "kuvaus";
            this.kuvaus.HeaderText = "kuvaus";
            this.kuvaus.Name = "kuvaus";
            this.kuvaus.ReadOnly = true;
            // 
            // hinta
            // 
            this.hinta.DataPropertyName = "hinta";
            this.hinta.HeaderText = "hinta";
            this.hinta.Name = "hinta";
            this.hinta.ReadOnly = true;
            // 
            // alv
            // 
            this.alv.DataPropertyName = "alv";
            this.alv.HeaderText = "alv";
            this.alv.Name = "alv";
            this.alv.ReadOnly = true;
            // 
            // palveluBindingSource3
            // 
            this.palveluBindingSource3.DataMember = "palvelu";
            this.palveluBindingSource3.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // palveluBindingSource1
            // 
            this.palveluBindingSource1.DataMember = "palvelu";
            this.palveluBindingSource1.DataSource = this.dataSet1;
            // 
            // lbNimi
            // 
            this.lbNimi.AutoSize = true;
            this.lbNimi.Location = new System.Drawing.Point(232, 55);
            this.lbNimi.Name = "lbNimi";
            this.lbNimi.Size = new System.Drawing.Size(27, 13);
            this.lbNimi.TabIndex = 4;
            this.lbNimi.Text = "Nimi";
            // 
            // lbTyyppi
            // 
            this.lbTyyppi.AutoSize = true;
            this.lbTyyppi.Location = new System.Drawing.Point(232, 110);
            this.lbTyyppi.Name = "lbTyyppi";
            this.lbTyyppi.Size = new System.Drawing.Size(38, 13);
            this.lbTyyppi.TabIndex = 6;
            this.lbTyyppi.Text = "Tyyppi";
            // 
            // txtTyyppi
            // 
            this.txtTyyppi.Location = new System.Drawing.Point(235, 124);
            this.txtTyyppi.Name = "txtTyyppi";
            this.txtTyyppi.Size = new System.Drawing.Size(100, 20);
            this.txtTyyppi.TabIndex = 4;
            // 
            // lbHinta
            // 
            this.lbHinta.AutoSize = true;
            this.lbHinta.Location = new System.Drawing.Point(358, 110);
            this.lbHinta.Name = "lbHinta";
            this.lbHinta.Size = new System.Drawing.Size(32, 13);
            this.lbHinta.TabIndex = 10;
            this.lbHinta.Text = "Hinta";
            // 
            // txtHinta
            // 
            this.txtHinta.Location = new System.Drawing.Point(361, 124);
            this.txtHinta.Name = "txtHinta";
            this.txtHinta.Size = new System.Drawing.Size(100, 20);
            this.txtHinta.TabIndex = 6;
            // 
            // lbKuvaus
            // 
            this.lbKuvaus.AutoSize = true;
            this.lbKuvaus.Location = new System.Drawing.Point(358, 57);
            this.lbKuvaus.Name = "lbKuvaus";
            this.lbKuvaus.Size = new System.Drawing.Size(43, 13);
            this.lbKuvaus.TabIndex = 8;
            this.lbKuvaus.Text = "Kuvaus";
            // 
            // txtKuvaus
            // 
            this.txtKuvaus.Location = new System.Drawing.Point(361, 71);
            this.txtKuvaus.Multiline = true;
            this.txtKuvaus.Name = "txtKuvaus";
            this.txtKuvaus.Size = new System.Drawing.Size(100, 36);
            this.txtKuvaus.TabIndex = 5;
            // 
            // lbAlv
            // 
            this.lbAlv.AutoSize = true;
            this.lbAlv.Location = new System.Drawing.Point(474, 71);
            this.lbAlv.Name = "lbAlv";
            this.lbAlv.Size = new System.Drawing.Size(22, 13);
            this.lbAlv.TabIndex = 12;
            this.lbAlv.Text = "Alv";
            // 
            // txtAlv
            // 
            this.txtAlv.Location = new System.Drawing.Point(477, 85);
            this.txtAlv.Name = "txtAlv";
            this.txtAlv.Size = new System.Drawing.Size(100, 20);
            this.txtAlv.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(317, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Muokkaa palveluita";
            // 
            // lbAlueID
            // 
            this.lbAlueID.AutoSize = true;
            this.lbAlueID.Location = new System.Drawing.Point(100, 110);
            this.lbAlueID.Name = "lbAlueID";
            this.lbAlueID.Size = new System.Drawing.Size(42, 13);
            this.lbAlueID.TabIndex = 15;
            this.lbAlueID.Text = "Alue_id";
            // 
            // txtAlueID
            // 
            this.txtAlueID.Location = new System.Drawing.Point(103, 124);
            this.txtAlueID.Name = "txtAlueID";
            this.txtAlueID.Size = new System.Drawing.Size(100, 20);
            this.txtAlueID.TabIndex = 2;
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(583, 85);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(84, 23);
            this.btnPaivita.TabIndex = 8;
            this.btnPaivita.Text = "Tallenna muutos";
            this.ToolTip.SetToolTip(this.btnPaivita, "Tallenna muutos");
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(673, 85);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(84, 23);
            this.btnPoista.TabIndex = 10;
            this.btnPoista.Text = "Poista";
            this.ToolTip.SetToolTip(this.btnPoista, "Poista tietokannasta");
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // palveluTableAdapter1
            // 
            this.palveluTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AlueenPAlvelutDataSet
            // 
            this.AlueenPAlvelutDataSet.DataSetName = "DataSet1";
            this.AlueenPAlvelutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Palvelu_id";
            // 
            // txtPalveluID
            // 
            this.txtPalveluID.Location = new System.Drawing.Point(103, 87);
            this.txtPalveluID.Name = "txtPalveluID";
            this.txtPalveluID.Size = new System.Drawing.Size(100, 20);
            this.txtPalveluID.TabIndex = 1;
            this.ToolTip.SetToolTip(this.txtPalveluID, "Hei!");
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.Location = new System.Drawing.Point(673, 113);
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.Size = new System.Drawing.Size(84, 23);
            this.btnTyhjenna.TabIndex = 11;
            this.btnTyhjenna.Text = "Tyhjennä rivit";
            this.ToolTip.SetToolTip(this.btnTyhjenna, "Tyhjennä muokkaus rivit");
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.Click += new System.EventHandler(this.btnTyhjenna_Click);
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.ReshowDelay = 100;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLbHae,
            this.tsTxtHae});
            this.toolStrip1.Location = new System.Drawing.Point(0, 520);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(865, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsLbHae
            // 
            this.tsLbHae.Name = "tsLbHae";
            this.tsLbHae.Size = new System.Drawing.Size(87, 22);
            this.tsLbHae.Text = "Hae palvelu_id:";
            // 
            // tsTxtHae
            // 
            this.tsTxtHae.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsTxtHae.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTxtHae.Name = "tsTxtHae";
            this.tsTxtHae.Size = new System.Drawing.Size(100, 25);
            this.tsTxtHae.TextChanged += new System.EventHandler(this.tsTxtHae_TextChanged);
            // 
            // frmUusiPalvelu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 545);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnTyhjenna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPalveluID);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.lbAlueID);
            this.Controls.Add(this.txtAlueID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAlv);
            this.Controls.Add(this.txtAlv);
            this.Controls.Add(this.lbHinta);
            this.Controls.Add(this.txtHinta);
            this.Controls.Add(this.lbKuvaus);
            this.Controls.Add(this.txtKuvaus);
            this.Controls.Add(this.lbTyyppi);
            this.Controls.Add(this.txtTyyppi);
            this.Controls.Add(this.lbNimi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.txtNimi);
            this.Name = "frmUusiPalvelu";
            this.Text = "Muokkaa palveluita";
            this.Load += new System.EventHandler(this.frmUusiPalvelu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlueenPAlvelutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNimi;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.palveluTableAdapter palveluTableAdapter1;
        private System.Windows.Forms.Label lbNimi;
        private System.Windows.Forms.Label lbTyyppi;
        private System.Windows.Forms.TextBox txtTyyppi;
        private System.Windows.Forms.Label lbHinta;
        private System.Windows.Forms.TextBox txtHinta;
        private System.Windows.Forms.Label lbKuvaus;
        private System.Windows.Forms.TextBox txtKuvaus;
        private System.Windows.Forms.Label lbAlv;
        private System.Windows.Forms.TextBox txtAlv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource palveluBindingSource1;
        private System.Windows.Forms.Label lbAlueID;
        private System.Windows.Forms.TextBox txtAlueID;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.Button btnPoista;
        private DataSet1 dataSet11;
        private DataSet1 AlueenPAlvelutDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPalveluID;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource palveluBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn palvelu_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn alue_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyyppi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvaus;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinta;
        private System.Windows.Forms.DataGridViewTextBoxColumn alv;
        private System.Windows.Forms.Button btnTyhjenna;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsLbHae;
        private System.Windows.Forms.ToolStripTextBox tsTxtHae;
    }
}