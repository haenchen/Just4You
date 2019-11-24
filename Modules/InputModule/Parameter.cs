using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just4You.Modules.InputModule
{
    public class Parameter
    {
        public double Value {
            get;
        }

        public String Input
        {
            get;
        }
        public Parameter(String name)
        {
            var Form = new InputForm();
            Form.SetLabel(name);
            Form.ShowDialog();
            Input = Form.GetInput();
            Value = Form.GetValue();
        }
    }
}
