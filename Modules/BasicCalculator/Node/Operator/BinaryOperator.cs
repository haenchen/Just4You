using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just4You.Modules.BasicCalculator.Node.Operator
{
    internal abstract class BinaryOperator : NodeInterface
    {
        protected NodeInterface lValue, rValue;

        public BinaryOperator(NodeInterface lValue, NodeInterface rValue)
        {
            this.lValue = lValue;
            this.rValue = rValue;
        }

        public NodeInterface LeftValue
        {
            get { return this.lValue; }
        }

        public NodeInterface RightValue
        {
            get { return this.rValue; }
        }

        public abstract Scalar Calculate();
    }
}
