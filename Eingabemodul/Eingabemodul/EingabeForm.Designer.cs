namespace Taschenrechner
{
    partial class EingabeForm
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
            this.btn_One = new System.Windows.Forms.Button();
            this.btn_Three = new System.Windows.Forms.Button();
            this.btn_Four = new System.Windows.Forms.Button();
            this.btn_Five = new System.Windows.Forms.Button();
            this.btn_Six = new System.Windows.Forms.Button();
            this.btn_Seven = new System.Windows.Forms.Button();
            this.btn_Eight = new System.Windows.Forms.Button();
            this.btn_Nine = new System.Windows.Forms.Button();
            this.btn_Comma = new System.Windows.Forms.Button();
            this.btn_Zero = new System.Windows.Forms.Button();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.lbl_VarName = new System.Windows.Forms.Label();
            this.tb_VarValue = new System.Windows.Forms.TextBox();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_NebenRechnung = new System.Windows.Forms.Button();
            this.btn_Two = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_One
            // 
            this.btn_One.Location = new System.Drawing.Point(0, 161);
            this.btn_One.Name = "btn_One";
            this.btn_One.Size = new System.Drawing.Size(94, 32);
            this.btn_One.TabIndex = 0;
            this.btn_One.Text = "1";
            this.btn_One.UseVisualStyleBackColor = true;
            this.btn_One.Click += new System.EventHandler(this.Add_Click);
            // 
            // btn_Three
            // 
            this.btn_Three.Location = new System.Drawing.Point(193, 161);
            this.btn_Three.Name = "btn_Three";
            this.btn_Three.Size = new System.Drawing.Size(94, 32);
            this.btn_Three.TabIndex = 3;
            this.btn_Three.Text = "3";
            this.btn_Three.UseVisualStyleBackColor = true;
            this.btn_Three.Click += new System.EventHandler(this.Add_Click);
            // 
            // btn_Four
            // 
            this.btn_Four.Location = new System.Drawing.Point(0, 116);
            this.btn_Four.Name = "btn_Four";
            this.btn_Four.Size = new System.Drawing.Size(94, 32);
            this.btn_Four.TabIndex = 3;
            this.btn_Four.Text = "4";
            this.btn_Four.UseVisualStyleBackColor = true;
            this.btn_Four.Click += new System.EventHandler(this.Add_Click);
            // 
            // btn_Five
            // 
            this.btn_Five.Location = new System.Drawing.Point(97, 116);
            this.btn_Five.Name = "btn_Five";
            this.btn_Five.Size = new System.Drawing.Size(94, 32);
            this.btn_Five.TabIndex = 4;
            this.btn_Five.Text = "5";
            this.btn_Five.UseVisualStyleBackColor = true;
            this.btn_Five.Click += new System.EventHandler(this.Add_Click);
            // 
            // btn_Six
            // 
            this.btn_Six.Location = new System.Drawing.Point(193, 116);
            this.btn_Six.Name = "btn_Six";
            this.btn_Six.Size = new System.Drawing.Size(94, 32);
            this.btn_Six.TabIndex = 5;
            this.btn_Six.Text = "6";
            this.btn_Six.UseVisualStyleBackColor = true;
            this.btn_Six.Click += new System.EventHandler(this.Add_Click);
            // 
            // btn_Seven
            // 
            this.btn_Seven.Location = new System.Drawing.Point(0, 69);
            this.btn_Seven.Name = "btn_Seven";
            this.btn_Seven.Size = new System.Drawing.Size(94, 32);
            this.btn_Seven.TabIndex = 6;
            this.btn_Seven.Text = "7";
            this.btn_Seven.UseVisualStyleBackColor = true;
            this.btn_Seven.Click += new System.EventHandler(this.Add_Click);
            // 
            // btn_Eight
            // 
            this.btn_Eight.Location = new System.Drawing.Point(97, 69);
            this.btn_Eight.Name = "btn_Eight";
            this.btn_Eight.Size = new System.Drawing.Size(94, 32);
            this.btn_Eight.TabIndex = 7;
            this.btn_Eight.Text = "8";
            this.btn_Eight.UseVisualStyleBackColor = true;
            this.btn_Eight.Click += new System.EventHandler(this.Add_Click);
            // 
            // btn_Nine
            // 
            this.btn_Nine.Location = new System.Drawing.Point(193, 69);
            this.btn_Nine.Name = "btn_Nine";
            this.btn_Nine.Size = new System.Drawing.Size(94, 32);
            this.btn_Nine.TabIndex = 8;
            this.btn_Nine.Text = "9";
            this.btn_Nine.UseVisualStyleBackColor = true;
            this.btn_Nine.Click += new System.EventHandler(this.Add_Click);
            // 
            // btn_Comma
            // 
            this.btn_Comma.Location = new System.Drawing.Point(193, 205);
            this.btn_Comma.Name = "btn_Comma";
            this.btn_Comma.Size = new System.Drawing.Size(94, 32);
            this.btn_Comma.TabIndex = 10;
            this.btn_Comma.Text = ",";
            this.btn_Comma.UseVisualStyleBackColor = true;
            this.btn_Comma.Click += new System.EventHandler(this.Add_Click);
            // 
            // btn_Zero
            // 
            this.btn_Zero.Location = new System.Drawing.Point(0, 205);
            this.btn_Zero.Name = "btn_Zero";
            this.btn_Zero.Size = new System.Drawing.Size(191, 32);
            this.btn_Zero.TabIndex = 11;
            this.btn_Zero.Text = "0";
            this.btn_Zero.UseVisualStyleBackColor = true;
            this.btn_Zero.Click += new System.EventHandler(this.Add_Click);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(293, 10);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(94, 34);
            this.btn_Apply.TabIndex = 14;
            this.btn_Apply.Text = "Übernehmen";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.Uebernehmen_Click);
            // 
            // lbl_VarName
            // 
            this.lbl_VarName.AutoSize = true;
            this.lbl_VarName.Location = new System.Drawing.Point(8, 27);
            this.lbl_VarName.Name = "lbl_VarName";
            this.lbl_VarName.Size = new System.Drawing.Size(83, 13);
            this.lbl_VarName.TabIndex = 15;
            this.lbl_VarName.Text = "Variablenname :";
            // 
            // tb_VarValue
            // 
            this.tb_VarValue.Enabled = false;
            this.tb_VarValue.Location = new System.Drawing.Point(97, 24);
            this.tb_VarValue.Name = "tb_VarValue";
            this.tb_VarValue.Size = new System.Drawing.Size(163, 20);
            this.tb_VarValue.TabIndex = 16;
            // 
            // btn_Minus
            // 
            this.btn_Minus.Location = new System.Drawing.Point(293, 116);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(94, 32);
            this.btn_Minus.TabIndex = 17;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = true;
            this.btn_Minus.Click += new System.EventHandler(this.Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(293, 205);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 32);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Löschen";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(293, 161);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(94, 32);
            this.btn_Clear.TabIndex = 19;
            this.btn_Clear.Text = "Leeren";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // btn_NebenRechnung
            // 
            this.btn_NebenRechnung.Location = new System.Drawing.Point(293, 69);
            this.btn_NebenRechnung.Name = "btn_NebenRechnung";
            this.btn_NebenRechnung.Size = new System.Drawing.Size(94, 32);
            this.btn_NebenRechnung.TabIndex = 20;
            this.btn_NebenRechnung.Text = "Nebenrechnung";
            this.btn_NebenRechnung.UseVisualStyleBackColor = true;
            this.btn_NebenRechnung.Click += new System.EventHandler(this.Nebenrechnungen_Click);
            // 
            // btn_Two
            // 
            this.btn_Two.Location = new System.Drawing.Point(97, 161);
            this.btn_Two.Name = "btn_Two";
            this.btn_Two.Size = new System.Drawing.Size(94, 32);
            this.btn_Two.TabIndex = 21;
            this.btn_Two.Text = "2";
            this.btn_Two.UseVisualStyleBackColor = true;
            this.btn_Two.Click += new System.EventHandler(this.Add_Click);
            // 
            // EingabeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 237);
            this.Controls.Add(this.btn_Two);
            this.Controls.Add(this.btn_NebenRechnung);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.tb_VarValue);
            this.Controls.Add(this.lbl_VarName);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.btn_Zero);
            this.Controls.Add(this.btn_Comma);
            this.Controls.Add(this.btn_Nine);
            this.Controls.Add(this.btn_Eight);
            this.Controls.Add(this.btn_Seven);
            this.Controls.Add(this.btn_Six);
            this.Controls.Add(this.btn_Five);
            this.Controls.Add(this.btn_Four);
            this.Controls.Add(this.btn_Three);
            this.Controls.Add(this.btn_One);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EingabeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eingabe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_One;
        private System.Windows.Forms.Button btn_Three;
        private System.Windows.Forms.Button btn_Four;
        private System.Windows.Forms.Button btn_Five;
        private System.Windows.Forms.Button btn_Six;
        private System.Windows.Forms.Button btn_Seven;
        private System.Windows.Forms.Button btn_Eight;
        private System.Windows.Forms.Button btn_Nine;
        private System.Windows.Forms.Button btn_Comma;
        private System.Windows.Forms.Button btn_Zero;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Label lbl_VarName;
        private System.Windows.Forms.TextBox tb_VarValue;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_NebenRechnung;
        private System.Windows.Forms.Button btn_Two;
    }
}

