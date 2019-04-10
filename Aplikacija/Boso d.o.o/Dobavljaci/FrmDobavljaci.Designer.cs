namespace Dobavljaci
{
    partial class FrmDobavljaci
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
            this.dgvNarudzba = new System.Windows.Forms.DataGridView();
            this.lblZaprimanje = new System.Windows.Forms.Label();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.odbijNarudzbu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzba)).BeginInit();
            this.SuspendLayout();
            // 
            // prihvatiNarudzbu
            // 
            this.prihvatiNarudzbu.Location = new System.Drawing.Point(12, 268);
            this.prihvatiNarudzbu.Name = "prihvatiNarudzbu";
            this.prihvatiNarudzbu.Size = new System.Drawing.Size(118, 23);
            this.prihvatiNarudzbu.TabIndex = 0;
            this.prihvatiNarudzbu.Text = "Prihvati narudzbu";
            this.prihvatiNarudzbu.UseVisualStyleBackColor = true;
            this.prihvatiNarudzbu.Click += new System.EventHandler(this.prihvatiNarudzbu_Click);
            // 
            // dgvNarudzba
            // 
            this.dgvNarudzba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzba.Location = new System.Drawing.Point(12, 81);
            this.dgvNarudzba.Name = "dgvNarudzba";
            this.dgvNarudzba.ReadOnly = true;
            this.dgvNarudzba.Size = new System.Drawing.Size(443, 163);
            this.dgvNarudzba.TabIndex = 1;
            // 
            // lblZaprimanje
            // 
            this.lblZaprimanje.AutoSize = true;
            this.lblZaprimanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZaprimanje.Location = new System.Drawing.Point(98, 28);
            this.lblZaprimanje.Name = "lblZaprimanje";
            this.lblZaprimanje.Size = new System.Drawing.Size(286, 36);
            this.lblZaprimanje.TabIndex = 2;
            this.lblZaprimanje.Text = "Zaprimanje narudžbi";
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzlaz.Location = new System.Drawing.Point(427, 273);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 3;
            this.lblIzlaz.Text = "Izlaz";
            this.lblIzlaz.Click += new System.EventHandler(this.lblIzlaz_Click);
            this.lblIzlaz.MouseLeave += new System.EventHandler(this.lblIzlaz_MouseLeave);
            this.lblIzlaz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblIzlaz_MouseMove);
            // 
            // odbijNarudzbu
            // 
            this.odbijNarudzbu.Location = new System.Drawing.Point(162, 268);
            this.odbijNarudzbu.Name = "odbijNarudzbu";
            this.odbijNarudzbu.Size = new System.Drawing.Size(116, 23);
            this.odbijNarudzbu.TabIndex = 4;
            this.odbijNarudzbu.Text = "Odbij narudzbu";
            this.odbijNarudzbu.UseVisualStyleBackColor = true;
            this.odbijNarudzbu.Click += new System.EventHandler(this.odbijNarudzbu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(304, 270);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // FrmDobavljaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(473, 303);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.odbijNarudzbu);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.lblZaprimanje);
            this.Controls.Add(this.dgvNarudzba);
            this.Controls.Add(this.prihvatiNarudzbu);
            this.Name = "FrmDobavljaci";
            this.Text = "Dobavljaci";
            this.Load += new System.EventHandler(this.FrmDobavljaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prihvatiNarudzbu;
        private System.Windows.Forms.DataGridView dgvNarudzba;
        private System.Windows.Forms.Label lblZaprimanje;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.Button odbijNarudzbu;
        private System.Windows.Forms.TextBox textBox1;
    }
}

