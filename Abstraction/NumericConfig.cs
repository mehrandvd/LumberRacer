using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumberRacer
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NumericConfigAttribute : Attribute
    {
        public NumericConfigAttribute(string displayText)
        {
            this.DisplayText = displayText;
        }
        public string DisplayText { get; set; }
        public int Step { get; set; }
        public int Min { get; set; }
        public int Max { get; set; } = 1000;
        public int DefaultValue { get; set; }
    }
}
