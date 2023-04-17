using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_RE
{
    internal class Saber_Pro_R : Cart
    {
        public Saber_Pro_R()
        {
            drift = 900;
            acceleration = 1049;
            cornering = 975;
            boosterTime = 910;
            boosterCharge = 660;
            name = "세이버 Pro-R";
        }
    }
}
