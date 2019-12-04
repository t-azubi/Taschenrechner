namespace Taschenrechner
{
    partial class fm_BitByte
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
            this.gB_BitByte = new System.Windows.Forms.GroupBox();
            this.rB_Byte = new System.Windows.Forms.RadioButton();
            this.rB_Bit = new System.Windows.Forms.RadioButton();
            this.btn_Weiter = new System.Windows.Forms.Button();
            this.gB_BitByte.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_BitByte
            // 
            this.gB_BitByte.Controls.Add(this.rB_Byte);
            this.gB_BitByte.Controls.Add(this.rB_Bit);
            this.gB_BitByte.Location = new System.Drawing.Point(48, 43);
            this.gB_BitByte.Name = "gB_BitByte";
            this.gB_BitByte.Size = new System.Drawing.Size(200, 100);
            this.gB_BitByte.TabIndex = 0;
            this.gB_BitByte.TabStop = false;
            this.gB_BitByte.Text = "Bit oder Byte?";
            // 
            // rB_Byte
            // 
            this.rB_Byte.AutoSize = true;
            this.rB_Byte.Location = new System.Drawing.Point(7, 54);
            this.rB_Byte.Name = "rB_Byte";
            this.rB_Byte.Size = new System.Drawing.Size(46, 17);
            this.rB_Byte.TabIndex = 1;
            this.rB_Byte.TabStop = true;
            this.rB_Byte.Text = "Byte";
            this.rB_Byte.UseVisualStyleBackColor = true;
            // 
            // rB_Bit
            // 
            this.rB_Bit.AutoSize = true;
            this.rB_Bit.Location = new System.Drawing.Point(7, 20);
            this.rB_Bit.Name = "rB_Bit";
            this.rB_Bit.Size = new System.Drawing.Size(37, 17);
            this.rB_Bit.TabIndex = 0;
            this.rB_Bit.TabStop = true;
            this.rB_Bit.Text = "Bit";
            this.rB_Bit.UseVisualStyleBackColor = true;
            // 
            // btn_Weiter
            // 
            this.btn_Weiter.Location = new System.Drawing.Point(191, 187);
            this.btn_Weiter.Name = "btn_Weiter";
            this.btn_Weiter.Size = new System.Drawing.Size(75, 23);
            this.btn_Weiter.TabIndex = 1;
            this.btn_Weiter.Text = "Weiter";
            this.btn_Weiter.UseVisualStyleBackColor = true;
            this.btn_Weiter.Click += new System.EventHandler(this.btn_Weiter_Click);
            // 
            // fm_BitByte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_Weiter);
            this.Controls.Add(this.gB_BitByte);
            this.Name = "fm_BitByte";
            this.Text = "Konvertierung Bit <-> Byte";
            this.gB_BitByte.ResumeLayout(false);
            this.gB_BitByte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gB_BitByte;
        private System.Windows.Forms.RadioButton rB_Byte;
        private System.Windows.Forms.RadioButton rB_Bit;
        private System.Windows.Forms.Button btn_Weiter;
    }
}