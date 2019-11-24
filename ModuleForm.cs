using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Just4You
{
    public abstract partial class ModuleForm : Form
    {
        protected List<String> output;
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
    }
}
