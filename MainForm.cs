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
        }

        private void AddLine(String line)
        {
            txtHistory.Text += line + Environment.NewLine;
        }
        private void btnBasicCalculator_Click(object sender, EventArgs e)
        {
            var basic = new Parameter("Grundrechner");
            AddLine(basic.Input + " = " + basic.Value.ToString().Replace(".", ","));
        }

        private void btnModuleOne_Click(object sender, EventArgs e)
        {
            BaseModuleFunction(modules[1]);
        }

        private void BaseModuleFunction(Type type)
        {
            var form = (ModuleForm)Activator.CreateInstance(type);
            form.ShowDialog();
            var output = form.GetOutput();
            foreach (String line in output)
            {
                AddLine(line);
            }
        }
    }
}
