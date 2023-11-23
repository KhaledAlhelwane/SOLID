using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSampel
{
    internal class BinaryConverter : Converter
    {
        public BinaryConverter(int decimalnumber):base(decimalnumber)
        {
                
        }
        public override string Convert()
        {
            return $"the nubmer converted to binary is {System.Convert.ToString(DecimalNumber, 2)}";
        }
    }
}
