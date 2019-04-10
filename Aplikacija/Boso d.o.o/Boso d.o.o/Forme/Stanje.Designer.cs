namespace Boso_d.o.o.Forme
{
    partial class Stanje
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
            this.prikazStanja = new System.Windows.Forms.DataGridView();
            this.odjava = new System.Windows.Forms.Label();
            this.naslov = new System.Windows.Forms.Label();
            this.natrag = new System.Windows.Forms.Label();
            this.izlaz = new System.Windows.Forms.Label();
            this.korisnik = new System.Windows.Forms.Label();
            this.kIme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prikazStanja)).BeginInit();
            this.SuspendLayout();
            // 
            // prikazStanja
            // 
            this.prikazStanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prikazStanja.Location = new System.Drawing.Point(30, 97);
            this.prikazStanja.Margin = new System.Windows.Forms.Padding(2);
            this.prikazStanja.Name = "prikazStanja";
            this.prikazStanja.ReadOnly = true;
            this.prikazStanja.RowTemplate.Height = 28;
            this.prikazStanja.Size = new System.Drawing.Size(361, 244);
            this.prikazStanja.TabIndex = 0;
            // 
            // odjava
            // 
            this.odjava.AutoSize = true;
            this.odjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odjava.Location = new System.Drawing.Point(372, 9);
            this.odjava.Name = "odjava";
            this.odjava.Size = new System.Drawing.Size(41, 13);
            this.odjava.TabIndex = 1;
            this.odjava.Text = "Odjava";
            this.odjava.Click += new System.EventHandler(this.odjava_Click);
            this.odjava.MouseLeave += new System.EventHandler(this.odjava_MouseLeave);
            this.odjava.MouseMove += new System.Windows.Forms.MouseEventHandler(this.odjava_MouseMove);
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naslov.Location = new System.Drawing.Point(86, 42);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(265, 36);
            this.naslov.TabIndex = 2;
            this.naslov.Text = "Stanje na skladištu";
            // 
            // natrag
            // 
            this.natrag.AutoSize = true;
            this.natrag.Location = new System.Drawing.Point(27, 359);
            this.natrag.Name = "natrag";
            this.natrag.Size = new System.Drawing.Size(54, 13);
            this.natrag.TabIndex = 3;
            this.natrag.Text = "<< Natrag";
            this.natrag.Click += new System.EventHandler(this.natrag_Click);
            this.natrag.MouseLeave += new System.EventHandler(this.natrag_MouseLeave);
            this.natrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.natrag_MouseMove_1);
            // 
            // izlaz
            // 
            this.izlaz.AutoSize = true;
            this.izlaz.Location = new System.Drawing.Point(385, 359);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(28, 13);
            this.izlaz.TabIndex = 4;
            this.izlaz.Text = "Izlaz";
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            this.izlaz.MouseLeave += new System.EventHandler(this.izlaz_MouseLeave);
            this.izlaz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.izlaz_MouseMove);
            // 
            // korisnik
            // 
            this.korisnik.AutoSize = true;
            this.korisnik.Location = new System.Drawing.Point(273, 9);
            this.korisnik.Name = "korisnik";
            this.korisnik.Size = new System.Drawing.Size(47, 13);
            this.korisnik.TabIndex = 5;
            this.korisnik.Text = "Korisnik:";
            // 
            // kIme
            // 
            this.kIme.AutoSize = true;
            this.kIme.Location = new System.Drawing.Point(316, 9);
            this.kIme.Name = "kIme";
            this.kIme.Size = new System.Drawing.Size(10, 13);
            this.kIme.TabIndex = 6;
            this.kIme.Text = ".";
            // 
            // Stanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(425, 381);
            this.Controls.Add(this.kIme);
            this.Controls.Add(this.korisnik);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.natrag);
            this.Controls.Add(this.naslov);
            this.Controls.Add(this.odjava);
            this.Controls.Add(this.prikazStanja);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Stanje";
            this.Text = "Stanje na skladištu";
            ((System.ComponentModel.ISupportInitialize)(this.prikazStanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView prikazStanja;
        private System.Windows.Forms.Label odjava;
        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Label natrag;
        private System.Windows.Forms.Label izlaz;
        private System.Windows.Forms.Label korisnik;
        private System.Windows.Forms.Label kIme;
    }
}