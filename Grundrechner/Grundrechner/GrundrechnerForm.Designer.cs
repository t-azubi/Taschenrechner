namespace Taschenrechner
{
    partial class GrundrechnerForm
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
            this.tb_input = new System.Windows.Forms.TextBox();
            this.btn_one = new System.Windows.Forms.Button();
            this.btn_two = new System.Windows.Forms.Button();
            this.btn_three = new System.Windows.Forms.Button();
            this.btn_four = new System.Windows.Forms.Button();
            this.btn_five = new System.Windows.Forms.Button();
            this.btn_six = new System.Windows.Forms.Button();
            this.btn_seven = new System.Windows.Forms.Button();
            this.btn_eight = new System.Windows.Forms.Button();
            this.btn_nine = new System.Windows.Forms.Button();
            this.btn_solve = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_divis = new System.Windows.Forms.Button();
            this.btn_bracketopen = new System.Windows.Forms.Button();
            this.btn_bracketclose = new System.Windows.Forms.Button();
            this.btn_zero = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_comma = new System.Windows.Forms.Button();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_rechenschritte = new System.Windows.Forms.Button();
            this.tb_rechenschritteout = new System.Windows.Forms.RichTextBox();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(10, 41);
            this.tb_input.Name = "tb_input";
            this.tb_input.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_input.Size = new System.Drawing.Size(214, 20);
            this.tb_input.TabIndex = 0;
            this.tb_input.TextChanged += new System.EventHandler(this.tb_input_Changed);
            // 
            // btn_one
            // 
            this.btn_one.Location = new System.Drawing.Point(10, 76);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(47, 23);
            this.btn_one.TabIndex = 1;
            this.btn_one.Text = "1";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.Nbr_Add_Click);
            // 
            // btn_two
            // 
            this.btn_two.Location = new System.Drawing.Point(63, 76);
            this.btn_two.Name = "btn_two";
            this.btn_two.Size = new System.Drawing.Size(47, 23);
            this.btn_two.TabIndex = 2;
            this.btn_two.Text = "2";
            this.btn_two.UseVisualStyleBackColor = true;
            this.btn_two.Click += new System.EventHandler(this.Nbr_Add_Click);
            // 
            // btn_three
            // 
            this.btn_three.Location = new System.Drawing.Point(116, 76);
            this.btn_three.Name = "btn_three";
            this.btn_three.Size = new System.Drawing.Size(47, 23);
            this.btn_three.TabIndex = 3;
            this.btn_three.Text = "3";
            this.btn_three.UseVisualStyleBackColor = true;
            this.btn_three.Click += new System.EventHandler(this.Nbr_Add_Click);
            // 
            // btn_four
            // 
            this.btn_four.Location = new System.Drawing.Point(10, 105);
            this.btn_four.Name = "btn_four";
            this.btn_four.Size = new System.Drawing.Size(47, 23);
            this.btn_four.TabIndex = 4;
            this.btn_four.Text = "4";
            this.btn_four.UseVisualStyleBackColor = true;
            this.btn_four.Click += new System.EventHandler(this.Nbr_Add_Click);
            // 
            // btn_five
            // 
            this.btn_five.Location = new System.Drawing.Point(63, 105);
            this.btn_five.Name = "btn_five";
            this.btn_five.Size = new System.Drawing.Size(47, 23);
            this.btn_five.TabIndex = 5;
            this.btn_five.Text = "5";
            this.btn_five.UseVisualStyleBackColor = true;
            this.btn_five.Click += new System.EventHandler(this.Nbr_Add_Click);
            // 
            // btn_six
            // 
            this.btn_six.Location = new System.Drawing.Point(116, 106);
            this.btn_six.Name = "btn_six";
            this.btn_six.Size = new System.Drawing.Size(47, 23);
            this.btn_six.TabIndex = 6;
            this.btn_six.Text = "6";
            this.btn_six.UseVisualStyleBackColor = true;
            this.btn_six.Click += new System.EventHandler(this.Nbr_Add_Click);
            // 
            // btn_seven
            // 
            this.btn_seven.Location = new System.Drawing.Point(10, 135);
            this.btn_seven.Name = "btn_seven";
            this.btn_seven.Size = new System.Drawing.Size(47, 23);
            this.btn_seven.TabIndex = 7;
            this.btn_seven.Text = "7";
            this.btn_seven.UseVisualStyleBackColor = true;
            this.btn_seven.Click += new System.EventHandler(this.Nbr_Add_Click);
            // 
            // btn_eight
            // 
            this.btn_eight.Location = new System.Drawing.Point(63, 135);
            this.btn_eight.Name = "btn_eight";
            this.btn_eight.Size = new System.Drawing.Size(47, 23);
            this.btn_eight.TabIndex = 8;
            this.btn_eight.Text = "8";
            this.btn_eight.UseVisualStyleBackColor = true;
            this.btn_eight.Click += new System.EventHandler(this.Nbr_Add_Click);
            // 
            // btn_nine
            // 
            this.btn_nine.Location = new System.Drawing.Point(116, 135);
            this.btn_nine.Name = "btn_nine";
            this.btn_nine.Size = new System.Drawing.Size(47, 23);
            this.btn_nine.TabIndex = 9;
            this.btn_nine.Text = "9";
            this.btn_nine.UseVisualStyleBackColor = true;
            this.btn_nine.Click += new System.EventHandler(this.Nbr_Add_Click);
            // 
            // btn_solve
            // 
            this.btn_solve.Location = new System.Drawing.Point(63, 194);
            this.btn_solve.Name = "btn_solve";
            this.btn_solve.Size = new System.Drawing.Size(47, 23);
            this.btn_solve.TabIndex = 10;
            this.btn_solve.Text = "=";
            this.btn_solve.UseVisualStyleBackColor = true;
            this.btn_solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(177, 76);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(47, 23);
            this.btn_plus.TabIndex = 11;
            this.btn_plus.Text = " + ";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.Nbr_Add_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Location = new System.Drawing.Point(177, 106);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(47, 23);
            this.btn_minus.TabIndex = 12;
            this.btn_minus.Text = " - ";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.Nbr_Add_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Location = new System.Drawing.Point(177, 135);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(47, 23);
            this.btn_multi.TabIndex = 13;
            this.btn_multi.Text = " * ";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.Nbr_Add_Click);
            // 
            // btn_divis
            // 
            this.btn_divis.Location = new System.Drawing.Point(177, 164);
            this.btn_divis.Name = "btn_divis";
            this.btn_divis.Size = new System.Drawing.Size(47, 23);
            this.btn_divis.TabIndex = 14;
            this.btn_divis.Text = " / ";
            this.btn_divis.UseVisualStyleBackColor = true;
            this.btn_divis.Click += new System.EventHandler(this.Nbr_Add_Click);
            // 
            // btn_bracketopen
            // 
            this.btn_bracketopen.Location = new System.Drawing.Point(10, 164);
            this.btn_bracketopen.Name = "btn_bracketopen";
            this.btn_bracketopen.Size = new System.Drawing.Size(47, 23);
            this.btn_bracketopen.TabIndex = 15;
            this.btn_bracketopen.Text = " ( ";
            this.btn_bracketopen.UseVisualStyleBackColor = true;
            this.btn_bracketopen.Click += new System.EventHandler(this.Nbr_Add_Click);
            // 
            // btn_bracketclose
            // 
            this.btn_bracketclose.Location = new System.Drawing.Point(116, 164);
            this.btn_bracketclose.Name = "btn_bracketclose";
            this.btn_bracketclose.Size = new System.Drawing.Size(47, 23);
            this.btn_bracketclose.TabIndex = 16;
            this.btn_bracketclose.Text = " ) ";
            this.btn_bracketclose.UseVisualStyleBackColor = true;
            this.btn_bracketclose.Click += new System.EventHandler(this.Nbr_Add_Click);
            // 
            // btn_zero
            // 
            this.btn_zero.Location = new System.Drawing.Point(63, 164);
            this.btn_zero.Name = "btn_zero";
            this.btn_zero.Size = new System.Drawing.Size(47, 23);
            this.btn_zero.TabIndex = 17;
            this.btn_zero.Text = "0";
            this.btn_zero.UseVisualStyleBackColor = true;
            this.btn_zero.Click += new System.EventHandler(this.Nbr_Add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(177, 194);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(47, 23);
            this.btn_clear.TabIndex = 18;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(116, 194);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(47, 23);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Del";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btn_comma
            // 
            this.btn_comma.Location = new System.Drawing.Point(10, 194);
            this.btn_comma.Name = "btn_comma";
            this.btn_comma.Size = new System.Drawing.Size(47, 23);
            this.btn_comma.TabIndex = 20;
            this.btn_comma.Text = ",";
            this.btn_comma.UseVisualStyleBackColor = true;
            this.btn_comma.Click += new System.EventHandler(this.Nbr_Add_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(276, 137);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(89, 23);
            this.btn_apply.TabIndex = 21;
            this.btn_apply.Text = "Übernehmen";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.apply_click);
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(276, 164);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(89, 36);
            this.btn_history.TabIndex = 22;
            this.btn_history.Text = "Übernehmen in Historie";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.History_Click);
            // 
            // btn_rechenschritte
            // 
            this.btn_rechenschritte.Location = new System.Drawing.Point(276, 106);
            this.btn_rechenschritte.Name = "btn_rechenschritte";
            this.btn_rechenschritte.Size = new System.Drawing.Size(89, 23);
            this.btn_rechenschritte.TabIndex = 23;
            this.btn_rechenschritte.Text = "Rechenschritte";
            this.btn_rechenschritte.UseVisualStyleBackColor = true;
            this.btn_rechenschritte.Click += new System.EventHandler(this.Rechenschritte_Click);
            // 
            // tb_rechenschritteout
            // 
            this.tb_rechenschritteout.Location = new System.Drawing.Point(229, 6);
            this.tb_rechenschritteout.Margin = new System.Windows.Forms.Padding(2);
            this.tb_rechenschritteout.Name = "tb_rechenschritteout";
            this.tb_rechenschritteout.ReadOnly = true;
            this.tb_rechenschritteout.Size = new System.Drawing.Size(182, 97);
            this.tb_rechenschritteout.TabIndex = 24;
            this.tb_rechenschritteout.Text = "";
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(10, 6);
            this.tb_output.Name = "tb_output";
            this.tb_output.ReadOnly = true;
            this.tb_output.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_output.Size = new System.Drawing.Size(214, 20);
            this.tb_output.TabIndex = 25;
            this.tb_output.Text = "Ergebnis";
            // 
            // GrundrechnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 229);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.tb_rechenschritteout);
            this.Controls.Add(this.btn_rechenschritte);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.btn_comma);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_zero);
            this.Controls.Add(this.btn_bracketclose);
            this.Controls.Add(this.btn_bracketopen);
            this.Controls.Add(this.btn_divis);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_solve);
            this.Controls.Add(this.btn_nine);
            this.Controls.Add(this.btn_eight);
            this.Controls.Add(this.btn_seven);
            this.Controls.Add(this.btn_six);
            this.Controls.Add(this.btn_five);
            this.Controls.Add(this.btn_four);
            this.Controls.Add(this.btn_three);
            this.Controls.Add(this.btn_two);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.tb_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GrundrechnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grundrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.Button btn_two;
        private System.Windows.Forms.Button btn_three;
        private System.Windows.Forms.Button btn_four;
        private System.Windows.Forms.Button btn_five;
        private System.Windows.Forms.Button btn_six;
        private System.Windows.Forms.Button btn_seven;
        private System.Windows.Forms.Button btn_eight;
        private System.Windows.Forms.Button btn_nine;
        private System.Windows.Forms.Button btn_solve;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_divis;
        private System.Windows.Forms.Button btn_bracketopen;
        private System.Windows.Forms.Button btn_bracketclose;
        private System.Windows.Forms.Button btn_zero;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_comma;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_rechenschritte;
        private System.Windows.Forms.RichTextBox tb_rechenschritteout;
        private System.Windows.Forms.TextBox tb_output;
    }
}

