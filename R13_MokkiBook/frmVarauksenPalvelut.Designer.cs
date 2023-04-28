namespace R13_MokkiBook
{
    partial class frmVarauksenPalvelut
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
            this.dgvVarauksenPalvelut = new System.Windows.Forms.DataGridView();
            this.varauksenpalvelutBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.varauksenPAlvelutDataSet = new R13_MokkiBook.VarauksenPAlvelutDataSet();
            this.varauksenpalvelutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new R13_MokkiBook.DataSet1();
            this.varauksen_palvelutTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.varauksen_palvelutTableAdapter();
            this.pnlToiminnot = new System.Windows.Forms.Panel();
            this.btnLisaaValittu = new System.Windows.Forms.Button();
            this.cbPalvelu = new System.Windows.Forms.ComboBox();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnLisaaUusi = new System.Windows.Forms.Button();
            this.epVarauksenPalvelut = new System.Windows.Forms.ErrorProvider(this.components);
            this.palveluTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.palveluTableAdapter();
            this.varauksen_palvelutTableAdapter1 = new R13_MokkiBook.VarauksenPAlvelutDataSetTableAdapters.varauksen_palvelutTableAdapter();
            this.varauksenPAlvelutDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varauksenpalvelutBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenPAlvelutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.pnlToiminnot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epVarauksenPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenPAlvelutDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVarauksenPalvelut
            // 
            this.dgvVarauksenPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVarauksenPalvelut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVarauksenPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarauksenPalvelut.Location = new System.Drawing.Point(2, 1);
            this.dgvVarauksenPalvelut.Name = "dgvVarauksenPalvelut";
            this.dgvVarauksenPalvelut.Size = new System.Drawing.Size(527, 269);
            this.dgvVarauksenPalvelut.TabIndex = 0;
            this.dgvVarauksenPalvelut.SelectionChanged += new System.EventHandler(this.dgvVarauksenPalvelut_SelectionChanged);
            // 
            // varauksenpalvelutBindingSource1
            // 
            this.varauksenpalvelutBindingSource1.DataMember = "varauksen_palvelut";
            this.varauksenpalvelutBindingSource1.DataSource = this.varauksenPAlvelutDataSet;
            // 
            // varauksenPAlvelutDataSet
            // 
            this.varauksenPAlvelutDataSet.DataSetName = "VarauksenPAlvelutDataSet";
            this.varauksenPAlvelutDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // varauksenpalvelutBindingSource
            // 
            this.varauksenpalvelutBindingSource.DataMember = "varauksen_palvelut";
            this.varauksenpalvelutBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // varauksen_palvelutTableAdapter
            // 
            this.varauksen_palvelutTableAdapter.ClearBeforeFill = true;
            // 
            // pnlToiminnot
            // 
            this.pnlToiminnot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlToiminnot.Controls.Add(this.btnLisaaValittu);
            this.pnlToiminnot.Controls.Add(this.cbPalvelu);
            this.pnlToiminnot.Controls.Add(this.btnPoista);
            this.pnlToiminnot.Controls.Add(this.btnLisaaUusi);
            this.pnlToiminnot.Location = new System.Drawing.Point(2, 269);
            this.pnlToiminnot.Name = "pnlToiminnot";
            this.pnlToiminnot.Size = new System.Drawing.Size(526, 40);
            this.pnlToiminnot.TabIndex = 1;
            // 
            // btnLisaaValittu
            // 
            this.btnLisaaValittu.Location = new System.Drawing.Point(315, 7);
            this.btnLisaaValittu.Name = "btnLisaaValittu";
            this.btnLisaaValittu.Size = new System.Drawing.Size(75, 23);
            this.btnLisaaValittu.TabIndex = 3;
            this.btnLisaaValittu.Text = "Lisää valittu";
            this.btnLisaaValittu.UseVisualStyleBackColor = true;
            this.btnLisaaValittu.Click += new System.EventHandler(this.btnLisaaValittu_Click);
            // 
            // cbPalvelu
            // 
            this.cbPalvelu.FormattingEnabled = true;
            this.cbPalvelu.Location = new System.Drawing.Point(188, 9);
            this.cbPalvelu.Name = "cbPalvelu";
            this.cbPalvelu.Size = new System.Drawing.Size(121, 21);
            this.cbPalvelu.TabIndex = 2;
            this.cbPalvelu.SelectedIndexChanged += new System.EventHandler(this.cbPalvelu_SelectedIndexChanged);
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataMember = "palvelu";
            this.palveluBindingSource.DataSource = this.dataSet1;
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(10, 7);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(75, 23);
            this.btnPoista.TabIndex = 1;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnLisaaUusi
            // 
            this.btnLisaaUusi.Location = new System.Drawing.Point(441, 7);
            this.btnLisaaUusi.Name = "btnLisaaUusi";
            this.btnLisaaUusi.Size = new System.Drawing.Size(75, 23);
            this.btnLisaaUusi.TabIndex = 4;
            this.btnLisaaUusi.Text = "Lisää uusi";
            this.btnLisaaUusi.UseVisualStyleBackColor = true;
            this.btnLisaaUusi.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // epVarauksenPalvelut
            // 
            this.epVarauksenPalvelut.ContainerControl = this;
            // 
            // palveluTableAdapter
            // 
            this.palveluTableAdapter.ClearBeforeFill = true;
            // 
            // varauksen_palvelutTableAdapter1
            // 
            this.varauksen_palvelutTableAdapter1.ClearBeforeFill = true;
            // 
            // varauksenPAlvelutDataSetBindingSource
            // 
            this.varauksenPAlvelutDataSetBindingSource.DataSource = this.varauksenPAlvelutDataSet;
            this.varauksenPAlvelutDataSetBindingSource.Position = 0;
            // 
            // varauksenpalvelutBindingSource2
            // 
            this.varauksenpalvelutBindingSource2.DataMember = "varauksen_palvelut";
            this.varauksenpalvelutBindingSource2.DataSource = this.varauksenPAlvelutDataSetBindingSource;
            // 
            // frmVarauksenPalvelut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 310);
            this.Controls.Add(this.pnlToiminnot);
            this.Controls.Add(this.dgvVarauksenPalvelut);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(546, 349);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(546, 349);
            this.Name = "frmVarauksenPalvelut";
            this.Text = "Varauksen palvelut";
            this.Load += new System.EventHandler(this.frmVarauksenPalvelut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenPAlvelutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.pnlToiminnot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epVarauksenPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenPAlvelutDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVarauksenPalvelut;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource varauksenpalvelutBindingSource;
        private DataSet1TableAdapters.varauksen_palvelutTableAdapter varauksen_palvelutTableAdapter;
        private System.Windows.Forms.Panel pnlToiminnot;
        private System.Windows.Forms.ErrorProvider epVarauksenPalvelut;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnLisaaUusi;
        private System.Windows.Forms.Button btnLisaaValittu;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private DataSet1TableAdapters.palveluTableAdapter palveluTableAdapter;
        private System.Windows.Forms.ComboBox cbPalvelu;
        private VarauksenPAlvelutDataSet varauksenPAlvelutDataSet;
        private System.Windows.Forms.BindingSource varauksenpalvelutBindingSource1;
        private VarauksenPAlvelutDataSetTableAdapters.varauksen_palvelutTableAdapter varauksen_palvelutTableAdapter1;
        private System.Windows.Forms.BindingSource varauksenPAlvelutDataSetBindingSource;
        private System.Windows.Forms.BindingSource varauksenpalvelutBindingSource2;
    }
}