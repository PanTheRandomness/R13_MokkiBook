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
            this.dataSet1 = new R13_MokkiBook.DataSet1();
            this.varauksenpalvelutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varauksen_palvelutTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.varauksen_palvelutTableAdapter();
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lkmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlToiminnot = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVarauksenPalvelut
            // 
            this.dgvVarauksenPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVarauksenPalvelut.AutoGenerateColumns = false;
            this.dgvVarauksenPalvelut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVarauksenPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarauksenPalvelut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varausidDataGridViewTextBoxColumn,
            this.palveluidDataGridViewTextBoxColumn,
            this.lkmDataGridViewTextBoxColumn});
            this.dgvVarauksenPalvelut.DataSource = this.varauksenpalvelutBindingSource;
            this.dgvVarauksenPalvelut.Location = new System.Drawing.Point(2, 1);
            this.dgvVarauksenPalvelut.Name = "dgvVarauksenPalvelut";
            this.dgvVarauksenPalvelut.Size = new System.Drawing.Size(527, 269);
            this.dgvVarauksenPalvelut.TabIndex = 0;
            this.dgvVarauksenPalvelut.SelectionChanged += new System.EventHandler(this.dgvVarauksenPalvelut_SelectionChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // varauksenpalvelutBindingSource
            // 
            this.varauksenpalvelutBindingSource.DataMember = "varauksen_palvelut";
            this.varauksenpalvelutBindingSource.DataSource = this.dataSet1;
            // 
            // varauksen_palvelutTableAdapter
            // 
            this.varauksen_palvelutTableAdapter.ClearBeforeFill = true;
            // 
            // varausidDataGridViewTextBoxColumn
            // 
            this.varausidDataGridViewTextBoxColumn.DataPropertyName = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.HeaderText = "Varaustunnus";
            this.varausidDataGridViewTextBoxColumn.Name = "varausidDataGridViewTextBoxColumn";
            // 
            // palveluidDataGridViewTextBoxColumn
            // 
            this.palveluidDataGridViewTextBoxColumn.DataPropertyName = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.HeaderText = "Palvelutunnus";
            this.palveluidDataGridViewTextBoxColumn.Name = "palveluidDataGridViewTextBoxColumn";
            // 
            // lkmDataGridViewTextBoxColumn
            // 
            this.lkmDataGridViewTextBoxColumn.DataPropertyName = "lkm";
            this.lkmDataGridViewTextBoxColumn.HeaderText = "lkm";
            this.lkmDataGridViewTextBoxColumn.Name = "lkmDataGridViewTextBoxColumn";
            // 
            // pnlToiminnot
            // 
            this.pnlToiminnot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlToiminnot.Location = new System.Drawing.Point(2, 269);
            this.pnlToiminnot.Name = "pnlToiminnot";
            this.pnlToiminnot.Size = new System.Drawing.Size(526, 40);
            this.pnlToiminnot.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVarauksenPalvelut;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource varauksenpalvelutBindingSource;
        private DataSet1TableAdapters.varauksen_palvelutTableAdapter varauksen_palvelutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn palveluidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lkmDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pnlToiminnot;
    }
}