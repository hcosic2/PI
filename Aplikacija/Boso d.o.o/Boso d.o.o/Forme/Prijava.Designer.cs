namespace Boso_d.o.o
{
    partial class Prijava
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
            this.prijavaNaslov = new System.Windows.Forms.Label();
            this.lozinka = new System.Windows.Forms.Label();
            this.korIme = new System.Windows.Forms.Label();
            this.korImeUnos = new System.Windows.Forms.TextBox();
            this.lozinkaUnos = new System.Windows.Forms.TextBox();
            this.potvrdaPrijave = new System.Windows.Forms.Button();
            this.izlaz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prijavaNaslov
            // 
            this.prijavaNaslov.AutoSize = true;
            this.prijavaNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prijavaNaslov.Location = new System.Drawing.Point(140, 40);
            this.prijavaNaslov.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prijavaNaslov.Name = "prijavaNaslov";
            this.prijavaNaslov.Size = new System.Drawing.Size(106, 36);
            this.prijavaNaslov.TabIndex = 0;
            this.prijavaNaslov.Text = "Prijava";
            // 
            // lozinka
            // 
            this.lozinka.AutoSize = true;
            this.lozinka.Location = new System.Drawing.Point(58, 170);
            this.lozinka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lozinka.Name = "lozinka";
            this.lozinka.Size = new System.Drawing.Size(47, 13);
            this.lozinka.TabIndex = 1;
            this.lozinka.Text = "Lozinka:";
            // 
            // korIme
            // 
            this.korIme.AutoSize = true;
            this.korIme.Location = new System.Drawing.Point(27, 121);
            this.korIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.korIme.Name = "korIme";
            this.korIme.Size = new System.Drawing.Size(78, 13);
            this.korIme.TabIndex = 2;
            this.korIme.Text = "Korisničko ime:";
            // 
            // korImeUnos
            // 
            this.korImeUnos.Location = new System.Drawing.Point(131, 117);
            this.korImeUnos.Margin = new System.Windows.Forms.Padding(2);
            this.korImeUnos.Name = "korImeUnos";
            this.korImeUnos.Size = new System.Drawing.Size(121, 20);
            this.korImeUnos.TabIndex = 3;
            // 
            // lozinkaUnos
            // 
            this.lozinkaUnos.Location = new System.Drawing.Point(131, 166);
            this.lozinkaUnos.Margin = new System.Windows.Forms.Padding(2);
            this.lozinkaUnos.Name = "lozinkaUnos";
            this.lozinkaUnos.Size = new System.Drawing.Size(121, 20);
            this.lozinkaUnos.TabIndex = 4;
            this.lozinkaUnos.UseSystemPasswordChar = true;
            // 
            // potvrdaPrijave
            // 
            this.potvrdaPrijave.Location = new System.Drawing.Point(153, 212);
            this.potvrdaPrijave.Margin = new System.Windows.Forms.Padding(2);
            this.potvrdaPrijave.Name = "potvrdaPrijave";
            this.potvrdaPrijave.Size = new System.Drawing.Size(70, 21);
            this.potvrdaPrijave.TabIndex = 5;
            this.potvrdaPrijave.Text = "Prijava";
            this.potvrdaPrijave.UseVisualStyleBackColor = true;
            this.potvrdaPrijave.Click += new System.EventHandler(this.potvrdaPrijave_Click);
            // 
            // izlaz
            // 
            this.izlaz.AutoSize = true;
            this.izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izlaz.Location = new System.Drawing.Point(300, 263);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(28, 13);
            this.izlaz.TabIndex = 6;
            this.izlaz.Text = "Izlaz";
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            this.izlaz.MouseLeave += new System.EventHandler(this.izlaz_MouseLeave);
            this.izlaz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.izlaz_MouseMove);
            // 
            // Prijava
            // 
            this.AcceptButton = this.potvrdaPrijave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(347, 285);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.potvrdaPrijave);
            this.Controls.Add(this.lozinkaUnos);
            this.Controls.Add(this.korImeUnos);
            this.Controls.Add(this.korIme);
            this.Controls.Add(this.lozinka);
            this.Controls.Add(this.prijavaNaslov);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Prijava";
            this.Text = "Boso d.o.o";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prijavaNaslov;
        private System.Windows.Forms.Label lozinka;
        private System.Windows.Forms.Label korIme;
        private System.Windows.Forms.TextBox korImeUnos;
        private System.Windows.Forms.TextBox lozinkaUnos;
        private System.Windows.Forms.Button potvrdaPrijave;
        private System.Windows.Forms.Label izlaz;
    }
}

