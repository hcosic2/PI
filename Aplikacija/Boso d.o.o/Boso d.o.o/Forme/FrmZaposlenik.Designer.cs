namespace Boso_d.o.o
{
    partial class FrmZaposlenik
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
            this.btnStanje = new System.Windows.Forms.Button();
            this.btnNarudzba = new System.Windows.Forms.Button();
            this.btnArhiva = new System.Windows.Forms.Button();
            this.btnOtpis = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblOdjava = new System.Windows.Forms.Label();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.lblKIme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStanje
            // 
            this.btnStanje.Location = new System.Drawing.Point(49, 125);
            this.btnStanje.Name = "btnStanje";
            this.btnStanje.Size = new System.Drawing.Size(264, 30);
            this.btnStanje.TabIndex = 0;
            this.btnStanje.Text = "Stanje na skladištu";
            this.btnStanje.UseVisualStyleBackColor = true;
            this.btnStanje.Click += new System.EventHandler(this.btnStanje_Click);
            // 
            // btnNarudzba
            // 
            this.btnNarudzba.Location = new System.Drawing.Point(49, 183);
            this.btnNarudzba.Name = "btnNarudzba";
            this.btnNarudzba.Size = new System.Drawing.Size(264, 29);
            this.btnNarudzba.TabIndex = 1;
            this.btnNarudzba.Text = "Naručivanje robe";
            this.btnNarudzba.UseVisualStyleBackColor = true;
            this.btnNarudzba.Click += new System.EventHandler(this.btnNarudzba_Click);
            // 
            // btnArhiva
            // 
            this.btnArhiva.Location = new System.Drawing.Point(49, 238);
            this.btnArhiva.Name = "btnArhiva";
            this.btnArhiva.Size = new System.Drawing.Size(264, 30);
            this.btnArhiva.TabIndex = 2;
            this.btnArhiva.Text = "Arhiva Narudžbi";
            this.btnArhiva.UseVisualStyleBackColor = true;
            // 
            // btnOtpis
            // 
            this.btnOtpis.Location = new System.Drawing.Point(49, 291);
            this.btnOtpis.Name = "btnOtpis";
            this.btnOtpis.Size = new System.Drawing.Size(264, 29);
            this.btnOtpis.TabIndex = 3;
            this.btnOtpis.Text = "Otpis robe sa skladišta";
            this.btnOtpis.UseVisualStyleBackColor = true;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.Location = new System.Drawing.Point(136, 52);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(84, 36);
            this.lblNaslov.TabIndex = 4;
            this.lblNaslov.Text = "Boso";
            // 
            // lblOdjava
            // 
            this.lblOdjava.AutoSize = true;
            this.lblOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdjava.Location = new System.Drawing.Point(303, 9);
            this.lblOdjava.Name = "lblOdjava";
            this.lblOdjava.Size = new System.Drawing.Size(41, 13);
            this.lblOdjava.TabIndex = 5;
            this.lblOdjava.Text = "Odjava";
            this.lblOdjava.Click += new System.EventHandler(this.lblOdjava_Click);
            this.lblOdjava.MouseLeave += new System.EventHandler(this.lblOdjava_MouseLeave);
            this.lblOdjava.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblOdjava_MouseMove);
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzlaz.Location = new System.Drawing.Point(309, 337);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 6;
            this.lblIzlaz.Text = "Izlaz";
            this.lblIzlaz.Click += new System.EventHandler(this.lblIzlaz_Click);
            this.lblIzlaz.MouseLeave += new System.EventHandler(this.lblIzlaz_MouseLeave);
            this.lblIzlaz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblIzlaz_MouseMove);
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(214, 9);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(47, 13);
            this.lblKorisnik.TabIndex = 7;
            this.lblKorisnik.Text = "Korisnik:";
            // 
            // lblKIme
            // 
            this.lblKIme.AutoSize = true;
            this.lblKIme.Location = new System.Drawing.Point(257, 9);
            this.lblKIme.Name = "lblKIme";
            this.lblKIme.Size = new System.Drawing.Size(10, 13);
            this.lblKIme.TabIndex = 8;
            this.lblKIme.Text = ".";
            // 
            // FrmZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(356, 359);
            this.Controls.Add(this.lblKIme);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.lblOdjava);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnOtpis);
            this.Controls.Add(this.btnArhiva);
            this.Controls.Add(this.btnNarudzba);
            this.Controls.Add(this.btnStanje);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmZaposlenik";
            this.Text = "Boso zaposlenik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStanje;
        private System.Windows.Forms.Button btnNarudzba;
        private System.Windows.Forms.Button btnArhiva;
        private System.Windows.Forms.Button btnOtpis;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblOdjava;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Label lblKIme;
    }
}