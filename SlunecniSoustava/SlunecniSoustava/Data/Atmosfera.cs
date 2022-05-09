using System;
using System.Collections.Generic;
using System.Text;

namespace SlunecniSoustava.Data
{
    public struct Atmosfera
    {
        public decimal Tlak { get; set; }

        public override string ToString()
        {
            return $"Tlak: {Tlak}";
        }
    }
}
