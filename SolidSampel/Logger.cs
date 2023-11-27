using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSampel
{
    internal class Logger:Iloger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
