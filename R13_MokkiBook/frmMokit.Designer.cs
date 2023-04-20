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
            this.lbAsiakasid = new System.Windows.Forms.Label();
            this.lbPostinumero = new System.Windows.Forms.Label();
            this.lbEtunimi = new System.Windows.Forms.Label();
            this.lbSukunimi = new System.Windows.Forms.Label();
            this.lbLahiosoite = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPuhelinnumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAsiakasid
            // 
            this.lbAsiakasid.AutoSize = true;
            this.lbAsiakasid.Location = new System.Drawing.Point(27, 37);
            this.lbAsiakasid.Name = "lbAsiakasid";
            this.lbAsiakasid.Size = new System.Drawing.Size(74, 16);
            this.lbAsiakasid.TabIndex = 0;
            this.lbAsiakasid.Text = "Asiakas_id";
            // 
            // lbPostinumero
            // 
            this.lbPostinumero.AutoSize = true;
            this.lbPostinumero.Location = new System.Drawing.Point(27, 83);
            this.lbPostinumero.Name = "lbPostinumero";
            this.lbPostinumero.Size = new System.Drawing.Size(82, 16);
            this.lbPostinumero.TabIndex = 2;
            this.lbPostinumero.Text = "Postinumero";
            // 
            // lbEtunimi
            // 
            this.lbEtunimi.AutoSize = true;
            this.lbEtunimi.Location = new System.Drawing.Point(27, 125);
            this.lbEtunimi.Name = "lbEtunimi";
            this.lbEtunimi.Size = new System.Drawing.Size(50, 16);
            this.lbEtunimi.TabIndex = 3;
            this.lbEtunimi.Text = "Etunimi";
            // 
            // lbSukunimi
            // 
            this.lbSukunimi.AutoSize = true;
            this.lbSukunimi.Location = new System.Drawing.Point(27, 168);
            this.lbSukunimi.Name = "lbSukunimi";
            this.lbSukunimi.Size = new System.Drawing.Size(61, 16);
            this.lbSukunimi.TabIndex = 4;
            this.lbSukunimi.Text = "Sukunimi";
            // 
            // lbLahiosoite
            // 
            this.lbLahiosoite.AutoSize = true;
            this.lbLahiosoite.Location = new System.Drawing.Point(27, 213);
            this.lbLahiosoite.Name = "lbLahiosoite";
            this.lbLahiosoite.Size = new System.Drawing.Size(69, 16);
            this.lbLahiosoite.TabIndex = 5;
            this.lbLahiosoite.Text = "Lähiosoite";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(27, 256);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(41, 16);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "Email";
            // 
            // lbPuhelinnumero
            // 
            this.lbPuhelinnumero.AutoSize = true;
            this.lbPuhelinnumero.Location = new System.Drawing.Point(27, 295);
            this.lbPuhelinnumero.Name = "lbPuhelinnumero";
            this.lbPuhelinnumero.Size = new System.Drawing.Size(96, 16);
            this.lbPuhelinnumero.TabIndex = 7;
            this.lbPuhelinnumero.Text = "Puhelinnumero";
            // 
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPuhelinnumero);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbLahiosoite);
            this.Controls.Add(this.lbSukunimi);
            this.Controls.Add(this.lbEtunimi);
            this.Controls.Add(this.lbPostinumero);
            this.Controls.Add(this.lbAsiakasid);
            this.Name = "frmMokit";
            this.Text = "Mokit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAsiakasid;
        private System.Windows.Forms.Label lbPostinumero;
        private System.Windows.Forms.Label lbEtunimi;
        private System.Windows.Forms.Label lbSukunimi;
        private System.Windows.Forms.Label lbLahiosoite;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPuhelinnumero;
    }
}