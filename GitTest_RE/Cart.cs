using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_RE
{
    public abstract class Cart
    {
        public abstract int drift { get; set; }
        public abstract int acceleration { get; set; }
        public abstract int cornering { get; set; }
        public abstract int boosterTime { get; set; }
        public abstract int boosterCharge { get; set; }
    }
}
