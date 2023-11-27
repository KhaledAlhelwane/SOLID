using System;
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
        //here acutully we replaced these instances to make the dependeny inversion principle through the dependency injuction pattern
        // now we will replace them with the abstraction as we connected the low level with abstraction , now we connecting the high level mudole with the abstraciotn 
     //   Logger loging=new Logger();
     //   Reader reader=new Reader();
     Iloger loging { get; set; }
        IReader reader { get; set; }
        public NumberConverter(Iloger loger,IReader reader)
        {
                loging = loger;
            this.reader=reader;
        }
        public void Convert()
        {
            loging.Log("please enter the number that you want to convert:");
            DecimalNumber = IntParsing();
            Console.WriteLine("now,please entert the Type that you want to convert (EX: 2,8,16)");
            var baseType = (BaseType)IntParsing();
            string result=string.Empty;
            var type = ConvertFactory.create(baseType, DecimalNumber);
            result = type.Convert();
            loging.Log($"you result is this {result}");
            loging.Log("The program is ending");


        }
        public int IntParsing()
        {
            return reader.Read();
        }
    }
}
