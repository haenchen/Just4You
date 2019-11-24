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
    public partial class MathematicalFunctionChoosingForm : ModuleForm
    {
        public MathematicalFunctionChoosingForm()
        {
            InitializeComponent();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            var param = new Parameter("Fakultät");
            double value = param.Value;
            // Prüfen ob Wert Ganzzahl ist
            if (value % 1 != 0)
            {
                GlobalLogger.addError("Keine Ganzzahl für Fakultätsfunktion angegeben");
                this.result = Double.NaN;
                this.Close();
                return;
            }
            for (int i = (int) value - 1; i > 0; i--)
            {
                value *= i;
            }
            result = value;
            output.Add(param.Input + "! = " + value.ToString());
            this.Close();
        }

        private void btnExponentiation_Click(object sender, EventArgs e)
        {
            var exponentiationBase = new Parameter("Basis");
            var exponent = new Parameter("Exponent");
            double result = Power(exponentiationBase.Value, exponent.Value);
            output.Add(exponentiationBase.Input + " ^ " + exponent.Input + " = " + result.ToString().Replace(".", ","));
            this.result = result;
            this.Close();
        }

        private double Power(double exponentiationBase, double power, double precision = 0.000001)
        {
            if (power < 0)
                return 1 / this.Power(exponentiationBase, - power, precision);
            if (power >= 10)
                return Square(this.Power(exponentiationBase, power / 2, precision / 2));
            if (power >= 1)
                return exponentiationBase * this.Power(exponentiationBase, power - 1, precision);
            if (precision >= 1)
                return SquareRoot(exponentiationBase);
            return SquareRoot(this.Power(exponentiationBase, power * 2, precision * 2));
        }

        private double Square(double x)
        {
            return x * x;
        }

        // Newton Approximation
        private double SquareRoot(double x)
        {
            if (x < 0)
            {
                GlobalLogger.addError("Nur positive Zahlen können radiziert werden.");
                return Double.NaN;
            }
            double precision = 0.000001;
            double y = 1.0;
            while (Absolute(x/y - y) > precision)
            {
                y = (y + x / y) / 2;
            }
            return y;
        }

        private double Absolute(double x)
        {
            return x < 0 ? x * (-1) : x;
        }

        private double NthRoot(double x, int n)
        {
            return Power(x, 1 / n);
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            var index = new Parameter("Wurzelexponent");
            if (index.Value % 1 != 0)
            {
                GlobalLogger.addError("Nichtganzzahlige Eingabe für Wurzelexponent");
                this.result = Double.NaN;
                this.Close();
                return;
            }
            var radicand = new Parameter("Radikand");
            if (index.Value < 0 || radicand.Value < 0)
            {
                GlobalLogger.addError("Nur positive Zahlen können radiziert werden");
                this.result = Double.NaN;
                this.Close();
                return;
            }
            double result = NthRoot(radicand.Value, (int) index.Value);
            output.Add(index.Input + "te Wurzel von " + radicand.Input + " = " + result.ToString().Replace(".", ","));
            this.result = result;
            this.Close();
        }

        private void btnPrimes_Click(object sender, EventArgs e)
        {
            var lower = new Parameter("Untere Intervalgrenze");
            var upper = new Parameter("Obere Intervalgrenze");
            if (lower.Value <= upper.Value)
            {
                GlobalLogger.addError("Die untere Intervalgrenze muss kleiner sein als die obere Intervalgrenze.");
                this.Close();
            }
            int actualLower = lower.Value % 1 == 0
                ? (int)lower.Value
                : (int)lower.Value + 1;
            var primes = new List<int>();
            for (int i = actualLower; i < upper.Value; ++i)
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
            if (x < 1)
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
    }
}
