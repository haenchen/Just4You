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
    }
}
