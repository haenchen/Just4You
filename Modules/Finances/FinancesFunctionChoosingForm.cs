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
            var amount = new Parameter("Kreditbetrag", new InputConstraint[] { new PositiveConstraint(), new NonZeroConstraint() });
            if (ParamAborted(amount))
                return;
            var count = new Parameter("Laufzeit", new InputConstraint[] { new PositiveConstraint(), new NonZeroConstraint(), new IntegerConstraint() });
            if (ParamAborted(count))
                return;
            var interest = new Parameter("Zinssatz (in %)", new InputConstraint[] { new PositiveConstraint() });
            if (ParamAborted(interest))
                return;
            double fullAmount = amount.Value + (amount.Value * interest.Value / 100);
            output.Add("Kreditbetrag: " + amount.Value.ToString().Replace('.', ',') + " €");
            output.Add("Laufzeit: " + count.Value.ToString().Replace('.', ',') + " Monate");
            output.Add("Zinssatz: " + interest.Value.ToString().Replace('.', ',') + " %");
            output.Add("Ratenhöhe: " + Math.Round(fullAmount / count.Value, 2).ToString().Replace('.', ',') + " €");
            this.Close();
        }

        private void btnPaymentAmount_Click(object sender, EventArgs e)
        {
            var amount = new Parameter("Kreditbetrag", new InputConstraint[] { new PositiveConstraint(), new NonZeroConstraint() });
            if (ParamAborted(amount))
                return;
            var payment = new Parameter("Ratenhöhe", new InputConstraint[] { new PositiveConstraint(), new NonZeroConstraint() });
            if (ParamAborted(payment))
                return;
            var interest = new Parameter("Zinssatz (in %)", new InputConstraint[] { new PositiveConstraint() });
            if (ParamAborted(interest))
                return;
            if (payment.Value >= amount.Value)
            {
                GlobalLogger.addError("Ratenhöhe muss kleiner als der Kreditbetrag sein.");
                this.Close();
                return;
            }
            output.Add("Kreditbetrag: " + amount.Value.ToString().Replace('.', ',') + " €");
            output.Add("Ratenhöhe: " + payment.Value.ToString().Replace('.', ',') + " €");
            output.Add("Zinssatz: " + interest.Value.ToString().Replace('.', ',') + " %");
            double fullAmount = amount.Value + (amount.Value * interest.Value / 100);
            double fullPayment = Math.Floor(fullAmount / payment.Value);
            double mod = amount.Value % payment.Value;
            if (mod != 0)
            {
                output.Add("Laufzeit: " + (fullPayment + 1).ToString().Replace('.', ',') + " Monate");
                output.Add("Wobei die Schlussrate " + mod.ToString().Replace('.', ',') + " € beträgt.");
            }
            else
            {
                output.Add("Laufzeit: " + fullPayment.ToString().Replace('.', ',') + " Monate");
            }
            this.Close();
        }

        public override string GetModuleText()
        {
            return "Finanzierung";
        }
    }
}
