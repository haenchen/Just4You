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
                this.Close();
                return;
            }
            for (int i = (int) value - 1; i > 0; i--)
            {
                value *= i;
            }
            output.Add(param.Input + "! = " + value.ToString());
            this.Close();
        }

        private void btnExponentiation_Click(object sender, EventArgs e)
        {
            var exponentiationBase = new Parameter("Basis");
            var exponent = new Parameter("Exponent");
            double result = Power(exponentiationBase.Value, exponent.Value);
            output.Add(exponentiationBase.Input + " ^ " + exponent.Input + " = " + result.ToString().Replace(".", ","));
        }

        private double Power(double exponentiationBase, double power, double precision = 0.000001)
        {
            if (power < 0) return 1 / this.Power(exponentiationBase, - power, precision);
            if (power >= 10) return Square(this.Power(exponentiationBase, power / 2, precision / 2));
            if (power >= 1) return exponentiationBase * this.Power(exponentiationBase, power - 1, precision);
            if (precision >= 1) return SquareRoot(exponentiationBase);
            return SquareRoot(this.Power(exponentiationBase, power * 2, precision * 2));
        }

        private double Square(double x)
        {
            return x * x;
        }

        // Newton Approximation
        private double SquareRoot(double x)
        {
            double precision = 0.000001;
            double y = 1.0;
            while (abs(x/y - y) > precision)
            {
                y = (y + x / y) / 2;
            }
            return y;
        }

        private double abs(double x)
        {
            return x < 0 ? x * (-1) : x;
        }

        private double NthRoot(double x, int n)
        {
            return Power(x, 1 / n);
        }
    }
}
