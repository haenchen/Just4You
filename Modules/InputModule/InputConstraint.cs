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
            bool result = x > 0;
            if (!result)
                GlobalLogger.addError("Nur positive Eingaben sind für diese Operation gestattet.");
            return result;
        }
    }

    public class NonZeroConstraint : InputConstraint
    {
        public bool IsValid(double x)
        {
            bool result = x != 0;
            if (!result)
                GlobalLogger.addError("Nur nicht-null Eingaben sind für diese Operation gestattet.");
            return result;
        }
    }

    public class IntegerConstraint : InputConstraint
    {
        public bool IsValid(double x)
        {
            bool result = x % 1 == 0;
            if (!result)
                GlobalLogger.addError("Nur ganzzahlige Eingaben sind für diese Operation gestattet.");
            return result;
        }
    }
}
