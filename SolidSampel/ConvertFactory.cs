using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSampel
{
    internal class ConvertFactory
    {
        public static Converter create(BaseType type,int DecimalNumber)
        {
            //if (type == BaseType.binary)
            //{
            //    return new BinaryConverter(DecimalNumber);
            //}
            //else if (type == BaseType.ocatal)
            //{
            //    return new Octalconverter(DecimalNumber);
            //}
            //else if (type == BaseType.Hixadicemal)
            //{
            //    return new Hixadecimalconverter(DecimalNumber);
            //}
            //else
            //{
            //    return null;
            //}
            // as we have alot of cases it will be so hard to start testing it because every condition is code path 
            // so we are going to user refliction
            // Refliction help in creating instances dynmiclay 

            return (Converter)
            Activator.CreateInstance(
          Type.GetType($"SolidSampel.{type.ToString()}Converter"),
           new object[] { DecimalNumber });

        }
       
    }
}
