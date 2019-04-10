namespace Boso_d.o.o.Forme
{
    partial class FrmStanje
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
            this.dgvStanje = new System.Windows.Forms.DataGridView();
            this.lblOdjava = new System.Windows.Forms.Label();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblNatrag = new System.Windows.Forms.Label();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.lblKIme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanje)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStanje
            // 
            this.dgvStanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStanje.Location = new System.Drawing.Point(30, 97);
            this.dgvStanje.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStanje.Name = "dgvStanje";
            this.dgvStanje.ReadOnly = true;
            this.dgvStanje.RowTemplate.Height = 28;
            this.dgvStanje.Size = new System.Drawing.Size(361, 244);
            this.dgvStanje.TabIndex = 0;
            // 
            // lblOdjava
            // 
            this.lblOdjava.AutoSize = true;
            this.lblOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdjava.Location = new System.Drawing.Point(372, 9);
            this.lblOdjava.Name = "lblOdjava";
            this.lblOdjava.Size = new System.Drawing.Size(41, 13);
            this.lblOdjava.TabIndex = 1;
            this.lblOdjava.Text = "Odjava";
            this.lblOdjava.Click += new System.EventHandler(this.lblOdjava_Click);
            this.lblOdjava.MouseLeave += new System.EventHandler(this.lblOdjava_MouseLeave);
            this.lblOdjava.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblOdjava_MouseMove);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.Location = new System.Drawing.Point(86, 38);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(265, 36);
            this.lblNaslov.TabIndex = 2;
            this.lblNaslov.Text = "Stanje na skladištu";
            // 
            // lblNatrag
            // 
            this.lblNatrag.AutoSize = true;
            this.lblNatrag.Location = new System.Drawing.Point(27, 359);
            this.lblNatrag.Name = "lblNatrag";
            this.lblNatrag.Size = new System.Drawing.Size(54, 13);
            this.lblNatrag.TabIndex = 3;
            this.lblNatrag.Text = "<< Natrag";
            this.lblNatrag.Click += new System.EventHandler(this.lblNatrag_Click);
            this.lblNatrag.MouseLeave += new System.EventHandler(this.lblNatrag_MouseLeave);
            this.lblNatrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblNatrag_MouseMove_1);
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Location = new System.Drawing.Point(385, 359);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 4;
            this.lblIzlaz.Text = "Izlaz";
            this.lblIzlaz.Click += new System.EventHandler(this.lblIzlaz_Click);
            this.lblIzlaz.MouseLeave += new System.EventHandler(this.lblIzlaz_MouseLeave);
            this.lblIzlaz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblIzlaz_MouseMove);
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(273, 9);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(47, 13);
            this.lblKorisnik.TabIndex = 5;
            this.lblKorisnik.Text = "Korisnik:";
            // 
            // lblKIme
            // 
            this.lblKIme.AutoSize = true;
            this.lblKIme.Location = new System.Drawing.Point(316, 9);
            this.lblKIme.Name = "lblKIme";
            this.lblKIme.Size = new System.Drawing.Size(10, 13);
            this.lblKIme.TabIndex = 6;
            this.lblKIme.Text = ".";
            // 
            // FrmStanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(425, 381);
            this.Controls.Add(this.lblKIme);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.lblNatrag);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblOdjava);
            this.Controls.Add(this.dgvStanje);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmStanje";
            this.Text = "Stanje na skladištu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStanje;
        private System.Windows.Forms.Label lblOdjava;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblNatrag;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Label lblKIme;
    }
}