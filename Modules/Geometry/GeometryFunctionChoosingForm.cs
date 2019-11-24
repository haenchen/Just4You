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
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            var radius = new Parameter("Radius");
            if (ParamAborted(radius))
                return;
            if (radius.Value < 0)
            {
                GlobalLogger.addError("Radius kann nur positiv sein.");
                this.Close();
                return;
            }
            double area = Math.PI * Math.Pow(radius.Value, 2);
            double circumference = 2 * Math.PI * radius.Value;
            output.Add("r = " + radius.Input);
            output.Add("A = " + area.ToString().Replace(".", ","));
            output.Add("U = " + circumference.ToString().Replace(".", ","));
            this.Close();
        }

        public override String GetModuleText()
        {
            return "Geometrie";
        }
    }
}
