﻿namespace R13_MokkiBook
{
    partial class frmHaePalvelu
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
            this.dgvAlueenPalvelut = new System.Windows.Forms.DataGridView();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.nudMaara = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlueenPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaara)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlueenPalvelut
            // 
            this.dgvAlueenPalvelut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlueenPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlueenPalvelut.Location = new System.Drawing.Point(0, 0);
            this.dgvAlueenPalvelut.Name = "dgvAlueenPalvelut";
            this.dgvAlueenPalvelut.Size = new System.Drawing.Size(540, 147);
            this.dgvAlueenPalvelut.TabIndex = 0;
            this.dgvAlueenPalvelut.SelectionChanged += new System.EventHandler(this.dgvAlueenPalvelut_SelectionChanged);
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Location = new System.Drawing.Point(0, 153);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(175, 88);
            this.tbKuvaus.TabIndex = 1;
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(336, 189);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(105, 23);
            this.btnLisaa.TabIndex = 2;
            this.btnLisaa.Text = "Lisää varaukseen";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // nudMaara
            // 
            this.nudMaara.Location = new System.Drawing.Point(225, 192);
            this.nudMaara.Name = "nudMaara";
            this.nudMaara.Size = new System.Drawing.Size(105, 20);
            this.nudMaara.TabIndex = 3;
            this.nudMaara.ValueChanged += new System.EventHandler(this.nudMaara_ValueChanged);
            // 
            // frmHaePalvelu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 244);
            this.Controls.Add(this.nudMaara);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.tbKuvaus);
            this.Controls.Add(this.dgvAlueenPalvelut);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(556, 283);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(556, 283);
            this.Name = "frmHaePalvelu";
            this.Text = "Hae alueen palvelut";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlueenPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlueenPalvelut;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.NumericUpDown nudMaara;
    }
}