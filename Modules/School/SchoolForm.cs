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

namespace Just4You.Modules.School
{
    public partial class SchoolForm : ModuleForm
    {
        public SchoolForm()
        {
            InitializeComponent();
        }

        // Es tut mir Leid, Götter des guten Codes
        public new void DoModuleFunction()
        {
            var count = new Parameter("Notenanzahl");
            var grades = new List<int>();
            if (ParamAborted(count))
                return;
            if (count.Value < 1 || count.Value % 1 != 0)
            {
                GlobalLogger.addError("Ungültige Anzahl von Noten eingegeben");
                result = Double.NaN;
                this.Close();
                return;
            }
            for (int i = 1; i <= (int) count.Value; ++i)
            {
                var param = new Parameter("Note " + i.ToString());
                if (ParamAborted(param))
                    return;
                if (param.Value % 1 != 0 || param.Value < 1 || param.Value > 6)
                {
                    result = Double.NaN;
                    this.Close();
                    return;
                }
                grades.Add((int)param.Value);
            }
            var gradeLine = new StringBuilder();
            int sum = 0;
            for (int i =  0; i < grades.Count; ++i)
            {
                gradeLine.Append(grades[i].ToString());
                if (i != grades.Count - 1)
                    gradeLine.Append(", ");
                sum += grades[i];
            }
            output.Add("Notendurchschnitt von: ");
            output.Add(gradeLine.ToString());
            output.Add("= " + ((double)(sum / grades.Count)).ToString());
        }

        public override String GetModuleText()
        {
            return "Schule";
        }
    }
}
