namespace Taschenrechner
{
    partial class fm_Zahlensystem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB_Octal = new System.Windows.Forms.RadioButton();
            this.rB_Ternär = new System.Windows.Forms.RadioButton();
            this.rB_Binär = new System.Windows.Forms.RadioButton();
            this.rB_Dezimal = new System.Windows.Forms.RadioButton();
            this.btn_weiter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB_Octal);
            this.groupBox1.Controls.Add(this.rB_Ternär);
            this.groupBox1.Controls.Add(this.rB_Binär);
            this.groupBox1.Controls.Add(this.rB_Dezimal);
            this.groupBox1.Location = new System.Drawing.Point(20, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zahlensystem der Ausgangszahl";
            // 
            // rB_Octal
            // 
            this.rB_Octal.AutoSize = true;
            this.rB_Octal.Location = new System.Drawing.Point(7, 92);
            this.rB_Octal.Name = "rB_Octal";
            this.rB_Octal.Size = new System.Drawing.Size(50, 17);
            this.rB_Octal.TabIndex = 3;
            this.rB_Octal.TabStop = true;
            this.rB_Octal.Text = "Octal";
            this.rB_Octal.UseVisualStyleBackColor = true;
            // 
            // rB_Ternär
            // 
            this.rB_Ternär.AutoSize = true;
            this.rB_Ternär.Location = new System.Drawing.Point(7, 68);
            this.rB_Ternär.Name = "rB_Ternär";
            this.rB_Ternär.Size = new System.Drawing.Size(59, 17);
            this.rB_Ternär.TabIndex = 2;
            this.rB_Ternär.TabStop = true;
            this.rB_Ternär.Text = "Terrnär";
            this.rB_Ternär.UseVisualStyleBackColor = true;
            // 
            // rB_Binär
            // 
            this.rB_Binär.AutoSize = true;
            this.rB_Binär.Location = new System.Drawing.Point(7, 44);
            this.rB_Binär.Name = "rB_Binär";
            this.rB_Binär.Size = new System.Drawing.Size(49, 17);
            this.rB_Binär.TabIndex = 1;
            this.rB_Binär.TabStop = true;
            this.rB_Binär.Text = "Binär";
            this.rB_Binär.UseVisualStyleBackColor = true;
            // 
            // rB_Dezimal
            // 
            this.rB_Dezimal.AutoSize = true;
            this.rB_Dezimal.Location = new System.Drawing.Point(7, 20);
            this.rB_Dezimal.Name = "rB_Dezimal";
            this.rB_Dezimal.Size = new System.Drawing.Size(62, 17);
            this.rB_Dezimal.TabIndex = 0;
            this.rB_Dezimal.TabStop = true;
            this.rB_Dezimal.Text = "Dezimal";
            this.rB_Dezimal.UseVisualStyleBackColor = true;
            // 
            // btn_weiter
            // 
            this.btn_weiter.Location = new System.Drawing.Point(145, 199);
            this.btn_weiter.Name = "btn_weiter";
            this.btn_weiter.Size = new System.Drawing.Size(75, 23);
            this.btn_weiter.TabIndex = 1;
            this.btn_weiter.Text = "Weiter";
            this.btn_weiter.UseVisualStyleBackColor = true;
            this.btn_weiter.Click += new System.EventHandler(this.btn_weiter_Click);
            // 
            // fm_Zahlensystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_weiter);
            this.Controls.Add(this.groupBox1);
            this.Name = "fm_Zahlensystem";
            this.Text = "Zahlensystem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB_Octal;
        private System.Windows.Forms.RadioButton rB_Ternär;
        private System.Windows.Forms.RadioButton rB_Binär;
        private System.Windows.Forms.RadioButton rB_Dezimal;
        private System.Windows.Forms.Button btn_weiter;
    }
}