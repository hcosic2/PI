namespace Boso_d.o.o.Forme
{
    partial class Narudzba
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
            this.odabirDobavljaca = new System.Windows.Forms.ComboBox();
            this.odabirArtikla = new System.Windows.Forms.ComboBox();
            this.unosKolicine = new System.Windows.Forms.TextBox();
            this.ispisStavki = new System.Windows.Forms.DataGridView();
            this.dodajStavku = new System.Windows.Forms.Button();
            this.naruciRobu = new System.Windows.Forms.Button();
            this.dobavljac = new System.Windows.Forms.Label();
            this.artikl = new System.Windows.Forms.Label();
            this.kolicina = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.Label();
            this.danasnjiDatum = new System.Windows.Forms.DateTimePicker();
            this.odjava = new System.Windows.Forms.Label();
            this.naslov = new System.Windows.Forms.Label();
            this.otkaziNarudzbu = new System.Windows.Forms.Button();
            this.izlaz = new System.Windows.Forms.Label();
            this.korisnik = new System.Windows.Forms.Label();
            this.kIme = new System.Windows.Forms.Label();
            this.ispisUkupneCijene = new System.Windows.Forms.TextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.natrag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ispisStavki)).BeginInit();
            this.SuspendLayout();
            // 
            // odabirDobavljaca
            // 
            this.odabirDobavljaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.odabirDobavljaca.FormattingEnabled = true;
            this.odabirDobavljaca.Location = new System.Drawing.Point(148, 132);
            this.odabirDobavljaca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.odabirDobavljaca.Name = "odabirDobavljaca";
            this.odabirDobavljaca.Size = new System.Drawing.Size(180, 28);
            this.odabirDobavljaca.TabIndex = 0;
            this.odabirDobavljaca.SelectedIndexChanged += new System.EventHandler(this.odabirDobavljaca_SelectedIndexChanged);
            // 
            // odabirArtikla
            // 
            this.odabirArtikla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.odabirArtikla.FormattingEnabled = true;
            this.odabirArtikla.Location = new System.Drawing.Point(148, 200);
            this.odabirArtikla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.odabirArtikla.Name = "odabirArtikla";
            this.odabirArtikla.Size = new System.Drawing.Size(180, 28);
            this.odabirArtikla.TabIndex = 1;
            // 
            // unosKolicine
            // 
            this.unosKolicine.Location = new System.Drawing.Point(148, 272);
            this.unosKolicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.unosKolicine.Name = "unosKolicine";
            this.unosKolicine.Size = new System.Drawing.Size(180, 26);
            this.unosKolicine.TabIndex = 2;
            // 
            // ispisStavki
            // 
            this.ispisStavki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ispisStavki.Location = new System.Drawing.Point(404, 118);
            this.ispisStavki.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ispisStavki.Name = "ispisStavki";
            this.ispisStavki.ReadOnly = true;
            this.ispisStavki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ispisStavki.Size = new System.Drawing.Size(820, 300);
            this.ispisStavki.TabIndex = 3;
            // 
            // dodajStavku
            // 
            this.dodajStavku.Location = new System.Drawing.Point(186, 512);
            this.dodajStavku.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dodajStavku.Name = "dodajStavku";
            this.dodajStavku.Size = new System.Drawing.Size(144, 35);
            this.dodajStavku.TabIndex = 4;
            this.dodajStavku.Text = "Dodaj stavku";
            this.dodajStavku.UseVisualStyleBackColor = true;
            this.dodajStavku.Click += new System.EventHandler(this.dodajStavku_Click);
            // 
            // naruciRobu
            // 
            this.naruciRobu.Location = new System.Drawing.Point(1112, 512);
            this.naruciRobu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naruciRobu.Name = "naruciRobu";
            this.naruciRobu.Size = new System.Drawing.Size(112, 35);
            this.naruciRobu.TabIndex = 5;
            this.naruciRobu.Text = "Naruči";
            this.naruciRobu.UseVisualStyleBackColor = true;
            this.naruciRobu.Click += new System.EventHandler(this.naruciRobu_Click);
            // 
            // dobavljac
            // 
            this.dobavljac.AutoSize = true;
            this.dobavljac.Location = new System.Drawing.Point(18, 145);
            this.dobavljac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dobavljac.Name = "dobavljac";
            this.dobavljac.Size = new System.Drawing.Size(82, 20);
            this.dobavljac.TabIndex = 6;
            this.dobavljac.Text = "Dobavljač:";
            // 
            // artikl
            // 
            this.artikl.AutoSize = true;
            this.artikl.Location = new System.Drawing.Point(18, 212);
            this.artikl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artikl.Name = "artikl";
            this.artikl.Size = new System.Drawing.Size(48, 20);
            this.artikl.TabIndex = 7;
            this.artikl.Text = "Artikl:";
            // 
            // kolicina
            // 
            this.kolicina.AutoSize = true;
            this.kolicina.Location = new System.Drawing.Point(18, 283);
            this.kolicina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kolicina.Name = "kolicina";
            this.kolicina.Size = new System.Drawing.Size(67, 20);
            this.kolicina.TabIndex = 8;
            this.kolicina.Text = "Količina:";
            // 
            // datum
            // 
            this.datum.AutoSize = true;
            this.datum.Location = new System.Drawing.Point(18, 363);
            this.datum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(61, 20);
            this.datum.TabIndex = 10;
            this.datum.Text = "Datum:";
            // 
            // danasnjiDatum
            // 
            this.danasnjiDatum.Enabled = false;
            this.danasnjiDatum.Location = new System.Drawing.Point(148, 354);
            this.danasnjiDatum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.danasnjiDatum.Name = "danasnjiDatum";
            this.danasnjiDatum.Size = new System.Drawing.Size(180, 26);
            this.danasnjiDatum.TabIndex = 11;
            // 
            // odjava
            // 
            this.odjava.AutoSize = true;
            this.odjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odjava.ForeColor = System.Drawing.SystemColors.ControlText;
            this.odjava.Location = new System.Drawing.Point(1162, 14);
            this.odjava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.odjava.Name = "odjava";
            this.odjava.Size = new System.Drawing.Size(61, 20);
            this.odjava.TabIndex = 13;
            this.odjava.Text = "Odjava";
            this.odjava.Click += new System.EventHandler(this.odjava_Click);
            this.odjava.MouseLeave += new System.EventHandler(this.odjava_MouseLeave);
            this.odjava.MouseMove += new System.Windows.Forms.MouseEventHandler(this.odjava_MouseMove);
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naslov.Location = new System.Drawing.Point(465, 31);
            this.naslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(353, 52);
            this.naslov.TabIndex = 14;
            this.naslov.Text = "Naručivanje robe";
            // 
            // otkaziNarudzbu
            // 
            this.otkaziNarudzbu.Location = new System.Drawing.Point(938, 512);
            this.otkaziNarudzbu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.otkaziNarudzbu.Name = "otkaziNarudzbu";
            this.otkaziNarudzbu.Size = new System.Drawing.Size(142, 35);
            this.otkaziNarudzbu.TabIndex = 16;
            this.otkaziNarudzbu.Text = "Otkaži narudžbu";
            this.otkaziNarudzbu.UseVisualStyleBackColor = true;
            this.otkaziNarudzbu.Click += new System.EventHandler(this.otkaziNarudzbu_Click);
            // 
            // izlaz
            // 
            this.izlaz.AutoSize = true;
            this.izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izlaz.Location = new System.Drawing.Point(1182, 577);
            this.izlaz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(44, 20);
            this.izlaz.TabIndex = 17;
            this.izlaz.Text = "Izlaz";
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            this.izlaz.MouseLeave += new System.EventHandler(this.izlaz_MouseLeave);
            this.izlaz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.izlaz_MouseMove);
            // 
            // korisnik
            // 
            this.korisnik.AutoSize = true;
            this.korisnik.Location = new System.Drawing.Point(1030, 14);
            this.korisnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.korisnik.Name = "korisnik";
            this.korisnik.Size = new System.Drawing.Size(68, 20);
            this.korisnik.TabIndex = 18;
            this.korisnik.Text = "Korisnik:";
            // 
            // kIme
            // 
            this.kIme.AutoSize = true;
            this.kIme.Location = new System.Drawing.Point(1095, 14);
            this.kIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kIme.Name = "kIme";
            this.kIme.Size = new System.Drawing.Size(13, 20);
            this.kIme.TabIndex = 19;
            this.kIme.Text = ".";
            // 
            // ispisUkupneCijene
            // 
            this.ispisUkupneCijene.Location = new System.Drawing.Point(1112, 446);
            this.ispisUkupneCijene.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ispisUkupneCijene.Name = "ispisUkupneCijene";
            this.ispisUkupneCijene.ReadOnly = true;
            this.ispisUkupneCijene.Size = new System.Drawing.Size(110, 26);
            this.ispisUkupneCijene.TabIndex = 20;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(993, 451);
            this.lblCijena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(114, 20);
            this.lblCijena.TabIndex = 21;
            this.lblCijena.Text = "Ukupna cijena:";
            // 
            // natrag
            // 
            this.natrag.AutoSize = true;
            this.natrag.Location = new System.Drawing.Point(12, 577);
            this.natrag.Name = "natrag";
            this.natrag.Size = new System.Drawing.Size(75, 20);
            this.natrag.TabIndex = 23;
            this.natrag.Text = "<<Natrag";
            this.natrag.Click += new System.EventHandler(this.natrag_Click);
            this.natrag.MouseLeave += new System.EventHandler(this.natrag_MouseLeave);
            this.natrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.natrag_MouseMove);
            // 
            // Narudzba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1242, 611);
            this.Controls.Add(this.natrag);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.ispisUkupneCijene);
            this.Controls.Add(this.kIme);
            this.Controls.Add(this.korisnik);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.otkaziNarudzbu);
            this.Controls.Add(this.naslov);
            this.Controls.Add(this.odjava);
            this.Controls.Add(this.danasnjiDatum);
            this.Controls.Add(this.datum);
            this.Controls.Add(this.kolicina);
            this.Controls.Add(this.artikl);
            this.Controls.Add(this.dobavljac);
            this.Controls.Add(this.naruciRobu);
            this.Controls.Add(this.dodajStavku);
            this.Controls.Add(this.ispisStavki);
            this.Controls.Add(this.unosKolicine);
            this.Controls.Add(this.odabirArtikla);
            this.Controls.Add(this.odabirDobavljaca);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Narudzba";
            this.Text = "Narudžba";
            this.Load += new System.EventHandler(this.Narudzba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ispisStavki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBoxDobavljac;
        private System.Windows.Forms.TextBox txtBoxKolicina;
        private System.Windows.Forms.DataGridView dgvNarudzba;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Label dobavljac;
        private System.Windows.Forms.Label artikl;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker danasnjiDatum;
        private System.Windows.Forms.ComboBox comBoxArtikl;
        private System.Windows.Forms.Label lblOdjava;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblNatrag;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.Label lblKorisni;
        private System.Windows.Forms.Label lblKIme;
        private System.Windows.Forms.TextBox txtBoxUkupnaCijena;
        private System.Windows.Forms.Label lblUkupnaCijena;
        private System.Windows.Forms.ComboBox odabirDobavljaca;
        private System.Windows.Forms.ComboBox odabirArtikla;
        private System.Windows.Forms.TextBox unosKolicine;
        private System.Windows.Forms.DataGridView ispisStavki;
        private System.Windows.Forms.Button dodajStavku;
        private System.Windows.Forms.Button naruciRobu;
        private System.Windows.Forms.Label kolicina;
        private System.Windows.Forms.Label datum;
        private System.Windows.Forms.Label odjava;
        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Button otkaziNarudzbu;
        private System.Windows.Forms.Label izlaz;
        private System.Windows.Forms.Label korisnik;
        private System.Windows.Forms.Label kIme;
        private System.Windows.Forms.TextBox ispisUkupneCijene;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label natrag;
    }
}