namespace Taschenrechner
{
    partial class KreditForm

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
            this.btn_Krediteinmalig = new System.Windows.Forms.Button();
            this.lbl_Funktionen = new System.Windows.Forms.Label();
            this.btn_Laufzeitkredit = new System.Windows.Forms.Button();
            this.btn_Ratenhöhekredit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Krediteinmalig
            // 
            this.btn_Krediteinmalig.Location = new System.Drawing.Point(88, 88);
            this.btn_Krediteinmalig.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Krediteinmalig.Name = "btn_Krediteinmalig";
            this.btn_Krediteinmalig.Size = new System.Drawing.Size(172, 63);
            this.btn_Krediteinmalig.TabIndex = 0;
            this.btn_Krediteinmalig.Text = "Kredit mit einmaliger Rückzahlung";
            this.btn_Krediteinmalig.UseVisualStyleBackColor = true;
            this.btn_Krediteinmalig.Click += new System.EventHandler(this.btn_Krediteinmalig_Click);
            // 
            // lbl_Funktionen
            // 
            this.lbl_Funktionen.AutoSize = true;
            this.lbl_Funktionen.Location = new System.Drawing.Point(259, 37);
            this.lbl_Funktionen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Funktionen.Name = "lbl_Funktionen";
            this.lbl_Funktionen.Size = new System.Drawing.Size(63, 13);
            this.lbl_Funktionen.TabIndex = 1;
            this.lbl_Funktionen.Text = "Funktionen:";
            // 
            // btn_Laufzeitkredit
            // 
            this.btn_Laufzeitkredit.Location = new System.Drawing.Point(328, 88);
            this.btn_Laufzeitkredit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Laufzeitkredit.Name = "btn_Laufzeitkredit";
            this.btn_Laufzeitkredit.Size = new System.Drawing.Size(172, 63);
            this.btn_Laufzeitkredit.TabIndex = 2;
            this.btn_Laufzeitkredit.Text = "Ratenkredit mit Vorgabe der Laufzeit";
            this.btn_Laufzeitkredit.UseVisualStyleBackColor = true;
            this.btn_Laufzeitkredit.Click += new System.EventHandler(this.btn_Laufzeitkredit_Click);
            // 
            // btn_Ratenhöhekredit
            // 
            this.btn_Ratenhöhekredit.Location = new System.Drawing.Point(88, 207);
            this.btn_Ratenhöhekredit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ratenhöhekredit.Name = "btn_Ratenhöhekredit";
            this.btn_Ratenhöhekredit.Size = new System.Drawing.Size(172, 63);
            this.btn_Ratenhöhekredit.TabIndex = 3;
            this.btn_Ratenhöhekredit.Text = "Ratenkredit mit Vorgabe der Ratenhöhe";
            this.btn_Ratenhöhekredit.UseVisualStyleBackColor = true;
            this.btn_Ratenhöhekredit.Click += new System.EventHandler(this.Btn_Ratenhöhekredit_Click);
            // 
            // KreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 348);
            this.Controls.Add(this.btn_Ratenhöhekredit);
            this.Controls.Add(this.btn_Laufzeitkredit);
            this.Controls.Add(this.lbl_Funktionen);
            this.Controls.Add(this.btn_Krediteinmalig);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KreditForm";
            this.Text = "Kreditberechnung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Krediteinmalig;
        private System.Windows.Forms.Label lbl_Funktionen;
        private System.Windows.Forms.Button btn_Laufzeitkredit;
        private System.Windows.Forms.Button btn_Ratenhöhekredit;
    }
}

