using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just4You.Modules.BasicCalculator.Node.Operator
{
    internal class Add : BinaryOperator
    {
        public Add(NodeInterface lValue, NodeInterface rValue) : base(lValue, rValue)
        {
        }

        public override Scalar Calculate()
        {
            return new Scalar(lValue.Calculate().Value + rValue.Calculate().Value);
        }
    }
}
