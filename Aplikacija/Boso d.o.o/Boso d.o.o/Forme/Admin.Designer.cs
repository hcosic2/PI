namespace Boso_d.o.o
{
    partial class Admin
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
            this.stanjeSkladista = new System.Windows.Forms.Button();
            this.arhiva = new System.Windows.Forms.Button();
            this.narudzbaRobe = new System.Windows.Forms.Button();
            this.otpis = new System.Windows.Forms.Button();
            this.dodajDobavljaca = new System.Windows.Forms.Button();
            this.dodajZaposlenika = new System.Windows.Forms.Button();
            this.dodajArtikl = new System.Windows.Forms.Button();
            this.naslov = new System.Windows.Forms.Label();
            this.odjava = new System.Windows.Forms.Label();
            this.izlaz = new System.Windows.Forms.Label();
            this.korisnik = new System.Windows.Forms.Label();
            this.kIme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stanjeSkladista
            // 
            this.stanjeSkladista.Location = new System.Drawing.Point(28, 110);
            this.stanjeSkladista.Margin = new System.Windows.Forms.Padding(2);
            this.stanjeSkladista.Name = "stanjeSkladista";
            this.stanjeSkladista.Size = new System.Drawing.Size(186, 30);
            this.stanjeSkladista.TabIndex = 0;
            this.stanjeSkladista.Text = "Stanje na skladištu";
            this.stanjeSkladista.UseVisualStyleBackColor = true;
            this.stanjeSkladista.Click += new System.EventHandler(this.stanjeSkladista_Click);
            // 
            // arhiva
            // 
            this.arhiva.Location = new System.Drawing.Point(28, 245);
            this.arhiva.Name = "arhiva";
            this.arhiva.Size = new System.Drawing.Size(186, 30);
            this.arhiva.TabIndex = 1;
            this.arhiva.Text = "Arhiva Narudžbi";
            this.arhiva.UseVisualStyleBackColor = true;
            // 
            // narudzbaRobe
            // 
            this.narudzbaRobe.Location = new System.Drawing.Point(28, 180);
            this.narudzbaRobe.Name = "narudzbaRobe";
            this.narudzbaRobe.Size = new System.Drawing.Size(186, 30);
            this.narudzbaRobe.TabIndex = 2;
            this.narudzbaRobe.Text = "Naručivanje robe";
            this.narudzbaRobe.UseVisualStyleBackColor = true;
            this.narudzbaRobe.Click += new System.EventHandler(this.narudzbaRobe_Click);
            // 
            // otpis
            // 
            this.otpis.Location = new System.Drawing.Point(174, 305);
            this.otpis.Name = "otpis";
            this.otpis.Size = new System.Drawing.Size(186, 30);
            this.otpis.TabIndex = 3;
            this.otpis.Text = "Otpis robe sa skladišta";
            this.otpis.UseVisualStyleBackColor = true;
            // 
            // dodajDobavljaca
            // 
            this.dodajDobavljaca.Location = new System.Drawing.Point(322, 110);
            this.dodajDobavljaca.Name = "dodajDobavljaca";
            this.dodajDobavljaca.Size = new System.Drawing.Size(186, 30);
            this.dodajDobavljaca.TabIndex = 4;
            this.dodajDobavljaca.Text = "Dodaj, izbriši dobavljača";
            this.dodajDobavljaca.UseVisualStyleBackColor = true;
            // 
            // dodajZaposlenika
            // 
            this.dodajZaposlenika.Location = new System.Drawing.Point(322, 180);
            this.dodajZaposlenika.Name = "dodajZaposlenika";
            this.dodajZaposlenika.Size = new System.Drawing.Size(186, 30);
            this.dodajZaposlenika.TabIndex = 5;
            this.dodajZaposlenika.Text = "Dodaj, izbriši zaposlenika";
            this.dodajZaposlenika.UseVisualStyleBackColor = true;
            // 
            // dodajArtikl
            // 
            this.dodajArtikl.Location = new System.Drawing.Point(322, 245);
            this.dodajArtikl.Name = "dodajArtikl";
            this.dodajArtikl.Size = new System.Drawing.Size(186, 30);
            this.dodajArtikl.TabIndex = 6;
            this.dodajArtikl.Text = "Dodaj, izbriši artikl";
            this.dodajArtikl.UseVisualStyleBackColor = true;
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naslov.Location = new System.Drawing.Point(224, 48);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(84, 36);
            this.naslov.TabIndex = 7;
            this.naslov.Text = "Boso";
            // 
            // odjava
            // 
            this.odjava.AutoSize = true;
            this.odjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odjava.Location = new System.Drawing.Point(494, 9);
            this.odjava.Name = "odjava";
            this.odjava.Size = new System.Drawing.Size(41, 13);
            this.odjava.TabIndex = 8;
            this.odjava.Text = "Odjava";
            this.odjava.Click += new System.EventHandler(this.odjava_Click);
            this.odjava.MouseLeave += new System.EventHandler(this.odjava_MouseLeave);
            this.odjava.MouseMove += new System.Windows.Forms.MouseEventHandler(this.odjava_MouseMove);
            // 
            // izlaz
            // 
            this.izlaz.AutoSize = true;
            this.izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izlaz.Location = new System.Drawing.Point(507, 353);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(28, 13);
            this.izlaz.TabIndex = 9;
            this.izlaz.Text = "Izlaz";
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            this.izlaz.MouseLeave += new System.EventHandler(this.izlaz_MouseLeave);
            this.izlaz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.izlaz_MouseMove);
            // 
            // korisnik
            // 
            this.korisnik.AutoSize = true;
            this.korisnik.Location = new System.Drawing.Point(402, 9);
            this.korisnik.Name = "korisnik";
            this.korisnik.Size = new System.Drawing.Size(47, 13);
            this.korisnik.TabIndex = 10;
            this.korisnik.Text = "Korisnik:";
            // 
            // kIme
            // 
            this.kIme.AutoSize = true;
            this.kIme.Location = new System.Drawing.Point(446, 9);
            this.kIme.Name = "kIme";
            this.kIme.Size = new System.Drawing.Size(10, 13);
            this.kIme.TabIndex = 11;
            this.kIme.Text = ".";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(547, 375);
            this.Controls.Add(this.kIme);
            this.Controls.Add(this.korisnik);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.odjava);
            this.Controls.Add(this.naslov);
            this.Controls.Add(this.dodajArtikl);
            this.Controls.Add(this.dodajZaposlenika);
            this.Controls.Add(this.dodajDobavljaca);
            this.Controls.Add(this.otpis);
            this.Controls.Add(this.narudzbaRobe);
            this.Controls.Add(this.arhiva);
            this.Controls.Add(this.stanjeSkladista);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Admin";
            this.Text = "Boso Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stanjeSkladista;
        private System.Windows.Forms.Button arhiva;
        private System.Windows.Forms.Button narudzbaRobe;
        private System.Windows.Forms.Button otpis;
        private System.Windows.Forms.Button dodajDobavljaca;
        private System.Windows.Forms.Button dodajZaposlenika;
        private System.Windows.Forms.Button dodajArtikl;
        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Label odjava;
        private System.Windows.Forms.Label izlaz;
        private System.Windows.Forms.Label korisnik;
        private System.Windows.Forms.Label kIme;
    }
}