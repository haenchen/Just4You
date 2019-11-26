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
            output.Add("Kreditbetrag: " + FormatMoney(amount.Value) + " €");
            output.Add("Zinssatz: " + interest.Value.ToString().Replace('.', ',') + " %");
            double result = amount.Value + (amount.Value * interest.Value / 100);
            output.Add("Rückzahlungsbetrag: " + FormatMoney(result) + " €");
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
            var interest = new Parameter("Jahreszinssatz (in %)", new InputConstraint[] { new PositiveConstraint() });
            if (ParamAborted(interest))
                return;
            double interestAmount = Math.Round(amount.Value * (interest.Value / 100) * (count.Value / 360), 2);
            double totalAmount = amount.Value + interestAmount;
            output.Add("Nettokreditbetrag: " + FormatMoney(amount.Value) + " €");
            output.Add("Gesamtkreditbetrag: " + FormatMoney(totalAmount) + " €");
            output.Add("Laufzeit: " + count.Value.ToString().Replace('.', ',') + " Monate");
            output.Add("Jahreszinssatz: " + interest.Value.ToString().Replace('.', ',') + " %");
            output.Add("Gesamtzins: " + FormatMoney(interestAmount) + " €");
            output.Add("Ratenhöhe: " + FormatMoney(Math.Round(totalAmount / count.Value, 2)) + " €");
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
            var interest = new Parameter("Gesamtzinssatz (in %)", new InputConstraint[] { new PositiveConstraint() });
            if (ParamAborted(interest))
                return;
            if (payment.Value >= amount.Value)
            {
                GlobalLogger.addError("Ratenhöhe muss kleiner als der Kreditbetrag sein.");
                this.Close();
                return;
            }
            output.Add("Kreditbetrag: " + FormatMoney(amount.Value) + " €");
            output.Add("Ratenhöhe: " + FormatMoney(payment.Value) + " €");
            output.Add("Gesamtzinssatz: " + interest.Value.ToString().Replace('.', ',') + " %");
            double fullAmount = amount.Value + (amount.Value * interest.Value / 100);
            output.Add("Gesamtzins: " + FormatMoney(fullAmount - amount.Value) + " €");
            double count = Math.Floor(fullAmount / payment.Value);
            double mod = fullAmount % payment.Value;
            if (mod == 0)
            {
                output.Add("Laufzeit: " + count.ToString().Replace('.', ',') + " Monate");
            }
            else
            {
                output.Add("Laufzeit: " + (count + 1).ToString().Replace('.', ',') + " Monate");
                output.Add("Die letzte Rate beträgt: " + FormatMoney(mod) + " €.");
            }
            this.Close();
        }

        public override string GetModuleText()
        {
            return "Finanzierung";
        }
    }
}
