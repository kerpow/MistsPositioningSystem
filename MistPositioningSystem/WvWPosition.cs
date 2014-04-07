using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MistPositioningSystem
{
    class WvWPosition
    {
        public string mtc { get; set; }
        public string name { get; set; }
        public float posx { get; set; }
        public float posy { get; set; }
        public float posz { get; set; }
        public Boolean is_friendly { get; set; }
    }
}
