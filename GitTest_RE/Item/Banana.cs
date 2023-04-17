using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_RE.Item
{
    internal class Banana : Item
    {
        private Banana() { }

        public void UseBanana()
        {
            UseItem();
            Console.WriteLine("바나나 던지기");
        }
    }
}
