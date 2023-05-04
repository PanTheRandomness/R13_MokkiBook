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
            this.tbAlueId = new System.Windows.Forms.TextBox();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.dgvAlue = new System.Windows.Forms.DataGridView();
            this.alue_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new R13_MokkiBook.DataSet1();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.btnHae = new System.Windows.Forms.Button();
            this.btnTyhjenna = new System.Windows.Forms.Button();
            this.tbHae = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
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
            // tbAlueId
            // 
            this.tbAlueId.Location = new System.Drawing.Point(141, 56);
            this.tbAlueId.Name = "tbAlueId";
            this.tbAlueId.Size = new System.Drawing.Size(131, 22);
            this.tbAlueId.TabIndex = 0;
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(141, 89);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(131, 22);
            this.tbNimi.TabIndex = 1;
            // 
            // dgvAlue
            // 
            this.dgvAlue.AutoGenerateColumns = false;
            this.dgvAlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alue_id,
            this.nimi});
            this.dgvAlue.DataSource = this.alueBindingSource;
            this.dgvAlue.Location = new System.Drawing.Point(33, 186);
            this.dgvAlue.Name = "dgvAlue";
            this.dgvAlue.RowHeadersWidth = 51;
            this.dgvAlue.RowTemplate.Height = 24;
            this.dgvAlue.Size = new System.Drawing.Size(739, 243);
            this.dgvAlue.TabIndex = 6;
            this.dgvAlue.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAlue_RowHeaderMouseDoubleClick);
            this.dgvAlue.SelectionChanged += new System.EventHandler(this.dgvAlue_SelectionChanged);
            // 
            // alue_id
            // 
            this.alue_id.DataPropertyName = "alue_id";
            this.alue_id.HeaderText = "alue_id";
            this.alue_id.MinimumWidth = 6;
            this.alue_id.Name = "alue_id";
            this.alue_id.Width = 125;
            // 
            // nimi
            // 
            this.nimi.DataPropertyName = "nimi";
            this.nimi.HeaderText = "nimi";
            this.nimi.MinimumWidth = 6;
            this.nimi.Name = "nimi";
            this.nimi.Width = 125;
            // 
            // alueBindingSource
            // 
            this.alueBindingSource.DataMember = "alue";
            this.alueBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(33, 141);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(161, 39);
            this.btnLisaa.TabIndex = 2;
            this.btnLisaa.Text = "Lisää alue";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnMuokkaa
            // 
            this.btnMuokkaa.Location = new System.Drawing.Point(221, 141);
            this.btnMuokkaa.Name = "btnMuokkaa";
            this.btnMuokkaa.Size = new System.Drawing.Size(161, 39);
            this.btnMuokkaa.TabIndex = 3;
            this.btnMuokkaa.Text = "Tallenna muutos";
            this.btnMuokkaa.UseVisualStyleBackColor = true;
            this.btnMuokkaa.Click += new System.EventHandler(this.btnMuokkaa_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(417, 141);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(161, 39);
            this.btnPoista.TabIndex = 4;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // btnHae
            // 
            this.btnHae.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHae.Location = new System.Drawing.Point(705, 442);
            this.btnHae.Margin = new System.Windows.Forms.Padding(4);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(67, 28);
            this.btnHae.TabIndex = 8;
            this.btnHae.Text = "Hae";
            this.btnHae.UseVisualStyleBackColor = true;
            this.btnHae.Click += new System.EventHandler(this.btnHae_Click);
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.Location = new System.Drawing.Point(611, 141);
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.Size = new System.Drawing.Size(161, 39);
            this.btnTyhjenna.TabIndex = 5;
            this.btnTyhjenna.Text = "Tyhjennä rivit";
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.Click += new System.EventHandler(this.btnTyhjenna_Click);
            // 
            // tbHae
            // 
            this.tbHae.Location = new System.Drawing.Point(537, 445);
            this.tbHae.Name = "tbHae";
            this.tbHae.Size = new System.Drawing.Size(150, 22);
            this.tbHae.TabIndex = 7;
            // 
            // frmAlueet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.tbHae);
            this.Controls.Add(this.btnTyhjenna);
            this.Controls.Add(this.btnHae);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnMuokkaa);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.dgvAlue);
            this.Controls.Add(this.tbNimi);
            this.Controls.Add(this.tbAlueId);
            this.Controls.Add(this.lbNimi);
            this.Controls.Add(this.lbAlueID);
            this.Name = "frmAlueet";
            this.Text = "Alueet";
            this.Load += new System.EventHandler(this.frmAlueet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAlueID;
        private System.Windows.Forms.Label lbNimi;
        private System.Windows.Forms.TextBox tbAlueId;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.DataGridView dgvAlue;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnMuokkaa;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.BindingSource alueBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alue_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimi;
        private System.Windows.Forms.Button btnTyhjenna;
        private System.Windows.Forms.TextBox tbHae;
    }
}