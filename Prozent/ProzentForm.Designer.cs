namespace Taschenrechner
{
    partial class ProzentForm
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
            this.lbl_Uebersicht = new System.Windows.Forms.Label();
            this.btn_ProzentDazu = new System.Windows.Forms.Button();
            this.btn_ProzentWeg = new System.Windows.Forms.Button();
            this.btn_ProzentVon = new System.Windows.Forms.Button();
            this.btn_Satz = new System.Windows.Forms.Button();
            this.btn_BruttoVonNetto = new System.Windows.Forms.Button();
            this.btn_NettoVonBrutto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Uebersicht
            // 
            this.lbl_Uebersicht.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Uebersicht.AutoSize = true;
            this.lbl_Uebersicht.Location = new System.Drawing.Point(233, 36);
            this.lbl_Uebersicht.Name = "lbl_Uebersicht";
            this.lbl_Uebersicht.Size = new System.Drawing.Size(63, 13);
            this.lbl_Uebersicht.TabIndex = 0;
            this.lbl_Uebersicht.Text = "Funktionen:";
            this.lbl_Uebersicht.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_ProzentDazu
            // 
            this.btn_ProzentDazu.Location = new System.Drawing.Point(92, 87);
            this.btn_ProzentDazu.Name = "btn_ProzentDazu";
            this.btn_ProzentDazu.Size = new System.Drawing.Size(103, 48);
            this.btn_ProzentDazu.TabIndex = 1;
            this.btn_ProzentDazu.Text = "%dazu";
            this.btn_ProzentDazu.UseVisualStyleBackColor = true;
            this.btn_ProzentDazu.Click += new System.EventHandler(this.btn_ProzentDazu_Click);
            // 
            // btn_ProzentWeg
            // 
            this.btn_ProzentWeg.Location = new System.Drawing.Point(92, 153);
            this.btn_ProzentWeg.Name = "btn_ProzentWeg";
            this.btn_ProzentWeg.Size = new System.Drawing.Size(103, 48);
            this.btn_ProzentWeg.TabIndex = 2;
            this.btn_ProzentWeg.Text = "%weg";
            this.btn_ProzentWeg.UseVisualStyleBackColor = true;
            this.btn_ProzentWeg.Click += new System.EventHandler(this.btn_ProzentWeg_Click);
            // 
            // btn_ProzentVon
            // 
            this.btn_ProzentVon.Location = new System.Drawing.Point(92, 220);
            this.btn_ProzentVon.Name = "btn_ProzentVon";
            this.btn_ProzentVon.Size = new System.Drawing.Size(103, 48);
            this.btn_ProzentVon.TabIndex = 3;
            this.btn_ProzentVon.Text = "% davon";
            this.btn_ProzentVon.UseVisualStyleBackColor = true;
            this.btn_ProzentVon.Click += new System.EventHandler(this.btn_ProzentVon_Click);
            // 
            // btn_Satz
            // 
            this.btn_Satz.Location = new System.Drawing.Point(318, 87);
            this.btn_Satz.Name = "btn_Satz";
            this.btn_Satz.Size = new System.Drawing.Size(103, 48);
            this.btn_Satz.TabIndex = 4;
            this.btn_Satz.Text = "% Satz";
            this.btn_Satz.UseVisualStyleBackColor = true;
            this.btn_Satz.Click += new System.EventHandler(this.btn_Satz_Click);
            // 
            // btn_BruttoVonNetto
            // 
            this.btn_BruttoVonNetto.Location = new System.Drawing.Point(318, 153);
            this.btn_BruttoVonNetto.Name = "btn_BruttoVonNetto";
            this.btn_BruttoVonNetto.Size = new System.Drawing.Size(103, 48);
            this.btn_BruttoVonNetto.TabIndex = 5;
            this.btn_BruttoVonNetto.Text = "Brutto von Netto";
            this.btn_BruttoVonNetto.UseVisualStyleBackColor = true;
            this.btn_BruttoVonNetto.Click += new System.EventHandler(this.btn_BruttoVonNetto_Click);
            // 
            // btn_NettoVonBrutto
            // 
            this.btn_NettoVonBrutto.Location = new System.Drawing.Point(318, 220);
            this.btn_NettoVonBrutto.Name = "btn_NettoVonBrutto";
            this.btn_NettoVonBrutto.Size = new System.Drawing.Size(103, 48);
            this.btn_NettoVonBrutto.TabIndex = 6;
            this.btn_NettoVonBrutto.Text = "Netto von Brutto";
            this.btn_NettoVonBrutto.UseVisualStyleBackColor = true;
            this.btn_NettoVonBrutto.Click += new System.EventHandler(this.btn_NettoVonBrutto_Click);
            // 
            // ProzentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 343);
            this.Controls.Add(this.btn_NettoVonBrutto);
            this.Controls.Add(this.btn_BruttoVonNetto);
            this.Controls.Add(this.btn_Satz);
            this.Controls.Add(this.btn_ProzentVon);
            this.Controls.Add(this.btn_ProzentWeg);
            this.Controls.Add(this.btn_ProzentDazu);
            this.Controls.Add(this.lbl_Uebersicht);
            this.Name = "ProzentForm";
            this.Text = "Prozentrechnung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Uebersicht;
        private System.Windows.Forms.Button btn_ProzentDazu;
        private System.Windows.Forms.Button btn_ProzentWeg;
        private System.Windows.Forms.Button btn_ProzentVon;
        private System.Windows.Forms.Button btn_Satz;
        private System.Windows.Forms.Button btn_BruttoVonNetto;
        private System.Windows.Forms.Button btn_NettoVonBrutto;
    }
}

