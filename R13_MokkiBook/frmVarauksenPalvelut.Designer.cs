﻿namespace R13_MokkiBook
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
            this.pnlToiminnot = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenPAlvelutDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.pnlToiminnot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoistettavat)).BeginInit();
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
            this.dgvVarauksenPalvelut.TabIndex = 4;
            this.dgvVarauksenPalvelut.TabStop = false;
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
            this.pnlToiminnot.Controls.Add(this.nudPoistettavat);
            this.pnlToiminnot.Controls.Add(this.btnPoistaValittuMaara);
            this.pnlToiminnot.Controls.Add(this.btnHaePalvelu);
            this.pnlToiminnot.Controls.Add(this.btnPoista);
            this.pnlToiminnot.Location = new System.Drawing.Point(2, 269);
            this.pnlToiminnot.Name = "pnlToiminnot";
            this.pnlToiminnot.Size = new System.Drawing.Size(526, 40);
            this.pnlToiminnot.TabIndex = 1;
            // 
            // nudPoistettavat
            // 
            this.nudPoistettavat.Location = new System.Drawing.Point(128, 9);
            this.nudPoistettavat.Name = "nudPoistettavat";
            this.nudPoistettavat.Size = new System.Drawing.Size(43, 20);
            this.nudPoistettavat.TabIndex = 1;
            this.ttVarauksenPAlvelut.SetToolTip(this.nudPoistettavat, "Valitse varauksesta poistettavien palveluiden määrä");
            // 
            // btnPoistaValittuMaara
            // 
            this.btnPoistaValittuMaara.Location = new System.Drawing.Point(3, 7);
            this.btnPoistaValittuMaara.Name = "btnPoistaValittuMaara";
            this.btnPoistaValittuMaara.Size = new System.Drawing.Size(119, 23);
            this.btnPoistaValittuMaara.TabIndex = 0;
            this.btnPoistaValittuMaara.Text = "Poista valittu määrä";
            this.ttVarauksenPAlvelut.SetToolTip(this.btnPoistaValittuMaara, "Poista varauksesta valittu määrä valittua palvelua");
            this.btnPoistaValittuMaara.UseVisualStyleBackColor = true;
            this.btnPoistaValittuMaara.Click += new System.EventHandler(this.btnPoistaValittuMaara_Click);
            // 
            // btnHaePalvelu
            // 
            this.btnHaePalvelu.Location = new System.Drawing.Point(372, 7);
            this.btnHaePalvelu.Name = "btnHaePalvelu";
            this.btnHaePalvelu.Size = new System.Drawing.Size(144, 23);
            this.btnHaePalvelu.TabIndex = 3;
            this.btnHaePalvelu.Text = "Lisää palvelu varaukseen";
            this.ttVarauksenPAlvelut.SetToolTip(this.btnHaePalvelu, "Lisää varaukseen palvelun erilliseltä sivulta");
            this.btnHaePalvelu.UseVisualStyleBackColor = true;
            this.btnHaePalvelu.Click += new System.EventHandler(this.btnHaePalvelu_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(266, 7);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(100, 23);
            this.btnPoista.TabIndex = 2;
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
            // frmVarauksenPalvelut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 310);
            this.Controls.Add(this.pnlToiminnot);
            this.Controls.Add(this.dgvVarauksenPalvelut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(546, 349);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(546, 349);
            this.Name = "frmVarauksenPalvelut";
            this.Text = "Varauksen palvelut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVarauksenPalvelut_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVarauksenPalvelut_FormClosed);
            this.Load += new System.EventHandler(this.frmVarauksenPalvelut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarauksenPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenPAlvelutDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varauksenpalvelutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.pnlToiminnot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPoistettavat)).EndInit();
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
    }
}