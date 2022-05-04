using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SlunecniSoustava.Data
{
    public struct Planeta : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string jmeno;
        public string Jmeno { get => jmeno; set { jmeno = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Jmeno")); } }
        public FyzikalniCharakteristika FyzikalniCharakteristika { get; set; }
        public ObeznaDraha ObeznaDraha { get; set; }
        public Atmosfera Atmosfera { get; set; }
    }
}
