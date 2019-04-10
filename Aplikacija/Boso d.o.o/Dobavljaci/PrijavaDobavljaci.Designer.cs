namespace Dobavljaci
{
    partial class PrijavaDobavljaci
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
            this.korImeUnos = new System.Windows.Forms.TextBox();
            this.lozinkaUnos = new System.Windows.Forms.TextBox();
            this.naslov = new System.Windows.Forms.Label();
            this.kIme = new System.Windows.Forms.Label();
            this.lozinka = new System.Windows.Forms.Label();
            this.potvrdiPrijavu = new System.Windows.Forms.Button();
            this.izlaz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // korImeUnos
            // 
            this.korImeUnos.Location = new System.Drawing.Point(156, 129);
            this.korImeUnos.Name = "korImeUnos";
            this.korImeUnos.Size = new System.Drawing.Size(134, 26);
            this.korImeUnos.TabIndex = 0;
            // 
            // lozinkaUnos
            // 
            this.lozinkaUnos.Location = new System.Drawing.Point(156, 178);
            this.lozinkaUnos.Name = "lozinkaUnos";
            this.lozinkaUnos.Size = new System.Drawing.Size(134, 26);
            this.lozinkaUnos.TabIndex = 1;
            this.lozinkaUnos.UseSystemPasswordChar = true;
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naslov.Location = new System.Drawing.Point(134, 46);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(157, 52);
            this.naslov.TabIndex = 2;
            this.naslov.Text = "Prijava";
            // 
            // kIme
            // 
            this.kIme.AutoSize = true;
            this.kIme.Location = new System.Drawing.Point(12, 129);
            this.kIme.Name = "kIme";
            this.kIme.Size = new System.Drawing.Size(114, 20);
            this.kIme.TabIndex = 3;
            this.kIme.Text = "Korisničko ime:";
            // 
            // lozinka
            // 
            this.lozinka.AutoSize = true;
            this.lozinka.Location = new System.Drawing.Point(58, 185);
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(68, 20);
            this.lozinka.TabIndex = 4;
            this.lozinka.Text = "Lozinka:";
            // 
            // potvrdiPrijavu
            // 
            this.potvrdiPrijavu.Location = new System.Drawing.Point(180, 240);
            this.potvrdiPrijavu.Name = "potvrdiPrijavu";
            this.potvrdiPrijavu.Size = new System.Drawing.Size(75, 43);
            this.potvrdiPrijavu.TabIndex = 5;
            this.potvrdiPrijavu.Text = "Prijava";
            this.potvrdiPrijavu.UseVisualStyleBackColor = true;
            this.potvrdiPrijavu.Click += new System.EventHandler(this.potvrdiPrijavu_Click);
            // 
            // izlaz
            // 
            this.izlaz.AutoSize = true;
            this.izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izlaz.Location = new System.Drawing.Point(353, 271);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(42, 20);
            this.izlaz.TabIndex = 6;
            this.izlaz.Text = "Izlaz";
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            this.izlaz.MouseLeave += new System.EventHandler(this.izlaz_MouseLeave);
            this.izlaz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.izlaz_MouseMove);
            // 
            // PrijavaDobavljaci
            // 
            this.AcceptButton = this.potvrdiPrijavu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(420, 300);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.potvrdiPrijavu);
            this.Controls.Add(this.lozinka);
            this.Controls.Add(this.kIme);
            this.Controls.Add(this.naslov);
            this.Controls.Add(this.lozinkaUnos);
            this.Controls.Add(this.korImeUnos);
            this.Name = "PrijavaDobavljaci";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox korImeUnos;
        private System.Windows.Forms.TextBox lozinkaUnos;
        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Label kIme;
        private System.Windows.Forms.Label lozinka;
        private System.Windows.Forms.Button potvrdiPrijavu;
        private System.Windows.Forms.Label izlaz;
    }
}