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
    public partial class fm_Informatik : BaseForm
    {
        private readonly Zahlensystemkonvertierung Zahlensystem = new Zahlensystemkonvertierung();
        private readonly fm_BitByte BitByte = new fm_BitByte();
        public fm_Informatik()
        {
            Zahlensystem.AdviseParent += new BaseForm.AdviseParentEventHandler(SetFromForm2);
            BitByte.AdviseParent += new BaseForm.AdviseParentEventHandler(SetFromForm2);
            InitializeComponent();
        }

        private void btn_Zahlensystem_Click(object sender, EventArgs e)
        {
            Zahlensystem.Font = this.Font;
            Zahlensystem.BackColor = this.BackColor;
            Zahlensystem.ForeColor = this.ForeColor;
            Zahlensystem.ShowDialog();
        }
        //für das Bild
        private void btn_Bild_Click(object sender, EventArgs e)
        {
            ShowMessage("Bitte Bildhöhe eingeben");
            var höhe = returnUserInputValue;
            ShowMessage("Bitte Bildbreite eingeben");
            var breite = returnUserInputValue;
            ShowMessage("Bitte Farbtiefe eingeben");
            var tiefe = returnUserInputValue;
            var bild = höhe * breite * tiefe;
            var rückgabe= "Ein Bild mit der Größe " + höhe + " x " + breite + " und einer Farbtiefe von " + tiefe + " hat eine Größe von " + bild + "bit";
            SetResultInParent(rückgabe);
        }

        private void btn_Video_Click(object sender, EventArgs e)
        {
            ShowMessage("Bitte Bildhöhe eingeben");
            var höhe = returnUserInputValue;
            ShowMessage("Bitte Bildbreite eingeben");
            var breite = returnUserInputValue;
            ShowMessage("Bitte Farbtiefe eingeben");
            var tiefe = returnUserInputValue;
            ShowMessage("Bitte Länge des Videos in Sec. angeben");
            var länge = 200; 
            var video = höhe * breite * tiefe * länge;
            var rückgabe = "Ein Bild mit der Größe " + höhe + " x " + breite + " und einer Farbtiefe von " + tiefe + " sowie einer Länge von "+länge+" hat eine Größe von " + video + " bit ";
            SetResultInParent(rückgabe);
        }

        private void btn_BitByte_Click(object sender, EventArgs e)
        {
            BitByte.Font = this.Font;
            BitByte.BackColor = this.BackColor;
            BitByte.ForeColor = this.ForeColor;
            BitByte.ShowDialog();
        }
    }
}
