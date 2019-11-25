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

namespace Just4You.Modules.Informatics
{
    public partial class InformaticsFunctionChoosingForm : ModuleForm
    {
        public InformaticsFunctionChoosingForm()
        {
            InitializeComponent();
            var unitTooltipText = new StringBuilder();
            unitTooltipText.Append("Starteinheit:" + Environment.NewLine);
            for (int i = 0; i < 10; ++i)
                unitTooltipText.Append(i.ToString() + " = " + GetUnit(i) + Environment.NewLine);
            var unitTooltip = new ToolTip();
            unitTooltip.SetToolTip(btnUnits, unitTooltipText.ToString());
            var systemTooltipText = new StringBuilder();
            systemTooltipText.Append("Startsystem:" + Environment.NewLine);
            for (int i = 0; i < 4; ++i)
                systemTooltipText.Append(i.ToString() + " = " + GetSystemSuffix(i) + Environment.NewLine);
            var systemTooltip = new ToolTip();
            systemTooltip.SetToolTip(btnNumber, systemTooltipText.ToString());
        }

        public override String GetModuleText()
        {
            return "Informationstechnik";
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            var width = new Parameter("Breite", new InputConstraint[] { new IntegerConstraint() });
            if (ParamAborted(width))
                return;
            if (width.Value < 1)
            {
                GlobalLogger.addError("Ungültige Eingabe für Breite.");
                this.Close();
                return;
            }
            var height = new Parameter("Höhe", new InputConstraint[] { new IntegerConstraint() });
            if (ParamAborted(height))
                return;
            if (height.Value < 1)
            {
                GlobalLogger.addError("Ungültige Eingabe für Höhe.");
                this.Close();
                return;
            }
            var depth = new Parameter("Farbtiefe", new InputConstraint[] { new IntegerConstraint() });
            if (ParamAborted(depth))
                return;
            if (depth.Value < 1)
            {
                GlobalLogger.addError("Ungültige Eingabe für Farbtiefe.");
                this.Close();
                return;
            }

            double size = width.Value * height.Value * depth.Value;
            int i = 0;
            output.Add(size.ToString().Replace(".", ",") + " b");
            size /= 8;
            do
            {
                String unit = GetUnit(i++);
                if (unit != "")
                {
                    output.Add(size.ToString().Replace(".", ",") + " " + unit);
                    size /= 1024;
                }
                else
                {
                    GlobalLogger.addError("Errechnete Dateigröße zu groß.");
                    this.Close();
                    return;
                }
            } while (size > 1024);
            this.Close();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            var startUnit = new Parameter("Ausgangseinheit", new InputConstraint[] { new IntegerConstraint() });
            if (ParamAborted(startUnit))
                return;
            if (startUnit.Value < 0 || startUnit.Value > 8)
            {
                GlobalLogger.addError("Ungülütige Eingabe für Ausgangseinheit.");
                this.Close();
                return;
            }
            int unit = (int)startUnit.Value;
            var inputValue = new Parameter("Wert in " + GetUnit(unit), new InputConstraint[] { new PositiveConstraint() });
            if (ParamAborted(inputValue))
                return;
            if (unit < 2 && inputValue.Value % 1 != 0)
            {
                GlobalLogger.addError("Ungülütige Eingabe für Wert.");
                this.Close();
                return;
            }
            double value = inputValue.Value;
            double tmpVal = value;
            int tmpInt = unit + 1;
            while (tmpVal > 1024)
            {
                tmpVal /= 1024;
                output.Add(tmpVal.ToString().Replace(".", ",") + " " + GetUnit(tmpInt++));
            }
            output.Add(value.ToString().Replace(".", ",") + " " + GetUnit(unit));
            for (int i = unit - 1; i >= 0; --i)
            {
                tmpVal = value;
                for (int j = unit - i; j > 0; j--)
                    tmpVal *= 1024;
                if (i == 0)
                {
                    tmpVal *= 8;
                }
                output.Add(tmpVal.ToString().Replace(".", ",") + " " + GetUnit(i));
            }
            this.Close();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            var startSystem = new Parameter("Startsystem", new InputConstraint[] { new IntegerConstraint() });
            if (ParamAborted(startSystem))
                return;
            if (startSystem.Value < 0 || startSystem.Value > 3) {
                GlobalLogger.addError("Ungültige Eingabe für Startsystem.");
                this.Close();
                return;
            }
            int system = (int)startSystem.Value;
            var value = new Parameter("Wert", new InputConstraint[] { new IntegerConstraint(), new PositiveConstraint() });
            if (ParamAborted(value))
                return;
            int actualVal = (int)value.Value;
            for (int i = 0; i < 4; ++i)
            {
                HandleSystem(i, actualVal);
            }
            this.Close();
        }

        private String GetUnit(int i)
        {
            switch(i)
            {
                case 0: return "b";
                case 1: return "B";
                case 2: return "KiB";
                case 3: return "MiB";
                case 4: return "GiB";
                case 5: return "TiB";
                case 6: return "PiB";
                case 7: return "EiB";
                case 8: return "ZiB";
                case 9: return "YiB";
                default: return "";
            }
        }

        private String GetSystemSuffix(int i)
        {
            switch (i)
            {
                case 0: return "dez";
                case 1: return "bin";
                case 2: return "oct";
                case 3: return "hex";
                default: return "";
            }
        }

        private void HandleSystem(int i, int val)
        {
            String result = "";
            switch(i)
            {
                case 0:
                    result = val.ToString();
                    break;
                case 1: 
                    result = Convert.ToString(val, 2);
                    break;
                case 2: 
                    result = Convert.ToString(val, 8);
                    break;
                case 3:
                    result = Convert.ToString(val, 16);
                    break;
            }
            output.Add(result + " " + GetSystemSuffix(i));
        }
    }
}
