using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_RE.Item
{
    internal class Banana : Item
    {
        string name = "바나나";

        public void UseBanana()
        {
            UseItem(name);
            Console.WriteLine("바나나 던지기");
        }
    }
}
