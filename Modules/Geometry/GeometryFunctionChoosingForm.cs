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

namespace Just4You.Modules.Geometry
{
    public partial class GeometryFunctionChoosingForm : ModuleForm
    {
        public GeometryFunctionChoosingForm()
        {
            InitializeComponent();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            var sideA = new Parameter("Seite a", new InputConstraint[] { new PositiveConstraint(), new NonZeroConstraint() });
            if (ParamAborted(sideA))
                return;
            var sideB = new Parameter("Seite b", new InputConstraint[] { new PositiveConstraint(), new NonZeroConstraint() });
            if (ParamAborted(sideB))
                return;
            var angle = new Parameter("Winkel γ (°)");
            if (ParamAborted(angle))
                return;
            double a = sideA.Value;
            double b = sideB.Value;
            double actualAngle = angle.Value % 180;
            double c = Math.Pow(a, 2) + Math.Pow(b, 2) - (2 * a * b * Math.Cos(actualAngle));
            double alpha = Math.Acos((-Math.Pow(a, 2) / 2) + (Math.Pow(b,2) / 2) + (Math.Pow(c, 2) / 2));
            double beta = 180 - actualAngle - alpha;
            double height = b * Math.Sin(actualAngle);
            double area = (a * height) / 2;
            double circumference = a + b + c;
            output.Add("Seite a = " + a.ToString().Replace(".", ","));
            output.Add("Seite b = " + b.ToString().Replace(".", ","));
            output.Add("Seite c = " + c.ToString().Replace(".", ","));
            output.Add("Winkel α = " + alpha.ToString().Replace(".", ","));
            output.Add("Winkel β = " + beta.ToString().Replace(".", ","));
            output.Add("Winkel γ = " + actualAngle.ToString().Replace(".", ","));
            output.Add("Höhe h = " + height.ToString().Replace(".", ","));
            output.Add("Umfang U = " + circumference.ToString().Replace(".", ","));
            output.Add("Fläche A = " + area.ToString().Replace(".", ","));
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sideA = new Parameter("Seite a", new InputConstraint[] { new PositiveConstraint(), new NonZeroConstraint() });
            if (ParamAborted(sideA))
                return;
            double a = sideA.Value;
            var sideB = new Parameter("Seite b", new InputConstraint[] { new PositiveConstraint(), new NonZeroConstraint() });
            if (ParamAborted(sideB))
                return;
            double b = sideB.Value;
            var angle = new Parameter("Winkel α (°)");
            if (ParamAborted(angle))
                return;
            double actualAngle = angle.Value % 180;
            double beta = 180 - actualAngle;
            double width = a * Math.Sin(beta);
            double height = b * Math.Sin(actualAngle);
            double diagonalAlpha = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - (2 * a * b * Math.Cos(beta)));
            double diagonalBeta = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - (2 * a * b * Math.Cos(actualAngle)));
            double circumference = (2 * a) + (2 * b);
            double area = a * height;
            output.Add("Seite a = " + a.ToString().Replace(".", ","));
            output.Add("Seite b = " + b.ToString().Replace(".", ","));
            output.Add("Winkel α = " + actualAngle.ToString().Replace(".", ","));
            output.Add("Winkel β = " + beta.ToString().Replace(".", ","));
            output.Add("Höhe ha = " + height.ToString().Replace(".", ","));
            output.Add("Breite hb = " + width.ToString().Replace(".", ","));
            output.Add("Diagonale in Winkel α = " + diagonalAlpha.ToString().Replace(".", ","));
            output.Add("Diagonale in Winkel β = " + diagonalBeta.ToString().Replace(".", ","));
            output.Add("Umfang U = " + circumference.ToString().Replace(".", ","));
            output.Add("Fläche A = " + area.ToString().Replace(".", ","));
            this.Close();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            var radius = new Parameter("Radius", new InputConstraint[] { new PositiveConstraint(), new NonZeroConstraint() });
            if (ParamAborted(radius))
                return;
            double area = Math.PI * Math.Pow(radius.Value, 2);
            double circumference = 2 * Math.PI * radius.Value;
            output.Add("Radius r = " + radius.Input);
            output.Add("Umfang U = " + circumference.ToString().Replace(".", ","));
            output.Add("Fläche A = " + area.ToString().Replace(".", ","));
            this.Close();
        }

        public override String GetModuleText()
        {
            return "Geometrie";
        }
    }
}
