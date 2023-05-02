namespace R13_MokkiBook
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
            this.laskuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new R13_MokkiBook.DataSet1();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnTulosta = new System.Windows.Forms.ToolStripButton();
            this.lbOtsikko = new System.Windows.Forms.Label();
            this.laskuTableAdapter = new R13_MokkiBook.DataSet1TableAdapters.laskuTableAdapter();
            this.txtLaskuID = new System.Windows.Forms.TextBox();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.lbVarausID = new System.Windows.Forms.Label();
            this.txtVarausID = new System.Windows.Forms.TextBox();
            this.lbAlv = new System.Windows.Forms.Label();
            this.txtAlv = new System.Windows.Forms.TextBox();
            this.lbSumma = new System.Windows.Forms.Label();
            this.txtSumma = new System.Windows.Forms.TextBox();
            this.lbTyyppi = new System.Windows.Forms.Label();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.lbLaskuID = new System.Windows.Forms.Label();
            this.laskuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.laskuBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new R13_MokkiBook.DataSet1();
            this.lasku_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varaus_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lasku_id,
            this.varaus_id,
            this.summa,
            this.alv});
            this.dataGridView1.DataSource = this.laskuBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(945, 274);
            this.dataGridView1.TabIndex = 5;
            // 
            // laskuBindingSource
            // 
            this.laskuBindingSource.DataMember = "lasku";
            this.laskuBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnTulosta});
            this.toolStrip1.Location = new System.Drawing.Point(0, 535);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(945, 25);
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
            this.lbOtsikko.Location = new System.Drawing.Point(278, 9);
            this.lbOtsikko.Name = "lbOtsikko";
            this.lbOtsikko.Size = new System.Drawing.Size(309, 29);
            this.lbOtsikko.TabIndex = 7;
            this.lbOtsikko.Text = "Hallitse ja tarkastele laskuja";
            // 
            // laskuTableAdapter
            // 
            this.laskuTableAdapter.ClearBeforeFill = true;
            // 
            // txtLaskuID
            // 
            this.txtLaskuID.Location = new System.Drawing.Point(303, 100);
            this.txtLaskuID.Name = "txtLaskuID";
            this.txtLaskuID.Size = new System.Drawing.Size(100, 20);
            this.txtLaskuID.TabIndex = 16;
            // 
            // btnPaivita
            // 
            this.btnPaivita.Location = new System.Drawing.Point(335, 196);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(84, 23);
            this.btnPaivita.TabIndex = 25;
            this.btnPaivita.Text = "Päivitä";
            this.btnPaivita.UseVisualStyleBackColor = true;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // lbVarausID
            // 
            this.lbVarausID.AutoSize = true;
            this.lbVarausID.Location = new System.Drawing.Point(300, 123);
            this.lbVarausID.Name = "lbVarausID";
            this.lbVarausID.Size = new System.Drawing.Size(57, 13);
            this.lbVarausID.TabIndex = 31;
            this.lbVarausID.Text = "Varaus_ID";
            // 
            // txtVarausID
            // 
            this.txtVarausID.Location = new System.Drawing.Point(303, 137);
            this.txtVarausID.Name = "txtVarausID";
            this.txtVarausID.Size = new System.Drawing.Size(100, 20);
            this.txtVarausID.TabIndex = 17;
            // 
            // lbAlv
            // 
            this.lbAlv.AutoSize = true;
            this.lbAlv.Location = new System.Drawing.Point(438, 84);
            this.lbAlv.Name = "lbAlv";
            this.lbAlv.Size = new System.Drawing.Size(22, 13);
            this.lbAlv.TabIndex = 30;
            this.lbAlv.Text = "Alv";
            // 
            // txtAlv
            // 
            this.txtAlv.Location = new System.Drawing.Point(441, 98);
            this.txtAlv.Name = "txtAlv";
            this.txtAlv.Size = new System.Drawing.Size(100, 20);
            this.txtAlv.TabIndex = 24;
            // 
            // lbSumma
            // 
            this.lbSumma.AutoSize = true;
            this.lbSumma.Location = new System.Drawing.Point(438, 124);
            this.lbSumma.Name = "lbSumma";
            this.lbSumma.Size = new System.Drawing.Size(42, 13);
            this.lbSumma.TabIndex = 29;
            this.lbSumma.Text = "Summa";
            // 
            // txtSumma
            // 
            this.txtSumma.Location = new System.Drawing.Point(441, 138);
            this.txtSumma.Name = "txtSumma";
            this.txtSumma.Size = new System.Drawing.Size(100, 20);
            this.txtSumma.TabIndex = 22;
            // 
            // lbTyyppi
            // 
            this.lbTyyppi.AutoSize = true;
            this.lbTyyppi.Location = new System.Drawing.Point(432, 123);
            this.lbTyyppi.Name = "lbTyyppi";
            this.lbTyyppi.Size = new System.Drawing.Size(0, 13);
            this.lbTyyppi.TabIndex = 23;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(432, 196);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(84, 23);
            this.btnLisaa.TabIndex = 27;
            this.btnLisaa.Text = "Lisää ";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // lbLaskuID
            // 
            this.lbLaskuID.AutoSize = true;
            this.lbLaskuID.Location = new System.Drawing.Point(300, 84);
            this.lbLaskuID.Name = "lbLaskuID";
            this.lbLaskuID.Size = new System.Drawing.Size(50, 13);
            this.lbLaskuID.TabIndex = 32;
            this.lbLaskuID.Text = "Lasku_id";
            // 
            // laskuBindingSource1
            // 
            this.laskuBindingSource1.DataMember = "lasku";
            this.laskuBindingSource1.DataSource = this.dataSet1;
            // 
            // laskuBindingSource2
            // 
            this.laskuBindingSource2.DataMember = "lasku";
            this.laskuBindingSource2.DataSource = this.dataSet1;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lasku_id
            // 
            this.lasku_id.DataPropertyName = "lasku_id";
            this.lasku_id.HeaderText = "lasku_id";
            this.lasku_id.Name = "lasku_id";
            // 
            // varaus_id
            // 
            this.varaus_id.DataPropertyName = "varaus_id";
            this.varaus_id.HeaderText = "varaus_id";
            this.varaus_id.Name = "varaus_id";
            // 
            // summa
            // 
            this.summa.DataPropertyName = "summa";
            this.summa.HeaderText = "summa";
            this.summa.Name = "summa";
            // 
            // alv
            // 
            this.alv.DataPropertyName = "alv";
            this.alv.HeaderText = "alv";
            this.alv.Name = "alv";
            // 
            // frmLaskut
            // 
            this.ClientSize = new System.Drawing.Size(945, 560);
            this.Controls.Add(this.lbLaskuID);
            this.Controls.Add(this.txtLaskuID);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.lbVarausID);
            this.Controls.Add(this.txtVarausID);
            this.Controls.Add(this.lbAlv);
            this.Controls.Add(this.txtAlv);
            this.Controls.Add(this.lbSumma);
            this.Controls.Add(this.txtSumma);
            this.Controls.Add(this.lbTyyppi);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.lbOtsikko);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmLaskut";
            this.Load += new System.EventHandler(this.frmLaskut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
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
        private System.Windows.Forms.TextBox txtLaskuID;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.Label lbVarausID;
        private System.Windows.Forms.TextBox txtVarausID;
        private System.Windows.Forms.Label lbAlv;
        private System.Windows.Forms.TextBox txtAlv;
        private System.Windows.Forms.Label lbSumma;
        private System.Windows.Forms.TextBox txtSumma;
        private System.Windows.Forms.Label lbTyyppi;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Label lbLaskuID;
        private System.Windows.Forms.BindingSource laskuBindingSource1;
        private System.Windows.Forms.BindingSource laskuBindingSource2;
        private DataSet1 dataSet11;
        private System.Windows.Forms.DataGridViewTextBoxColumn lasku_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn varaus_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn summa;
        private System.Windows.Forms.DataGridViewTextBoxColumn alv;
    }
}