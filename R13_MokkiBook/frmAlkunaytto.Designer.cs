namespace R13_MokkiBook
{
    partial class frmAlkunaytto
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
            this.btnVaraukset = new System.Windows.Forms.Button();
            this.btnMokit = new System.Windows.Forms.Button();
            this.btnAlueet = new System.Windows.Forms.Button();
            this.btnAsiakkaat = new System.Windows.Forms.Button();
            this.btnPalvelut = new System.Windows.Forms.Button();
            this.btnLaskut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVaraukset
            // 
            this.btnVaraukset.Location = new System.Drawing.Point(68, 42);
            this.btnVaraukset.Name = "btnVaraukset";
            this.btnVaraukset.Size = new System.Drawing.Size(150, 41);
            this.btnVaraukset.TabIndex = 0;
            this.btnVaraukset.Text = "Varaukset";
            this.btnVaraukset.UseVisualStyleBackColor = true;
            // 
            // btnMokit
            // 
            this.btnMokit.Location = new System.Drawing.Point(68, 159);
            this.btnMokit.Name = "btnMokit";
            this.btnMokit.Size = new System.Drawing.Size(150, 41);
            this.btnMokit.TabIndex = 1;
            this.btnMokit.Text = "Mökit";
            this.btnMokit.UseVisualStyleBackColor = true;
            // 
            // btnAlueet
            // 
            this.btnAlueet.Location = new System.Drawing.Point(68, 287);
            this.btnAlueet.Name = "btnAlueet";
            this.btnAlueet.Size = new System.Drawing.Size(150, 41);
            this.btnAlueet.TabIndex = 2;
            this.btnAlueet.Text = "Alueet";
            this.btnAlueet.UseVisualStyleBackColor = true;
            // 
            // btnAsiakkaat
            // 
            this.btnAsiakkaat.Location = new System.Drawing.Point(68, 403);
            this.btnAsiakkaat.Name = "btnAsiakkaat";
            this.btnAsiakkaat.Size = new System.Drawing.Size(150, 41);
            this.btnAsiakkaat.TabIndex = 3;
            this.btnAsiakkaat.Text = "Asiakkaat";
            this.btnAsiakkaat.UseVisualStyleBackColor = true;
            // 
            // btnPalvelut
            // 
            this.btnPalvelut.Location = new System.Drawing.Point(436, 42);
            this.btnPalvelut.Name = "btnPalvelut";
            this.btnPalvelut.Size = new System.Drawing.Size(150, 41);
            this.btnPalvelut.TabIndex = 4;
            this.btnPalvelut.Text = "Palvelut";
            this.btnPalvelut.UseVisualStyleBackColor = true;
            // 
            // btnLaskut
            // 
            this.btnLaskut.Location = new System.Drawing.Point(436, 159);
            this.btnLaskut.Name = "btnLaskut";
            this.btnLaskut.Size = new System.Drawing.Size(150, 41);
            this.btnLaskut.TabIndex = 5;
            this.btnLaskut.Text = "Laskut";
            this.btnLaskut.UseVisualStyleBackColor = true;
            // 
            // frmAlkunaytto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 505);
            this.Controls.Add(this.btnLaskut);
            this.Controls.Add(this.btnPalvelut);
            this.Controls.Add(this.btnAsiakkaat);
            this.Controls.Add(this.btnAlueet);
            this.Controls.Add(this.btnMokit);
            this.Controls.Add(this.btnVaraukset);
            this.Name = "frmAlkunaytto";
            this.Text = "MökkiBook";
            this.Load += new System.EventHandler(this.frmAlkunaytto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVaraukset;
        private System.Windows.Forms.Button btnMokit;
        private System.Windows.Forms.Button btnAlueet;
        private System.Windows.Forms.Button btnAsiakkaat;
        private System.Windows.Forms.Button btnPalvelut;
        private System.Windows.Forms.Button btnLaskut;
    }
}

