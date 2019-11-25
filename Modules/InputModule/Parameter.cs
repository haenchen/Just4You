using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just4You.Modules.InputModule
{
    public class Parameter
    {
        public double Value
        {
            get;
            set;
        }

        public String Input
        {
            get;
            set;
        }

        public bool Aborted
        {
            get;
            set;
        }
        public Parameter(String name)
        {
            var Form = new InputForm();
            Form.SetLabel(name);
            Form.ShowDialog();
            Aborted = Form.Aborted;
            Input = Form.GetInput();
            Value = Form.GetValue();
        }

        public Parameter(String name, InputConstraint[] constraints) : this(name)
        {
            foreach (InputConstraint constraint in constraints)
                if (constraint.IsValid(Value))
                    Aborted = true;
        }
    }
}
