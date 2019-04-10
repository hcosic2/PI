namespace Boso_d.o.o
{
    partial class Zaposlenik
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
            this.stanje = new System.Windows.Forms.Button();
            this.narudzba = new System.Windows.Forms.Button();
            this.arhiva = new System.Windows.Forms.Button();
            this.otpis = new System.Windows.Forms.Button();
            this.naslov = new System.Windows.Forms.Label();
            this.odjava = new System.Windows.Forms.Label();
            this.izlaz = new System.Windows.Forms.Label();
            this.korisnik = new System.Windows.Forms.Label();
            this.kIme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stanje
            // 
            this.stanje.Location = new System.Drawing.Point(49, 125);
            this.stanje.Name = "stanje";
            this.stanje.Size = new System.Drawing.Size(264, 30);
            this.stanje.TabIndex = 0;
            this.stanje.Text = "Stanje na skladištu";
            this.stanje.UseVisualStyleBackColor = true;
            this.stanje.Click += new System.EventHandler(this.stanje_Click);
            // 
            // narudzba
            // 
            this.narudzba.Location = new System.Drawing.Point(49, 183);
            this.narudzba.Name = "narudzba";
            this.narudzba.Size = new System.Drawing.Size(264, 29);
            this.narudzba.TabIndex = 1;
            this.narudzba.Text = "Naručivanje robe";
            this.narudzba.UseVisualStyleBackColor = true;
            this.narudzba.Click += new System.EventHandler(this.narudzba_Click);
            // 
            // arhiva
            // 
            this.arhiva.Location = new System.Drawing.Point(49, 238);
            this.arhiva.Name = "arhiva";
            this.arhiva.Size = new System.Drawing.Size(264, 30);
            this.arhiva.TabIndex = 2;
            this.arhiva.Text = "Arhiva Narudžbi";
            this.arhiva.UseVisualStyleBackColor = true;
            // 
            // otpis
            // 
            this.otpis.Location = new System.Drawing.Point(49, 291);
            this.otpis.Name = "otpis";
            this.otpis.Size = new System.Drawing.Size(264, 29);
            this.otpis.TabIndex = 3;
            this.otpis.Text = "Otpis robe sa skladišta";
            this.otpis.UseVisualStyleBackColor = true;
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naslov.Location = new System.Drawing.Point(136, 52);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(84, 36);
            this.naslov.TabIndex = 4;
            this.naslov.Text = "Boso";
            // 
            // odjava
            // 
            this.odjava.AutoSize = true;
            this.odjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odjava.Location = new System.Drawing.Point(303, 9);
            this.odjava.Name = "odjava";
            this.odjava.Size = new System.Drawing.Size(41, 13);
            this.odjava.TabIndex = 5;
            this.odjava.Text = "Odjava";
            this.odjava.Click += new System.EventHandler(this.odjava_Click);
            this.odjava.MouseLeave += new System.EventHandler(this.odjava_MouseLeave);
            this.odjava.MouseMove += new System.Windows.Forms.MouseEventHandler(this.odjava_MouseMove);
            // 
            // izlaz
            // 
            this.izlaz.AutoSize = true;
            this.izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izlaz.Location = new System.Drawing.Point(309, 337);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(28, 13);
            this.izlaz.TabIndex = 6;
            this.izlaz.Text = "Izlaz";
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            this.izlaz.MouseLeave += new System.EventHandler(this.izlaz_MouseLeave);
            this.izlaz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.izlaz_MouseMove);
            // 
            // korisnik
            // 
            this.korisnik.AutoSize = true;
            this.korisnik.Location = new System.Drawing.Point(214, 9);
            this.korisnik.Name = "korisnik";
            this.korisnik.Size = new System.Drawing.Size(47, 13);
            this.korisnik.TabIndex = 7;
            this.korisnik.Text = "Korisnik:";
            // 
            // kIme
            // 
            this.kIme.AutoSize = true;
            this.kIme.Location = new System.Drawing.Point(257, 9);
            this.kIme.Name = "kIme";
            this.kIme.Size = new System.Drawing.Size(10, 13);
            this.kIme.TabIndex = 8;
            this.kIme.Text = ".";
            // 
            // Zaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(356, 359);
            this.Controls.Add(this.kIme);
            this.Controls.Add(this.korisnik);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.odjava);
            this.Controls.Add(this.naslov);
            this.Controls.Add(this.otpis);
            this.Controls.Add(this.arhiva);
            this.Controls.Add(this.narudzba);
            this.Controls.Add(this.stanje);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Zaposlenik";
            this.Text = "Boso zaposlenik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stanje;
        private System.Windows.Forms.Button narudzba;
        private System.Windows.Forms.Button arhiva;
        private System.Windows.Forms.Button otpis;
        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Label odjava;
        private System.Windows.Forms.Label izlaz;
        private System.Windows.Forms.Label korisnik;
        private System.Windows.Forms.Label kIme;
    }
}