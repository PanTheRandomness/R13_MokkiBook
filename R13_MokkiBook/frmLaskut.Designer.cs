﻿namespace R13_MokkiBook
{
    partial class frmLaskut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaskut));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnTulosta = new System.Windows.Forms.ToolStripButton();
            this.lbOtsikko = new System.Windows.Forms.Label();
            this.dataSet1 = new R13_MokkiBook.DataSet1();
            this.laskuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laskuTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.laskuTableAdapter();
            this.laskuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varausidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.laskuidDataGridViewTextBoxColumn,
            this.varausidDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn,
            this.alvDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.laskuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 274);
            this.dataGridView1.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnTulosta});
            this.toolStrip1.Location = new System.Drawing.Point(0, 346);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(602, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnTulosta
            // 
            this.tsBtnTulosta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnTulosta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnTulosta.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnTulosta.Image")));
            this.tsBtnTulosta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnTulosta.Name = "tsBtnTulosta";
            this.tsBtnTulosta.Size = new System.Drawing.Size(79, 22);
            this.tsBtnTulosta.Text = "Tulosta lasku";
            this.tsBtnTulosta.Click += new System.EventHandler(this.tsBtnTulosta_Click);
            // 
            // lbOtsikko
            // 
            this.lbOtsikko.AutoSize = true;
            this.lbOtsikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbOtsikko.Location = new System.Drawing.Point(154, 9);
            this.lbOtsikko.Name = "lbOtsikko";
            this.lbOtsikko.Size = new System.Drawing.Size(309, 29);
            this.lbOtsikko.TabIndex = 7;
            this.lbOtsikko.Text = "Hallitse ja tarkastele laskuja";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // laskuBindingSource
            // 
            this.laskuBindingSource.DataMember = "lasku";
            this.laskuBindingSource.DataSource = this.dataSet1;
            // 
            // laskuTableAdapter
            // 
            this.laskuTableAdapter.ClearBeforeFill = true;
            // 
            // laskuidDataGridViewTextBoxColumn
            // 
            this.laskuidDataGridViewTextBoxColumn.DataPropertyName = "lasku_id";
            this.laskuidDataGridViewTextBoxColumn.HeaderText = "lasku_id";
            this.laskuidDataGridViewTextBoxColumn.Name = "laskuidDataGridViewTextBoxColumn";
            // 
            // varausidDataGridViewTextBoxColumn
            // 
            this.varausidDataGridViewTextBoxColumn.DataPropertyName = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.HeaderText = "varaus_id";
            this.varausidDataGridViewTextBoxColumn.Name = "varausidDataGridViewTextBoxColumn";
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "summa";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            // 
            // alvDataGridViewTextBoxColumn
            // 
            this.alvDataGridViewTextBoxColumn.DataPropertyName = "alv";
            this.alvDataGridViewTextBoxColumn.HeaderText = "alv";
            this.alvDataGridViewTextBoxColumn.Name = "alvDataGridViewTextBoxColumn";
            // 
            // frmLaskut
            // 
            this.ClientSize = new System.Drawing.Size(602, 371);
            this.Controls.Add(this.lbOtsikko);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmLaskut";
            this.Load += new System.EventHandler(this.frmLaskut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnTulosta;
        private System.Windows.Forms.Label lbOtsikko;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource laskuBindingSource;
        private DataSet1TableAdapters.laskuTableAdapter laskuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn laskuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varausidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alvDataGridViewTextBoxColumn;
    }
}