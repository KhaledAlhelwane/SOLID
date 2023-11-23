﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSampel
{
    internal class BinaryConverter : Converter, IBinaryConverter
    {
        public BinaryConverter(int decimalnumber) : base(decimalnumber)
        {

        }
        public override string Convert()
        {
            return $"the nubmer converted to binary is {System.Convert.ToString(DecimalNumber, 2)}";
        }
        public string BinaryToText(string binaryNumber)
        {
            binaryNumber = binaryNumber.Replace(" ", "");
            var list = new List<Byte>();
            for (int i = 0; i < binaryNumber.Length; i += 8)
            {
                String t = binaryNumber.Substring(i, 8);
                list.Add(System.Convert.ToByte(t, 2));
            }
            var result = list.ToArray();
            return Encoding.ASCII.GetString(result);

        }
        public string TextToBinary(string text)
        {
            var bytes = Encoding.ASCII.GetBytes(text);
            return string.Join(" ",
            bytes.Select(byt => System.Convert.ToString(byt, 2).PadLeft(8,
            '0')));
        }
    }
}

