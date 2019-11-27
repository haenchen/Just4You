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

        /// <summary>
        /// SchoolForm wird theoretisch nie geöffnet, daher überschreibt es DoModuleFunction.
        /// </summary>
        public override void DoModuleFunction()
        {
            var count = new Parameter("Notenanzahl",
                new InputConstraint[] { new IntegerConstraint(), new PositiveConstraint(), new NonZeroConstraint() });
            var grades = new List<int>();
            if (ParamAborted(count))
                return;
            for (int i = 1; i <= (int) count.Value; ++i)
            {
                var param = new Parameter("Note " + i.ToString(), new InputConstraint[] { new IntegerConstraint() });
                if (ParamAborted(param))
                    return;
                if (param.Value < 1 || param.Value > 6)
                {
                    GlobalLogger.addError("Ungültige Note eingegeben: " + param.Value.ToString().Replace(".", ","));
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
            output.Add("= " + ((double)sum / grades.Count).ToString());
        }

        public override String GetModuleText()
        {
            return "Schule";
        }
    }
}
