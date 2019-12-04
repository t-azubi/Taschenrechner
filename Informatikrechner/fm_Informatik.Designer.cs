namespace Taschenrechner
{
    partial class fm_Informatik
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
            this.btn_Zahlensystem = new System.Windows.Forms.Button();
            this.btn_Video = new System.Windows.Forms.Button();
            this.btn_Bild = new System.Windows.Forms.Button();
            this.btn_BitByte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Zahlensystem
            // 
            this.btn_Zahlensystem.Location = new System.Drawing.Point(51, 59);
            this.btn_Zahlensystem.Name = "btn_Zahlensystem";
            this.btn_Zahlensystem.Size = new System.Drawing.Size(164, 23);
            this.btn_Zahlensystem.TabIndex = 0;
            this.btn_Zahlensystem.Text = "Zahlensystem";
            this.btn_Zahlensystem.UseVisualStyleBackColor = true;
            this.btn_Zahlensystem.Click += new System.EventHandler(this.btn_Zahlensystem_Click);
            // 
            // btn_Video
            // 
            this.btn_Video.Location = new System.Drawing.Point(51, 144);
            this.btn_Video.Name = "btn_Video";
            this.btn_Video.Size = new System.Drawing.Size(164, 23);
            this.btn_Video.TabIndex = 1;
            this.btn_Video.Text = "Videogröße bestimmen";
            this.btn_Video.UseVisualStyleBackColor = true;
            this.btn_Video.Click += new System.EventHandler(this.btn_Video_Click);
            // 
            // btn_Bild
            // 
            this.btn_Bild.Location = new System.Drawing.Point(51, 102);
            this.btn_Bild.Name = "btn_Bild";
            this.btn_Bild.Size = new System.Drawing.Size(164, 23);
            this.btn_Bild.TabIndex = 2;
            this.btn_Bild.Text = "Bildgröße bestimmen";
            this.btn_Bild.UseVisualStyleBackColor = true;
            this.btn_Bild.Click += new System.EventHandler(this.btn_Bild_Click);
            // 
            // btn_BitByte
            // 
            this.btn_BitByte.Location = new System.Drawing.Point(51, 184);
            this.btn_BitByte.Name = "btn_BitByte";
            this.btn_BitByte.Size = new System.Drawing.Size(164, 23);
            this.btn_BitByte.TabIndex = 3;
            this.btn_BitByte.Text = "Konvertierung Bit <-> Byte";
            this.btn_BitByte.UseVisualStyleBackColor = true;
            this.btn_BitByte.Click += new System.EventHandler(this.btn_BitByte_Click);
            // 
            // fm_Informatik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_BitByte);
            this.Controls.Add(this.btn_Bild);
            this.Controls.Add(this.btn_Video);
            this.Controls.Add(this.btn_Zahlensystem);
            this.Name = "fm_Informatik";
            this.Text = "Informatik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Zahlensystem;
        private System.Windows.Forms.Button btn_Video;
        private System.Windows.Forms.Button btn_Bild;
        private System.Windows.Forms.Button btn_BitByte;
    }
}