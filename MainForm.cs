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
using Just4You.Modules.MathematicalFunctions;
using Just4You.Modules.School;

namespace Just4You
{
    public partial class MainForm : Form
    {

        private Dictionary<int, Type> modules;
        public MainForm()
        {
            InitializeComponent();
            modules = new Dictionary<int, Type>();
            // Einfach die gewünschten Module eintragen
            modules.Add(1, typeof(MathematicalFunctionChoosingForm));
            modules.Add(2, typeof(SchoolForm));

            btnModuleOne.Text = ((ModuleForm)Activator.CreateInstance(modules[1])).GetModuleText();
            btnModuleTwo.Text = ((ModuleForm)Activator.CreateInstance(modules[2])).GetModuleText();
        }

        private void AddLine(String line)
        {
            txtHistory.Text += line + Environment.NewLine;
        }

        private void AddLines(List<String> lines)
        {
            foreach (String line in lines)
                AddLine(line);
        }
        private void btnBasicCalculator_Click(object sender, EventArgs e)
        {
            var basic = new Parameter("Grundrechner");
            AddLine(basic.Input + " = " + basic.Value.ToString().Replace(".", ","));
        }

        private void btnModuleOne_Click(object sender, EventArgs e)
        {
            BaseModuleFunction(1);
        }

        private void BaseModuleFunction(int index)
        {
            var form = (ModuleForm)Activator.CreateInstance(modules[index]);
            form.DoModuleFunction();
            if (GlobalLogger.NewErrorsExist())
            {
                AddLines(GlobalLogger.GetRecentErrors());
                return;
            }
            var output = form.GetOutput();
            AddLines(output);
        }

        private void btnModuleTwo_Click(object sender, EventArgs e)
        {
            BaseModuleFunction(2);
        }
    }
}
