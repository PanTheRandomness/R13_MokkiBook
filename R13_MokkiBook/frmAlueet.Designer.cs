namespace R13_MokkiBook
{
    partial class frmAlueet
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
            this.lbAlueID = new System.Windows.Forms.Label();
            this.lbNimi = new System.Windows.Forms.Label();
            this.tbAlueID = new System.Windows.Forms.TextBox();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.dgwAlue = new System.Windows.Forms.DataGridView();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.dtpLoppu = new System.Windows.Forms.DateTimePicker();
            this.lblViiva = new System.Windows.Forms.Label();
            this.dtpAlku = new System.Windows.Forms.DateTimePicker();
            this.lblPaivat = new System.Windows.Forms.Label();
            this.btnHae = new System.Windows.Forms.Button();
            this.dataSet1 = new R13_MokkiBook.DataSet1();
            this.alueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alueidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAlueID
            // 
            this.lbAlueID.AutoSize = true;
            this.lbAlueID.Location = new System.Drawing.Point(40, 59);
            this.lbAlueID.Name = "lbAlueID";
            this.lbAlueID.Size = new System.Drawing.Size(53, 16);
            this.lbAlueID.TabIndex = 0;
            this.lbAlueID.Text = "Alue ID:";
            // 
            // lbNimi
            // 
            this.lbNimi.AutoSize = true;
            this.lbNimi.Location = new System.Drawing.Point(40, 95);
            this.lbNimi.Name = "lbNimi";
            this.lbNimi.Size = new System.Drawing.Size(79, 16);
            this.lbNimi.TabIndex = 1;
            this.lbNimi.Text = "Alueen nimi:";
            // 
            // tbAlueID
            // 
            this.tbAlueID.Location = new System.Drawing.Point(141, 56);
            this.tbAlueID.Name = "tbAlueID";
            this.tbAlueID.Size = new System.Drawing.Size(131, 22);
            this.tbAlueID.TabIndex = 2;
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(141, 89);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(131, 22);
            this.tbNimi.TabIndex = 3;
            // 
            // dgwAlue
            // 
            this.dgwAlue.AutoGenerateColumns = false;
            this.dgwAlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAlue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alueidDataGridViewTextBoxColumn,
            this.nimiDataGridViewTextBoxColumn});
            this.dgwAlue.DataSource = this.alueBindingSource;
            this.dgwAlue.Location = new System.Drawing.Point(33, 186);
            this.dgwAlue.Name = "dgwAlue";
            this.dgwAlue.RowHeadersWidth = 51;
            this.dgwAlue.RowTemplate.Height = 24;
            this.dgwAlue.Size = new System.Drawing.Size(739, 243);
            this.dgwAlue.TabIndex = 4;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(33, 141);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(161, 39);
            this.btnLisaa.TabIndex = 5;
            this.btnLisaa.Text = "Lisää alue";
            this.btnLisaa.UseVisualStyleBackColor = true;
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(226, 141);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(161, 39);
            this.btnMuokkaa.TabIndex = 6;
            this.btnMuokkaa.Text = "Muokkaa";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(426, 141);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(161, 39);
            this.btnPoista.TabIndex = 7;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            // 
            // dtpLoppu
            // 
            this.dtpLoppu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpLoppu.Location = new System.Drawing.Point(393, 448);
            this.dtpLoppu.Margin = new System.Windows.Forms.Padding(4);
            this.dtpLoppu.Name = "dtpLoppu";
            this.dtpLoppu.Size = new System.Drawing.Size(265, 22);
            this.dtpLoppu.TabIndex = 10;
            // 
            // lblViiva
            // 
            this.lblViiva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblViiva.AutoSize = true;
            this.lblViiva.Location = new System.Drawing.Point(371, 450);
            this.lblViiva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViiva.Name = "lblViiva";
            this.lblViiva.Size = new System.Drawing.Size(11, 16);
            this.lblViiva.TabIndex = 11;
            this.lblViiva.Text = "-";
            // 
            // dtpAlku
            // 
            this.dtpAlku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpAlku.Location = new System.Drawing.Point(97, 448);
            this.dtpAlku.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAlku.Name = "dtpAlku";
            this.dtpAlku.Size = new System.Drawing.Size(265, 22);
            this.dtpAlku.TabIndex = 8;
            // 
            // lblPaivat
            // 
            this.lblPaivat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPaivat.AutoSize = true;
            this.lblPaivat.Location = new System.Drawing.Point(34, 450);
            this.lblPaivat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaivat.Name = "lblPaivat";
            this.lblPaivat.Size = new System.Drawing.Size(51, 16);
            this.lblPaivat.TabIndex = 9;
            this.lblPaivat.Text = "Päiviltä";
            // 
            // btnHae
            // 
            this.btnHae.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHae.Location = new System.Drawing.Point(705, 442);
            this.btnHae.Margin = new System.Windows.Forms.Padding(4);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(67, 28);
            this.btnHae.TabIndex = 12;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alueBindingSource
            // 
            this.alueBindingSource.DataMember = "alue";
            this.alueBindingSource.DataSource = this.dataSet1;
            // 
            // alueidDataGridViewTextBoxColumn
            // 
            this.alueidDataGridViewTextBoxColumn.DataPropertyName = "alue_id";
            this.alueidDataGridViewTextBoxColumn.HeaderText = "alue_id";
            this.alueidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alueidDataGridViewTextBoxColumn.Name = "alueidDataGridViewTextBoxColumn";
            this.alueidDataGridViewTextBoxColumn.Width = 125;
            // 
            // nimiDataGridViewTextBoxColumn
            // 
            this.nimiDataGridViewTextBoxColumn.DataPropertyName = "nimi";
            this.nimiDataGridViewTextBoxColumn.HeaderText = "nimi";
            this.nimiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nimiDataGridViewTextBoxColumn.Name = "nimiDataGridViewTextBoxColumn";
            this.nimiDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmAlueet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.btnHae);
            this.Controls.Add(this.dtpLoppu);
            this.Controls.Add(this.lblViiva);
            this.Controls.Add(this.dtpAlku);
            this.Controls.Add(this.lblPaivat);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnMuokkaa);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.dgwAlue);
            this.Controls.Add(this.tbNimi);
            this.Controls.Add(this.tbAlueID);
            this.Controls.Add(this.lbNimi);
            this.Controls.Add(this.lbAlueID);
            this.Name = "frmAlueet";
            this.Text = "Alueet";
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAlueID;
        private System.Windows.Forms.Label lbNimi;
        private System.Windows.Forms.TextBox tbAlueID;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.DataGridView dgwAlue;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.DateTimePicker dtpLoppu;
        private System.Windows.Forms.Label lblViiva;
        private System.Windows.Forms.DateTimePicker dtpAlku;
        private System.Windows.Forms.Label lblPaivat;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.DataGridViewTextBoxColumn alueidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alueBindingSource;
        private DataSet1 dataSet1;
    }
}