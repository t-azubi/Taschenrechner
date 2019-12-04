namespace Taschenrechner
{
    partial class LogForm
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
            this.rib_Log = new System.Windows.Forms.RichTextBox();
            this.btn_Percent = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.navi_Navi = new System.Windows.Forms.ToolStripMenuItem();
            this.navi_BgColor = new System.Windows.Forms.ToolStripMenuItem();
            this.navi_FontType = new System.Windows.Forms.ToolStripMenuItem();
            this.navi_FontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Geo = new System.Windows.Forms.Button();
            this.btn_School = new System.Windows.Forms.Button();
            this.btn_MathFunc = new System.Windows.Forms.Button();
            this.btn_Loan = new System.Windows.Forms.Button();
            this.btn_ITCalc = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // rib_Log
            // 
            this.rib_Log.Location = new System.Drawing.Point(5, 47);
            this.rib_Log.Name = "rib_Log";
            this.rib_Log.ReadOnly = true;
            this.rib_Log.Size = new System.Drawing.Size(567, 247);
            this.rib_Log.TabIndex = 0;
            this.rib_Log.Text = "";
            // 
            // btn_Percent
            // 
            this.btn_Percent.Location = new System.Drawing.Point(12, 300);
            this.btn_Percent.Name = "btn_Percent";
            this.btn_Percent.Size = new System.Drawing.Size(147, 32);
            this.btn_Percent.TabIndex = 1;
            this.btn_Percent.Text = "Prozentrechnung";
            this.btn_Percent.UseVisualStyleBackColor = false;
            this.btn_Percent.Click += new System.EventHandler(this.OpenProzentrechnung_Click);
            // 
            // Menu
            // 
            this.Menu.GripMargin = new System.Windows.Forms.Padding(292, 2, 1000, 2);
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navi_Navi});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(576, 27);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "Menu";
            // 
            // navi_Navi
            // 
            this.navi_Navi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navi_BgColor,
            this.navi_FontType,
            this.navi_FontColor});
            this.navi_Navi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navi_Navi.Name = "navi_Navi";
            this.navi_Navi.Size = new System.Drawing.Size(57, 23);
            this.navi_Navi.Text = "Menü";
            // 
            // navi_BgColor
            // 
            this.navi_BgColor.Name = "navi_BgColor";
            this.navi_BgColor.Size = new System.Drawing.Size(184, 24);
            this.navi_BgColor.Text = "Hintergrundfarbe";
            this.navi_BgColor.Click += new System.EventHandler(this.HintergrundfarbeToolStripMenuItem_Click);
            // 
            // navi_FontType
            // 
            this.navi_FontType.Name = "navi_FontType";
            this.navi_FontType.Size = new System.Drawing.Size(184, 24);
            this.navi_FontType.Text = "Schrift";
            this.navi_FontType.Click += new System.EventHandler(this.SchriftToolStripMenuItem_Click);
            // 
            // navi_FontColor
            // 
            this.navi_FontColor.Name = "navi_FontColor";
            this.navi_FontColor.Size = new System.Drawing.Size(184, 24);
            this.navi_FontColor.Text = "Schriftfarbe";
            this.navi_FontColor.Click += new System.EventHandler(this.SchriftfarbeToolStripMenuItem_Click);
            // 
            // btn_Geo
            // 
            this.btn_Geo.Location = new System.Drawing.Point(179, 300);
            this.btn_Geo.Name = "btn_Geo";
            this.btn_Geo.Size = new System.Drawing.Size(147, 32);
            this.btn_Geo.TabIndex = 3;
            this.btn_Geo.Text = "Geometrie";
            this.btn_Geo.UseVisualStyleBackColor = false;
            this.btn_Geo.Click += new System.EventHandler(this.Open_Geometrie_Click);
            // 
            // btn_School
            // 
            this.btn_School.Location = new System.Drawing.Point(344, 300);
            this.btn_School.Name = "btn_School";
            this.btn_School.Size = new System.Drawing.Size(147, 32);
            this.btn_School.TabIndex = 4;
            this.btn_School.Text = "Schule";
            this.btn_School.UseVisualStyleBackColor = false;
            this.btn_School.Click += new System.EventHandler(this.Schule_Click);
            // 
            // btn_MathFunc
            // 
            this.btn_MathFunc.Location = new System.Drawing.Point(12, 359);
            this.btn_MathFunc.Name = "btn_MathFunc";
            this.btn_MathFunc.Size = new System.Drawing.Size(147, 32);
            this.btn_MathFunc.TabIndex = 5;
            this.btn_MathFunc.Text = "Mathematische Funktionen";
            this.btn_MathFunc.UseVisualStyleBackColor = false;
            this.btn_MathFunc.Click += new System.EventHandler(this.Mathe_Click);
            // 
            // btn_Loan
            // 
            this.btn_Loan.Location = new System.Drawing.Point(179, 359);
            this.btn_Loan.Name = "btn_Loan";
            this.btn_Loan.Size = new System.Drawing.Size(147, 32);
            this.btn_Loan.TabIndex = 6;
            this.btn_Loan.Text = "Kreditberechnung";
            this.btn_Loan.UseVisualStyleBackColor = false;
            this.btn_Loan.Click += new System.EventHandler(this.Kredit_Click);
            // 
            // btn_ITCalc
            // 
            this.btn_ITCalc.Location = new System.Drawing.Point(344, 359);
            this.btn_ITCalc.Name = "btn_ITCalc";
            this.btn_ITCalc.Size = new System.Drawing.Size(147, 32);
            this.btn_ITCalc.TabIndex = 7;
            this.btn_ITCalc.Text = "Informatikrechner";
            this.btn_ITCalc.UseVisualStyleBackColor = false;
            this.btn_ITCalc.Click += new System.EventHandler(this.Inforechner_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(576, 443);
            this.Controls.Add(this.btn_ITCalc);
            this.Controls.Add(this.btn_Loan);
            this.Controls.Add(this.btn_MathFunc);
            this.Controls.Add(this.btn_School);
            this.Controls.Add(this.btn_Geo);
            this.Controls.Add(this.btn_Percent);
            this.Controls.Add(this.rib_Log);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.Menu;
            this.Name = "LogForm";
            this.Text = "LogFenster";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rib_Log;
        private System.Windows.Forms.Button btn_Percent;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem navi_Navi;
        private System.Windows.Forms.ToolStripMenuItem navi_BgColor;
        private System.Windows.Forms.ToolStripMenuItem navi_FontType;
        private System.Windows.Forms.ToolStripMenuItem navi_FontColor;
        private System.Windows.Forms.Button btn_Geo;
        private System.Windows.Forms.Button btn_School;
        private System.Windows.Forms.Button btn_MathFunc;
        private System.Windows.Forms.Button btn_Loan;
        private System.Windows.Forms.Button btn_ITCalc;
    }
}

