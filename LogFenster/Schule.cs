using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    class Schule
    {
        public string helper = string.Empty;
        public List<string> output = new List<string>();
        private EingabeForm eingabeForm = new EingabeForm();
        public delegate void AdviseParentEventHandler(string text);
        public bool stop = false;
        private void ShowMessage(string Message)
        {
            MessageBox.Show(Message, "Noteneingabe");
            eingabeForm.ShowDialog();
        }
        public void SetFromForm2(string result)
        {
            if (Regex.Match(result, @"[,]{2,}").Success)
            {
                MessageBox.Show("Deine Eingabe war fehlerhaft!", "Fehlerhafte Eingabe");
                stop = true;
            }
            helper = result;
        }
        public List<string> StartModule(Font font, Color foreColor, Color backColor)
        { 
            stop = false;
            eingabeForm.Font = font;
            eingabeForm.BackColor = backColor;
            eingabeForm.ForeColor = foreColor;
            eingabeForm.AdviseParent += new EingabeForm.AdviseParentEventHandler(SetFromForm2);
            const char seperator = ',';
            foreach (var button in eingabeForm.Controls.OfType<Button>())
            {
                var isInt = int.TryParse(button.Text, out int a);
                if (isInt && a > 6)
                {
                    button.Enabled = false;
                }
                if (isInt && a == 0 || button.Text == "-")
                {
                    button.Enabled = false;
                }
            }
            ShowMessage($"Bitte geben sie alle Noten an!(mit {seperator} Trennen)");
            var Noten = helper.Split(seperator);


            if (stop || (Noten.Length == 1 && Noten[0] == ""))
            {
                return output;
            }
            Notenberechnung(Noten);
            Notenanzahl(Noten);
            return output;
        }
        private void Notenberechnung(string[] noten)
        {
            double helper = 0;
            foreach (var item in noten)
            {
                if (Convert.ToInt16(item) < 7 && Convert.ToInt16(item) > 0)
                {
                    helper += Convert.ToInt16(item);
                }
                else
                {
                    var x = noten.ToList();
                    x.RemoveAt(x.IndexOf(item));

                }
            }
            var count = noten.Count().ToString();
            var helper2 = new Grundrechner().CalcConst(helper.ToString() + " / " + count);
            output.Add("Notenberechnung : " + helper.ToString() + " / " + count + " = " + helper2.ToString());
            Notenempfehlung(helper2);
        }
        private void Notenanzahl(string[] noten)
        {
            List<int> counter = new List<int> { 0, 0, 0, 0, 0, 0 };
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
            }
            output.Add("Noten: " + "1x " + counter[0].ToString() + " | 2x " + counter[1].ToString() + " | 3x " + counter[2].ToString() + " | 4x " + counter[3].ToString() + " | 5x " + counter[4].ToString() + " | 6x " + counter[5].ToString());
        }
        private void Notenempfehlung(double Note)
        {
            var zahl = new MathCalc().splitExp(Note);
            if ((zahl.Item2 < .5))
            {
                output.Add("Notenempfehlung: " + zahl.Item1.ToString());
            }
            else
            {
                zahl.Item1++;
                output.Add("Notenempfehlung: " + zahl.Item1.ToString());
            }
        }
    }
}

