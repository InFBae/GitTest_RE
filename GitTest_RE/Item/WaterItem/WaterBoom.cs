using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_RE.Item.WaterItem
{
    internal class WaterBoom : WaterItem
    {
        private WaterBoom()
        {

        }

        private void UseWaterBoom()
        {
            UseItem();
            Console.WriteLine("물폭탄 던지기");
        }
    }
}
