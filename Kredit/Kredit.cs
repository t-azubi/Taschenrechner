using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taschenrechner;

namespace Taschenrechner
{
    public partial class KreditForm : BaseForm
    {
        public KreditForm()
        {
            InitializeComponent();
        }
        private void btn_Krediteinmalig_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben sie den Kreditbetrag an");

            double Kreditbetrag = returnUserInputValue;

            ShowMessage("Geben sie den Jahreszins in % an");

            double Zinshöhe = returnUserInputValue;

            ShowMessage("Geben sie die Laufzeit in Jahren an!");

            double Laufzeit = returnUserInputValue;

            double zins =(1 + Zinshöhe / 100);
            double tempresult = new MathCalc().Power(zins, Laufzeit);
            double result = Kreditbetrag * tempresult;
            double Zinsen_gesamt = tempresult * Kreditbetrag - Kreditbetrag;


            SetResultInParent($"({Kreditbetrag} * ((1+ {Zinshöhe}/100)^{Laufzeit} Jahre) = {result}");
            SetResultInParent($"Kreditbetrag: {Kreditbetrag}, Zinssatz: {Zinshöhe}, Laufzeit: {Laufzeit} Jahre");
            SetResultInParent($"Ratenhöhe (einmalig): {result} Zinsen insgesamt: {Zinsen_gesamt}");

        }

        private void btn_Laufzeitkredit_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben sie den Kreditbetrag an");

            double Kreditbetrag = returnUserInputValue;

            ShowMessage("Geben sie den Jahreszins in % an");

            double Zinshöhe = returnUserInputValue;

            ShowMessage("Geben sie die Laufzeit in Jahren an!");

            double Laufzeit = returnUserInputValue;

            double zins =(1+ Zinshöhe / 100);
            double tempresult = new MathCalc().Power(zins, Laufzeit);
            double Monatsrate = tempresult * Kreditbetrag / (12 * Laufzeit);
            double Zinsen_gesamt = tempresult * Kreditbetrag -Kreditbetrag;

            SetResultInParent($"(({Kreditbetrag} * (1+ {Zinshöhe}/100))^{Laufzeit} Jahre) /12 = {Monatsrate}");
            SetResultInParent($"Kreditbetrag: {Kreditbetrag}€, Zinssatz: {Zinshöhe}, Laufzeit: {Laufzeit} Jahre");
            SetResultInParent($"Ratenhöhe (monatlich): {Monatsrate}€ Zinsen insgesamt: {Zinsen_gesamt}€");
        }

        private void Btn_Ratenhöhekredit_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben sie den Kreditbetrag an");

            double Kreditbetrag = returnUserInputValue;

            ShowMessage("Geben sie den Jahreszins in % an");

            double Zinshoehe = returnUserInputValue;

            ShowMessage("Geben sie die Ratenhöhe pro Monat an!");

            double Ratenhoehe = returnUserInputValue;
            double counter = 0;
            double zins = (1 + Zinshoehe / 100);
            double Kreditbetrag1 = Kreditbetrag;
            double Laufzeit = Kreditbetrag/Ratenhoehe;

       
            double tempresult = new MathCalc().Power(zins, Laufzeit);
            double Monatsrate = tempresult * Kreditbetrag / (12 * Laufzeit);
            double Zinsen_gesamt = tempresult * Kreditbetrag - Kreditbetrag;



            //SetResultInParent($"({Kreditbetrag} * {Zinshöhe}/100 *{Laufzeit}/12 + {Kreditbetrag}) / {Laufzeit} = {result}");
            SetResultInParent($"Kreditbetrag: {Kreditbetrag1}, Zinssatz: {Zinshoehe}, Ratenhöhe: (monatlich) {Ratenhoehe}");
            SetResultInParent($"Laufzeit: {Laufzeit} Jahre, Zinsen + Kredit (gesamt): {Zinsen_gesamt}");
        }
    }
}
