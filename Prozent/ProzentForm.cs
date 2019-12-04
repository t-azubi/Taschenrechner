using System;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class ProzentForm : BaseForm
    {
        public ProzentForm()
        {
            InitializeComponent();
        }
        private void btn_ProzentDazu_Click(object sender, EventArgs e)
        {
            ShowMessage("Gib die Grundzahl ein");
            var meineZahl = returnUserInputValue;
            ShowMessage("Wieviel Prozent soll dazu gerechnet werden ?");
            var sovielProzent = returnUserInputValue;
            var endergebnis = meineZahl + new Grundrechner().CalcConst(sovielProzent.ToString() + " / 100 * " + meineZahl.ToString());
            SetResultInParent("( " + sovielProzent.ToString() + " / 100 * " + meineZahl.ToString() + " ) + " + meineZahl.ToString() + " = " + endergebnis.ToString());
            if (sovielProzent < 0)
            {
                MessageBox.Show("Geben sie eine korrekte Zahl ein");
            }
        }

        private void btn_ProzentWeg_Click(object sender, EventArgs e)
        {
            ShowMessage("Bitte gib die Grundzahl ein");
            var meineZahl = returnUserInputValue;
            ShowMessage("Wieviel Prozent sollen abgezogen werden? ");
            var sovielProzent = returnUserInputValue;
            var endergebnis = meineZahl - new Grundrechner().CalcConst(sovielProzent.ToString()+ " / 100 * " +meineZahl.ToString()) ;
            SetResultInParent(meineZahl.ToString() + " - ( " + sovielProzent.ToString() + " / 100 * " + meineZahl.ToString() + ")  = " + endergebnis.ToString());
        }
        private void btn_ProzentVon_Click(object sender, EventArgs e)
        {
            ShowMessage("Bitte gib die Grundzahl ein");
            var meineZahl = returnUserInputValue;
            ShowMessage("Geben sie die Prozentzahl ein!");
            var sovielProzent = returnUserInputValue;
            var ergebnis = new Grundrechner().CalcConst(sovielProzent.ToString() +"/ 100 *"+ meineZahl.ToString());
            SetResultInParent(sovielProzent.ToString() + " / 100 * " + meineZahl.ToString() + " = " + ergebnis.ToString());
        }

        private void btn_Satz_Click(object sender, EventArgs e)
        {
            ShowMessage("Bitte gib die Grundzahl ein");
            var meineZahl = returnUserInputValue;
            ShowMessage("Geben sie die zweite Zahl ein!");
            var zweiteZahl = returnUserInputValue;
            var ergebnis = new Grundrechner().CalcConst(zweiteZahl.ToString()+ " * 100 / " + meineZahl.ToString());
            SetResultInParent(zweiteZahl.ToString() + " * 100 / " + meineZahl.ToString() + " = " + ergebnis.ToString());
        }
        private void btn_BruttoVonNetto_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben sie ihr Netto an!");
            var meineZahl = returnUserInputValue;
            ShowMessage("Geben sie ihre Steuern in Prozent an!");
            var zweiteZahl = returnUserInputValue;
            var ergebnis = new Grundrechner().CalcConst("((100 +" + zweiteZahl + ")/100) *" + meineZahl) ;
            SetResultInParent($"(100 + {zweiteZahl}) / 100 * {meineZahl}  = " + ergebnis.ToString());
        }

        private void btn_NettoVonBrutto_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben sie ihr Brutto an!");
            var meineZahl = returnUserInputValue;
            ShowMessage(" Geben sie ihre Steuern in Prozent an");
            var zweiteZahl = returnUserInputValue;
            var ergebnis = new Grundrechner().CalcConst(meineZahl.ToString() + "* (1 - (" + zweiteZahl.ToString() + " / 100))");
            SetResultInParent(meineZahl.ToString() + " * ( 1 - ( " + zweiteZahl.ToString() + " / 100 ) ) = " + ergebnis.ToString());
        }
    }
}
