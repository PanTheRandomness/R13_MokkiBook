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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVarauksenPalvelut));
            this.dgvVarauksenPalvelut = new System.Windows.Forms.DataGridView();
            this.varauksenpalvelutBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.varauksenPAlvelutDataSet = new R13_MokkiBook.VarauksenPAlvelutDataSet();
            this.varauksenpalvelutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new R13_MokkiBook.DataSet1();
            this.varauksen_palvelutTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.varauksen_palvelutTableAdapter();
            this.pnlPalvelut = new System.Windows.Forms.Panel();
            this.nudPoistettavat = new System.Windows.Forms.NumericUpDown();
            this.btnPoistaValittuMaara = new System.Windows.Forms.Button();
            this.btnHaePalvelu = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.epVarauksenPalvelut = new System.Windows.Forms.ErrorProvider(this.components);
            this.palveluTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.palveluTableAdapter();
            this.varauksen_palvelutTableAdapter1 = new R13_MokkiBook.VarauksenPAlvelutDataSetTableAdapters.varauksen_palvelutTableAdapter();
            this.varauksenPAlvelutDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varauksenpalvelutBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ttVarauksenPAlvelut = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTiedot = new System.Windows.Forms.Panel();
            this.stpAlku = new System.Windows.Forms.DateTimePicker();
            this.stpLoppu = new System.Windows.Forms.DateTimePicker();
            this.lblAjankohta = new System.Windows.Forms.Label();
            this.lblPalvelut = new System.Windows.Forms.Label();
            this.lblViiva = new System.Windows.Forms.Label();
            this.lblVarausId = new System.Windows.Forms.Label();
            this.btnVahvista = new System.Windows.Forms.Button();
            this.btnPaivita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenPAlvelutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.pnlPalvelut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoistettavat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epVarauksenPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenPAlvelutDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource2)).BeginInit();
            this.pnlTiedot.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVarauksenPalvelut
            // 
            this.dgvVarauksenPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVarauksenPalvelut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVarauksenPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarauksenPalvelut.Location = new System.Drawing.Point(10, 22);
            this.dgvVarauksenPalvelut.Name = "dgvVarauksenPalvelut";
            this.dgvVarauksenPalvelut.Size = new System.Drawing.Size(563, 225);
            this.dgvVarauksenPalvelut.TabIndex = 3;
            this.dgvVarauksenPalvelut.TabStop = false;
            this.dgvVarauksenPalvelut.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVarauksenPalvelut_RowHeaderMouseClick);
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
            // pnlPalvelut
            // 
            this.pnlPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPalvelut.Controls.Add(this.btnPaivita);
            this.pnlPalvelut.Controls.Add(this.lblPalvelut);
            this.pnlPalvelut.Controls.Add(this.nudPoistettavat);
            this.pnlPalvelut.Controls.Add(this.btnPoista);
            this.pnlPalvelut.Controls.Add(this.dgvVarauksenPalvelut);
            this.pnlPalvelut.Controls.Add(this.btnPoistaValittuMaara);
            this.pnlPalvelut.Controls.Add(this.btnHaePalvelu);
            this.pnlPalvelut.Location = new System.Drawing.Point(2, 72);
            this.pnlPalvelut.Name = "pnlPalvelut";
            this.pnlPalvelut.Size = new System.Drawing.Size(583, 287);
            this.pnlPalvelut.TabIndex = 1;
            // 
            // nudPoistettavat
            // 
            this.nudPoistettavat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudPoistettavat.Location = new System.Drawing.Point(10, 256);
            this.nudPoistettavat.Name = "nudPoistettavat";
            this.nudPoistettavat.Size = new System.Drawing.Size(43, 20);
            this.nudPoistettavat.TabIndex = 4;
            this.ttVarauksenPAlvelut.SetToolTip(this.nudPoistettavat, "Valitse varauksesta poistettavien palveluiden määrä");
            // 
            // btnPoistaValittuMaara
            // 
            this.btnPoistaValittuMaara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPoistaValittuMaara.Location = new System.Drawing.Point(59, 253);
            this.btnPoistaValittuMaara.Name = "btnPoistaValittuMaara";
            this.btnPoistaValittuMaara.Size = new System.Drawing.Size(119, 23);
            this.btnPoistaValittuMaara.TabIndex = 5;
            this.btnPoistaValittuMaara.Text = "Poista valittu määrä";
            this.ttVarauksenPAlvelut.SetToolTip(this.btnPoistaValittuMaara, "Poista varauksesta valittu määrä valittua palvelua");
            this.btnPoistaValittuMaara.UseVisualStyleBackColor = true;
            this.btnPoistaValittuMaara.Click += new System.EventHandler(this.btnPoistaValittuMaara_Click);
            // 
            // btnHaePalvelu
            // 
            this.btnHaePalvelu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHaePalvelu.Location = new System.Drawing.Point(450, 253);
            this.btnHaePalvelu.Name = "btnHaePalvelu";
            this.btnHaePalvelu.Size = new System.Drawing.Size(123, 23);
            this.btnHaePalvelu.TabIndex = 8;
            this.btnHaePalvelu.Text = "Lisää palvelu";
            this.ttVarauksenPAlvelut.SetToolTip(this.btnHaePalvelu, "Lisää varaukseen palvelun erilliseltä sivulta");
            this.btnHaePalvelu.UseVisualStyleBackColor = true;
            this.btnHaePalvelu.Click += new System.EventHandler(this.btnHaePalvelu_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPoista.Location = new System.Drawing.Point(184, 253);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(100, 23);
            this.btnPoista.TabIndex = 6;
            this.btnPoista.Text = "Poista kokonaan";
            this.ttVarauksenPAlvelut.SetToolTip(this.btnPoista, "Poista valittu palvelu varauksesta kokonaan");
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataMember = "palvelu";
            this.palveluBindingSource.DataSource = this.dataSet1;
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
            // pnlTiedot
            // 
            this.pnlTiedot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTiedot.Controls.Add(this.btnVahvista);
            this.pnlTiedot.Controls.Add(this.lblVarausId);
            this.pnlTiedot.Controls.Add(this.lblViiva);
            this.pnlTiedot.Controls.Add(this.lblAjankohta);
            this.pnlTiedot.Controls.Add(this.stpLoppu);
            this.pnlTiedot.Controls.Add(this.stpAlku);
            this.pnlTiedot.Location = new System.Drawing.Point(2, 1);
            this.pnlTiedot.Name = "pnlTiedot";
            this.pnlTiedot.Size = new System.Drawing.Size(583, 74);
            this.pnlTiedot.TabIndex = 0;
            // 
            // stpAlku
            // 
            this.stpAlku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stpAlku.Location = new System.Drawing.Point(10, 41);
            this.stpAlku.Name = "stpAlku";
            this.stpAlku.Size = new System.Drawing.Size(200, 20);
            this.stpAlku.TabIndex = 0;
            this.stpAlku.ValueChanged += new System.EventHandler(this.stpAlku_ValueChanged);
            // 
            // stpLoppu
            // 
            this.stpLoppu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stpLoppu.Location = new System.Drawing.Point(232, 41);
            this.stpLoppu.Name = "stpLoppu";
            this.stpLoppu.Size = new System.Drawing.Size(200, 20);
            this.stpLoppu.TabIndex = 1;
            this.stpLoppu.ValueChanged += new System.EventHandler(this.stpLoppu_ValueChanged);
            // 
            // lblAjankohta
            // 
            this.lblAjankohta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAjankohta.AutoSize = true;
            this.lblAjankohta.Location = new System.Drawing.Point(10, 25);
            this.lblAjankohta.Name = "lblAjankohta";
            this.lblAjankohta.Size = new System.Drawing.Size(111, 13);
            this.lblAjankohta.TabIndex = 0;
            this.lblAjankohta.Text = "Muokkaa ajankohtaa:";
            // 
            // lblPalvelut
            // 
            this.lblPalvelut.AutoSize = true;
            this.lblPalvelut.Location = new System.Drawing.Point(10, 6);
            this.lblPalvelut.Name = "lblPalvelut";
            this.lblPalvelut.Size = new System.Drawing.Size(100, 13);
            this.lblPalvelut.TabIndex = 3;
            this.lblPalvelut.Text = "Muokkaa palveluita";
            // 
            // lblViiva
            // 
            this.lblViiva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblViiva.AutoSize = true;
            this.lblViiva.Location = new System.Drawing.Point(216, 47);
            this.lblViiva.Name = "lblViiva";
            this.lblViiva.Size = new System.Drawing.Size(10, 13);
            this.lblViiva.TabIndex = 1;
            this.lblViiva.Text = "-";
            // 
            // lblVarausId
            // 
            this.lblVarausId.AutoSize = true;
            this.lblVarausId.Location = new System.Drawing.Point(10, 8);
            this.lblVarausId.Name = "lblVarausId";
            this.lblVarausId.Size = new System.Drawing.Size(78, 13);
            this.lblVarausId.TabIndex = 0;
            this.lblVarausId.Text = "Varaustunnus: ";
            // 
            // btnVahvista
            // 
            this.btnVahvista.Location = new System.Drawing.Point(438, 42);
            this.btnVahvista.Name = "btnVahvista";
            this.btnVahvista.Size = new System.Drawing.Size(78, 23);
            this.btnVahvista.TabIndex = 2;
            this.btnVahvista.Text = "Vahvista muutos";
            this.btnVahvista.UseVisualStyleBackColor = true;
            this.btnVahvista.Click += new System.EventHandler(this.btnVahvista_Click);
            // 
            // btnPaivita
            // 
            this.btnPaivita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaivita.Location = new System.Drawing.Point(345, 253);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(75, 23);
            this.btnPaivita.TabIndex = 7;
            this.btnPaivita.Text = "Päivitä taulu";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // frmVarauksenPalvelut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 360);
            this.Controls.Add(this.pnlTiedot);
            this.Controls.Add(this.pnlPalvelut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(546, 349);
            this.Name = "frmVarauksenPalvelut";
            this.Text = "Muokkaa varausta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVarauksenPalvelut_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVarauksenPalvelut_FormClosed);
            this.Load += new System.EventHandler(this.frmVarauksenPalvelut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenPAlvelutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.pnlPalvelut.ResumeLayout(false);
            this.pnlPalvelut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoistettavat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epVarauksenPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenPAlvelutDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource2)).EndInit();
            this.pnlTiedot.ResumeLayout(false);
            this.pnlTiedot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVarauksenPalvelut;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource varauksenpalvelutBindingSource;
        private DataSet1TableAdapters.varauksen_palvelutTableAdapter varauksen_palvelutTableAdapter;
        private System.Windows.Forms.Panel pnlPalvelut;
        private System.Windows.Forms.ErrorProvider epVarauksenPalvelut;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Button btnHaePalvelu;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private DataSet1TableAdapters.palveluTableAdapter palveluTableAdapter;
        private VarauksenPAlvelutDataSet varauksenPAlvelutDataSet;
        private System.Windows.Forms.BindingSource varauksenpalvelutBindingSource1;
        private VarauksenPAlvelutDataSetTableAdapters.varauksen_palvelutTableAdapter varauksen_palvelutTableAdapter1;
        private System.Windows.Forms.BindingSource varauksenPAlvelutDataSetBindingSource;
        private System.Windows.Forms.BindingSource varauksenpalvelutBindingSource2;
        private System.Windows.Forms.NumericUpDown nudPoistettavat;
        private System.Windows.Forms.Button btnPoistaValittuMaara;
        private System.Windows.Forms.ToolTip ttVarauksenPAlvelut;
        private System.Windows.Forms.Label lblPalvelut;
        private System.Windows.Forms.Panel pnlTiedot;
        private System.Windows.Forms.Label lblVarausId;
        private System.Windows.Forms.Label lblViiva;
        private System.Windows.Forms.Label lblAjankohta;
        private System.Windows.Forms.DateTimePicker stpLoppu;
        private System.Windows.Forms.DateTimePicker stpAlku;
        private System.Windows.Forms.Button btnVahvista;
        private System.Windows.Forms.Button btnPaivita;
    }
}