using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormElectronics
{
    class Value
    {
        private double mantissa;
        private int exponent;

        public Value()
        {
            mantissa = 0;
            exponent = 0;
        }

        public Value(double m, int e)
        {
            mantissa = m;
            exponent = e;
        }

        public static Value operator +(Value v1, Value v2)
        {
            Value result = new Value();
            
            return result;
        }
    }
}
