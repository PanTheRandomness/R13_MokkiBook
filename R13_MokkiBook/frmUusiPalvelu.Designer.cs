
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
            this.palveluidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyyppiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuvausDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.fillBy2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnPoista = new System.Windows.Forms.Button();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palveluTableAdapter1 = new R13_MokkiBook.DataSet1TableAdapters.palveluTableAdapter();
            this.dataSet11 = new R13_MokkiBook.DataSet1();
            this.AlueenPAlvelutDataSet = new R13_MokkiBook.DataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPalveluID = new System.Windows.Forms.TextBox();
            this.palveluBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource1)).BeginInit();
            this.fillBy2ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlueenPAlvelutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNimi
            // 
            this.txtNimi.Location = new System.Drawing.Point(235, 87);
            this.txtNimi.Name = "txtNimi";
            this.txtNimi.Size = new System.Drawing.Size(100, 20);
            this.txtNimi.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(583, 111);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(84, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Lisää palvelu";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.palveluidDataGridViewTextBoxColumn,
            this.alueidDataGridViewTextBoxColumn,
            this.nimiDataGridViewTextBoxColumn,
            this.tyyppiDataGridViewTextBoxColumn,
            this.kuvausDataGridViewTextBoxColumn,
            this.hintaDataGridViewTextBoxColumn,
            this.alvDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.palveluBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(3, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(862, 368);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // palveluidDataGridViewTextBoxColumn
            // 
            this.palveluidDataGridViewTextBoxColumn.DataPropertyName = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.HeaderText = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.Name = "palveluidDataGridViewTextBoxColumn";
            // 
            // alueidDataGridViewTextBoxColumn
            // 
            this.alueidDataGridViewTextBoxColumn.DataPropertyName = "alue_id";
            this.alueidDataGridViewTextBoxColumn.HeaderText = "alue_id";
            this.alueidDataGridViewTextBoxColumn.Name = "alueidDataGridViewTextBoxColumn";
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "nimi";
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            // 
            // tyyppiDataGridViewTextBoxColumn
            // 
            this.tyyppiDataGridViewTextBoxColumn.DataPropertyName = "tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.HeaderText = "tyyppi";
            this.tyyppiDataGridViewTextBoxColumn.Name = "tyyppiDataGridViewTextBoxColumn";
            // 
            // kuvausDataGridViewTextBoxColumn
            // 
            this.kuvausDataGridViewTextBoxColumn.DataPropertyName = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.HeaderText = "kuvaus";
            this.kuvausDataGridViewTextBoxColumn.Name = "kuvausDataGridViewTextBoxColumn";
            // 
            // hintaDataGridViewTextBoxColumn
            // 
            this.hintaDataGridViewTextBoxColumn.DataPropertyName = "hinta";
            this.hintaDataGridViewTextBoxColumn.HeaderText = "hinta";
            this.hintaDataGridViewTextBoxColumn.Name = "hintaDataGridViewTextBoxColumn";
            // 
            // alvDataGridViewTextBoxColumn
            // 
            this.alvDataGridViewTextBoxColumn.DataPropertyName = "alv";
            this.alvDataGridViewTextBoxColumn.HeaderText = "alv";
            this.alvDataGridViewTextBoxColumn.Name = "alvDataGridViewTextBoxColumn";
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
            this.lbNimi.Location = new System.Drawing.Point(232, 71);
            this.lbNimi.Name = "lbNimi";
            this.lbNimi.Size = new System.Drawing.Size(27, 13);
            this.lbNimi.TabIndex = 4;
            this.lbNimi.Text = "Nimi";
            this.lbNimi.Click += new System.EventHandler(this.lbNimi_Click);
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
            this.lbHinta.Location = new System.Drawing.Point(358, 113);
            this.lbHinta.Name = "lbHinta";
            this.lbHinta.Size = new System.Drawing.Size(32, 13);
            this.lbHinta.TabIndex = 10;
            this.lbHinta.Text = "Hinta";
            // 
            // txtHinta
            // 
            this.txtHinta.Location = new System.Drawing.Point(361, 127);
            this.txtHinta.Name = "txtHinta";
            this.txtHinta.Size = new System.Drawing.Size(100, 20);
            this.txtHinta.TabIndex = 6;
            // 
            // lbKuvaus
            // 
            this.lbKuvaus.AutoSize = true;
            this.lbKuvaus.Location = new System.Drawing.Point(358, 73);
            this.lbKuvaus.Name = "lbKuvaus";
            this.lbKuvaus.Size = new System.Drawing.Size(43, 13);
            this.lbKuvaus.TabIndex = 8;
            this.lbKuvaus.Text = "Kuvaus";
            // 
            // txtKuvaus
            // 
            this.txtKuvaus.Location = new System.Drawing.Point(361, 87);
            this.txtKuvaus.Name = "txtKuvaus";
            this.txtKuvaus.Size = new System.Drawing.Size(100, 20);
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
            this.lbAlv.Click += new System.EventHandler(this.lbAlv_Click);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.btnPaivita.Location = new System.Drawing.Point(583, 82);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(84, 23);
            this.btnPaivita.TabIndex = 8;
            this.btnPaivita.Text = "Päivitä";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // fillBy2ToolStrip
            // 
            this.fillBy2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy2ToolStripButton});
            this.fillBy2ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy2ToolStrip.Name = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Size = new System.Drawing.Size(865, 25);
            this.fillBy2ToolStrip.TabIndex = 17;
            this.fillBy2ToolStrip.Text = "fillBy2ToolStrip";
            // 
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fillBy2ToolStripButton.Text = "Päivitä";
            this.fillBy2ToolStripButton.Click += new System.EventHandler(this.fillBy2ToolStripButton_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(583, 140);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(84, 23);
            this.btnPoista.TabIndex = 10;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataMember = "palvelu";
            this.palveluBindingSource.DataSource = this.dataSet1;
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
            this.label2.TabIndex = 20;
            this.label2.Text = "Palvelu_id";
            // 
            // txtPalveluID
            // 
            this.txtPalveluID.Location = new System.Drawing.Point(103, 87);
            this.txtPalveluID.Name = "txtPalveluID";
            this.txtPalveluID.Size = new System.Drawing.Size(100, 20);
            this.txtPalveluID.TabIndex = 1;
            // 
            // palveluBindingSource2
            // 
            this.palveluBindingSource2.DataMember = "palvelu";
            this.palveluBindingSource2.DataSource = this.dataSet1;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // frmUusiPalvelu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPalveluID);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.fillBy2ToolStrip);
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
            this.fillBy2ToolStrip.ResumeLayout(false);
            this.fillBy2ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlueenPAlvelutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNimi;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource palveluBindingSource;
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
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;
        private System.Windows.Forms.Button btnPoista;
        private DataSet1 dataSet11;
        private DataSet1 AlueenPAlvelutDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPalveluID;
        private System.Windows.Forms.BindingSource palveluBindingSource2;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn palveluidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyyppiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuvausDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hintaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alvDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource palveluBindingSource3;
    }
}