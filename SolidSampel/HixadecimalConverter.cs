using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSampel
{
    internal class HixadecimalConverter : Converter
    {

        public HixadecimalConverter(int Decimall):base(Decimall)
        {
                
        }
        public override string Convert()
        {
           
            return $"the result of hixdecimal is {DecimalNumber.ToString("X")}";
        }
    }
}
