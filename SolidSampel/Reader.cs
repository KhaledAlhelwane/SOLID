﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidSampel
{
    internal class Reader:IReader
    {
        public int Read() {
          return int.Parse(Console.ReadLine());
        }
    }
}
