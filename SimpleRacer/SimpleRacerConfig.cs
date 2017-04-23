using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumberRacer.SimpleRacer
{
    public class SimpleRacerConfig : IAlgorithmConfig
    {
        [NumericConfig(@"Griding Size (px)", DefaultValue = 8)]
        public int GrdidingSize { get; set; }
        [NumericConfig(@"Beam Size (px)", DefaultValue = 3)]
        public int BeamSize { get; set; }
        [NumericConfig(@"Color Precision (px)", DefaultValue = 10)]
        public int ColorPrecision { get; set; }

        [NumericConfig(@"Refresh Rate (ms)", DefaultValue = 1)]
        public int RefreshRate { get; set; } = 1;
        [NumericConfig(@"Requested Score", DefaultValue = 150, Max = 1000)]
        public int RequiredScore { get; set; }
    }
}
