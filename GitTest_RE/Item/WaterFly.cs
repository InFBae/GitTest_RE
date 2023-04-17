using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GitTest_RE.Item
{
    internal class WaterFly : Item
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
