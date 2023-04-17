using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_RE.Item.WaterItem
{
    internal class WaterBoom : WaterItem
    {
        string name = "물폭탄";

        public void UseWaterBoom()
        {
            UseItem(name);
            Console.WriteLine("물폭탄 던지기");
        }
    }
}
