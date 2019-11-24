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

namespace Just4You
{
    public abstract partial class ModuleForm : Form
    {
        protected List<String> output = new List<string>();
        protected double result = 0;
        public ModuleForm()
        {
            InitializeComponent();
        }

        public List<String> GetOutput()
        {
            return output;
        }

        public double GetResult()
        {
            return result;
        }

        // Das ist leider etwas hacky
        public virtual void DoModuleFunction()
        {
            this.ShowDialog();
        }
        protected bool ParamAborted(Parameter param)
        {
            if (param.Aborted)
            {
                result = Double.NaN;
                this.Close();
                return true;
            }
            return false;
        }

        public abstract String GetModuleText();
    }
}
