using System;
using System.Collections.Generic;
using System.Text;

namespace SlunecniSoustava.Data
{
    public struct FyzikalniCharakteristika
    {
        public decimal RovnikovyPrumer { get; set; }
        public decimal PolarniPrumer { get; set; }
        public decimal Povrch { get; set; }
        public decimal Objem { get; set; }
        public decimal Hmotnot { get; set; }
        public decimal GravitaceNaRovniku { get; set; }
    }
}
