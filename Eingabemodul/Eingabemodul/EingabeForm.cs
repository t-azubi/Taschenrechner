using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class EingabeForm : Form
    {
        public string Equation;
        private GrundrechnerForm GrundrechnerForm = new GrundrechnerForm();
        public delegate void AdviseParentEventHandler(string text);
        public event AdviseParentEventHandler AdviseParent = delegate { };
        public bool notSchool;
        public EingabeForm( bool notschool = true)
        {
            notSchool = notschool;
            InitializeComponent();
            GrundrechnerForm.AdviseParent += new GrundrechnerForm.AdviseParentEventHandler(SetFromForm2);
            new Button().Click += Add_Click;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Equation += ((Button)(sender)).Text;
           
            if (notSchool && (Regex.Match(Equation, @"[,]{2,}").Success || Regex.Match(Equation, @"[\d]+[,][\d]+[,]").Success))
            {
                MessageBox.Show("Fehler in der Eingabe!", "Error");
                Equation = string.Empty;
            }
            if (Regex.Match(Equation, @"[-]{2,}").Success ||
               Regex.Match(Equation, @"[,,]{2,}").Success  ||
               Regex.Match(Equation, @"[-]{2,}").Success ||
               Regex.Match(Equation, @"^[,][\d]+").Success)
            {
                MessageBox.Show("Fehler in der Eingabe!", "Error");
                Equation = string.Empty;
            }
            tb_VarValue.Text = Equation;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (Equation.Count() > 0)
            {
                Equation = Equation.Remove(Equation.Count() - 1);
                tb_VarValue.Text = Equation;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            tb_VarValue.Text = String.Empty;
            Equation = String.Empty;
        }

        private void Nebenrechnungen_Click(object sender, EventArgs e)
        {
            GrundrechnerForm.Font = this.Font;
            GrundrechnerForm.ForeColor = this.ForeColor;
            GrundrechnerForm.BackColor = this.BackColor;
            GrundrechnerForm.ShowDialog();
        }
        public void SetFromForm2(string result)
        {
            if (Regex.IsMatch(result, "="))
            {
                SetResultInParent(result);
            }
            else
            {
                tb_VarValue.Text = result;
                Equation = result;
            }
        }
        private void Uebernehmen_Click(object sender, EventArgs e)
        {
            bool illegalNumber = false;

            foreach (var button in this.Controls.OfType<Button>())
            {

                if (button.Enabled == false && tb_VarValue.Text.Contains(button.Text))
                {
                    illegalNumber = true;
                }
            }

            if (Equation == "-" || Equation == "," || Regex.Match(tb_VarValue.Text, @"[\d]+[-][\d]+").Success || Regex.Match(tb_VarValue.Text, @"[\d]+[-]+").Success || illegalNumber )
            {
                MessageBox.Show("Fehler in deiner Eingabe!", "Error");
                Equation = string.Empty;
                tb_VarValue.Text = string.Empty;
            }
            else
            {
                Equation = tb_VarValue.Text;
                SetResultInParent(Equation);
                tb_VarValue.Text = string.Empty;
                Equation = string.Empty;
                this.Close();
            }
        }
        public void SetResultInParent(string label)
        {
            AdviseParent(label);
        }
        private void Two_Click(object sender, EventArgs e)
        {
            Equation += ((Button)(sender)).Text;
            tb_VarValue.Text = Equation;
        }
    }
}
