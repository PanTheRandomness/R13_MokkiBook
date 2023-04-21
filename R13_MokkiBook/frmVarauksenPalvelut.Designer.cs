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
            this.pnlToiminnot = new System.Windows.Forms.Panel();
            this.dgvVarauksenPalvelut = new System.Windows.Forms.DataGridView();
            this.varauksetData = new R13_MokkiBook.VarauksetData();
            this.varauksenpalvelutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varauksen_palvelutTableAdapter = new R13_MokkiBook.VarauksetDataTableAdapters.varauksen_palvelutTableAdapter();
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palveluidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lkmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlToiminnot
            // 
            this.pnlToiminnot.Location = new System.Drawing.Point(1, 409);
            this.pnlToiminnot.Name = "pnlToiminnot";
            this.pnlToiminnot.Size = new System.Drawing.Size(799, 40);
            this.pnlToiminnot.TabIndex = 0;
            // 
            // dgvVarauksenPalvelut
            // 
            this.dgvVarauksenPalvelut.AutoGenerateColumns = false;
            this.dgvVarauksenPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarauksenPalvelut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varausidDataGridViewTextBoxColumn,
            this.palveluidDataGridViewTextBoxColumn,
            this.lkmDataGridViewTextBoxColumn});
            this.dgvVarauksenPalvelut.DataSource = this.varauksenpalvelutBindingSource;
            this.dgvVarauksenPalvelut.Location = new System.Drawing.Point(2, 1);
            this.dgvVarauksenPalvelut.Name = "dgvVarauksenPalvelut";
            this.dgvVarauksenPalvelut.Size = new System.Drawing.Size(797, 408);
            this.dgvVarauksenPalvelut.TabIndex = 1;
            // 
            // varauksetData
            // 
            this.varauksetData.DataSetName = "VarauksetData";
            this.varauksetData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // varauksenpalvelutBindingSource
            // 
            this.varauksenpalvelutBindingSource.DataMember = "varauksen_palvelut";
            this.varauksenpalvelutBindingSource.DataSource = this.varauksetData;
            // 
            // varauksen_palvelutTableAdapter
            // 
            this.varauksen_palvelutTableAdapter.ClearBeforeFill = true;
            // 
            // varausidDataGridViewTextBoxColumn
            // 
            this.varausidDataGridViewTextBoxColumn.DataPropertyName = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.HeaderText = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.Name = "varausidDataGridViewTextBoxColumn";
            // 
            // palveluidDataGridViewTextBoxColumn
            // 
            this.palveluidDataGridViewTextBoxColumn.DataPropertyName = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.HeaderText = "palvelu_id";
            this.palveluidDataGridViewTextBoxColumn.Name = "palveluidDataGridViewTextBoxColumn";
            // 
            // lkmDataGridViewTextBoxColumn
            // 
            this.lkmDataGridViewTextBoxColumn.DataPropertyName = "lkm";
            this.lkmDataGridViewTextBoxColumn.HeaderText = "lkm";
            this.lkmDataGridViewTextBoxColumn.Name = "lkmDataGridViewTextBoxColumn";
            // 
            // frmVarauksenPalvelut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVarauksenPalvelut);
            this.Controls.Add(this.pnlToiminnot);
            this.Name = "frmVarauksenPalvelut";
            this.Text = "Varauksen palvelut";
            this.Load += new System.EventHandler(this.frmVarauksenPalvelut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToiminnot;
        private System.Windows.Forms.DataGridView dgvVarauksenPalvelut;
        private VarauksetData varauksetData;
        private System.Windows.Forms.BindingSource varauksenpalvelutBindingSource;
        private VarauksetDataTableAdapters.varauksen_palvelutTableAdapter varauksen_palvelutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn palveluidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lkmDataGridViewTextBoxColumn;
    }
}