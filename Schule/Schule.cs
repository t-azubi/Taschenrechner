using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class SchuleForm : Form
    {
        public string helper = string.Empty;
        private EingabeForm EingabeForm = new EingabeForm();
        public delegate void AdviseParentEventHandler(string text);
        public event AdviseParentEventHandler AdviseParent = delegate { };
        public SchuleForm()
        {
            EingabeForm.AdviseParent += new EingabeForm.AdviseParentEventHandler(SetFromForm2);
            EingabeForm.Font = this.Font;
            EingabeForm.ForeColor = this.ForeColor;
            EingabeForm.BackColor = this.BackColor;
            InitializeComponent();
        }
        public void SetResultInParent(string label)
        {
            AdviseParent(label);
        }
        public void SetFromForm2(string result)
        {
            helper = result;
        }
        private void ShowMessage(string Message)
        {
            MessageBox.Show(Message, "Zahleneingabe");
            EingabeForm.ShowDialog();
        }
        public void StartModule()
        {
           ShowMessage("Bitte geben sie alle Noten an!(mit , Trennen");
            var noten = helper.Split(',');
            Notenberechnung(noten);
            Notenanzahl(noten);
        }
        public void Notenberechnung(string[] noten)
        {
            double helper = 0;
            foreach (var item in noten)
            {
                helper += Convert.ToInt16(item);
            }
            var count = noten.Count().ToString();
            helper = new Grundrechner().CalcConst(helper.ToString() + "/" + count );
            SetResultInParent("Notenberechnung : "+ helper.ToString() + "/" + count);
            Notenempfehlung(helper);
        }
        public void Notenanzahl(string[] noten)
        {
            List<int> counter = new List<int>();
            foreach (var item in noten)
            {
                switch (item)
                {
                    case "1":
                        counter[0]++;
                        continue;
                    case "2":
                        counter[1]++;
                        continue;
                    case "3":
                        counter[2]++;
                        continue;
                    case "4":
                        counter[3]++;
                        continue;
                    case "5":
                        counter[4]++;
                        continue;
                    case "6":
                        counter[5]++;
                        continue;
                    default:
                        break;
                }
                SetResultInParent("Noten: "+counter[0].ToString()+" x1" + counter[1].ToString() + " x2" + counter[2].ToString() + " x3" + counter[3].ToString() + " x4" + counter[4].ToString() + " x5" + counter[5].ToString() + " x6")
            }
        }
        public static double Notenempfehlung(double Note)
        {
            var zahl = new MathCalc().DoubleToFraction(Note);
            if (zahl.Item2 < 0.5)
            {
                return zahl.Item1;
            }
            else
            {
                zahl.Item1++;
                return zahl.Item1;
            }
        }
    }
}
