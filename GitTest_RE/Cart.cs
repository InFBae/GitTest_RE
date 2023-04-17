using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_RE
{
    public abstract class Cart
    {
        private int drift { get; set; }
        private int acceleration { get; set; }
        private int cornering { get; set; }
        private int boosterTime { get; set; }
        private int boosterCharge { get; set; }
    }
}
