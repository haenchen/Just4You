using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Just4You.Modules.InputModule
{
    public interface InputConstraint
    {
        bool IsValid(double x);
    }

    public class PositiveConstraint : InputConstraint
    { 
        public bool IsValid(double x)
        {
            return x > 0;
        }
    }

    public class NonZeroConstraint : InputConstraint
    {
        public bool IsValid(double x)
        {
            return x != 0;
        }
    }

    public class IntegerConstraint : InputConstraint
    {
        public bool IsValid(double x)
        {
            return x % 1 == 0;
        }
    }
}
