using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class GrundrechnerForm : Form
    {
        public string Equation;
        public string oldEquation;
        public delegate void AdviseParentEventHandler(string text);
        public event AdviseParentEventHandler AdviseParent = delegate { };
        public List<string> RechenSchritte = new List<string>();
        public bool stop = false;
        public GrundrechnerForm()
        {
            InitializeComponent();

            foreach (var button in this.Controls.OfType<Button>())
            {

                if (button.Name == "btn_apply")
                {
                    button.Enabled = false;
                }
            }

            new Button().Click += Nbr_Add_Click;
        }



        private void Nbr_Add_Click(object sender, EventArgs e)
        {
            Equation += ((Button)(sender)).Text;
            tb_input.Text = Equation;
        }
        private void Solve_Click(object sender, EventArgs e)
        {
           var match = Regex.Match(Regex.Replace(tb_input.Text, @"\s", ""), @"/0");
           if (match.Success)
           {
               if (Regex.Replace(Equation, @"\s", "").Substring(match.Index + match.Length).IndexOf(',') != 0)
               {
                   MessageBox.Show("You can't divide by Zero!!");
               }
               else
               {
                   Equation = new ErrorHandling().CorrectEquation(Equation, new ErrorHandling().CountBrackets(Equation, true), new ErrorHandling().CountBrackets(Equation, false));
                   var result = new Grundrechner().Solve(Equation, out RechenSchritte);
                   oldEquation = Equation;
                   Equation = result.ToString();
                   tb_output.Text = result.ToString();
               }
           }
           else
           {
               Equation = new ErrorHandling().CorrectEquation(Equation, new ErrorHandling().CountBrackets(Equation, true), new ErrorHandling().CountBrackets(Equation, false));
               var result = new Grundrechner().Solve(Equation, out RechenSchritte);
               oldEquation = Equation;
               Equation = result.ToString();
               tb_output.Text = result.ToString();
           }

           btn_apply.Enabled = true;
            
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_rechenschritteout.Clear();
            RechenSchritte.Clear();
            tb_input.Text = String.Empty;
            Equation = String.Empty;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Equation == null || Equation == " " || Equation == String.Empty)
            {
                tb_input.Text = Equation;
            }
            else
            {
                if (Equation.LastIndexOf(' ') + 1 == Equation.Count())
                {
                    Equation = Equation.Remove(Equation.Count() - 3);
                }
                else
                {
                    Equation = Equation.Remove(Equation.Count() - 1);
                }
                tb_input.Text = Equation;
            }
        }
        private void tb_input_Changed(object sender, EventArgs e)
        {
            tb_input.Text = new ErrorHandling().checkForErrors(tb_input.Text);
            tb_input.SelectionStart = tb_input.TextLength;
            tb_input.SelectionLength = 0;
            Equation = tb_input.Text;
        }
        private void apply_click(object sender, EventArgs e)
        {
            SetResultInParent(Equation);
        }
        private void History_Click(object sender, EventArgs e)
        {
            SetResultInParent(oldEquation + " = " + tb_input.Text);
        }
        public void SetResultInParent(string label)
        {
            AdviseParent(label);
        }
        private void Rechenschritte_Click(object sender, EventArgs e)
        {
            var Count = RechenSchritte.Count;
            var length = tb_rechenschritteout.Text.Length;
            for (int i = 0; i < Count; i++)
            {
                RechenSchritte[i] = Regex.Replace(RechenSchritte[i], "#", @"/-");
                RechenSchritte[i] = Regex.Replace(RechenSchritte[i], "x", @"*-");
                tb_rechenschritteout.AppendText(RechenSchritte[i] + "\n");
                var substring = RechenSchritte[i].Substring(0, RechenSchritte[i].IndexOf(')') + 1);
                var firstindex = substring.LastIndexOf('(');
                if (firstindex != -1)
                {
                    var lastindex = substring.Substring(substring.LastIndexOf('(')).Length;
                    tb_rechenschritteout.Select(firstindex + length, lastindex);
                    length += RechenSchritte[i].Length + 1;
                    var show = tb_rechenschritteout.SelectedText;
                    tb_rechenschritteout.SelectionColor = Color.Red;
                }
            }
        }
    }
}
