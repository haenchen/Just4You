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
            var tooltipText = new StringBuilder();
            tooltipText.Append("Starteinheit:" + Environment.NewLine);
            for (int i = 0; i < 10; ++i)
                tooltipText.Append(i.ToString() + " = " + GetUnit(i) + Environment.NewLine);
            var unitTooltip = new ToolTip();
            unitTooltip.SetToolTip(btnUnits, tooltipText.ToString());
        }

        public override String GetModuleText()
        {
            return "Informationstechnik";
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            var width = new Parameter("Breite");
            if (ParamAborted(width))
                return;
            if (width.Value % 1 != 0 || width.Value < 1)
            {
                GlobalLogger.addError("Ungültige Eingabe für Breite.");
                result = Double.NaN;
                this.Close();
                return;
            }
            var height = new Parameter("Höhe");
            if (ParamAborted(height))
                return;
            if (height.Value % 1 != 0 || height.Value < 1)
            {
                GlobalLogger.addError("Ungültige Eingabe für Höhe.");
                result = Double.NaN;
                this.Close();
                return;
            }
            var depth = new Parameter("Farbtiefe");
            if (ParamAborted(depth))
                return;
            if (depth.Value % 1 != 0 || depth.Value < 1)
            {
                GlobalLogger.addError("Ungültige Eingabe für Farbtiefe.");
                result = Double.NaN;
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
                    result = Double.NaN;
                    GlobalLogger.addError("Errechnete Dateigröße zu groß.");
                    this.Close();
                    return;
                }
            } while (size > 1024);
            this.Close();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            var startUnit = new Parameter("Ausgangseinheit");
            if (ParamAborted(startUnit))
                return;
            if (startUnit.Value % 1 != 0 || startUnit.Value < 0 || startUnit.Value > 8)
            {
                GlobalLogger.addError("Ungülütige Eingabe für Ausgangseinheit.");
                result = Double.NaN;
                this.Close();
                return;
            }
            int unit = (int)startUnit.Value;
            var inputValue = new Parameter("Wert in " + GetUnit(unit));
            if (ParamAborted(inputValue))
                return;
            if (inputValue.Value < 0 || (unit < 2 && inputValue.Value % 1 != 0))
            {
                GlobalLogger.addError("Ungülütige Eingabe für Wert.");
                result = Double.NaN;
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
    }
}
