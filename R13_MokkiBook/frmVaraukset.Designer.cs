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
            this.pnlAlapaneeli = new System.Windows.Forms.Panel();
            this.dgvVaraukset = new System.Windows.Forms.DataGridView();
            this.dataVaraukset = new R13_MokkiBook.VarauksetData();
            this.tamTauluAdapteriManageri = new R13_MokkiBook.VarauksetDataTableAdapters.TableAdapterManager();
            this.taVarauksenPalvelut = new R13_MokkiBook.VarauksetDataTableAdapters.varauksen_palvelutTableAdapter();
            this.taVaraus = new R13_MokkiBook.VarauksetDataTableAdapters.varausTableAdapter();
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asiakasidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokkimokkiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vahvistuspvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattualkupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varattuloppupvmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVaraukset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAlapaneeli
            // 
            this.pnlAlapaneeli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAlapaneeli.Location = new System.Drawing.Point(0, 620);
            this.pnlAlapaneeli.Name = "pnlAlapaneeli";
            this.pnlAlapaneeli.Size = new System.Drawing.Size(1274, 42);
            this.pnlAlapaneeli.TabIndex = 0;
            // 
            // dgvVaraukset
            // 
            this.dgvVaraukset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVaraukset.AutoGenerateColumns = false;
            this.dgvVaraukset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraukset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.varausidDataGridViewTextBoxColumn,
            this.asiakasidDataGridViewTextBoxColumn,
            this.mokkimokkiidDataGridViewTextBoxColumn,
            this.varattupvmDataGridViewTextBoxColumn,
            this.vahvistuspvmDataGridViewTextBoxColumn,
            this.varattualkupvmDataGridViewTextBoxColumn,
            this.varattuloppupvmDataGridViewTextBoxColumn});
            this.dgvVaraukset.DataSource = this.varausBindingSource;
            this.dgvVaraukset.Location = new System.Drawing.Point(0, 1);
            this.dgvVaraukset.Name = "dgvVaraukset";
            this.dgvVaraukset.Size = new System.Drawing.Size(1273, 619);
            this.dgvVaraukset.TabIndex = 1;
            this.dgvVaraukset.SelectionChanged += new System.EventHandler(this.dgvVaraukset_SelectionChanged);
            // 
            // dataVaraukset
            // 
            this.dataVaraukset.DataSetName = "VarauksetData";
            this.dataVaraukset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tamTauluAdapteriManageri
            // 
            this.tamTauluAdapteriManageri.BackupDataSetBeforeUpdate = true;
            this.tamTauluAdapteriManageri.UpdateOrder = R13_MokkiBook.VarauksetDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tamTauluAdapteriManageri.varauksen_palvelutTableAdapter = this.taVarauksenPalvelut;
            this.tamTauluAdapteriManageri.varausTableAdapter = this.taVaraus;
            // 
            // taVarauksenPalvelut
            // 
            this.taVarauksenPalvelut.ClearBeforeFill = true;
            // 
            // taVaraus
            // 
            this.taVaraus.ClearBeforeFill = true;
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.dataVaraukset;
            // 
            // varausidDataGridViewTextBoxColumn
            // 
            this.varausidDataGridViewTextBoxColumn.DataPropertyName = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.HeaderText = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.Name = "varausidDataGridViewTextBoxColumn";
            // 
            // asiakasidDataGridViewTextBoxColumn
            // 
            this.asiakasidDataGridViewTextBoxColumn.DataPropertyName = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.HeaderText = "asiakas_id";
            this.asiakasidDataGridViewTextBoxColumn.Name = "asiakasidDataGridViewTextBoxColumn";
            // 
            // mokkimokkiidDataGridViewTextBoxColumn
            // 
            this.mokkimokkiidDataGridViewTextBoxColumn.DataPropertyName = "mokki_mokki_id";
            this.mokkimokkiidDataGridViewTextBoxColumn.HeaderText = "mokki_mokki_id";
            this.mokkimokkiidDataGridViewTextBoxColumn.Name = "mokkimokkiidDataGridViewTextBoxColumn";
            // 
            // varattupvmDataGridViewTextBoxColumn
            // 
            this.varattupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_pvm";
            this.varattupvmDataGridViewTextBoxColumn.HeaderText = "varattu_pvm";
            this.varattupvmDataGridViewTextBoxColumn.Name = "varattupvmDataGridViewTextBoxColumn";
            // 
            // vahvistuspvmDataGridViewTextBoxColumn
            // 
            this.vahvistuspvmDataGridViewTextBoxColumn.DataPropertyName = "vahvistus_pvm";
            this.vahvistuspvmDataGridViewTextBoxColumn.HeaderText = "vahvistus_pvm";
            this.vahvistuspvmDataGridViewTextBoxColumn.Name = "vahvistuspvmDataGridViewTextBoxColumn";
            // 
            // varattualkupvmDataGridViewTextBoxColumn
            // 
            this.varattualkupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_alkupvm";
            this.varattualkupvmDataGridViewTextBoxColumn.HeaderText = "varattu_alkupvm";
            this.varattualkupvmDataGridViewTextBoxColumn.Name = "varattualkupvmDataGridViewTextBoxColumn";
            // 
            // varattuloppupvmDataGridViewTextBoxColumn
            // 
            this.varattuloppupvmDataGridViewTextBoxColumn.DataPropertyName = "varattu_loppupvm";
            this.varattuloppupvmDataGridViewTextBoxColumn.HeaderText = "varattu_loppupvm";
            this.varattuloppupvmDataGridViewTextBoxColumn.Name = "varattuloppupvmDataGridViewTextBoxColumn";
            // 
            // frmVaraukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 662);
            this.Controls.Add(this.dgvVaraukset);
            this.Controls.Add(this.pnlAlapaneeli);
            this.Name = "frmVaraukset";
            this.Text = "Varaukset";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraukset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVaraukset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAlapaneeli;
        private System.Windows.Forms.DataGridView dgvVaraukset;
        private VarauksetData dataVaraukset;
        private VarauksetDataTableAdapters.TableAdapterManager tamTauluAdapteriManageri;
        private VarauksetDataTableAdapters.varauksen_palvelutTableAdapter taVarauksenPalvelut;
        private VarauksetDataTableAdapters.varausTableAdapter taVaraus;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiakasidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mokkimokkiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vahvistuspvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattualkupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varattuloppupvmDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource varausBindingSource;
    }
}