﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SolidSampel
{
  public enum BaseType
    {
        Binary = 2,
        Octal = 8,
        Hixadecimal= 16,
        None=0
    }
    internal class NumberConverter
    {
        public int DecimalNumber { get; set; }
        Logger loging=new Logger();
        Reader reader=new Reader();
        public void Convert()
        {
            loging.Log("please enter the number that you want to convert:");
            DecimalNumber = IntParsing();
            Console.WriteLine("now,please entert the Type that you want to convert (EX: 2,8,16)");
            var baseType = (BaseType)IntParsing();
            string result=string.Empty;
            switch (baseType)
            {
                    case BaseType.Binary:
                    var type = ConvertFactory.create(baseType, DecimalNumber);
                    result = type.Convert();
                    break;
                    case BaseType.Octal:
                    var type2 = ConvertFactory.create(baseType, DecimalNumber);
                    result = type2.Convert();
                    break;
                case BaseType.Hixadecimal:
                    var type3 = ConvertFactory.create(baseType, DecimalNumber);
                    result = type3.Convert();
                    break;
                    default:
                    result = "No base"; 
                    break;
            }
            loging.Log($"you result is this {result}");
            loging.Log("The program is ending");


        }
        public int IntParsing()
        {
            return int.Parse(reader.Read());
        }
    }
}