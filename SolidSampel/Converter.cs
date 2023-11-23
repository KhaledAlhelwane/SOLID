using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSampel
{
    public abstract class Converter
    {
        public int DecimalNumber { get; set; }
        protected Converter(int DecimalNumber) {

            this.DecimalNumber = DecimalNumber;
                
                }

        public abstract string Convert();
    }
}
