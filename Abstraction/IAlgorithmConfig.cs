using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LumberRacer
{
    public interface IAlgorithmConfig
    {
        int RefreshRate { get; set; }
        int RequiredScore { get; set; }
    }
}
