using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_RE
{
    public abstract class Cart
    {
        protected int drift { get; set; }
        protected int acceleration { get; set; }
        protected int cornering { get; set; }
        protected int boosterTime { get; set; }
        protected int boosterCharge { get; set; }
    }
}
