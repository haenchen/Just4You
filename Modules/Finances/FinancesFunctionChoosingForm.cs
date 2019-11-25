using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Just4You.Modules.InputModule;

namespace Just4You.Modules.Finances
{
    public partial class FinancesFunctionChoosingForm : ModuleForm
    {
        public FinancesFunctionChoosingForm()
        {
            InitializeComponent();
        }

        private void btnOneTimePayment_Click(object sender, EventArgs e)
        {
            var amount = new Parameter("Kreditbetrag", new InputConstraint[] { new PositiveConstraint(), new NonZeroConstraint() });
            if (ParamAborted(amount))
                return;
            var interest = new Parameter("Zinssatz (in %)", new InputConstraint[] { new PositiveConstraint() });
            if (ParamAborted(interest))
                return;
            output.Add("Kreditbetrag: " + amount.Value.ToString().Replace('.', ',') + " €");
            output.Add("Zinssatz: " + interest.Value.ToString().Replace('.', ',') + " %");
            double result = amount.Value + (amount.Value * interest.Value / 100);
            output.Add("Rückzahlungsbetrag: " + result.ToString().Replace('.', ',') + " €");
            this.Close();
        }

        private void btnNumberOfPayments_Click(object sender, EventArgs e)
        {

        }

        private void btnPaymentAmount_Click(object sender, EventArgs e)
        {

        }

        public override string GetModuleText()
        {
            return "Finanzierung";
        }
    }
}
