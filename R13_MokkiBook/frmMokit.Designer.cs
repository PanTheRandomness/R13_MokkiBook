namespace R13_MokkiBook
{
    partial class frmMokit
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
            this.lbMokkiId = new System.Windows.Forms.Label();
            this.lbPostinumero = new System.Windows.Forms.Label();
            this.lbNimi = new System.Windows.Forms.Label();
            this.lbHinta = new System.Windows.Forms.Label();
            this.lbLahiosoite = new System.Windows.Forms.Label();
            this.lbKuvaus = new System.Windows.Forms.Label();
            this.lbHenkilomaara = new System.Windows.Forms.Label();
            this.lbAlueId = new System.Windows.Forms.Label();
            this.lbVarustelu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMokkiId
            // 
            this.lbMokkiId.AutoSize = true;
            this.lbMokkiId.Location = new System.Drawing.Point(27, 37);
            this.lbMokkiId.Name = "lbMokkiId";
            this.lbMokkiId.Size = new System.Drawing.Size(62, 16);
            this.lbMokkiId.TabIndex = 0;
            this.lbMokkiId.Text = "Mökki ID:";
            // 
            // lbPostinumero
            // 
            this.lbPostinumero.AutoSize = true;
            this.lbPostinumero.Location = new System.Drawing.Point(27, 102);
            this.lbPostinumero.Name = "lbPostinumero";
            this.lbPostinumero.Size = new System.Drawing.Size(82, 16);
            this.lbPostinumero.TabIndex = 2;
            this.lbPostinumero.Text = "Postinumero";
            // 
            // lbNimi
            // 
            this.lbNimi.AutoSize = true;
            this.lbNimi.Location = new System.Drawing.Point(27, 139);
            this.lbNimi.Name = "lbNimi";
            this.lbNimi.Size = new System.Drawing.Size(70, 16);
            this.lbNimi.TabIndex = 3;
            this.lbNimi.Text = "Mökin nimi";
            // 
            // lbHinta
            // 
            this.lbHinta.AutoSize = true;
            this.lbHinta.Location = new System.Drawing.Point(361, 37);
            this.lbHinta.Name = "lbHinta";
            this.lbHinta.Size = new System.Drawing.Size(38, 16);
            this.lbHinta.TabIndex = 4;
            this.lbHinta.Text = "Hinta";
            // 
            // lbLahiosoite
            // 
            this.lbLahiosoite.AutoSize = true;
            this.lbLahiosoite.Location = new System.Drawing.Point(27, 177);
            this.lbLahiosoite.Name = "lbLahiosoite";
            this.lbLahiosoite.Size = new System.Drawing.Size(70, 16);
            this.lbLahiosoite.TabIndex = 5;
            this.lbLahiosoite.Text = "Katuosoite";
            // 
            // lbKuvaus
            // 
            this.lbKuvaus.AutoSize = true;
            this.lbKuvaus.Location = new System.Drawing.Point(361, 67);
            this.lbKuvaus.Name = "lbKuvaus";
            this.lbKuvaus.Size = new System.Drawing.Size(51, 16);
            this.lbKuvaus.TabIndex = 6;
            this.lbKuvaus.Text = "Kuvaus";
            // 
            // lbHenkilomaara
            // 
            this.lbHenkilomaara.AutoSize = true;
            this.lbHenkilomaara.Location = new System.Drawing.Point(361, 102);
            this.lbHenkilomaara.Name = "lbHenkilomaara";
            this.lbHenkilomaara.Size = new System.Drawing.Size(92, 16);
            this.lbHenkilomaara.TabIndex = 7;
            this.lbHenkilomaara.Text = "Henkilömäärä";
            // 
            // lbAlueId
            // 
            this.lbAlueId.AutoSize = true;
            this.lbAlueId.Location = new System.Drawing.Point(27, 67);
            this.lbAlueId.Name = "lbAlueId";
            this.lbAlueId.Size = new System.Drawing.Size(53, 16);
            this.lbAlueId.TabIndex = 8;
            this.lbAlueId.Text = "Alue ID:";
            // 
            // lbVarustelu
            // 
            this.lbVarustelu.AutoSize = true;
            this.lbVarustelu.Location = new System.Drawing.Point(361, 139);
            this.lbVarustelu.Name = "lbVarustelu";
            this.lbVarustelu.Size = new System.Drawing.Size(63, 16);
            this.lbVarustelu.TabIndex = 9;
            this.lbVarustelu.Text = "Varustelu";
            // 
            // frmMokit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbVarustelu);
            this.Controls.Add(this.lbAlueId);
            this.Controls.Add(this.lbHenkilomaara);
            this.Controls.Add(this.lbKuvaus);
            this.Controls.Add(this.lbLahiosoite);
            this.Controls.Add(this.lbHinta);
            this.Controls.Add(this.lbNimi);
            this.Controls.Add(this.lbPostinumero);
            this.Controls.Add(this.lbMokkiId);
            this.Name = "frmMokit";
            this.Text = "Mokit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMokkiId;
        private System.Windows.Forms.Label lbPostinumero;
        private System.Windows.Forms.Label lbNimi;
        private System.Windows.Forms.Label lbHinta;
        private System.Windows.Forms.Label lbLahiosoite;
        private System.Windows.Forms.Label lbKuvaus;
        private System.Windows.Forms.Label lbHenkilomaara;
        private System.Windows.Forms.Label lbAlueId;
        private System.Windows.Forms.Label lbVarustelu;
    }
}