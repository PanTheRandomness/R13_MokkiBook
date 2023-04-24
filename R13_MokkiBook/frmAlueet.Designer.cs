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
            this.lbAlueID = new System.Windows.Forms.Label();
            this.lbNimi = new System.Windows.Forms.Label();
            this.tbAlueID = new System.Windows.Forms.TextBox();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.dgwAlue = new System.Windows.Forms.DataGridView();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnMuokkaa = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlue)).BeginInit();
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
            this.dgwAlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // frmAlueet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}