using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSampel
{
    internal class InvalidBaseConverter : Converter
    {
        public InvalidBaseConverter(int DecimalNumber) : base(DecimalNumber)
        {
        }

        public override string Convert()
        {
            return "This base type is not valid please choose another one";
        }
    }
}
