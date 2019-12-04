namespace Taschenrechner
{
    partial class GeometrieForm
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
            this.lbl_geometrie = new System.Windows.Forms.Label();
            this.btn_kreis = new System.Windows.Forms.Button();
            this.btn_parallelogramm = new System.Windows.Forms.Button();
            this.btn_dreieck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_geometrie
            // 
            this.lbl_geometrie.AutoSize = true;
            this.lbl_geometrie.Location = new System.Drawing.Point(174, 32);
            this.lbl_geometrie.Name = "lbl_geometrie";
            this.lbl_geometrie.Size = new System.Drawing.Size(55, 13);
            this.lbl_geometrie.TabIndex = 0;
            this.lbl_geometrie.Text = "Geometrie";
            // 
            // btn_kreis
            // 
            this.btn_kreis.Location = new System.Drawing.Point(45, 84);
            this.btn_kreis.Name = "btn_kreis";
            this.btn_kreis.Size = new System.Drawing.Size(114, 44);
            this.btn_kreis.TabIndex = 1;
            this.btn_kreis.Text = "Kreis";
            this.btn_kreis.UseVisualStyleBackColor = true;
            this.btn_kreis.Click += new System.EventHandler(this.btn_kreis_Click);
            // 
            // btn_parallelogramm
            // 
            this.btn_parallelogramm.Location = new System.Drawing.Point(219, 84);
            this.btn_parallelogramm.Name = "btn_parallelogramm";
            this.btn_parallelogramm.Size = new System.Drawing.Size(114, 44);
            this.btn_parallelogramm.TabIndex = 2;
            this.btn_parallelogramm.Text = "Parallelogramm";
            this.btn_parallelogramm.UseVisualStyleBackColor = true;
            this.btn_parallelogramm.Click += new System.EventHandler(this.btn_parallelogramm_Click);
            // 
            // btn_dreieck
            // 
            this.btn_dreieck.Location = new System.Drawing.Point(45, 158);
            this.btn_dreieck.Name = "btn_dreieck";
            this.btn_dreieck.Size = new System.Drawing.Size(114, 44);
            this.btn_dreieck.TabIndex = 3;
            this.btn_dreieck.Text = "Dreieck";
            this.btn_dreieck.UseVisualStyleBackColor = true;
            this.btn_dreieck.Click += new System.EventHandler(this.btn_dreieck_Click);
            // 
            // Geometrie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 261);
            this.Controls.Add(this.btn_dreieck);
            this.Controls.Add(this.btn_parallelogramm);
            this.Controls.Add(this.btn_kreis);
            this.Controls.Add(this.lbl_geometrie);
            this.Name = "Geometrie";
            this.Text = "Geometrie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_geometrie;
        private System.Windows.Forms.Button btn_kreis;
        private System.Windows.Forms.Button btn_parallelogramm;
        private System.Windows.Forms.Button btn_dreieck;
    }
}