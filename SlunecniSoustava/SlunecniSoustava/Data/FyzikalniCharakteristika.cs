using System;
using System.Collections.Generic;
using System.Text;

namespace SlunecniSoustava.Data
{
    public struct FyzikalniCharakteristika
    {
        public decimal RovnikovyPrumer { get; set; }
        public decimal Objem { get; set; }
        public decimal Hmotnost { get; set; }

        public override string ToString()
        {
            return $"RovnikovyPrumer {RovnikovyPrumer}\nObjem: {Objem}\nHmotnost: {Hmotnost}";
        }
    }
}
