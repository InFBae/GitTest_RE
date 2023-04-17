using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GitTest_RE.Item.WaterItem
{
    internal class WaterFly : WaterItem
    {
        private WaterFly()
        {

        }

        private void UseWaterFly()
        {
            UseItem();
            Console.WriteLine("물파리 던지기");
        }

    }
}
