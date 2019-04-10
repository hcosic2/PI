namespace Dobavljaci
{
    partial class Dobavljaci
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
            this.prihvatiNarudzbu = new System.Windows.Forms.Button();
            this.narudzbePrikaz = new System.Windows.Forms.DataGridView();
            this.zaprimanje = new System.Windows.Forms.Label();
            this.izlaz = new System.Windows.Forms.Label();
            this.odbijNarudzbu = new System.Windows.Forms.Button();
            this.ispisUkupno = new System.Windows.Forms.TextBox();
            this.ukupno = new System.Windows.Forms.Label();
            this.stavkeNarudzbePrikaz = new System.Windows.Forms.DataGridView();
            this.korisnik = new System.Windows.Forms.Label();
            this.imeKorisnika = new System.Windows.Forms.Label();
            this.narudžbe = new System.Windows.Forms.Label();
            this.stavke = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbePrikaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbePrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // prihvatiNarudzbu
            // 
            this.prihvatiNarudzbu.Location = new System.Drawing.Point(18, 628);
            this.prihvatiNarudzbu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prihvatiNarudzbu.Name = "prihvatiNarudzbu";
            this.prihvatiNarudzbu.Size = new System.Drawing.Size(177, 35);
            this.prihvatiNarudzbu.TabIndex = 0;
            this.prihvatiNarudzbu.Text = "Prihvati narudzbu";
            this.prihvatiNarudzbu.UseVisualStyleBackColor = true;
            this.prihvatiNarudzbu.Click += new System.EventHandler(this.prihvatiNarudzbu_Click);
            // 
            // narudzbePrikaz
            // 
            this.narudzbePrikaz.AllowUserToAddRows = false;
            this.narudzbePrikaz.AllowUserToDeleteRows = false;
            this.narudzbePrikaz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.narudzbePrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.narudzbePrikaz.Location = new System.Drawing.Point(50, 97);
            this.narudzbePrikaz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.narudzbePrikaz.MultiSelect = false;
            this.narudzbePrikaz.Name = "narudzbePrikaz";
            this.narudzbePrikaz.ReadOnly = true;
            this.narudzbePrikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.narudzbePrikaz.Size = new System.Drawing.Size(747, 251);
            this.narudzbePrikaz.TabIndex = 0;
            this.narudzbePrikaz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.narudzbePrikaz_CellContentClick);
            // 
            // zaprimanje
            // 
            this.zaprimanje.AutoSize = true;
            this.zaprimanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zaprimanje.Location = new System.Drawing.Point(237, 45);
            this.zaprimanje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zaprimanje.Name = "zaprimanje";
            this.zaprimanje.Size = new System.Drawing.Size(345, 40);
            this.zaprimanje.TabIndex = 2;
            this.zaprimanje.Text = "Zaprimanje narudžbi";
            // 
            // izlaz
            // 
            this.izlaz.AutoSize = true;
            this.izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izlaz.Location = new System.Drawing.Point(797, 690);
            this.izlaz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(44, 20);
            this.izlaz.TabIndex = 3;
            this.izlaz.Text = "Izlaz";
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            this.izlaz.MouseLeave += new System.EventHandler(this.izlaz_MouseLeave);
            this.izlaz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.izlaz_MouseMove);
            // 
            // odbijNarudzbu
            // 
            this.odbijNarudzbu.Location = new System.Drawing.Point(18, 683);
            this.odbijNarudzbu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.odbijNarudzbu.Name = "odbijNarudzbu";
            this.odbijNarudzbu.Size = new System.Drawing.Size(174, 35);
            this.odbijNarudzbu.TabIndex = 4;
            this.odbijNarudzbu.Text = "Odbij narudzbu";
            this.odbijNarudzbu.UseVisualStyleBackColor = true;
            this.odbijNarudzbu.Click += new System.EventHandler(this.odbijNarudzbu_Click);
            // 
            // ispisUkupno
            // 
            this.ispisUkupno.Location = new System.Drawing.Point(693, 632);
            this.ispisUkupno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ispisUkupno.Name = "ispisUkupno";
            this.ispisUkupno.ReadOnly = true;
            this.ispisUkupno.Size = new System.Drawing.Size(148, 26);
            this.ispisUkupno.TabIndex = 5;
            // 
            // ukupno
            // 
            this.ukupno.AutoSize = true;
            this.ukupno.Location = new System.Drawing.Point(597, 643);
            this.ukupno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ukupno.Name = "ukupno";
            this.ukupno.Size = new System.Drawing.Size(69, 20);
            this.ukupno.TabIndex = 6;
            this.ukupno.Text = "Ukupno:";
            // 
            // stavkeNarudzbePrikaz
            // 
            this.stavkeNarudzbePrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stavkeNarudzbePrikaz.Location = new System.Drawing.Point(18, 377);
            this.stavkeNarudzbePrikaz.Name = "stavkeNarudzbePrikaz";
            this.stavkeNarudzbePrikaz.ReadOnly = true;
            this.stavkeNarudzbePrikaz.RowTemplate.Height = 28;
            this.stavkeNarudzbePrikaz.Size = new System.Drawing.Size(823, 227);
            this.stavkeNarudzbePrikaz.TabIndex = 7;
            // 
            // korisnik
            // 
            this.korisnik.AutoSize = true;
            this.korisnik.Location = new System.Drawing.Point(589, 9);
            this.korisnik.Name = "korisnik";
            this.korisnik.Size = new System.Drawing.Size(68, 20);
            this.korisnik.TabIndex = 8;
            this.korisnik.Text = "Korisnik:";
            // 
            // imeKorisnika
            // 
            this.imeKorisnika.AutoSize = true;
            this.imeKorisnika.Location = new System.Drawing.Point(653, 9);
            this.imeKorisnika.Name = "imeKorisnika";
            this.imeKorisnika.Size = new System.Drawing.Size(13, 20);
            this.imeKorisnika.TabIndex = 9;
            this.imeKorisnika.Text = ".";
            // 
            // narudžbe
            // 
            this.narudžbe.AutoSize = true;
            this.narudžbe.Location = new System.Drawing.Point(46, 72);
            this.narudžbe.Name = "narudžbe";
            this.narudžbe.Size = new System.Drawing.Size(82, 20);
            this.narudžbe.TabIndex = 11;
            this.narudžbe.Text = "Narudžbe:";
            // 
            // stavke
            // 
            this.stavke.AutoSize = true;
            this.stavke.Location = new System.Drawing.Point(14, 354);
            this.stavke.Name = "stavke";
            this.stavke.Size = new System.Drawing.Size(133, 20);
            this.stavke.TabIndex = 12;
            this.stavke.Text = "Stavke narudžbe:";
            // 
            // Dobavljaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(859, 738);
            this.Controls.Add(this.stavke);
            this.Controls.Add(this.narudžbe);
            this.Controls.Add(this.imeKorisnika);
            this.Controls.Add(this.korisnik);
            this.Controls.Add(this.stavkeNarudzbePrikaz);
            this.Controls.Add(this.ukupno);
            this.Controls.Add(this.ispisUkupno);
            this.Controls.Add(this.odbijNarudzbu);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.zaprimanje);
            this.Controls.Add(this.narudzbePrikaz);
            this.Controls.Add(this.prihvatiNarudzbu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dobavljaci";
            this.Text = "Dobavljaci";
            this.Load += new System.EventHandler(this.Dobavljaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.narudzbePrikaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkeNarudzbePrikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prihvatiNarudzbu;
        private System.Windows.Forms.DataGridView narudzbePrikaz;
        private System.Windows.Forms.Label zaprimanje;
        private System.Windows.Forms.Label izlaz;
        private System.Windows.Forms.Button odbijNarudzbu;
        private System.Windows.Forms.TextBox ispisUkupno;
        private System.Windows.Forms.Label ukupno;
        private System.Windows.Forms.DataGridView stavkeNarudzbePrikaz;
        private System.Windows.Forms.Label korisnik;
        private System.Windows.Forms.Label imeKorisnika;
        private System.Windows.Forms.Label narudžbe;
        private System.Windows.Forms.Label stavke;
    }
}

