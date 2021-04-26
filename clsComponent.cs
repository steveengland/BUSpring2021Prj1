using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBU07
{
    public class clsComponent
    {
        public string CompName { get; set; }                  // Describe as...
        public float Cost { get; set; }                       // 34.95
        public string CompType { get; set; }                  // "CPU", "MB", "MEM", "VIDEO", "P/S"
        public string Tier { get; set; }                      // LOW, MED, HIGH
    }
}
