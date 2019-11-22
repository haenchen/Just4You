using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just4You.Modules.BasicCalculator.Node
{
    public class Scalar : NodeInterface
    {
        private Double value;

        public Scalar(Double value)
        {
            this.value = value;
        }

        public Double Value { get { return value; } }

        Scalar NodeInterface.Calculate()
        {
            return this;
        }
    }
}
