namespace Taschenrechner
{
    partial class MatheForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Funktionen = new System.Windows.Forms.Label();
            this.btn_Fakultaet = new System.Windows.Forms.Button();
            this.btn_Wurzel = new System.Windows.Forms.Button();
            this.btn_Potenz = new System.Windows.Forms.Button();
            this.btn_Primzahlen = new System.Windows.Forms.Button();
            this.btn_Dezimalbruch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Funktionen
            // 
            this.lbl_Funktionen.AutoSize = true;
            this.lbl_Funktionen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_Funktionen.Location = new System.Drawing.Point(256, 37);
            this.lbl_Funktionen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Funktionen.Name = "lbl_Funktionen";
            this.lbl_Funktionen.Size = new System.Drawing.Size(115, 25);
            this.lbl_Funktionen.TabIndex = 0;
            this.lbl_Funktionen.Text = "Funktionen:";
            // 
            // btn_Fakultaet
            // 
            this.btn_Fakultaet.Location = new System.Drawing.Point(125, 94);
            this.btn_Fakultaet.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Fakultaet.Name = "btn_Fakultaet";
            this.btn_Fakultaet.Size = new System.Drawing.Size(153, 51);
            this.btn_Fakultaet.TabIndex = 1;
            this.btn_Fakultaet.Text = "Fakultät";
            this.btn_Fakultaet.UseVisualStyleBackColor = true;
            this.btn_Fakultaet.Click += new System.EventHandler(this.Fakultät_Click);
            // 
            // btn_Wurzel
            // 
            this.btn_Wurzel.Location = new System.Drawing.Point(350, 94);
            this.btn_Wurzel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Wurzel.Name = "btn_Wurzel";
            this.btn_Wurzel.Size = new System.Drawing.Size(151, 51);
            this.btn_Wurzel.TabIndex = 2;
            this.btn_Wurzel.Text = "Wurzel";
            this.btn_Wurzel.UseVisualStyleBackColor = true;
            this.btn_Wurzel.Click += new System.EventHandler(this.Wurzel_Click);
            // 
            // btn_Potenz
            // 
            this.btn_Potenz.Location = new System.Drawing.Point(125, 158);
            this.btn_Potenz.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Potenz.Name = "btn_Potenz";
            this.btn_Potenz.Size = new System.Drawing.Size(153, 53);
            this.btn_Potenz.TabIndex = 3;
            this.btn_Potenz.Text = "Potenzfunktion";
            this.btn_Potenz.UseVisualStyleBackColor = true;
            this.btn_Potenz.Click += new System.EventHandler(this.Potenz_Click);
            // 
            // btn_Primzahlen
            // 
            this.btn_Primzahlen.Location = new System.Drawing.Point(350, 158);
            this.btn_Primzahlen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Primzahlen.Name = "btn_Primzahlen";
            this.btn_Primzahlen.Size = new System.Drawing.Size(151, 53);
            this.btn_Primzahlen.TabIndex = 4;
            this.btn_Primzahlen.Text = "Primzahlen";
            this.btn_Primzahlen.UseVisualStyleBackColor = true;
            this.btn_Primzahlen.Click += new System.EventHandler(this.Primzahlen_Click);
            // 
            // btn_Dezimalbruch
            // 
            this.btn_Dezimalbruch.Location = new System.Drawing.Point(125, 225);
            this.btn_Dezimalbruch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Dezimalbruch.Name = "btn_Dezimalbruch";
            this.btn_Dezimalbruch.Size = new System.Drawing.Size(153, 54);
            this.btn_Dezimalbruch.TabIndex = 5;
            this.btn_Dezimalbruch.Text = "Dezimalbruch-Konvertierung";
            this.btn_Dezimalbruch.UseVisualStyleBackColor = true;
            this.btn_Dezimalbruch.Click += new System.EventHandler(this.Dezimalbruchkonvertierung_Click);
            // 
            // MatheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 366);
            this.Controls.Add(this.btn_Dezimalbruch);
            this.Controls.Add(this.btn_Primzahlen);
            this.Controls.Add(this.btn_Potenz);
            this.Controls.Add(this.btn_Wurzel);
            this.Controls.Add(this.btn_Fakultaet);
            this.Controls.Add(this.lbl_Funktionen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MatheForm";
            this.Text = "Mathamatische Funktionen";
            this.Load += new System.EventHandler(this.MatheForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Funktionen;
        private System.Windows.Forms.Button btn_Fakultaet;
        private System.Windows.Forms.Button btn_Wurzel;
        private System.Windows.Forms.Button btn_Potenz;
        private System.Windows.Forms.Button btn_Primzahlen;
        private System.Windows.Forms.Button btn_Dezimalbruch;
    }
}

