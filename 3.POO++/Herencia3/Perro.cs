﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Perro : AnimalDomestico
    {
        public override string comunicarse()
        {
            return "Guau... guau...";
        }
    }
}
