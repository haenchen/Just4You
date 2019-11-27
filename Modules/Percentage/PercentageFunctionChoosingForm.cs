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

namespace Just4You.Modules.Percentage
{
    public partial class PercentageFunctionChoosingForm : ModuleForm
    {
        public PercentageFunctionChoosingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Wert prozentual verringern.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubPercent_Click(object sender, EventArgs e)
        {
            var value = new Parameter("Wert");
            if (ParamAborted(value))
                return;
            var percent = new Parameter("Prozent");
            if (ParamAborted(percent))
                return;
            output.Add(value.Input + " - " + percent.Input + " % = " + (value.Value - (value.Value * percent.Value / 100)).ToString().Replace('.', ','));
            this.Close();
        }

        /// <summary>
        /// Wert prozentual erhöhen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPercent_Click(object sender, EventArgs e)
        {
            var value = new Parameter("Wert");
            if (ParamAborted(value))
                return;
            var percent = new Parameter("Prozent");
            if (ParamAborted(percent))
                return;
            output.Add(value.Input + " + " + percent.Input + " % = " + (value.Value + (value.Value * percent.Value / 100)).ToString().Replace('.', ',') + ".");
            this.Close();
        }

        /// <summary>
        /// Prozentualen Anteil ermitteln.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPercentOf_Click(object sender, EventArgs e)
        {
            var value = new Parameter("Wert");
            if (ParamAborted(value))
                return;
            var percent = new Parameter("Prozent");
            if (ParamAborted(percent))
                return;
            output.Add(percent.Input + " % von " + value.Input + " = " + (value.Value * percent.Value / 100).ToString().Replace('.', ',') + ".");
            this.Close();
        }

        /// <summary>
        /// Prozentualen Anteil zweier Werte ermitteln.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPercentage_Click(object sender, EventArgs e)
        {
            var valueOne = new Parameter("Wert");
            if (ParamAborted(valueOne))
                return;
            var valueTwo = new Parameter("von");
            if (ParamAborted(valueTwo))
                return;
            if (valueOne.Value >= 0 && valueTwo.Value >= 0 || valueOne.Value < 0 && valueTwo.Value < 0)
                output.Add(valueOne.Input + " sind " + (valueOne.Value / valueTwo.Value * 100).ToString().Replace('.', ',') + " % von " + valueTwo.Input + ".");
            else
                GlobalLogger.addError("Beide Eingaben müssen das gleiche Vorzeichen haben.");
            this.Close();
        }

        /// <summary>
        /// Brutto zu Netto umrechnen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGrossToNet_Click(object sender, EventArgs e)
        {
            var gross = new Parameter("Brutto", new InputConstraint[] { new PositiveConstraint(), new NonZeroConstraint() });
            if (ParamAborted(gross))
                return;
            var percent = new Parameter("Steuer (in %)", new InputConstraint[] { new PositiveConstraint() });
            if (ParamAborted(percent))
                return;
            double net = gross.Value / (1 + percent.Value / 100);
            output.Add(FormatMoney(gross.Value) + " € Brutto sind " + FormatMoney(net) + " € Netto bei " + percent.Input + " % Steuer.");
            this.Close();
        }

        /// <summary>
        /// Netto zu Brutto umrechnen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNetToGross_Click(object sender, EventArgs e)
        {
            var net = new Parameter("Netto", new InputConstraint[] { new PositiveConstraint(), new NonZeroConstraint() });
            if (ParamAborted(net))
                return;
            var percent = new Parameter("Steuer (in %)", new InputConstraint[] { new PositiveConstraint() });
            if (ParamAborted(percent))
                return;
            double gross = net.Value + (net.Value * percent.Value / 100);
            output.Add(FormatMoney(net.Value) + " € Netto sind " + FormatMoney(gross) + " € Brutto bei " + percent.Input + " % Steuer.");
            this.Close();
        }

        public override string GetModuleText()
        {
            return "Prozentrechnung";
        }
    }
}
