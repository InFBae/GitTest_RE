using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_RE.Item.WaterItem
{
    internal class WaterItem : Item, Isubmerge
    {
        protected void Submerge()
        {
            // 물에 닿으면 공중에 1초동안 체류
        }
    }
}
