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
    public partial class fm_BitByte : BaseForm
    {
        public fm_BitByte()
        {
            InitializeComponent();
            
        }

        private void btn_Weiter_Click(object sender, EventArgs e)
        {
            ShowMessage("Bitte Eingabe machen");
            var eingabe = Convert.ToInt32(returnUserInputValue);
            double ergebnis = 0;
            var rückgabe = string.Empty;
            if (rB_Bit.Checked)
            {
                ergebnis = (int)(eingabe / 8);
                rückgabe = eingabe + " bit = " + ergebnis + "byte";
            }
            if (rB_Byte.Checked)
            {
                ergebnis = eingabe * 8;
                rückgabe = eingabe + " byte = " + ergebnis + "bit";
            }
            SetResultInParent(rückgabe);
        }
    }
}
