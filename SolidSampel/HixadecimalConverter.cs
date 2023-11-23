using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSampel
{
    internal class HixadecimalConverter : Converter, IHexadecimalConverter
    {

        public HixadecimalConverter(int Decimall):base(Decimall)
        {
                
        }
        public override string Convert()
        {
           
            return $"the result of hixdecimal is {DecimalNumber.ToString("X")}";
        }
        public string HexadecimalToText(string text)
        {
            text = text.Replace(" ", "");
            byte[] raw = new byte[text.Length / 2];
            for (int i = 0; i < raw.Length; i++)
            {
                raw[i] = System.Convert.ToByte(text.Substring(i * 2, 2), 16);
            }
            return Encoding.ASCII.GetString(raw); ;
        }
        public string TextToHexadecimal(string text)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(text);
         
        var hexString = BitConverter.ToString(bytes);
            hexString = hexString.Replace("-", "");
            return hexString;
        }
   
    }
}
