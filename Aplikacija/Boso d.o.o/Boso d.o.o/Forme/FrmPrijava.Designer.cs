namespace Boso_d.o.o
{
    partial class FrmPrijava
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
            this.lblPrijava = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblKorIme = new System.Windows.Forms.Label();
            this.txtBoxKorIme = new System.Windows.Forms.TextBox();
            this.txtBoxLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrijava
            // 
            this.lblPrijava.AutoSize = true;
            this.lblPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrijava.Location = new System.Drawing.Point(140, 40);
            this.lblPrijava.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrijava.Name = "lblPrijava";
            this.lblPrijava.Size = new System.Drawing.Size(106, 36);
            this.lblPrijava.TabIndex = 0;
            this.lblPrijava.Text = "Prijava";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(58, 170);
            this.lblLozinka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(47, 13);
            this.lblLozinka.TabIndex = 1;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // lblKorIme
            // 
            this.lblKorIme.AutoSize = true;
            this.lblKorIme.Location = new System.Drawing.Point(27, 121);
            this.lblKorIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKorIme.Name = "lblKorIme";
            this.lblKorIme.Size = new System.Drawing.Size(78, 13);
            this.lblKorIme.TabIndex = 2;
            this.lblKorIme.Text = "Korisničko ime:";
            // 
            // txtBoxKorIme
            // 
            this.txtBoxKorIme.Location = new System.Drawing.Point(131, 117);
            this.txtBoxKorIme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxKorIme.Name = "txtBoxKorIme";
            this.txtBoxKorIme.Size = new System.Drawing.Size(121, 20);
            this.txtBoxKorIme.TabIndex = 3;
            // 
            // txtBoxLozinka
            // 
            this.txtBoxLozinka.Location = new System.Drawing.Point(131, 166);
            this.txtBoxLozinka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxLozinka.Name = "txtBoxLozinka";
            this.txtBoxLozinka.Size = new System.Drawing.Size(121, 20);
            this.txtBoxLozinka.TabIndex = 4;
            this.txtBoxLozinka.UseSystemPasswordChar = true;
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(153, 212);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(70, 21);
            this.btnPrijava.TabIndex = 5;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.AutoSize = true;
            this.lblIzlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzlaz.Location = new System.Drawing.Point(300, 263);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(28, 13);
            this.lblIzlaz.TabIndex = 6;
            this.lblIzlaz.Text = "Izlaz";
            this.lblIzlaz.Click += new System.EventHandler(this.lblIzlaz_Click);
            this.lblIzlaz.MouseLeave += new System.EventHandler(this.lblIzlaz_MouseLeave);
            this.lblIzlaz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblIzlaz_MouseMove);
            // 
            // FrmPrijava
            // 
            this.AcceptButton = this.btnPrijava;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(347, 285);
            this.Controls.Add(this.lblIzlaz);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtBoxLozinka);
            this.Controls.Add(this.txtBoxKorIme);
            this.Controls.Add(this.lblKorIme);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblPrijava);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPrijava";
            this.Text = "Boso d.o.o";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrijava;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblKorIme;
        private System.Windows.Forms.TextBox txtBoxKorIme;
        private System.Windows.Forms.TextBox txtBoxLozinka;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Label lblIzlaz;
    }
}

