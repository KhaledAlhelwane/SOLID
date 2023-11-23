using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSampel
{
    internal class OctalConverter : Converter
    {
        public OctalConverter(int decemalnumber):base(decemalnumber)
        {
                
        }
        public override string Convert()
        {
            return $"the value of octal converter is {System.Convert.ToString(DecimalNumber, 8)}";
        }
    }
}
