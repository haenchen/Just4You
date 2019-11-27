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

namespace Just4You.Modules.MathematicalFunctions
{
    /// <summary>
    /// Nutzung von Math functions wurde gestattet, da die Gruppe mehrere male zerbrochen ist.
    /// </summary>
    public partial class MathematicalFunctionChoosingForm : ModuleForm
    {
        public MathematicalFunctionChoosingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fakutltät eines Wertes ermitteln.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFactorial_Click(object sender, EventArgs e)
        {
            var param = new Parameter("Fakultät", new InputConstraint[] { new IntegerConstraint(), new PositiveConstraint() });
            if (ParamAborted(param))
                return;
            double value = param.Value;
            // Prüfen ob Wert Ganzzahl ist
            for (int i = (int) value - 1; i > 0; i--)
            {
                value *= i;
            }
            output.Add(param.Input + "! = " + value.ToString());
            this.Close();
        }

        /// <summary>
        /// Potenz ermitteln.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExponentiation_Click(object sender, EventArgs e)
        {
            var exponentiationBase = new Parameter("Basis");
            if (ParamAborted(exponentiationBase))
                return;
            var exponent = new Parameter("Exponent");
            if (ParamAborted(exponent))
                return;
            double result = Math.Pow(exponentiationBase.Value, exponent.Value);
            output.Add(exponentiationBase.Input + " ^ " + exponent.Input + " = " + result.ToString().Replace(".", ","));
            this.Close();
        }

        /// <summary>
        /// n-te Wurzel berechnen.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private double NthRoot(double x, int n)
        {
            return Math.Pow(x, 1.0 / n);
        }

        /// <summary>
        /// n-te Wurzel ermitteln;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoot_Click(object sender, EventArgs e)
        {
            var index = new Parameter("Wurzelexponent", new InputConstraint[] { new IntegerConstraint() });
            if (ParamAborted(index))
                return;
            var radicand = new Parameter("Radikand", new InputConstraint[] { new PositiveConstraint() });
            if (ParamAborted(radicand))
                return;
            double result = NthRoot(radicand.Value, (int) index.Value);
            output.Add(index.Input + "te Wurzel von " + radicand.Input + " = " + result.ToString().Replace(".", ","));
            this.Close();
        }

        /// <summary>
        /// Primzahlen zwischen zwei Grenzwerten ermitteln.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrimes_Click(object sender, EventArgs e)
        {
            var lower = new Parameter("Untere Grenze");
            if (ParamAborted(lower))
                return;
            var upper = new Parameter("Obere Grenze");
            if (ParamAborted(upper))
                return;
            if (lower.Value <= upper.Value)
            {
                GlobalLogger.addError("Die untere Intervalgrenze muss kleiner sein als die obere Intervalgrenze.");
                this.Close();
            }
            // Nichtganzzahlige Eingaben sind gestattet, für die Schleife ist aber ein int besser.
            int actualLower = lower.Value % 1 == 0
                ? (int)lower.Value
                : (int)lower.Value + 1;
            var primes = new List<int>();
            for (int i = actualLower; i <= upper.Value; ++i)
                if (IsPrime(i))
                    primes.Add(i);
            output.Add("Primzahlen zwischen " + lower.Input + " und " + upper.Input + ":");
            var line = new StringBuilder();
            foreach (int number in primes)
                if (number != primes[primes.Count - 1])
                    line.Append(number.ToString() + ", ");
                else
                    line.Append(number.ToString());
            output.Add(line.ToString());
        }

        private bool IsPrime(int x)
        {
            if (x <= 1)
                return false;
            if (x == 2)
                return true;
            if (x % 2 == 0)
                return false;
            for (int i = 3; i < x; i += 2)
                if (x % i == 0)
                    return false;
            return true;
        }

        public override String GetModuleText()
        {
            return "Mathematische Funktionen";
        }
    }
}
