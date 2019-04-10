namespace Boso_d.o.o.Forme
{
    partial class FrmNarudzba
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
            this.comBoxDobavljac = new System.Windows.Forms.ComboBox();
            this.comBoxArtikl = new System.Windows.Forms.ComboBox();
            this.txtBoxKolicina = new System.Windows.Forms.TextBox();
            this.dgvNarudzba = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.lblDobavljac = new System.Windows.Forms.Label();
            this.lblArtikl = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dateTPDatum = new System.Windows.Forms.DateTimePicker();
            this.lblOdjava = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblNatrag = new System.Windows.Forms.Label();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.lblKorisni = new System.Windows.Forms.Label();
            this.lblKIme = new System.Windows.Forms.Label();
            this.txtBoxUkupnaCijena = new System.Windows.Forms.TextBox();
            this.lblUkupnaCijena = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzba)).BeginInit();
            this.SuspendLayout();
            // 
            // comBoxDobavljac
            // 
            this.comBoxDobavljac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxDobavljac.FormattingEnabled = true;
            this.comBoxDobavljac.Location = new System.Drawing.Point(99, 86);
            this.comBoxDobavljac.Name = "comBoxDobavljac";
            this.comBoxDobavljac.Size = new System.Drawing.Size(121, 21);
            this.comBoxDobavljac.TabIndex = 0;
            this.comBoxDobavljac.SelectedIndexChanged += new System.EventHandler(this.comBoxDobavljac_SelectedIndexChanged);
            // 
            // comBoxArtikl
            // 
            this.comBoxArtikl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxArtikl.FormattingEnabled = true;
            this.comBoxArtikl.Location = new System.Drawing.Point(99, 130);
            this.comBoxArtikl.Name = "comBoxArtikl";
            this.comBoxArtikl.Size = new System.Drawing.Size(121, 21);
            this.comBoxArtikl.TabIndex = 1;
            // 
            // txtBoxKolicina
            // 
            this.txtBoxKolicina.Location = new System.Drawing.Point(99, 177);
            this.txtBoxKolicina.Name = "txtBoxKolicina";
            this.txtBoxKolicina.Size = new System.Drawing.Size(121, 20);
            this.txtBoxKolicina.TabIndex = 2;
            // 
            // dgvNarudzba
            // 
            this.dgvNarudzba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzba.Location = new System.Drawing.Point(269, 77);
            this.dgvNarudzba.Name = "dgvNarudzba";
            this.dgvNarudzba.ReadOnly = true;
            this.dgvNarudzba.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzba.Size = new System.Drawing.Size(547, 195);
            this.dgvNarudzba.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(124, 333);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(96, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj stavku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnNaruci
            // 
            this.btnNaruci.Location = new System.Drawing.Point(741, 333);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(75, 23);
            this.btnNaruci.TabIndex = 5;
            this.btnNaruci.Text = "Naruči";
            this.btnNaruci.UseVisualStyleBackColor = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // lblDobavljac
            // 
            this.lblDobavljac.AutoSize = true;
            this.lblDobavljac.Location = new System.Drawing.Point(12, 94);
            this.lblDobavljac.Name = "lblDobavljac";
            this.lblDobavljac.Size = new System.Drawing.Size(58, 13);
            this.lblDobavljac.TabIndex = 6;
            this.lblDobavljac.Text = "Dobavljač:";
            // 
            // lblArtikl
            // 
            this.lblArtikl.AutoSize = true;
            this.lblArtikl.Location = new System.Drawing.Point(12, 138);
            this.lblArtikl.Name = "lblArtikl";
            this.lblArtikl.Size = new System.Drawing.Size(33, 13);
            this.lblArtikl.TabIndex = 7;
            this.lblArtikl.Text = "Artikl:";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(12, 184);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(47, 13);
            this.lblKolicina.TabIndex = 8;
            this.lblKolicina.Text = "Količina:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(12, 236);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 10;
            this.lblDatum.Text = "Datum:";
            // 
            // dateTPDatum
            // 
            this.dateTPDatum.Enabled = false;
            this.dateTPDatum.Location = new System.Drawing.Point(99, 230);
            this.dateTPDatum.Name = "dateTPDatum";
            this.dateTPDatum.Size = new System.Drawing.Size(121, 20);
            this.dateTPDatum.TabIndex = 11;
            // 
            // lblOdjava
            // 
            this.lblOdjava.AutoSize = true;
            this.lblOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdjava.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOdjava.Location = new System.Drawing.Point(775, 9);
            this.lblOdjava.Name = "lblOdjava";
            this.lblOdjava.Size = new System.Drawing.Size(41, 13);
            this.lblOdjava.TabIndex = 13;
            this.lblOdjava.Text = "Odjava";
            this.lblOdjava.Click += new System.EventHandler(this.lblOdjava_Click);
            this.lblOdjava.MouseLeave += new System.EventHandler(this.lblOdjava_MouseLeave);
            this.lblOdjava.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblOdjava_MouseMove);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.Location = new System.Drawing.Point(310, 20);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(241, 36);
            this.lblNaslov.TabIndex = 14;
            this.lblNaslov.Text = "Naručivanje robe";
            // 
            // lblNatrag
            // 
            this.lblNatrag.AutoSize = true;
            this.lblNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNatrag.Location = new System.Drawing.Point(16, 374);
            this.lblNatrag.Name = "lblNatrag";
            this.lblNatrag.Size = new System.Drawing.Size(54, 13);
            this.lblNatrag.TabIndex = 15;
            this.lblNatrag.Text = "<< Natrag";
            this.lblNatrag.Click += new System.EventHandler(this.lblNatrag_Click);
            this.lblNatrag.MouseLeave += new System.EventHandler(this.lblNatrag_MouseLeave);
            this.lblNatrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblNatrag_MouseMove);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(625, 333);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(95, 23);
            this.btnOtkazi.TabIndex = 16;
            this.btnOtkazi.Text = "Otkaži narudžbu";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzlaz.Location = new System.Drawing.Point(788, 375);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 17;
            this.lblIzlaz.Text = "Izlaz";
            this.lblIzlaz.Click += new System.EventHandler(this.lblIzlaz_Click);
            this.lblIzlaz.MouseLeave += new System.EventHandler(this.lblIzlaz_MouseLeave);
            this.lblIzlaz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblIzlaz_MouseMove);
            // 
            // lblKorisni
            // 
            this.lblKorisni.AutoSize = true;
            this.lblKorisni.Location = new System.Drawing.Point(687, 9);
            this.lblKorisni.Name = "lblKorisni";
            this.lblKorisni.Size = new System.Drawing.Size(47, 13);
            this.lblKorisni.TabIndex = 18;
            this.lblKorisni.Text = "Korisnik:";
            // 
            // lblKIme
            // 
            this.lblKIme.AutoSize = true;
            this.lblKIme.Location = new System.Drawing.Point(730, 9);
            this.lblKIme.Name = "lblKIme";
            this.lblKIme.Size = new System.Drawing.Size(10, 13);
            this.lblKIme.TabIndex = 19;
            this.lblKIme.Text = ".";
            // 
            // txtBoxUkupnaCijena
            // 
            this.txtBoxUkupnaCijena.Location = new System.Drawing.Point(741, 290);
            this.txtBoxUkupnaCijena.Name = "txtBoxUkupnaCijena";
            this.txtBoxUkupnaCijena.ReadOnly = true;
            this.txtBoxUkupnaCijena.Size = new System.Drawing.Size(75, 20);
            this.txtBoxUkupnaCijena.TabIndex = 20;
            // 
            // lblUkupnaCijena
            // 
            this.lblUkupnaCijena.AutoSize = true;
            this.lblUkupnaCijena.Location = new System.Drawing.Point(662, 293);
            this.lblUkupnaCijena.Name = "lblUkupnaCijena";
            this.lblUkupnaCijena.Size = new System.Drawing.Size(79, 13);
            this.lblUkupnaCijena.TabIndex = 21;
            this.lblUkupnaCijena.Text = "Ukupna cijena:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 335);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmNarudzba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(828, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblUkupnaCijena);
            this.Controls.Add(this.txtBoxUkupnaCijena);
            this.Controls.Add(this.lblKIme);
            this.Controls.Add(this.lblKorisni);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.lblNatrag);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblOdjava);
            this.Controls.Add(this.dateTPDatum);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblArtikl);
            this.Controls.Add(this.lblDobavljac);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvNarudzba);
            this.Controls.Add(this.txtBoxKolicina);
            this.Controls.Add(this.comBoxArtikl);
            this.Controls.Add(this.comBoxDobavljac);
            this.Name = "FrmNarudzba";
            this.Text = "Narudžba";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBoxDobavljac;
        private System.Windows.Forms.TextBox txtBoxKolicina;
        private System.Windows.Forms.DataGridView dgvNarudzba;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Label lblDobavljac;
        private System.Windows.Forms.Label lblArtikl;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dateTPDatum;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}