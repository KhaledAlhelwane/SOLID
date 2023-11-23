using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSampel
{// this interface intended for illustartion of the interface segregation principle and it is not used any more 
    internal interface IConverter
    {
        string BinaryToText(string binary);
        string TextToBinary(string text);
        string HexadecimalToText(string text);
        string TextToHexadecimal(string text);
    }
}
