namespace R13_MokkiBook
{
    partial class frmVaraukset
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
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new R13_MokkiBook.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varausTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.varausTableAdapter();
            this.cmsVaraustaulunMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMuokkaa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVarauksenPalvelut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPoista = new System.Windows.Forms.ToolStripMenuItem();
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkimokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vahvistuspvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattualkupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattuloppupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            this.cmsVaraustaulunMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVaraukset.AutoGenerateColumns = false;
            this.dgvVaraukset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varausidDataGridViewTextBoxColumn,
            this.asiakasidDataGridViewTextBoxColumn,
            this.mokkimokkiidDataGridViewTextBoxColumn,
            this.varattupvmDataGridViewTextBoxColumn,
            this.vahvistuspvmDataGridViewTextBoxColumn,
            this.varattualkupvmDataGridViewTextBoxColumn,
            this.varattuloppupvmDataGridViewTextBoxColumn});
            this.dgvVaraukset.ContextMenuStrip = this.cmsVaraustaulunMenu;
            this.dgvVaraukset.DataSource = this.varausBindingSource;
            this.dgvVaraukset.Location = new System.Drawing.Point(2, 3);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.Size = new System.Drawing.Size(1282, 636);
            this.dgvVaraukset.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // varausTableAdapter
            // 
            this.varausTableAdapter.ClearBeforeFill = true;
            // 
            // cmsVaraustaulunMenu
            // 
            this.cmsVaraustaulunMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMuokkaa,
            this.tsmiVarauksenPalvelut,
            this.tsmiPoista});
            this.cmsVaraustaulunMenu.Name = "cmsVaraustaulunMenu";
            this.cmsVaraustaulunMenu.Size = new System.Drawing.Size(207, 70);
            // 
            // tsmiMuokkaa
            // 
            this.tsmiMuokkaa.Name = "tsmiMuokkaa";
            this.tsmiMuokkaa.Size = new System.Drawing.Size(206, 22);
            this.tsmiMuokkaa.Text = "Muokkaa varausta";
            // 
            // tsmiVarauksenPalvelut
            // 
            this.tsmiVarauksenPalvelut.Name = "tsmiVarauksenPalvelut";
            this.tsmiVarauksenPalvelut.Size = new System.Drawing.Size(206, 22);
            this.tsmiVarauksenPalvelut.Text = "Näytä varauksen palvelut";
            // 
            // tsmiPoista
            // 
            this.tsmiPoista.Name = "tsmiPoista";
            this.tsmiPoista.Size = new System.Drawing.Size(206, 22);
            this.tsmiPoista.Text = "Poista varaus";
            // 
            // varausidDataGridViewTextBoxColumn
            // 
            this.varausidDataGridViewTextBoxColumn.DataPropertyName = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.HeaderText = "Varaustunnus";
            this.varausidDataGridViewTextBoxColumn.Name = "varausidDataGridViewTextBoxColumn";
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "Asiakastunnus";
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            // 
            // mokkimokkiidDataGridViewTextBoxColumn
            // 
            this.mokkimokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_mokki_id";
            this.mokkimokkiidDataGridViewTextBoxColumn.HeaderText = "Mökki";
            this.mokkimokkiidDataGridViewTextBoxColumn.Name = "mokkimokkiidDataGridViewTextBoxColumn";
            // 
            // varattupvmDataGridViewTextBoxColumn
            // 
            this.varattupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_pvm";
            this.varattupvmDataGridViewTextBoxColumn.HeaderText = "Varaus tehty";
            this.varattupvmDataGridViewTextBoxColumn.Name = "varattupvmDataGridViewTextBoxColumn";
            // 
            // vahvistuspvmDataGridViewTextBoxColumn
            // 
            this.vahvistuspvmDataGridViewTextBoxColumn.DataPropertyName = "vahvistus_pvm";
            this.vahvistuspvmDataGridViewTextBoxColumn.HeaderText = "Varaus vahvistettu";
            this.vahvistuspvmDataGridViewTextBoxColumn.Name = "vahvistuspvmDataGridViewTextBoxColumn";
            // 
            // varattualkupvmDataGridViewTextBoxColumn
            // 
            this.varattualkupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_alkupvm";
            this.varattualkupvmDataGridViewTextBoxColumn.HeaderText = "Varauksen alkupävä";
            this.varattualkupvmDataGridViewTextBoxColumn.Name = "varattualkupvmDataGridViewTextBoxColumn";
            // 
            // varattuloppupvmDataGridViewTextBoxColumn
            // 
            this.varattuloppupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_loppupvm";
            this.varattuloppupvmDataGridViewTextBoxColumn.HeaderText = "Varauksen päättymispäivä";
            this.varattuloppupvmDataGridViewTextBoxColumn.Name = "varattuloppupvmDataGridViewTextBoxColumn";
            // 
            // frmVaraukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 678);
            this.Controls.Add(this.dgvVaraukset);
            this.Name = "frmVaraukset";
            this.Text = "Varaukset";
            this.Load += new System.EventHandler(this.frmVaraukset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            this.cmsVaraustaulunMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVaraukset;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private DataSet1TableAdapters.varausTableAdapter varausTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkimokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahvistuspvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattualkupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattuloppupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cmsVaraustaulunMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiMuokkaa;
        private System.Windows.Forms.ToolStripMenuItem tsmiVarauksenPalvelut;
        private System.Windows.Forms.ToolStripMenuItem tsmiPoista;
    }
}